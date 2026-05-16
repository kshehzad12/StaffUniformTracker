using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaffUniformTracker.Models;
using StaffUniformTracker.Patterns;

namespace StaffUniformTracker.Forms;

public partial class UniformsForm : Form
{
    public UniformsForm()
    {
        InitializeComponent();
        foreach (var t in UniformTrackingApp.Instance.Factory.KnownTypes) _typeCombo.Items.Add(t);
        foreach (var c in UniformTrackingApp.Instance.Clients.All().OrderBy(c => c.Id)) _clientCombo.Items.Add(c);
        _clientCombo.SelectedIndexChanged += (_, _) => RefillStaff();

        _addBtn.Click += OnCreateUniform;
        _soiledBtn.Click += (_, _) => Transition(u => u.MarkSoiled());
        _washBtn.Click += (_, _) => Transition(u => u.MarkWashing());
        _cleanBtn.Click += (_, _) => Transition(u => u.MarkCleaned());

        if (_typeCombo.Items.Count > 0) _typeCombo.SelectedIndex = 0;
        if (_clientCombo.Items.Count > 0) _clientCombo.SelectedIndex = 0;
        Refill();
    }
    private void OnCreateUniform(object? sender, EventArgs e)
    {
        if (_typeCombo.SelectedItem is not string type) { Warn("Pick a uniform type first."); return; }
        if (_clientCombo.SelectedItem is not Client c) { Warn("Pick a client first."); return; }
        var staffId = (_staffCombo.SelectedItem as Staff)?.Id;
        try
        {
            var u = UniformTrackingApp.Instance.Factory.Create(type, c.Id, staffId);
            UniformTrackingApp.Instance.Uniforms.Save(u);
            Refill();
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"Could not create uniform:\n{ex.Message}",
                            "Create failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    
    private void RefillStaff()
    {
        _staffCombo.Items.Clear();
        if (_clientCombo.SelectedItem is not Client c) return;
        foreach (var s in UniformTrackingApp.Instance.Staffs.Where(s => s.ClientId == c.Id).OrderBy(s => s.Id))
            _staffCombo.Items.Add(s);
    }

    private void Transition(Action<Uniform> action)
    {
        if (_list.SelectedItems.Count == 0)
        { Warn("Tick or select at least one uniform first."); return; }
        try
        {
            foreach (ListViewItem item in _list.SelectedItems)
                if (item.Tag is Uniform u) action(u);
            Refill();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(this, ex.Message, "Invalid transition",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    private void Refill()
    {
        _list.Items.Clear();
        foreach (var u in UniformTrackingApp.Instance.Uniforms.All().OrderBy(u => u.Id))
        {
            var r = new ListViewItem(u.Id);
            r.SubItems.Add(u.TypeName); r.SubItems.Add(u.ClientId);
            r.SubItems.Add(u.StaffId ?? "-"); r.SubItems.Add(u.State.Name);
            r.SubItems.Add(u.WashCount.ToString());
            r.Tag = u; _list.Items.Add(r);
        }
    }
    private void Warn(string msg) =>
    MessageBox.Show(this, msg, "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

}


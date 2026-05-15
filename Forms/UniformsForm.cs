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

        _addBtn.Click += (_, _) => Create();
        _soiledBtn.Click += (_, _) => Transition(u => u.MarkSoiled());
        _washBtn.Click += (_, _) => Transition(u => u.MarkWashing());
        _cleanBtn.Click += (_, _) => Transition(u => u.MarkCleaned());

        if (_typeCombo.Items.Count > 0) _typeCombo.SelectedIndex = 0;
        if (_clientCombo.Items.Count > 0) _clientCombo.SelectedIndex = 0;
        Refill();
    }
    private void Create()
    {
        if (_typeCombo.SelectedItem is not string t) return;
        if (_clientCombo.SelectedItem is not Client c) return;
        var s = (_staffCombo.SelectedItem as Staff)?.Id;
        var u = UniformTrackingApp.Instance.Factory.Create(t, c.Id, s);
        UniformTrackingApp.Instance.Uniforms.Save(u);
        Refill();
    }
    private void Transition(Action<Uniform> action)
    {
        try
        {
            foreach (ListViewItem i in _list.SelectedItems)
                if (i.Tag is Uniform u) action(u);
            Refill();
        }
        catch (InvalidOperationException ex)
        { MessageBox.Show(this, ex.Message, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }
    private void RefillStaff()
    {
        _staffCombo.Items.Clear();
        if (_clientCombo.SelectedItem is not Client c) return;
        foreach (var s in UniformTrackingApp.Instance.Staffs.Where(s => s.ClientId == c.Id).OrderBy(s => s.Id))
            _staffCombo.Items.Add(s);
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
}


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
using StaffUniformTracker.Common;

namespace StaffUniformTracker.Forms;

public partial class ClientsForm : Form
{
    public ClientsForm()
    {
        InitializeComponent();
        _addBtn.Click += OnAddOrUpdate;
        _delBtn.Click += OnRemove;
        _list.SelectedIndexChanged += OnSelected;
        Refill();
    }
    private void OnAddOrUpdate(object? sender, System.EventArgs e)
    {
        var id = _id.Text.Trim();
        var name = _name.Text.Trim();
        var email = _email.Text.Trim();

        if (Validation.IsBlank(id) || !Validation.LooksLikeId(id))
        { Warn("Client id is required and must be 3-12 chars of [A-Z 0-9 -]."); _id.Focus(); return; }
        if (Validation.IsBlank(name)) { Warn("Client name is required."); _name.Focus(); return; }
        if (!Validation.LooksLikeEmail(email))
        { Warn("Contact email does not look valid."); _email.Focus(); return; }

        var existing = UniformTrackingApp.Instance.Clients.Find(id);
        if (existing is null)
            UniformTrackingApp.Instance.Clients.Save(new Client(id, name, email));
        else if (MessageBox.Show(this,
                    $"Client '{id}' already exists. Update its details?",
                    "Confirm update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
            UniformTrackingApp.Instance.Clients.Save(new Client(id, name, email));
        else return;
        Refill();
    }

    private void OnRemove(object? sender, System.EventArgs e)
    {
        if (_list.SelectedItem is not Client c) { Warn("Select a client first."); return; }
        var app = UniformTrackingApp.Instance;
        var staffCount = app.Staffs.Where(s => s.ClientId == c.Id).Count();
        var uniformCount = app.Uniforms.Where(u => u.ClientId == c.Id).Count();
        if (staffCount + uniformCount > 0)
        {
            MessageBox.Show(this,
                $"Cannot delete '{c.Id}': owns {staffCount} staff and {uniformCount} uniforms.",
                "Delete blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (MessageBox.Show(this, $"Delete client '{c.Id} - {c.Name}'?", "Confirm delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        { app.Clients.Remove(c.Id); Refill(); }
    }

    private void OnSelected(object? sender, System.EventArgs e)
    {
        if (_list.SelectedItem is Client c)
        {
            _id.Text = c.Id; _name.Text = c.Name; _email.Text = c.ContactEmail;
        }
    }

    private void Refill()
    {
        _list.Items.Clear();
        foreach (var c in UniformTrackingApp.Instance.Clients.All().OrderBy(c => c.Id))
            _list.Items.Add(c);
    }

    private void Warn(string msg) =>
        MessageBox.Show(this, msg, "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

}


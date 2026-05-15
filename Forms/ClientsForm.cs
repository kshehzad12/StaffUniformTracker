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

public partial class ClientsForm : Form
{
    public ClientsForm()
    {
        InitializeComponent();
        _addBtn.Click += (_, _) => { Upsert(); Refill(); };
        _delBtn.Click += (_, _) => { Delete(); Refill(); };
        _list.SelectedIndexChanged += (_, _) => Pick();
        Refill();
    }
    private void Upsert()
    {
        if (string.IsNullOrWhiteSpace(_id.Text) || string.IsNullOrWhiteSpace(_name.Text))
        { MessageBox.Show(this, "Id and name are required."); return; }
        UniformTrackingApp.Instance.Clients.Save(new Client(_id.Text, _name.Text, _email.Text));
    }
    private void Delete()
    {
        if (_list.SelectedItem is Client c) UniformTrackingApp.Instance.Clients.Remove(c.Id);
    }
    private void Pick()
    {
        if (_list.SelectedItem is Client c)
        { _id.Text = c.Id; _name.Text = c.Name; _email.Text = c.ContactEmail; }
    }
    private void Refill()
    {
        _list.Items.Clear();
        foreach (var c in UniformTrackingApp.Instance.Clients.All().OrderBy(c => c.Id))
            _list.Items.Add(c);
    }
}


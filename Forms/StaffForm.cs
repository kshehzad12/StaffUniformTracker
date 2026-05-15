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

public partial class StaffForm : Form
{
    public StaffForm()
    {
        InitializeComponent();
        foreach (var c in UniformTrackingApp.Instance.Clients.All().OrderBy(c => c.Id))
            _client.Items.Add(c);
        _client.SelectedIndexChanged += (_, _) => Refill();
        _importBtn.Click += (_, _) =>
        {
            if (_client.SelectedItem is not Client c) return;
            var s = UniformTrackingApp.Instance.StaffSrc.ReadAll(c.Id);
            foreach (var x in s) UniformTrackingApp.Instance.Staffs.Save(x);
            Refill();
            MessageBox.Show(this, $"Imported {s.Count} staff from legacy HR system.");
        };
        if (_client.Items.Count > 0) _client.SelectedIndex = 0;
    }
    private void Refill()
    {
        _list.Items.Clear();
        if (_client.SelectedItem is not Client c) return;
        foreach (var s in UniformTrackingApp.Instance.Staffs.Where(s => s.ClientId == c.Id)
                                                              .OrderBy(s => s.Id))
            _list.Items.Add(s);
    }
}


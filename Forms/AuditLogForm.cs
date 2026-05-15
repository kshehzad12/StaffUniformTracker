using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaffUniformTracker.Patterns;

namespace StaffUniformTracker.Forms;

public partial class AuditLogForm : Form
{
    public AuditLogForm()
    {
        InitializeComponent();
        _refresh.Click += (_, _) => Refill();
        _subscribe.Click += (_, _) =>
        {
            UniformTrackingApp.Instance.Dashboard.OnAudit += (_, _) =>
            { if (InvokeRequired) BeginInvoke(Refill); else Refill(); };
            _subscribe.Enabled = false; _subscribe.Text = "Subscribed";
        };
        Refill();
    }
    private void Refill()
    {
        _list.Items.Clear();
        foreach (var e in UniformTrackingApp.Instance.Logger.Entries)
        {
            var r = new ListViewItem(e.Timestamp.ToString("yyyy-MM-dd HH:mm:ss"));
            r.SubItems.Add(e.Kind); r.SubItems.Add(e.UniformId);
            r.SubItems.Add(e.From); r.SubItems.Add(e.To);
            r.SubItems.Add(e.WashCount.ToString());
            _list.Items.Add(r);
        }
    }
}


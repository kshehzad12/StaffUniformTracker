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

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        _menuClients.Click += (_, _) => Open<ClientsForm>();
        _menuStaff.Click += (_, _) => Open<StaffForm>();
        _menuUniforms.Click += (_, _) => Open<UniformsForm>();
        _menuBatch.Click += (_, _) => Open<BatchWashForm>();
        _menuSearch.Click += (_, _) => Open<SearchForm>();
        _menuReport.Click += (_, _) => Open<ReportsForm>();
        _menuAudit.Click += (_, _) => Open<AuditLogForm>();
        _menuAbout.Click += (_, _) => MessageBox.Show(this,
            "StaffUniformTracker - SWE7302 demo.", "About");

        var app = UniformTrackingApp.Instance;
        _welcome.Text = $"Welcome, {app.CurrentUser ?? "user"}.";
        RefreshCounts();
        app.Dashboard.OnAudit += OnAudit;
        foreach (var e in app.Logger.Entries.Reverse())
            _activity.Items.Add(e.ToString());

        FormClosed += (_, _) => { app.Dashboard.OnAudit -= OnAudit; app.Logout(); };
    }
    private void RefreshCounts()
    {
        var a = UniformTrackingApp.Instance;
        _counts.Text = $"Clients: {a.Clients.Count}     " +
                       $"Staff: {a.Staffs.Count}     " +
                       $"Uniforms: {a.Uniforms.Count}";
    }
    private void OnAudit(object? s, StaffUniformTracker.Patterns.Observer.AuditEvent evt)
    {
        if (InvokeRequired) BeginInvoke(() => _activity.Items.Insert(0, evt.ToString()));
        else _activity.Items.Insert(0, evt.ToString());
        RefreshCounts();
    }
    private void Open<TForm>() where TForm : Form, new()
    { using var f = new TForm(); f.ShowDialog(this); RefreshCounts(); }
}


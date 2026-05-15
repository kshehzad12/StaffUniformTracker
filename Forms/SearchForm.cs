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

public partial class SearchForm : Form
{
    private abstract class SearchItems { public abstract IEnumerable<Uniform> Run(string c); }
    private sealed class SearchByClient : SearchItems
    {
        public override IEnumerable<Uniform> Run(string c) =>
        UniformTrackingApp.Instance.Uniforms.Where(u => string.Equals(u.ClientId, c, StringComparison.OrdinalIgnoreCase));
    }
    private sealed class SearchByStaff : SearchItems
    {
        public override IEnumerable<Uniform> Run(string s) =>
        UniformTrackingApp.Instance.Uniforms.Where(u => string.Equals(u.StaffId, s, StringComparison.OrdinalIgnoreCase));
    }
    private sealed class SearchByStatus : SearchItems
    {
        public override IEnumerable<Uniform> Run(string s) =>
        UniformTrackingApp.Instance.Uniforms.Where(u => string.Equals(u.State.Name, s, StringComparison.OrdinalIgnoreCase));
    }

    public SearchForm()
    {
        InitializeComponent();
        _runBtn.Click += (_, _) => Run();
    }
    private void Run()
    {
        SearchItems s = (_kind.SelectedItem as string) switch
        {
            "Client" => new SearchByClient(),
            "Staff" => new SearchByStaff(),
            "Status" => new SearchByStatus(),
            _ => new SearchByClient(),
        };
        var r = s.Run(_criterion.Text.Trim()).ToList();
        _results.Items.Clear();
        foreach (var u in r)
        {
            var row = new ListViewItem(u.Id);
            row.SubItems.Add(u.TypeName); row.SubItems.Add(u.ClientId);
            row.SubItems.Add(u.StaffId ?? "-"); row.SubItems.Add(u.State.Name);
            row.SubItems.Add(u.WashCount.ToString());
            _results.Items.Add(row);
        }
        Text = $"Search Items - {r.Count} match(es)";
    }
}


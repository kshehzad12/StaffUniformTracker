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

public partial class BatchWashForm : Form
{
    public BatchWashForm()
    {
        InitializeComponent();
        _runBtn.Click += (_, _) => Run();
        Refill();
    }
    private void Refill()
    {
        _items.Items.Clear();
        foreach (var u in UniformTrackingApp.Instance.Uniforms.All().OrderBy(u => u.Id))
            _items.Items.Add(u);
    }
    private void Run()
    {
        var sel = _items.CheckedItems.Cast<Uniform>().ToList();
        if (sel.Count == 0) { MessageBox.Show(this, "Tick at least one item."); return; }

        foreach (var u in sel)                    // LOOP fragment
        {
            try { if (u.State.Name == "Cleaned") u.MarkSoiled(); u.MarkWashing(); }
            catch (InvalidOperationException) { }
        }
        if (_success.Checked)                     // ALT success
            foreach (var u in sel) try { u.MarkCleaned(); } catch { }
        else                                      // ALT failure
            foreach (var u in sel) try { u.MarkSoiled(); } catch { }

        Refill();
        MessageBox.Show(this, $"{sel.Count} item(s) processed.");
    }
}


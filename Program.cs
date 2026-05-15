using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaffUniformTracker.Forms;
using StaffUniformTracker.Patterns;

namespace StaffUniformTracker;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        var app = UniformTrackingApp.Instance;        // <-- private Singleton ctor runs
        app.Bootstrap();                              // <-- idempotent demo seed
        try
        {
            using var login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
                Application.Run(new MainForm());
        }
        finally { app.Db.Dispose(); }                 // release SQLite handle
    }
}
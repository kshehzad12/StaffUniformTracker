using StaffUniformTracker.Data;
using StaffUniformTracker.Models;
using StaffUniformTracker.Patterns.Adapter;
using StaffUniformTracker.Patterns.Factory;
using StaffUniformTracker.Patterns.Observer;
using StaffUniformTracker.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Patteren: Singleton (creational) implementaion

namespace StaffUniformTracker.Patterns
{
    public sealed class UniformTrackingApp
    {
        private static readonly Lazy<UniformTrackingApp> _lazy =
            new(() => new UniformTrackingApp());
        public static UniformTrackingApp Instance => _lazy.Value;

        public LaundryDbContext Db { get; }
        public IRepository<Client> Clients { get; }
        public IRepository<Staff> Staffs { get; }
        public IRepository<Uniform> Uniforms { get; }
        public UniformFactory Factory { get; }
        public AuditLogger Logger { get; }
        public DashboardObserver Dashboard { get; }
        public IStaffSource StaffSrc { get; }
        public string? CurrentUser { get; private set; }

        public const string DemoUsername = "admin";
        public const string DemoPassword = "admin";

        private UniformTrackingApp()
        {
            Db = new LaundryDbContext();
            Db.Database.EnsureCreated();

            Clients = new EfRepository<Client>(Db, c => c.Id);
            Staffs = new EfRepository<Staff>(Db, s => s.Id);
            Uniforms = new EfRepository<Uniform>(Db, u => u.Id);

            Factory = new UniformFactory();
            Logger = new AuditLogger(Db);
            Dashboard = new DashboardObserver();
            StaffSrc = new ClientHRAdapter(new ExternalHRSystem());

            AuditSubject.Instance.Attach(Logger);
            AuditSubject.Instance.Attach(Dashboard);
        }

        public bool Login(string user, string pass)
        {
            user = (user ?? "").Trim(); pass = (pass ?? "").Trim();
            if (user == DemoUsername && pass == DemoPassword) { CurrentUser = user; return true; }
            return false;
        }
        public void Logout() => CurrentUser = null;

        public void Bootstrap()
        {
            if (Db.Clients.Any()) return;
            Clients.Save(new Client("C-001", "St. Helens General Hospital", "ops@sthelens.example"));
            Clients.Save(new Client("C-002", "Riverside Hotel & Catering", "ops@riverside.example"));
            foreach (var s in StaffSrc.ReadAll("C-001")) Staffs.Save(s);
            foreach (var s in StaffSrc.ReadAll("C-002")) Staffs.Save(s);
            Uniforms.Save(Factory.Create("Shirt", "C-001", "S-98011"));
            Uniforms.Save(Factory.Create("Trouser", "C-001", "S-98011"));
            Uniforms.Save(Factory.Create("Scrub", "C-001", "S-98012"));
            Uniforms.Save(Factory.Create("Jacket", "C-002", "S-20001"));
        }
    }

}

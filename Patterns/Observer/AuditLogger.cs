using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Concrete observer - persists every received event to SQLite
namespace StaffUniformTracker.Patterns.Observer
{
    public sealed class AuditLogger : IAuditObserver
    {
        private readonly LaundryDbContext _db;
        public AuditLogger(LaundryDbContext db) => _db = db;
        public IReadOnlyList<AuditEvent> Entries =>
            _db.AuditEvents.OrderBy(e => e.Id).ToList();
        public void Update(AuditEvent evt) { _db.AuditEvents.Add(evt); _db.SaveChanges(); }
    }

}

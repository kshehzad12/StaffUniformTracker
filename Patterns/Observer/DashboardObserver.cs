using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Concrete observer that re-broadcasts events as a .NET event
namespace StaffUniformTracker.Patterns.Observer;

public sealed class DashboardObserver : IAuditObserver
{
    public event EventHandler<AuditEvent>? OnAudit;
    public void Update(AuditEvent evt) => OnAudit?.Invoke(this, evt);
}
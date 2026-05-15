using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Record of actions on uniforms
namespace StaffUniformTracker.Patterns.Observer;

public sealed class AuditEvent
{
    public int Id { get; set; }                              // Primary Key in SQLite
    public DateTime Timestamp { get; set; } = DateTime.Now;
    public string Kind { get; set; } = string.Empty;
    public string UniformId { get; set; } = string.Empty;
    public string From { get; set; } = string.Empty;
    public string To { get; set; } = string.Empty;
    public int WashCount { get; set; }

    public AuditEvent() { }                                  // EF Core
    public AuditEvent(string kind, string uniformId, string from, string to, int washCount)
    { Kind = kind; UniformId = uniformId; From = from; To = to; WashCount = washCount; }

    public override string ToString() =>
        $"[{Timestamp:HH:mm:ss}] {Kind}  {UniformId}  {From} -> {To}  (washes={WashCount})";
}

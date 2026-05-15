using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Subject side of the Observer pattern (Singleton)
namespace StaffUniformTracker.Patterns.Observer;

public sealed class AuditSubject
{
    private static readonly object _lock = new();
    private static AuditSubject? _i;
    public static AuditSubject Instance
    {
        get { lock (_lock) { _i ??= new AuditSubject(); return _i; } }
    }
    private readonly List<IAuditObserver> _observers = new();
    public void Attach(IAuditObserver o) { if (!_observers.Contains(o)) _observers.Add(o); }
    public void Detach(IAuditObserver o) => _observers.Remove(o);
    public void Notify(AuditEvent evt)
    {
        foreach (var o in _observers.ToArray()) o.Update(evt);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Subject side of the Observer pattern (Singleton)
namespace StaffUniformTracker.Patterns.Observer;

public sealed class AuditSubject
{
    private static readonly object _instLock = new();
    private static AuditSubject? _instance;

    // Global access point - the canonical Singleton entry
    public static AuditSubject Instance
    {
        get
        {
            lock (_instLock)
            {
                _instance ??= new AuditSubject();
                return _instance;
            }
        }
    }

    private readonly List<IAuditObserver> _observers = new();
    private readonly object _observersLock = new();

    public void Attach(IAuditObserver o)
    {
        lock (_observersLock)
        {
            if (!_observers.Contains(o)) _observers.Add(o);
        }
    }

    public void Detach(IAuditObserver o)
    {
        lock (_observersLock)
        {
            _observers.Remove(o);
        }
    }
    public void Notify(AuditEvent evt)
    {
        IAuditObserver[] snapshot;
        lock (_observersLock)
        {
            snapshot = _observers.ToArray();
        }
        foreach (var o in snapshot)
        {
            o.Update(evt);
        }
    }
}

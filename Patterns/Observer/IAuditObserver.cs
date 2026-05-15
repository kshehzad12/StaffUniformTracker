using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffUniformTracker.Patterns.Observer
{
    public interface IAuditObserver { void Update(AuditEvent evt); }
}

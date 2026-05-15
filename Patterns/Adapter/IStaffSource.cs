using StaffUniformTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TARGET INTERFACE in the Adapter pattern.
namespace StaffUniformTracker.Patterns.Adapter
{
    public interface IStaffSource { IReadOnlyList<Staff> ReadAll(string clientId); }
}

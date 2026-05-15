using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffUniformTracker.Models;

public sealed class Staff
{
    public string Id { get; set; } = string.Empty;
    public string ClientId { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;

    public Staff() { }                                    // EF Core uses this
    public Staff(string id, string clientId, string fullName, string role)
    {
        Id = id; ClientId = clientId; FullName = fullName; Role = role;
    }
    public override string ToString() => $"{Id} - {FullName} ({Role})";
}

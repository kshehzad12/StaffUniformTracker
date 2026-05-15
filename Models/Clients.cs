using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffUniformTracker.Models;

public sealed class Client
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string ContactEmail { get; set; } = string.Empty;

    public Client() { }                                   // EF Core uses this
    public Client(string id, string name, string contactEmail)
    {
        Id = id; Name = name; ContactEmail = contactEmail;
    }
    public override string ToString() => $"{Id} - {Name}";
}

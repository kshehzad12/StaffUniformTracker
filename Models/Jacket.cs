using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffUniformTracker.Models;

public sealed class Jacket : Uniform
{
    public bool Waterproof { get; set; }
    public override string TypeName => "Jacket";

    public Jacket() { }                                      // EF Core Constructor
    public Jacket(string id, string clientId, string? staffId = null)
        : base(id, clientId, staffId) { }

    public override void Wash() => MarkWashing();
}

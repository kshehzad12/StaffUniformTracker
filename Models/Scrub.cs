using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffUniformTracker.Models;

public sealed class Scrub : Uniform
{
    public string Colour { get; set; } = "Blue";
    public override string TypeName => "Scrub";

    public Scrub() { }                                      // EF Core Constructor
    public Scrub(string id, string clientId, string? staffId = null)
        : base(id, clientId, staffId) { }

    public override void Wash() => MarkWashing();
}

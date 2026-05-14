using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffUniformTracker.Models
{
    public sealed class Shirt : Uniform
    {
        public string Size { get; set; } = "M";
        public override string TypeName => "Shirt";

        public Shirt() { }                                      // EF Core Constructor
        public Shirt(string id, string clientId, string? staffId = null)
            : base(id, clientId, staffId) { }

        public override void Wash() => MarkWashing();
    }

}

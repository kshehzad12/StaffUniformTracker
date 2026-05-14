using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffUniformTracker.Models
{
    public sealed class Trouser : Uniform
    {
        public int Length { get; set; } = 32;
        public override string TypeName => "Trouser";

        public Trouser() { }                                      // EF Core Constructor
        public Trouser(string id, string clientId, string? staffId = null)
            : base(id, clientId, staffId) { }

        public override void Wash() => MarkWashing();
    }

}

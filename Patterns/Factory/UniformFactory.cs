using StaffUniformTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// Factory Method - constructs the right concrete Uniform subclass.
namespace StaffUniformTracker.Patterns.Factory
{
    public sealed class UniformFactory
    {
        private readonly Dictionary<string, Func<string, string, string?, Uniform>> _r =
            new(StringComparer.OrdinalIgnoreCase);

        public UniformFactory()
        {
            Register("Shirt", (id, c, s) => new Shirt(id, c, s));
            Register("Trouser", (id, c, s) => new Trouser(id, c, s));
            Register("Jacket", (id, c, s) => new Jacket(id, c, s));
            Register("Scrub", (id, c, s) => new Scrub(id, c, s));
        }
        public void Register(string code, Func<string, string, string?, Uniform> f) => _r[code] = f;
        public IEnumerable<string> KnownTypes => _r.Keys;

        public Uniform Create(string code, string clientId, string? staffId = null)
        {
            if (!_r.TryGetValue(code, out var f))
                throw new ArgumentException($"Unknown uniform type code: '{code}'");
            var id = $"U-{Guid.NewGuid().ToString()[..8].ToUpperInvariant()}";
            return f(id, clientId, staffId);
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffUniformTracker.Models
{
    public abstract class Uniform
    {
        private static readonly IUniformState _soiled = new SoiledState();
        private static readonly IUniformState _washing = new WashingState();
        private static readonly IUniformState _cleaned = new CleanedState();

        public string Id { get; set; } = string.Empty;
        public string ClientId { get; set; } = string.Empty;
        public string? StaffId { get; set; }
        public int WashCount { get; set; }
        public string StateName { get; set; } = "Soiled";       // PERSISTED COLUMN

        [NotMapped]
        public IUniformState State => StateName switch
        {
            "Washing" => _washing,
            "Cleaned" => _cleaned,
            _ => _soiled,
        };

        [NotMapped]
        public abstract string TypeName { get; }

        protected Uniform() { }                                 // EF Core
        protected Uniform(string id, string clientId, string? staffId = null)
        {
            Id = id; ClientId = clientId; StaffId = staffId;
        }

        public abstract void Wash();

        public void SetState(IUniformState newState)
        {
            var previous = StateName;
            StateName = newState.Name;
            AuditSubject.Instance.Notify(new AuditEvent(        // Observer publish
                "StateChanged", Id, previous, newState.Name, WashCount));
        }

        internal void IncrementWashCount() => WashCount++;

        public void MarkSoiled() => State.MarkSoiled(this);
        public void MarkWashing() => State.MarkWashing(this);
        public void MarkCleaned() => State.MarkCleaned(this);
    }

}

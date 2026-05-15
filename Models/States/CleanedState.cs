using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//State Pattern Class
namespace StaffUniformTracker.Models.States
{
    public sealed class CleanedState : IUniformState
    {
        public string Name => "Cleaned";
        public void MarkSoiled(Uniform u) => u.SetState(new SoiledState());
        public void MarkWashing(Uniform u) =>
            throw new InvalidOperationException(
                "Cleaned items must be marked Soiled before washing.");
        public void MarkCleaned(Uniform u) { }                   // idempotent
    }

}

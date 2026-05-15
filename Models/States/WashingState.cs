using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//State Pattern Class
namespace StaffUniformTracker.Models.States;

public sealed class WashingState : IUniformState
{
    public string Name => "Washing";
    public void MarkSoiled(Uniform u) => u.SetState(new SoiledState()); // re-queue
    public void MarkWashing(Uniform u) { }                              // idempotent
    public void MarkCleaned(Uniform u)
    {
        u.IncrementWashCount();                       // <-- exactly once per cycle
        u.SetState(new CleanedState());
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//State Pattern Class
namespace StaffUniformTracker.Models.States;

public sealed class SoiledState : IUniformState
{
    public string Name => "Soiled";
    public void MarkSoiled(Uniform u) { }                    // idempotent
    public void MarkWashing(Uniform u) => u.SetState(new WashingState());
    public void MarkCleaned(Uniform u) =>
        throw new InvalidOperationException(
            "Cannot move directly from Soiled to Cleaned State. Wash Uniform first.");
}

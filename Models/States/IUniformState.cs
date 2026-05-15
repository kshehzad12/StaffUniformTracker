using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//State Pattern Class
namespace StaffUniformTracker.Models.States
{
    public interface IUniformState
    {
        string Name { get; }
        void MarkSoiled(Uniform u);
        void MarkWashing(Uniform u);
        void MarkCleaned(Uniform u);
    }

}

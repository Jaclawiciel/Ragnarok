using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    interface IMappable {
        MapLocation location { get; }
    }
    interface IMovable {
        void Move();
    }
    interface IInvader : IMappable, IMovable {
        bool PathEnded { get; }
        int GetPathStep();
        int HP { get; }
        int gain { get; }
        Image image { get; }
        bool IsDestroyed { get; }
        bool IsActive { get; }
        void TakeDamage(int damage);
    }
}

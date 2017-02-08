using System;
using System.Collections.Generic;
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
        int HP { get; }
        int gain { get; }
        bool IsDestroyed { get; }
        bool IsActive { get; }
        void TakeDamage(int damage);
    }
}

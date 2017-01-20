using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//podstawowa wieża z której można zrobić upgrade do innych typów.

namespace Ragnarok {
    class BasicTower : Tower {
        protected override int Range { get; } = 1;
        protected override int Power { get; } = 2;
        protected override double Accuracy { get; } = .75;

        public BasicTower(MapLocation location) : base(location) { }
    }
}

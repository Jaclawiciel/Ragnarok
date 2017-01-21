using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class CrossbowTower : Tower {
        protected override int Range { get; } = 2;
        protected override int Power { get; } = 3;
        protected override double Accuracy { get; } = .85;

        public CrossbowTower(MapLocation location) : base(location) { }
    }
}

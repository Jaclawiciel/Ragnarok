using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class CrossbowTower : Tower {
        public override int Range { get; protected set; } = 2;
        public override int Power { get; protected set; } = 3;
        protected override double Accuracy { get; } = .85;

        public CrossbowTower(MapLocation location) : base(location) { }
    }
}

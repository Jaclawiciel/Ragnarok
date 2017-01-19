using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class SniperTower : Tower {
        protected override int Range { get; } = 4;
        protected override int Power { get; } = 1;
        protected override double Accuracy { get; } = .95;

        public SniperTower(MapLocation location) : base(location) { }
    }
}

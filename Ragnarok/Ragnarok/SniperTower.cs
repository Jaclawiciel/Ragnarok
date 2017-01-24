using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class SniperTower : Tower {
        public override int Range { get; protected set; } = 4;
        public override int Power { get; protected set; } = 1;
        protected override double Accuracy { get; } = .95;

        public SniperTower(MapLocation location) : base(location) { }
    }
}

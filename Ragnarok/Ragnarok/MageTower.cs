using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class MageTower : Tower {
        public override int Range { get; protected set; } = 1;
        public override int Power { get; protected set; } = 10;
        protected override double Accuracy { get; } = .30;

        public MageTower(MapLocation location) : base(location) { }
    }
}

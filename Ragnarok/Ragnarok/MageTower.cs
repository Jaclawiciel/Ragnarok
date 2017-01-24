using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class MageTower : Tower {
        protected override int Range { get; set; } = 1;
        protected override int Power { get; set; } = 10;
        protected override double Accuracy { get; } = .30;

        public MageTower(MapLocation location) : base(location) { }
    }
}

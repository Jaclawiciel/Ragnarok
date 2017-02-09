using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class CrossbowTower : Tower {
        public override int Range { get; protected set; } = 2;
        public override int Power { get; protected set; } = 3;
        public override int Cost { get; protected set; } = 100;
        protected override double Accuracy { get; } = .85;
		public Image Image {
			get {
				switch (UpgradeLevel) {
					case 1:
						return Image.FromFile("../../Resources/Crossbow Tower.png");
					case 2:
						return Image.FromFile("../../Resources/Crossbow Tower2.png");
					case 3:
						return Image.FromFile("../../Resources/Crossbow Tower3.png");
					default:
						return null;
				}
			}
		}

		public CrossbowTower(MapLocation location) : base(location) { }
    }
}

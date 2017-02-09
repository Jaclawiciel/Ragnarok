using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class SniperTower : Tower {
        public override int Range { get; protected set; } = 4;
        public override int Power { get; protected set; } = 1;
        public override int Cost { get; protected set; } = 100;
        protected override double Accuracy { get; } = .95;
		public Image Image {
			get {
				switch (UpgradeLevel) {
					case 1:
						return Image.FromFile("../../Resources/Sniper Tower.png");
					case 2:
						return Image.FromFile("../../Resources/Sniper Tower2.png");
					case 3:
						return Image.FromFile("../../Resources/Sniper Tower3.png");
					default:
						return null;
				}
			}
		}

		public SniperTower(MapLocation location) : base(location) { }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class MageTower : Tower {
        public override int Range { get; protected set; } = 1;
        public override int Power { get; protected set; } = 10;
        public static int Cost { get; protected set; } = 100;
        protected override double Accuracy { get; } = .30;
		public static Image DefaultImage = Image.FromFile("../../Resources/Mage Tower.png");
		public Image Image {
			get {
				switch (UpgradeLevel) {
					case 1:
						return Image.FromFile("../../Resources/Mage Tower.png");
					case 2:
						return Image.FromFile("../../Resources/Mage Tower2.png");
					case 3:
						return Image.FromFile("../../Resources/Mage Tower3.png");
					default:
						return null;
				}
			}
		}

		public MageTower(MapLocation location) : base(location) { }
    }
}

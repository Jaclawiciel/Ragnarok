﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class CrossbowTower : Tower {
        public override int Range { get; protected set; } = 1;
        public override int Power { get; protected set; } = 2;
        public static int Cost { get; protected set; } = 100;
		public static int SellCost { get { return Cost / 2; } }
		protected override double Accuracy { get; } = .85;
		public static Image DefaultImage = Image.FromFile("../../Resources/Crossbow Tower.png");
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

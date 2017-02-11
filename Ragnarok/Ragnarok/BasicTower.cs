using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//podstawowa wieża z której można zrobić upgrade do innych typów.

namespace Ragnarok {
    class BasicTower : Tower {
        public override int Range { get; protected set; } = 1;
        public override int Power { get; protected set; } = 1;
        public static int Cost { get; protected set; } = 50;
		public static int SellCost { get { return Cost / 2; } }
        protected override double Accuracy { get; } = .75;
		public Image Image { get; private set; } = Image.FromFile("../../Resources/Basic Tower.png");

		public BasicTower(MapLocation location) : base(location) { }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class ShieldedInvader : Invader {
        public override int HP { get; protected set; } = 10;
        public override int gain { get; protected set; } = 20;
        public override Image image { get; protected set; } = Image.FromFile("../../Resources/Shielded Invader.png");

        public ShieldedInvader(Path path) : base(path) { }

        public override void TakeDamage(int damage) {
            if (Random.NextDouble() < .5) base.TakeDamage(damage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class TankInvader : Invader {
        public override int HP { get; protected set; } = 12;
        public override int gain { get; protected set; } = 15;
        public override Image image { get; protected set; } = Image.FromFile("../../Resources/Tank Invader.png");

        public TankInvader(Path path) : base(path) { }
    }
}

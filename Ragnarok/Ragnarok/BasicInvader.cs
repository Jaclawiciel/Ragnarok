using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class BasicInvader : Invader {
        public override int HP { get; protected set; } = 5;
        public override int gain { get; protected set; } = 10;
        public override Image image { get; protected set; } = Image.FromFile("../../Resources/Basic Invader.png");

        public BasicInvader(Path path) : base(path) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class TankInvader : Invader {
        public override int HP { get; protected set; } = 9;
        public override int gain { get; protected set; } = 30;

        public TankInvader(Path path) : base(path) { }
    }
}

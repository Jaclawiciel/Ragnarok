using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class BasicInvader : Invader {
        public override int HP { get; protected set; } = 3;
        public override int gain { get; protected set; } = 20;

        public BasicInvader(Path path) : base(path) { }
    }
}

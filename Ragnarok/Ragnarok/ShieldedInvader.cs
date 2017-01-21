﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class ShieldedInvader : Invader {
        public override int HP { get; protected set; } = 3;

        public ShieldedInvader(Path path) : base(path) { }

        public override void TakeDamage(int damage) {
            if (Random.NextDouble() < .5) base.TakeDamage(damage);
        }
    }
}

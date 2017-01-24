using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klasa Tower nie wymaga abstrakcji ponieważ tworząc typy wież, będziemy nadpisywać(override) właściwości wymagające zmiany dla danego typu.

namespace Ragnarok {
    class Tower {
        protected virtual int Range { get; set; } = 1;
        protected virtual int Power { get; set; } = 1;
        protected virtual double Accuracy { get; } = .75;
        private MapLocation location;
        public int UpgradeLevel { get; protected set; } = 1;

        public Tower(MapLocation location) {
            this.location = location;
        }

        public int GetX() { return location.X; }
        public int GetY() { return location.Y; }
        public int GetRange() { return Range; }
        public int GetPower() { return Power; }

        public void Upgrade() {
            if (UpgradeLevel <= 3) {
                Range += 1;
                Power += 1;
                UpgradeLevel += 1;
            }
        }

        private bool IsSuccessfulShot() {
            return Random.NextDouble() < Accuracy;
        }
        public void Shooting(List<IInvader> invaders) {
            foreach(IInvader invader in invaders) {
                if(invader.IsActive && location.InRangeOf(invader.location, Range)) {
                    if (IsSuccessfulShot()) {
                        invader.TakeDamage(Power);
                        if (invader.IsDestroyed) {
                            //GIVE ME GOLD
                        }
                        break;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klasa Tower nie wymaga abstrakcji ponieważ tworząc typy wież, będziemy nadpisywać(override) właściwości wymagające zmiany dla danego typu.

namespace Ragnarok {
    class Tower {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;
        private MapLocation location;

        public Tower(MapLocation location) {
            this.location = location;
        }

        public int GetX() { return location.X; }
        public int GetY() { return location.Y; }

        private bool IsSuccessfulShot() {
            return Random.NextDouble() < Accuracy;
        }
        public void Shooting(IInvader[] invaders) {
            foreach(IInvader invader in invaders) {
                if(invader.IsActive && location.InRangeOf(invader.location, Range)) {
                    if (IsSuccessfulShot()) {
                        invader.TakeDamage(Power);
                        if (invader.IsDestroyed) {
                            //Co się dzieje jak zostaje zniszczony? Trzeba to pokazać na ekranie w formsach jakoś.
                        }
                        else {
                            //Koleś idzie dalej. Może zrobić coś jak log tego co się dzieje na polu walki. Nie sądzę że uda nam się zobrazować otrzymywanie obrażeń w formsach.
                        }
                        break;
                    }
                }
            }
        }
    }
}

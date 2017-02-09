using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
    class Player {
        public int gold { get; private set; }
        public int lives { get; private set; }

        public Player() { gold = 400; lives = 5; }
        
        public void SubLives(int i) { lives -= i; }
        public void AddGold(int i) { gold += i; }
        public bool SubGold(int towerCost) {
            if (towerCost <= gold) {
                AddGold(0 - towerCost);
                return true;
            }
            else return false;
        }
    }
}

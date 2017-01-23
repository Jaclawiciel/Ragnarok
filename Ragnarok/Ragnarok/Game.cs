using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragnarok {
	class Game {
        public readonly Map map = new Map(15, 10);
        public Path path { get; private set; }
        public List<Tower> towers { get; private set; }
        public List<IInvader> invaders { get; private set; }
		public MapLocation[] towerSpots;

        public Game() {
            path =new Path(new[] { new MapLocation(0, 7, map), new MapLocation(1, 7, map), new MapLocation(2, 7, map), new MapLocation(2, 6, map),
             new MapLocation(2, 5, map), new MapLocation(2, 4, map), new MapLocation(2, 3, map), new MapLocation(2, 2, map),
             new MapLocation(3, 2, map), new MapLocation(4, 2, map), new MapLocation(5, 2, map), new MapLocation(6, 2, map),
             new MapLocation(6, 3, map), new MapLocation(6, 4, map), new MapLocation(6, 5, map), new MapLocation(6,6,map),
			new MapLocation(6,7,map), new MapLocation(6,8,map), new MapLocation(7,8,map), new MapLocation(8,8,map), new MapLocation(8,7,map), new MapLocation(8,6,map), new MapLocation(9,6,map), new MapLocation(10,6,map),
			new MapLocation(10, 5, map), new MapLocation(10,4,map), new MapLocation(10, 3, map), new MapLocation(10,2,map),
			new MapLocation(10,1,map), new MapLocation(11,1,map), new MapLocation(12,1,map), new MapLocation(13,1,map),
			new MapLocation(13,2,map), new MapLocation(13,3,map), new MapLocation(13,4,map), new MapLocation(13, 5,map),
			new MapLocation(13,6,map), new MapLocation(13,7,map), new MapLocation(14,7,map)});

			towerSpots = new MapLocation[] { new MapLocation(1,6,map), new MapLocation(4, 3,map), new MapLocation(4,5,map), new MapLocation(7,7,map), new MapLocation(8,3,map), new MapLocation(9,5,map), new MapLocation(9,7, map),
			new MapLocation(11, 2, map), new MapLocation(12,6,map), new MapLocation(14,3,map)};

            towers = new List<Tower>();
            invaders = new List<IInvader>();
            towers.Add(new SniperTower(new MapLocation(1, 3, map)));
        }

        public void PlayTurn() {

        }
        //przekazujesz tu tower w sposób AddTower(new TypWieży(new MapLocation(X, Y, map)));
        public void AddTower(Tower tower) {
            towers.Add(tower);
        }
        //przekazujesz tu X i Y punktu z jakiego ma byc usunięta wieża, refund będzie później
        public void DeleteTower(int x, int y) {
            foreach(Tower t in towers) {
                if (t.GetX() == x && t.GetY() == y) towers.Remove(t);
            }
        }
	}
}

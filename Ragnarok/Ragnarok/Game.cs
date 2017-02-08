using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	class Game {
		public readonly Map map = new Map(15, 10);
		public Path path { get; private set; }
		public List<Tower> towers { get; private set; }
		public List<IInvader> invaders { get; private set; }
		public MapLocation[] towerSpots;
        public Player player = new Player();
        public int waveCount { get; private set; } = 3;

		public Game() {
			path = new Path(new[] { new MapLocation(0, 7, map), new MapLocation(1, 7, map), new MapLocation(2, 7, map), new MapLocation(2, 6, map),
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
			towers.Add(new BasicTower(new MapLocation(4, 3, map)));
			towers.Add(new SniperTower(new MapLocation(4, 5, map)));
			towers.Add(new SniperTower(new MapLocation(7, 7, map)));
			towers[2].Upgrade(); towers[2].Upgrade();
		}
        public void PlayTurn() {
            Damage();
            MoveEveryone();
            AreYouAlive();
            WaveSpawn();
            CorpseRemoval();
        }
        //przekazujesz tu tower w sposób AddTower(new TypWieży(new MapLocation(X, Y, map)));
        public void AddTower(Tower tower) {
            towers.Add(tower);
        }
        public void DeleteTower(Tower tower) {
            foreach(Tower t in towers) {
                if (t.GetX() == tower.GetX() && t.GetY() == tower.GetY()) towers.Remove(t);
            }
        }
        public void SwitchTowers(Tower oldTower, int which) {
            DeleteTower(oldTower);
            switch (which) {
                case 1:
                    towers.Add(new CrossbowTower(new MapLocation(oldTower.GetX(), oldTower.GetY(), map)));
                    break;
                case 2:
                    towers.Add(new MageTower(new MapLocation(oldTower.GetX(), oldTower.GetY(), map)));
                    break;
                case 3:
                    towers.Add(new SniperTower(new MapLocation(oldTower.GetX(), oldTower.GetY(), map)));
                    break;
            }
        }
        public void AddInvader() {
            switch (Random.Random123()) {
                case 1:
                    invaders.Add(new BasicInvader(path));
                    break;
                case 2:
                    invaders.Add(new ShieldedInvader(path));
                    break;
                case 3:
                    invaders.Add(new TankInvader(path));
                    break;
            }
        }
        public void Damage() {
            foreach(Tower tower in towers) {
                tower.Shooting(invaders, player);
            }
        }
        public void MoveEveryone() {
            foreach(IInvader invader in invaders) {
                if (invader.IsActive) {
                    invader.Move();
                    if (invader.PathEnded) player.SubLives(1);
                }
            }
        }
        public void AreYouAlive() {
            if (player.lives <= 0) Dead();
        }
        public void Dead() {
            MessageBox.Show("YOU LOST !");
            towers = new List<Tower>();
            invaders = new List<IInvader>();
            player = new Player();
            waveCount = 3;
        }
        public void WaveSpawn() {
            if (invaders.Count() < waveCount) AddInvader();
        }
        public void CorpseRemoval() {
            bool temp = false;
            foreach(IInvader invader in invaders) {
                if (invader.IsActive) temp = true;
            }
            if (!temp) invaders = new List<IInvader>();
            waveCount += 1;
        }
	}
}

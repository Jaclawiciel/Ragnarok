﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	class Game {
        private Map map = new Map(15, 10);
        public Path path { get; private set; }
        public List<Tower> towers { get; private set; }
        public List<IInvader> invaders { get; private set; }
        public int waveCount { get; private set; } = 3;
        public int zycia { get; private set; } = 5;

        public Game() {
            path =new Path(new[] { new MapLocation(0, 5, map), new MapLocation(1, 5, map), new MapLocation(2, 5, map), new MapLocation(3, 5, map),
             new MapLocation(4, 5, map), new MapLocation(5, 5, map), new MapLocation(6, 5, map), new MapLocation(7, 5, map),
             new MapLocation(8, 5, map), new MapLocation(9, 5, map), new MapLocation(10, 5, map), new MapLocation(11, 5, map),
             new MapLocation(12, 5, map), new MapLocation(13, 5, map), new MapLocation(14, 5, map)});
            towers = new List<Tower>();
            invaders = new List<IInvader>();
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
                tower.Shooting(invaders);
            }
        }
        public void MoveEveryone() {
            foreach(IInvader invader in invaders) {
                if (invader.IsActive) {
                    invader.Move();
                    if (invader.PathEnded) zycia -= 1;
                }
            }
        }
        public void AreYouAlive() {
            if (zycia <= 0) Dead();
        }
        public void Dead() {
            MessageBox.Show("YOU LOST !");
            towers = new List<Tower>();
            invaders = new List<IInvader>();
            waveCount = 3;
            zycia = 5;
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

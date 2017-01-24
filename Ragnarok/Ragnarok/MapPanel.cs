using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	class MapPanel : IPanel {
		public Panel panel;
		private MapLocation[] MLTowerSpots;
		public PictureBox[] PBTowerSpots;


		public MapPanel(Panel panel, Map map, MapLocation[] towerSpots) {
			this.panel = panel;
			panel.Size = new System.Drawing.Size(map.Width * 70, map.Height * 70);
			this.MLTowerSpots = towerSpots;
			this.panel.BackgroundImage = Image.FromFile("../../Resources/MapOnly.png");
		}

		public void Show() {
			DrawTowersSpots(MLTowerSpots);
			panel.Show();
		}

		public void Hide() {
			panel.Hide();
		}

		private void DrawTowersSpots(MapLocation[] towerSpots) {
			PBTowerSpots = new PictureBox[towerSpots.Length];
			for (int i = 0; i < towerSpots.Length; i++) {
				PBTowerSpots[i] = new PictureBox();
				PBTowerSpots[i].Size = new Size(70, 70);
				PBTowerSpots[i].Location = new System.Drawing.Point(towerSpots[i].X * 70, towerSpots[i].Y * 70);
				PBTowerSpots[i].BackColor = Color.DarkRed;
				PBTowerSpots[i].Enabled = true;
				panel.Controls.Add(PBTowerSpots[i]);
			}
		}

		public Tower WhatTowerIsPlaced(MapLocation towerSpotLocation, Tower[] towers) {
			foreach (Tower tower in towers) {
				if (towerSpotLocation.X == tower.GetX() && towerSpotLocation.Y == tower.GetY()) {
					if (tower is BasicTower) {
						return new BasicTower(new MapLocation(0, 0, new Map(1, 1)));
					} else if (tower is CrossbowTower) {
						return new CrossbowTower(new MapLocation(0, 0, new Map(1, 1)));
					} else if (tower is MageTower) {
						return new MageTower(new MapLocation(0, 0, new Map(1, 1)));
					} else if (tower is SniperTower) {
						return new SniperTower(new MapLocation(0, 0, new Map(1, 1)));
					}
				}
			}
			return null;
		}
	}
}

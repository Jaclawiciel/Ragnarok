using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	class MapPanel {
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

		private void DrawTowerOnSpot(MapLocation location, Game game, Image image) {
			int index = 0;
			foreach (MapLocation towerSpot in game.towerSpots) {
				if (towerSpot.Equals(location)) {
					PBTowerSpots[index].Image = image;
				}
			}
			index++;
		}

		public void DrawTowerOnSpot(MapLocation location, BasicTower tower, Game game) {
			Image imageToDraw = tower.Image;
			DrawTowerOnSpot(location, game, imageToDraw);
		}

		public void DrawTowerOnSpot(MapLocation location, CrossbowTower tower, Game game) {
			Image imageToDraw = tower.Image;
			DrawTowerOnSpot(location, game, imageToDraw);
		}

		public void DrawTowerOnSpot(MapLocation location, MageTower tower, Game game) {
			Image imageToDraw = tower.Image;
			DrawTowerOnSpot(location, game, imageToDraw);
		}

		public void DrawTowerOnSpot(MapLocation location, SniperTower tower, Game game) {
			Image imageToDraw = tower.Image;
			DrawTowerOnSpot(location, game, imageToDraw);
		}

		public Tower WhatTowerIsPlacedOn(MapLocation towerSpotLocation, Tower[] towers) {
			foreach (Tower tower in towers) {
				if (towerSpotLocation.X == tower.GetX() && towerSpotLocation.Y == tower.GetY()) {
					return tower;
				}
			}
			return null;
		}
	}
}

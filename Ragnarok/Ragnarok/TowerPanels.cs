using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	static class TowerPanel {
		z
	}

	class BasicTowerPanel {
		private Panel basicTowerPanel;
		private PictureBox towerImage;
		private Label costLabel;
		private Label damageLabel;
		private Label rangeLabel;

		public BasicTowerPanel(Panel basicTowerPanel, PictureBox towerImage, Label costLabel, Label damageLabel, Label rangeLabel) {
			this.basicTowerPanel = basicTowerPanel;
			this.towerImage = towerImage;
			this.costLabel = costLabel;
			this.damageLabel = damageLabel;
			this.rangeLabel = rangeLabel;
		}

		public void Show(MapLocation towerSpotLocation, Tower[] towers) {
			towerImage.Image = Image.FromFile("../../Resources/Basic Tower.png");
			
			costLabel =
			//damageLabel = tower.GetDamage();
			//rangeLabel = tower.GetRange();
			//*******************************//

			basicTowerPanel.BringToFront();
			basicTowerPanel.Location = new System.Drawing.Point(towerSpotLocation.X * 70 + 50, towerSpotLocation.Y * 70 + 50);
			basicTowerPanel.Show();
		}

		public void Hide() {
			basicTowerPanel.Hide();
		}


	}

	class SwitchTowerPanel {
		private Panel switchPanel;
		private PictureBox towerImage;
		private Label costLabel;

		public SwitchTowerPanel(Panel switchPanel, PictureBox towerImage, Label costLabel) {
			this.switchPanel = switchPanel;
			this.towerImage = towerImage;
			this.costLabel = costLabel;
		}

		public void Show(MapLocation towerSpotLocation) {
			towerImage.Image = Image.FromFile("../../Resources/Basic Tower.png");

			//********************************//
			//costLabel = tower.GetCost();
			//*******************************//

			switchPanel.BringToFront();
			switchPanel.Location = new System.Drawing.Point(towerSpotLocation.X * 70 + 50, towerSpotLocation.Y * 70 + 50);
			switchPanel.Show();
		}

		public void Hide() {
			switchPanel.Hide();
		}
	}

	class UpgradeTowerPanel {

		private Panel upgradeTowerPanel;
		private PictureBox towerImage;
		private Label costLabel;
		private Label damageLabel;
		private Label rangeLabel;

		public UpgradeTowerPanel(Panel upgradeTowerPanel, PictureBox towerImage, Label costLabel, Label damageLabel, Label rangeLabel) {
			this.upgradeTowerPanel = upgradeTowerPanel;
			this.towerImage = towerImage;
			this.costLabel = costLabel;
			this.damageLabel = damageLabel;
			this.rangeLabel = rangeLabel;
		}

		public void Show(MapLocation towerSpotLocation, Tower[] towers) {
			foreach (Tower tower in towers) {
				if (towerSpotLocation.X == tower.GetX() && towerSpotLocation.Y == tower.GetY()) {
					towerImage.Image = GetTowerImageFor(tower);

					//********************************//
					//costLabel = tower.GetCost();
					//damageLabel = tower.GetDamage();
					//rangeLabel = tower.GetRange();
					//*******************************//

					upgradeTowerPanel.BringToFront();
					upgradeTowerPanel.Location = new System.Drawing.Point(towerSpotLocation.X * 70 + 50, towerSpotLocation.Y * 70 + 50);
					upgradeTowerPanel.Show();
				}
			}
		}

		public void Hide() {
			upgradeTowerPanel.Hide();
		}

		private Image GetTowerImageFor(Tower tower) {
			if (tower is BasicTower) {
				return Image.FromFile("../../Resources/Basic Tower.png");
			} else if (tower is MageTower) {
				if (tower.UpgradeLevel == 1) {
					return Image.FromFile("../../Resources/Mage Tower.png");
				} else if (tower.UpgradeLevel == 2) {
					return Image.FromFile("../../Resources/Mage Tower2.png");
				} else {
					return Image.FromFile("../../Resources/Mage Tower3.png");
				}
				
			} else if (tower is SniperTower) {
				if (tower.UpgradeLevel == 1) {
					return Image.FromFile("../../Resources/Sniper Tower.png");
				} else if (tower.UpgradeLevel == 2) {
					return Image.FromFile("../../Resources/Sniper Tower2.png");
				} else {
					return Image.FromFile("../../Resources/Sniper Tower3.png");
				}
			} else {
				if (tower.UpgradeLevel == 1) {
					return Image.FromFile("../../Resources/Crossbow Tower.png");
				} else if (tower.UpgradeLevel == 2) {
					return Image.FromFile("../../Resources/Crossbow Tower2.png");
				} else {
					return Image.FromFile("../../Resources/Crossbow Tower3.png");
				}
			}
		}
	}

	class RagnarokTowerPanel {

	}
}

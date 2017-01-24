using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	public enum TowerType { noneTower, basicTower, crossbowTower, mageTower, sniperTower }

	abstract class TowerPanel : IPanel {
		protected Panel towerPanel;
		protected int level;
		protected PictureBox towerPictureBox;
		protected Image towerImage {
			get {
				switch (towerType) {
					case TowerType.noneTower: {
							return Image.FromFile("../../Resources/Basic Tower.png");
						}
						break;
					case TowerType.basicTower: {
							return null;
						}
						break;
					case TowerType.crossbowTower: {
							switch (level) {
								case 1: {
										return Image.FromFile("../../Resources/Crossbow Tower.png");
									}
									break;
								case 2: {
										return Image.FromFile("../../Resources/Crossbow Tower2.png");
									}
								case 3: {
										return Image.FromFile("../../Resources/Crossbow Tower3.png");
									}
								default:
									return null;
							}
						}
					case TowerType.mageTower:
						switch (level) {
							case 1: {
									return Image.FromFile("../../Resources/Mage Tower.png");
								}
								break;
							case 2: {
									return Image.FromFile("../../Resources/Mage Tower2.png");
								}
							case 3: {
									return Image.FromFile("../../Resources/Mage Tower3.png");
								}
							default:
								return null;
						}
					case TowerType.sniperTower: {
							switch (level) {
								case 1: {
										return Image.FromFile("../../Resources/Mage Tower.png");
									}
									break;
								case 2: {
										return Image.FromFile("../../Resources/Mage Tower2.png");
									}
								case 3: {
										return Image.FromFile("../../Resources/Mage Tower3.png");
									}
								default:
									return null;
							}
						}
					default:
						return null;
				}
			}
		}
		//protected Label costlabel { get { return costlabel} set { costlabel.Text = "Cost: " + cost; } }
		protected Label rangeLabel;
		protected Label powerLabel;
		protected Tower tower;
		protected TowerType towerType;
		protected int cost;
		protected int range;
		protected int power;
		protected Map map;

		public virtual void Show(MapLocation spotLocation) {

			towerPanel.Location = CalculatePanelLocationFor(spotLocation, map);
			towerPanel.Show();
			towerPanel.BringToFront();
		}

		public void Hide() {
			towerPanel.Hide();
		}

		public void HideEveryPanelExcept(TowerPanel towerPanel) {

		}

		protected PictureBox FindPictureBoxIn(Panel panel, string namePictureBoxContains) {
			List<PictureBox> pictureBoxTempList = panel.Controls.OfType<PictureBox>().ToList();
			foreach (PictureBox pictureBox in pictureBoxTempList) {
				if (pictureBox.Name.Contains(namePictureBoxContains)) {
					return pictureBox;
				} else if (pictureBox.Name.Contains(namePictureBoxContains.First().ToString().ToUpper() + namePictureBoxContains.Substring(1))) {
					return pictureBox;
				}
			}
			return null;
		}

		protected Label FindLabelIn(Panel panel, string nameLabelContains) {
			List<Label> labelTempList = panel.Controls.OfType<Label>().ToList();
			foreach (Label label in labelTempList) {
				if (label.Name.Contains(nameLabelContains)) {
					return label;
				} else if(label.Name.Contains(nameLabelContains.First().ToString().ToUpper() + nameLabelContains.Substring(1))) {
					return label;
				}
			}
			return null;
		}

		protected virtual System.Drawing.Point CalculatePanelLocationFor(MapLocation spotLocation, Map map) {
			int x;
			int y;
			if (spotLocation.X > map.Width / 2) x = spotLocation.X * 70 - 150;
			else x = spotLocation.X * 70 + 50;
			if (spotLocation.Y > map.Height / 2) y = spotLocation.Y * 70 - 200;
			else y = spotLocation.Y * 70 + 50;
			return new System.Drawing.Point(x, y);
		}
	}





	class BasicTowerPanel : TowerPanel {
		private Label costLabel;
		private int cost;
		

		public BasicTowerPanel(Panel panel, Map map) {
			tower = new BasicTower(new MapLocation(0, 0, new Map(1, 1)));
			towerPanel = panel;
			level = 1;
			towerType = TowerType.noneTower;
			towerPictureBox = FindPictureBoxIn(panel, "basic");
			towerPictureBox.Image = towerImage;
			rangeLabel = FindLabelIn(panel, "range");
			range = tower.Range;
			rangeLabel.Text = "Range: " + range;
			powerLabel = FindLabelIn(panel, "power");
			power = tower.Power;
			powerLabel.Text = "Power: " + power;
			this.map = map;
		}

		public override void Show(MapLocation spotLocation) {


			base.Show(spotLocation);
		}
	}
	


	/*
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

			//********************************/
			//costLabel = tower.GetCost();
			//*******************************//
/*
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

					//********************************/
					//costLabel = tower.GetCost();
					//damageLabel = tower.GetDamage();
					//rangeLabel = tower.GetRange();
					//*******************************//
/*
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
*/
}

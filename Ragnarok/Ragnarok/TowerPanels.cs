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
										return Image.FromFile("../../Resources/Sniper Tower.png");
									}
									break;
								case 2: {
										return Image.FromFile("../../Resources/Sniper Tower2.png");
									}
								case 3: {
										return Image.FromFile("../../Resources/Sniper Tower3.png");
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

		public static void HideEveryPanelExceptFirst(TowerPanel towerPanel, BasicTowerPanel basicTowerPanel, SwitchTowerPanel switchTowerPanel, UpgradeTowerpanel upgradeTowerPanel) {
			if (towerPanel is BasicTowerPanel) {
				switchTowerPanel.Hide();
				upgradeTowerPanel.Hide();
			} else if (towerPanel is SwitchTowerPanel) {
				basicTowerPanel.Hide();
				upgradeTowerPanel.Hide();
			} else if (towerPanel is UpgradeTowerpanel) {
				basicTowerPanel.Hide();
				switchTowerPanel.Hide();
			}
		}

		public static void HideAllPanels(BasicTowerPanel basicTowerPanel, SwitchTowerPanel switchTowerPanel, UpgradeTowerpanel upgradeTowerPanel) {
			basicTowerPanel.Hide();
			switchTowerPanel.Hide();
			upgradeTowerPanel.Hide();
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

		protected Button FindButtonIn(Panel panel, string nameButtonContains) {
			List<Button> buttonTempList = panel.Controls.OfType<Button>().ToList();
			foreach (Button button in buttonTempList) {
				if (button.Name.Contains(nameButtonContains)) {
					return button;
				} else if (button.Name.Contains(nameButtonContains.First().ToString().ToUpper() + nameButtonContains.Substring(1))) {
					return button;
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
			costLabel = FindLabelIn(panel, "costLabel");
			//cost = tower.Cost;
			rangeLabel = FindLabelIn(panel, "range");
			range = tower.Range;
			rangeLabel.Text = "Range: " + range;
			powerLabel = FindLabelIn(panel, "power");
			power = tower.Power;
			powerLabel.Text = "Power: " + power;
			this.map = map;
		}
	}


	class SwitchTowerPanel : TowerPanel {
		private Label costLabel;
		private Label costLabel1;
		private Label costLabel2;
		private int cost;
		private int cost1;
		private int cost2;
		private Label rangeLabel1;
		private Label rangeLabel2;
		private Label powerLabel1;
		private Label powerLabel2;
		private Tower tower1;
		private Tower tower2;
		private int range1;
		private int range2;
		private int power1;
		private int power2;
		private Button sellButton;
		private int sellCost;

		public SwitchTowerPanel(Panel panel, Map map) {
			towerPanel = panel;
			tower = new CrossbowTower(new MapLocation(0, 0, map));
			tower1 = new MageTower(new MapLocation(0, 0, map));
			tower2 = new SniperTower(new MapLocation(0, 0, map));
			level = 1;
			towerType = TowerType.basicTower;
			rangeLabel = FindLabelIn(panel, "crossbowRange");
			range = tower.Range;
			rangeLabel.Text = "Range: " + range;
			rangeLabel1 = FindLabelIn(panel, "mageRange");
			range1 = tower1.Range;
			rangeLabel1.Text = "Range: " + range1;
			rangeLabel2 = FindLabelIn(panel, "sniperRange");
			range2 = tower2.Range;
			rangeLabel2.Text = "Range: " + range2;

			powerLabel = FindLabelIn(panel, "crossbowPower");
			power = tower.Power;
			powerLabel.Text = "Power: " + power;
			powerLabel1 = FindLabelIn(panel, "magePower");
			power1 = tower1.Power;
			powerLabel1.Text = "Power: " + power1;
			powerLabel2 = FindLabelIn(panel, "sniperPower");
			power2 = tower2.Power;
			powerLabel2.Text = "Power: " + power2;

			BasicTower basicTower = new BasicTower(new MapLocation(0, 0, map));
			//sellCost = basicTower.SellCost;
			//sellButton = FindButtonIn(panel, "sellButton");
			//sellButton.Text = "Sell: (+ $") +sellCost.ToString();

			this.map = map;
		}
	}

	class UpgradeTowerpanel : TowerPanel {
		private Label titleLabel;
		private Label costLabel;
		private int cost;
		private Label levelLabel;
		private Button sellButton;
		private int sellCost;

		public UpgradeTowerpanel(Panel panel, Map map) {
			towerPanel = panel;
			titleLabel = FindLabelIn(panel, "titleLabel");
			towerPictureBox = FindPictureBoxIn(panel, "upgrade");
			levelLabel = FindLabelIn(panel, "level");
			rangeLabel = FindLabelIn(panel, "rangeLabel");
			powerLabel = FindLabelIn(panel, "powerLabel");
			sellButton = FindButtonIn(panel, "sellButton");
			this.map = map;
		}

		public void Show(MapLocation spotLocation, Tower tower) {
			base.Show(spotLocation);
			if (tower is CrossbowTower) {
				titleLabel.Text = "Crossbow Tower";
				towerType = TowerType.crossbowTower;
			} else if (tower is MageTower) {
				titleLabel.Text = "Mage Tower";
				towerType = TowerType.mageTower;
			} else {
				titleLabel.Text = "Sniper Tower";
				towerType = TowerType.sniperTower;
			}
			towerPictureBox.Image = towerImage;
			level = tower.UpgradeLevel + 1;
			levelLabel.Text = "Level: " + level.ToString();
			//cost = tower.Cost;
			range = tower.Range;
			rangeLabel.Text = "Range: " + range.ToString();
			power = tower.Power;
			powerLabel.Text = "Power: " + power.ToString();
			//sellCost = tower.SellCost;
			//sellButton.Text = "Sell: (+ $") + sellCost.ToString();

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

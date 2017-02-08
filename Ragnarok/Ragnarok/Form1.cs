using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();

			game = new Game();

			// Inicjalizuję obiekty okien
			mainMenu = new MainMenu(mainMenuPanel, closeMenuButton, startNewGameButton, loadGameButton, menuSettingsButton, menuQuitButton);
			mainSettingsPanel = new Settings(this, mapPanel, settingsPanel, sfxCheckBox, musicCheckBox, navyColor, blackColor);
			mainMapPanel = new MapPanel(mapPanel, game.map, game.towerSpots, game.path);
			basicTowerPanelObj = new BasicTowerPanel(basicPanel, game.map);
			switchTowerPanelObj = new SwitchTowerPanel(switchPanel, game.map);
			upgradeTowerPanelObj = new UpgradeTowerPanel(upgradePanel, game.map);
			ragnarokTowerPanelObj = new RagnarokTowerPanel(ragnarokPanel, game.map);


			//Ukrywam kolejne panele programu
			mainMenu.Hide();
			mainSettingsPanel.Hide();
			mainMapPanel.Hide();
			TowerPanel.HideAllPanels(basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);

			mainMenu.ShowMenuWithoutCloseButtonIn(this);
		}

		private MainMenu mainMenu;
		private Settings mainSettingsPanel;
		private MapPanel mainMapPanel;
		private BasicTowerPanel basicTowerPanelObj;
		private SwitchTowerPanel switchTowerPanelObj;
		private UpgradeTowerPanel upgradeTowerPanelObj;
		private RagnarokTowerPanel ragnarokTowerPanelObj;

		private Game game;


		// Metoda centrująca panele w Formie
		public static System.Drawing.Point CenterPointOf(Form1 form, Panel panel) {
			System.Drawing.Point centerPoint = new System.Drawing.Point(
				form.Size.Width / 2 - panel.Size.Width / 2,
				form.Size.Height / 2 - panel.Size.Height);
			return centerPoint;
		}

		// Metody menu
		private void startNewGameButton_Click(object sender, EventArgs e) {
			mainMenu.Hide();
			mainMapPanel.Show();
			InitializePictureBoxEvents();
		}

		private void loadGameButton_Click(object sender, EventArgs e) {

		}

		private void menuSettingsButton_Click(object sender, EventArgs e) {
			mainMenu.Hide();
			mainSettingsPanel.Show(this);
		}

		private void menuQuitButton_Click(object sender, EventArgs e) {
			Close();
		}

		private void closeMenuButton_Click(object sender, EventArgs e) {
		}

		private void PBTowerSpots0_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[0].X, game.towerSpots[0].Y, game.map);
			Tower tower = mainMapPanel.WhatTowerIsPlacedOn(location, game.towers.ToArray());
			if (tower == null) {
				basicTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(basicTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is BasicTower) {
				switchTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(switchTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is CrossbowTower || tower is MageTower || tower is SniperTower) {
				if (tower.UpgradeLevel < 3) {
					upgradeTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(upgradeTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				} else {
					ragnarokTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(ragnarokTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				}
			}
		}

		private void PBTowerSpots1_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[1].X, game.towerSpots[1].Y, game.map);
			Tower tower = mainMapPanel.WhatTowerIsPlacedOn(location, game.towers.ToArray());
			if (tower == null) {
				basicTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(basicTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is BasicTower) {
				switchTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(switchTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is CrossbowTower || tower is MageTower || tower is SniperTower) {
				if (tower.UpgradeLevel < 3) {
					upgradeTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(upgradeTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				} else {
					ragnarokTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(ragnarokTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				}
			}
		}

		private void PBTowerSpots2_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[2].X, game.towerSpots[2].Y, game.map);
			Tower tower = mainMapPanel.WhatTowerIsPlacedOn(location, game.towers.ToArray());
			if (tower == null) {
				basicTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(basicTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is BasicTower) {
				switchTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(switchTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is CrossbowTower || tower is MageTower || tower is SniperTower) {
				if (tower.UpgradeLevel < 3) {
					upgradeTowerPanelObj.Show(location, tower);
					TowerPanel.HideEveryPanelExceptFirst(upgradeTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				} else {
					ragnarokTowerPanelObj.Show(location, tower);
					TowerPanel.HideEveryPanelExceptFirst(ragnarokTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				}
			}
		}

		private void PBTowerSpots3_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[3].X, game.towerSpots[3].Y, game.map);
			Tower tower = mainMapPanel.WhatTowerIsPlacedOn(location, game.towers.ToArray());
			if (tower == null) {
				basicTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(basicTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is BasicTower) {
				switchTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(switchTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is CrossbowTower || tower is MageTower || tower is SniperTower) {
				if (tower.UpgradeLevel < 3) {
					upgradeTowerPanelObj.Show(location, tower);
					TowerPanel.HideEveryPanelExceptFirst(upgradeTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				} else {
					ragnarokTowerPanelObj.Show(location, tower);
					TowerPanel.HideEveryPanelExceptFirst(ragnarokTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				}
			}
		}

		private void PBTowerSpots4_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[4].X, game.towerSpots[4].Y, game.map);
			Tower tower = mainMapPanel.WhatTowerIsPlacedOn(location, game.towers.ToArray());
			if (tower == null) {
				basicTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(basicTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is BasicTower) {
				switchTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(switchTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is CrossbowTower || tower is MageTower || tower is SniperTower) {
				if (tower.UpgradeLevel < 3) {
					upgradeTowerPanelObj.Show(location, tower);
					TowerPanel.HideEveryPanelExceptFirst(upgradeTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				} else {
					ragnarokTowerPanelObj.Show(location, tower);
					TowerPanel.HideEveryPanelExceptFirst(ragnarokTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				}
			}
		}

		private void PBTowerSpots5_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[5].X, game.towerSpots[5].Y, game.map);
			Tower tower = mainMapPanel.WhatTowerIsPlacedOn(location, game.towers.ToArray());
			if (tower == null) {
				basicTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(basicTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is BasicTower) {
				switchTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(switchTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is CrossbowTower || tower is MageTower || tower is SniperTower) {
				if (tower.UpgradeLevel < 3) {
					upgradeTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(upgradeTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				} else {
					ragnarokTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(ragnarokTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				}
			}
		}

		private void PBTowerSpots6_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[6].X, game.towerSpots[6].Y, game.map);
			Tower tower = mainMapPanel.WhatTowerIsPlacedOn(location, game.towers.ToArray());
			if (tower == null) {
				basicTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(basicTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is BasicTower) {
				switchTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(switchTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is CrossbowTower || tower is MageTower || tower is SniperTower) {
				if (tower.UpgradeLevel < 3) {
					upgradeTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(upgradeTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				} else {
					ragnarokTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(ragnarokTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				}
			}
		}

		private void PBTowerSpots7_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[7].X, game.towerSpots[7].Y, game.map);
			Tower tower = mainMapPanel.WhatTowerIsPlacedOn(location, game.towers.ToArray());
			if (tower == null) {
				basicTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(basicTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is BasicTower) {
				switchTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(switchTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is CrossbowTower || tower is MageTower || tower is SniperTower) {
				if (tower.UpgradeLevel < 3) {
					upgradeTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(upgradeTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				} else {
					ragnarokTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(ragnarokTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				}
			}
		}

		private void PBTowerSpots8_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[8].X, game.towerSpots[8].Y, game.map);
			Tower tower = mainMapPanel.WhatTowerIsPlacedOn(location, game.towers.ToArray());
			if (tower == null) {
				basicTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(basicTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is BasicTower) {
				switchTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(switchTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is CrossbowTower || tower is MageTower || tower is SniperTower) {
				if (tower.UpgradeLevel < 3) {
					upgradeTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(upgradeTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				} else {
					ragnarokTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(ragnarokTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				}
			}
		}

		private void PBTowerSpots9_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[9].X, game.towerSpots[9].Y, game.map);
			Tower tower = mainMapPanel.WhatTowerIsPlacedOn(location, game.towers.ToArray());
			if (tower == null) {
				basicTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(basicTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is BasicTower) {
				switchTowerPanelObj.Show(location);
				TowerPanel.HideEveryPanelExceptFirst(switchTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
			} else if (tower is CrossbowTower || tower is MageTower || tower is SniperTower) {
				if (tower.UpgradeLevel < 3) {
					upgradeTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(upgradeTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				} else {
					ragnarokTowerPanelObj.Show(location);
					TowerPanel.HideEveryPanelExceptFirst(ragnarokTowerPanelObj, basicTowerPanelObj, switchTowerPanelObj, upgradeTowerPanelObj, ragnarokTowerPanelObj);
				}
			}
		}

		private void basicPanelCloseButton_Click(object sender, EventArgs e) {
			basicTowerPanelObj.Hide();
		}

		private void switchCloseButton_Click(object sender, EventArgs e) {
			switchTowerPanelObj.Hide();
		}

		private void upgradePanelCloseButton_Click(object sender, EventArgs e) {
			upgradeTowerPanelObj.Hide();
		}

		private void ragnarokPanelCloseButton_Click(object sender, EventArgs e) {
			ragnarokTowerPanelObj.Hide();
		}

		private void closeButton_Click(object sender, EventArgs e) {
			mainSettingsPanel.Close(false);
			mainMenu.Show();
		}

		private void saveButton_Click(object sender, EventArgs e) {
			mainSettingsPanel.Close(true);
			mainMenu.Show();
		}
	}
}

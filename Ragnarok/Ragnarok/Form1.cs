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
			mainMapPanel = new MapPanel(mapPanel, game.map, game.towerSpots);
			basicTowerPanelObj = new BasicTowerPanel(basicPanel, basicPanelTowerImage, basicPanelCostLabel, basicPanelDamageLabel, basicPanelRangeLabel);
			switchTowerPanel = new SwitchTowerPanel(switchPanel, switchPictureBox, switchCostLabel);
			upgradeTowerPanelObj = new UpgradeTowerPanel(upgradePanel, upgradePanelImage, upgradePanelCostLabel, upgradePanelDamagelabel, upgradePanelRangeLabel);

			//Ukrywam kolejne panele programu
			mainMenu.Hide();
			mainMapPanel.Hide();
			basicTowerPanelObj.Hide();
			switchTowerPanel.Hide();
			upgradeTowerPanelObj.Hide();

			mainMenu.ShowMenuWithoutCloseButtonIn(this);
		}

		private MainMenu mainMenu;
		private MapPanel mainMapPanel;
		private BasicTowerPanel basicTowerPanelObj;
		private SwitchTowerPanel switchTowerPanel;
		private UpgradeTowerPanel upgradeTowerPanelObj;
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

		}

		private void menuQuitButton_Click(object sender, EventArgs e) {
			Close();
		}

		private void closeMenuButton_Click(object sender, EventArgs e) {
		}

		private void mapPanel_Click(object sender, EventArgs e) {
		}

		private void PBTowerSpots0_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[0].X, game.towerSpots[0].Y, game.map);
			Tower tempTower = mainMapPanel.WhatTowerIsPlaced(location, game.towers.ToArray());
			if (tempTower == null) {
				basicTowerPanelObj.Show(location);
				switchTowerPanel.Hide();
				upgradeTowerPanelObj.Hide();
			} else if (tempTower is BasicTower) {
				switchTowerPanel.Show(location);
				basicTowerPanelObj.Hide();
				upgradeTowerPanelObj.Hide();
			} else if (tempTower is CrossbowTower || tempTower is MageTower || tempTower is SniperTower) {
				upgradeTowerPanelObj.Show(location, game.towers.ToArray());
				basicTowerPanelObj.Hide();
				switchTowerPanel.Hide();
			}
		}

		private void PBTowerSpots1_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[1].X, game.towerSpots[1].Y, game.map);
			Tower tempTower = mainMapPanel.WhatTowerIsPlaced(location, game.towers.ToArray());
			if (tempTower == null) {
				basicTowerPanelObj.Show(location);
				switchTowerPanel.Hide();
				upgradeTowerPanelObj.Hide();
			} else if (tempTower is BasicTower) {
				switchTowerPanel.Show(location);
				basicTowerPanelObj.Hide();
				upgradeTowerPanelObj.Hide();
			} else if (tempTower is CrossbowTower || tempTower is MageTower || tempTower is SniperTower) {
				upgradeTowerPanelObj.Show(location, game.towers.ToArray());
				basicTowerPanelObj.Hide();
				switchTowerPanel.Hide();
			}
		}

		private void PBTowerSpots2_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[2].X, game.towerSpots[2].Y, game.map);
			Tower tempTower = mainMapPanel.WhatTowerIsPlaced(location, game.towers.ToArray());
			if (tempTower == null) {
				basicTowerPanelObj.Show(location);
				switchTowerPanel.Hide();
				upgradeTowerPanelObj.Hide();
			} else if (tempTower is BasicTower) {
				switchTowerPanel.Show(location);
				basicTowerPanelObj.Hide();
				upgradeTowerPanelObj.Hide();
			} else if (tempTower is CrossbowTower || tempTower is MageTower || tempTower is SniperTower) {
				upgradeTowerPanelObj.Show(location, game.towers.ToArray());
				basicTowerPanelObj.Hide();
				switchTowerPanel.Hide();
			}
		}

		private void PBTowerSpots3_Click(object sender, EventArgs e) {
			//basicTowerPanelObj.Show(new MapLocation(game.towerSpots[3].X, game.towerSpots[3].Y, game.map), game.towers.ToArray());
		}

		private void PBTowerSpots4_Click(object sender, EventArgs e) {
			//basicTowerPanelObj.Show(new MapLocation(game.towerSpots[4].X, game.towerSpots[4].Y, game.map), game.towers.ToArray());
		}

		private void PBTowerSpots5_Click(object sender, EventArgs e) {
			//basicTowerPanelObj.Show(new MapLocation(game.towerSpots[5].X, game.towerSpots[5].Y, game.map), game.towers.ToArray());
		}

		private void PBTowerSpots6_Click(object sender, EventArgs e) {
			//basicTowerPanelObj.Show(new MapLocation(game.towerSpots[6].X, game.towerSpots[6].Y, game.map), game.towers.ToArray());
		}

		private void PBTowerSpots7_Click(object sender, EventArgs e) {
			//basicTowerPanelObj.Show(new MapLocation(game.towerSpots[7].X, game.towerSpots[7].Y, game.map), game.towers.ToArray());
		}

		private void PBTowerSpots8_Click(object sender, EventArgs e) {
			//basicTowerPanelObj.Show(new MapLocation(game.towerSpots[8].X, game.towerSpots[8].Y, game.map), game.towers.ToArray());
		}

		private void PBTowerSpots9_Click(object sender, EventArgs e) {
			//basicTowerPanelObj.Show(new MapLocation(game.towerSpots[9].X, game.towerSpots[9].Y, game.map), game.towers.ToArray());
		}

		private void basicPanelCloseButton_Click(object sender, EventArgs e) {
			basicTowerPanelObj.Hide();
		}

		private void switchCloseButton_Click(object sender, EventArgs e) {
			switchTowerPanel.Hide();
		}

		private void upgradePanelCloseButton_Click(object sender, EventArgs e) {
			upgradeTowerPanelObj.Hide();
		}
	}
}

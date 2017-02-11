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

			lifesStatusLabel.Hide();
			goldStatusLabel.Hide();
			startButton.Hide();
			pauseButton.Hide();

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
			game = new Game();

			mainMenu.Hide();
			mainMapPanel.Show();
			InitializePictureBoxEvents();

			lifesStatusLabel.Show();
			goldStatusLabel.Show();
			startButton.Show();
			pauseButton.Show();

			UpdateLifes();
			UpdateGold();
			startButton.Enabled = true;
			pauseButton.Enabled = true;
			mapPanel.Enabled = true;
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
			drawing_timer.Start();
			startButton.Enabled = true;
			pauseButton.Enabled = true;
			mapPanel.Enabled = true;
			mainMenuPanel.Hide();
		}

		//Metody start i pause

		private void startButton_Click(object sender, EventArgs e) {
            game_timer.Start();
            drawing_timer.Start();
		}

		private void pauseButton_Click(object sender, EventArgs e) {
            game_timer.Stop();
            drawing_timer.Stop();
			startButton.Enabled = false;
			pauseButton.Enabled = false;
			mapPanel.Enabled = false;
			mainMenu.ShowMenuIn(this);
		}

		private void UpdateGold() {
			goldStatusLabel.Text = "Gold: " + game.player.gold + "$";
		}

		private void UpdateLifes() {
			lifesStatusLabel.Text = "Lifes: " + game.player.lives;
		}

		//Metoda wywoływana przy klikaniu na PB wieży
		private void TowerPBClickedOnSpot(MapLocation location) {
			TowerPanel.CurrentTowerSpot = location;
			Tower tower = mainMapPanel.WhatTowerIsPlacedOn(location, game.towers.ToArray());
			TowerPanel.CurrentTower = tower;
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

		private void PBTowerSpots0_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[0].X, game.towerSpots[0].Y, game.map);
			TowerPBClickedOnSpot(location);
		}

		private void PBTowerSpots1_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[1].X, game.towerSpots[1].Y, game.map);
			TowerPBClickedOnSpot(location);
		}

		private void PBTowerSpots2_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[2].X, game.towerSpots[2].Y, game.map);
			TowerPBClickedOnSpot(location);
		}

		private void PBTowerSpots3_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[3].X, game.towerSpots[3].Y, game.map);
			TowerPBClickedOnSpot(location);
		}

		private void PBTowerSpots4_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[4].X, game.towerSpots[4].Y, game.map);
			TowerPBClickedOnSpot(location);
		}

		private void PBTowerSpots5_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[5].X, game.towerSpots[5].Y, game.map);
			TowerPBClickedOnSpot(location);
		}

		private void PBTowerSpots6_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[6].X, game.towerSpots[6].Y, game.map);
			TowerPBClickedOnSpot(location);
		}

		private void PBTowerSpots7_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[7].X, game.towerSpots[7].Y, game.map);
			TowerPBClickedOnSpot(location);
		}

		private void PBTowerSpots8_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[8].X, game.towerSpots[8].Y, game.map);
			TowerPBClickedOnSpot(location);
		}

		private void PBTowerSpots9_Click(object sender, EventArgs e) {
			MapLocation location = new MapLocation(game.towerSpots[9].X, game.towerSpots[9].Y, game.map);
			TowerPBClickedOnSpot(location);
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

		//Przyciski stawiania, kupowania, upgradowania, sprzedawania wież
		private void buyBasicTowerButton_Click(object sender, EventArgs e) {
			if (game.player.SubGold(BasicTower.Cost)) {
				BasicTower basicTower = new BasicTower(TowerPanel.CurrentTowerSpot);
				game.AddTower(basicTower);
				mainMapPanel.DrawTowerOnSpot(TowerPanel.CurrentTowerSpot, basicTower, game);
				
			} else {
				MessageBox.Show("You need more gold to buy this tower.", "Not enough gold");
			}
			basicTowerPanelObj.Hide();
			UpdateGold();
		}

		private void switchCrossbowButton_Click(object sender, EventArgs e) {
			if (game.player.SubGold(CrossbowTower.Cost)) {
				game.SwitchTowers(TowerPanel.CurrentTower, TowerType.crossbowTower);
				mainMapPanel.DrawTowerOnSpot(TowerPanel.CurrentTowerSpot, (CrossbowTower)TowerPanel.CurrentTower, game);
			} else {
				MessageBox.Show("You need more gold to buy this tower.", "Not enough gold");
			}
			switchTowerPanelObj.Hide();
			UpdateGold();
		}

		private void switchMageButton_Click(object sender, EventArgs e) {
			if(game.player.SubGold(MageTower.Cost)) {
				game.SwitchTowers(TowerPanel.CurrentTower, TowerType.mageTower);
				mainMapPanel.DrawTowerOnSpot(TowerPanel.CurrentTowerSpot, (MageTower)TowerPanel.CurrentTower, game);
			} else {
				MessageBox.Show("You need more gold to buy this tower.", "Not enough gold");
			}
			switchTowerPanelObj.Hide();
			UpdateGold();
		}

		private void switchSniperButton_Click(object sender, EventArgs e) {
			if(game.player.SubGold(SniperTower.Cost)) {
				game.SwitchTowers(TowerPanel.CurrentTower, TowerType.sniperTower);
				mainMapPanel.DrawTowerOnSpot(TowerPanel.CurrentTowerSpot, (SniperTower)TowerPanel.CurrentTower, game);
			} else {
				MessageBox.Show("You need more gold to buy this tower.", "Not enough gold");
			}
			switchTowerPanelObj.Hide();
			UpdateGold();
		}

		private void switchSellButton_Click(object sender, EventArgs e) {
			game.player.AddGold(BasicTower.SellCost);
			game.DeleteTower(TowerPanel.CurrentTower);
			mainMapPanel.DrawTowerOnSpot(TowerPanel.CurrentTowerSpot, game);
			switchTowerPanelObj.Hide();
			UpdateGold();
		}

		private void upgradePanelSellButton_Click(object sender, EventArgs e) {
			if (TowerPanel.CurrentTower is CrossbowTower) {
				game.player.AddGold(CrossbowTower.SellCost * TowerPanel.CurrentTower.UpgradeLevel);
			} else if (TowerPanel.CurrentTower is MageTower) {
				game.player.AddGold(MageTower.SellCost * TowerPanel.CurrentTower.UpgradeLevel);
			} else {
				game.player.AddGold(SniperTower.SellCost * TowerPanel.CurrentTower.UpgradeLevel);
			}
			game.DeleteTower(TowerPanel.CurrentTower);
			mainMapPanel.DrawTowerOnSpot(TowerPanel.CurrentTowerSpot, game);
			upgradeTowerPanelObj.Hide();
			UpdateGold();
		}

		private void upgradePanelUpgradeButton_Click(object sender, EventArgs e) {
			if (upgradeTowerPanelObj.towerType == TowerType.crossbowTower) {
				if(game.player.SubGold(CrossbowTower.Cost * TowerPanel.CurrentTower.UpgradeLevel)) {
					TowerPanel.CurrentTower.Upgrade();
					mainMapPanel.DrawTowerOnSpot(TowerPanel.CurrentTowerSpot, (CrossbowTower)TowerPanel.CurrentTower, game);
					upgradeTowerPanelObj.Hide();
				} else {
					MessageBox.Show("You need more gold to buy this tower.", "Not enough gold");
				}
			} else if (upgradeTowerPanelObj.towerType == TowerType.mageTower) {
				if(game.player.SubGold(MageTower.Cost * TowerPanel.CurrentTower.UpgradeLevel)) {
					TowerPanel.CurrentTower.Upgrade();
					mainMapPanel.DrawTowerOnSpot(TowerPanel.CurrentTowerSpot, (MageTower)TowerPanel.CurrentTower, game);
					upgradeTowerPanelObj.Hide();
				} else {
					MessageBox.Show("You need more gold to buy this tower.", "Not enough gold");
				}
			} else {
				if(game.player.SubGold(SniperTower.Cost * TowerPanel.CurrentTower.UpgradeLevel)) {
					TowerPanel.CurrentTower.Upgrade();
					mainMapPanel.DrawTowerOnSpot(TowerPanel.CurrentTowerSpot, (SniperTower)TowerPanel.CurrentTower, game);
					upgradeTowerPanelObj.Hide();
				} else {
					MessageBox.Show("You need more gold to buy this tower.", "Not enough gold");
				}
			}
			UpdateGold();
		}

		private void ragnarokPanelSellButton_Click(object sender, EventArgs e) {
			if (TowerPanel.CurrentTower is CrossbowTower) {
				game.player.AddGold(CrossbowTower.SellCost * TowerPanel.CurrentTower.UpgradeLevel);
			} else if (TowerPanel.CurrentTower is MageTower) {
				game.player.AddGold(MageTower.SellCost * TowerPanel.CurrentTower.UpgradeLevel);
			} else {
				game.player.AddGold(SniperTower.SellCost * TowerPanel.CurrentTower.UpgradeLevel);
			}
			game.DeleteTower(TowerPanel.CurrentTower);
			mainMapPanel.DrawTowerOnSpot(TowerPanel.CurrentTowerSpot, game);
			ragnarokTowerPanelObj.Hide();
			UpdateGold();
		}

		//*******************************************************/////

		private void drawing_timer_Tick(object sender, EventArgs e) {
            game.UpdateDrawing(mainMapPanel);
        }

        private void game_timer_Tick(object sender, EventArgs e) {
            game.PlayTurn();
			UpdateGold();
			UpdateLifes();
        }
	}

}

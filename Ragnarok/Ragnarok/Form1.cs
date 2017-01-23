using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok
{
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();

            game = new Game();

			// Inicjalizuję obiekty okien
			mainMenu = new MainMenu(mainMenuPanel, closeMenuButton, startNewGameButton, loadGameButton, menuSettingsButton, menuQuitButton);
			mainMapPanel = new MapPanel(mapPanel, game.map, game.towerSpots);

			//Ukrywam kolejne panele programu
			mainMenu.Hide();
			mainMapPanel.Hide();

			mainMenu.ShowMenuWithoutCloseButtonIn(this);
		}

		private MainMenu mainMenu;
		private MapPanel mainMapPanel;
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
	}
}

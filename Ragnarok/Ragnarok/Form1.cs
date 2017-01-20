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

			// Inicjalizuję obiekty okien
			mainMenu = new MainMenu(mainMenuPanel, closeMenuButton, startNewGameButton, loadGameButton, menuSettingsButton, menuQuitButton);

			//Ukrywam kolejne panele programu
			mainMenu.HideMenu();


			mainMenu.ShowMenuWithoutCloseButtonIn(this);
		}

		private MainMenu mainMenu;

		// Metoda centrująca panele w Formie
		public static System.Drawing.Point CenterPointOf(Form1 form, Panel panel) {
			System.Drawing.Point centerPoint = new System.Drawing.Point(
				form.Size.Width / 2 - panel.Size.Width / 2,
				form.Size.Height / 2 - panel.Size.Height);
			return centerPoint;
		}

		// Metody menu
		private void startNewGameButton_Click(object sender, EventArgs e) {
			mainMenu.HideMenu();
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
	}
}

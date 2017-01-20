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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			mainMenu = new MainMenu(mainMenuPanel, closeMenuButton, startNewGameButton, loadGameButton, menuSettingsButton, menuQuitButton);
			mainMenu.ShowMenuWithoutCloseButtonIn(this);
		}

		private MainMenu mainMenu;

		private void startNewGameButton_Click(object sender, EventArgs e) {
			// New Game
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

		private void showMenuButton_Click(object sender, EventArgs e) {
		}

		
	}
}

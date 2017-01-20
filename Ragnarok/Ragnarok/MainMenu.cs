using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	class MainMenu {

		private Panel menuPanel;
		private Button closeButton;
		private Button startNewGameButton;
		private Button loadGameButton;
		private Button settingsButton;
		private Button quitButton;

		public MainMenu(
			Panel menuPanel, Button closeButton, Button startNewGameButton, 
			Button loadGameButton, Button settingsButton, Button quitButton) {
			this.menuPanel = menuPanel;
			this.closeButton = closeButton;
			this.startNewGameButton = startNewGameButton;
			this.loadGameButton = loadGameButton;
			this.settingsButton = settingsButton;
			this.quitButton = quitButton;
		}

		public System.Drawing.Point CenterPointOf(Form1 form, Panel panel) {
			System.Drawing.Point centerPoint = new System.Drawing.Point(
				form.Size.Width / 2 - panel.Size.Width / 2, 
				form.Size.Height / 2 - panel.Size.Height);
			return centerPoint;
		}

		public void ShowMenuIn(Form1 form) {
			menuPanel.Location = CenterPointOf(form, menuPanel);	
			menuPanel.Show();
		}

		public void ShowMenuWithoutCloseButtonIn(Form1 form) {
			ShowMenuIn(form);
			closeButton.Hide();
		}

		public void HideMenu() {
			menuPanel.Hide();
		}
	}
}

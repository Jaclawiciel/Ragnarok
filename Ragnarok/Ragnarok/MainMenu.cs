using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	class MainMenu : IPanel {

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

		public void Show() {
			menuPanel.Show();
		}

		public void ShowMenuIn(Form1 form) {
			menuPanel.Location = Form1.CenterPointOf(form, menuPanel);
			menuPanel.Show();
		}

		public void ShowMenuWithoutCloseButtonIn(Form1 form) {
			ShowMenuIn(form);
			closeButton.Hide();
		}

		public void Hide() {
			menuPanel.Hide();
		}
	}
}

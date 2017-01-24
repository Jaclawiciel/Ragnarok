using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	class BasicTowerPanel {
		private Panel basicTowerPanel;
		private PictureBox towerImage;
		private Label costLabel;
		private Label damageLabel;
		private Label rangeLabel;

		public BasicTowerPanel(Panel basicTowerPanel, PictureBox towerImage, Label costLabel, Label damageLabel, Label rangeLabel) {
			this.basicTowerPanel = basicTowerPanel;
			this.towerImage = towerImage;
			this.costLabel = costLabel;
			this.damageLabel = damageLabel;
			this.rangeLabel = rangeLabel;
		}

		public void Show(Tower tower) {
			towerImage.Image = GetTowerImageFor(tower);

			//********************************//
			//costLabel = tower.GetCost();
			//damageLabel = tower.GetDamage();
			//rangeLabel = tower.GetRange();
			//*******************************//

			basicTowerPanel.Show();
		}

		private Image GetTowerImageFor(Tower tower) {
			if (tower is BasicTower) {
				return Image.FromFile("../../Resources/Basic Tower.png");
			} else if (tower is MageTower) {
				// Sprawdź jaki stopień upgradu wieży
				return Image.FromFile("../../Resources/Mage Tower.png");
			} else if (tower is SniperTower) {
				// Sprawdź jaki stopień wieży
				return Image.FromFile("../../Resurces/Sniper Tower.png");
			} else {
				// Sprawdź jaki stopień wieży
				return Image.FromFile("../../Resources/Crossbow Tower.png");
			}
		}
	}

	class UpgradeTowerPanel {

	}
}

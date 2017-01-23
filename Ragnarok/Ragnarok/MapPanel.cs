using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	class MapPanel : IPanel {
		private Panel panel;
		public PictureBox[,] fields { get; private set; }

		public MapPanel(Panel panel, Map map) {
			this.panel = panel;
			panel.Size = new System.Drawing.Size(map.Width * 70, map.Height * 70);
			panel.BackgroundImage
		}

		public void Show() {
			panel.Show();
		}

		public void Hide() {
			panel.Hide();
		}

		private void DrawPath(Path path) {

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	class MapPanel {
		private Panel panel;
		public PictureBox[,] fields { get; private set; }

		public MapPanel(Panel panel, int width, int height) {
			this.panel = panel;
			GenerateFields(width, height);
		}

		public void Show() {
			panel.Show();
		}

		public void Hide() {
			panel.Hide();
		}

		private void GenerateFields(int width, int height) {
			fields = new PictureBox[width,height];
			for (int i = 0; i < width; i++) {
				for (int j = 0; j < height; j++) {
					fields[i, j] = new PictureBox();
					fields[i, j].Size = new System.Drawing.Size(70, 70);
					fields[i, j].Location = new System.Drawing.Point(i * 70, j * 70);
					fields[i, j].BackColor = System.Drawing.Color.Brown;
					fields[i, j].BorderStyle = BorderStyle.FixedSingle;
					panel.Controls.Add(fields[i, j]);
				}
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarok {
	class Settings {
		private Panel settingsPanel;
		private CheckBox sfxCheckBox;
		private CheckBox musicCheckBox;
		public bool AudioState;
		public bool MusicState;

		public Settings(Panel settingsPanel, CheckBox sfxCheckBox, CheckBox musicCheckBox) {
			this.settingsPanel = settingsPanel;
			this.sfxCheckBox = sfxCheckBox;
			this.musicCheckBox = musicCheckBox;
			LoadFromFie();
		}

		public void Hide() {
			settingsPanel.Hide();
		}

		public void Show(Form1 form) {
			settingsPanel.Location = Form1.CenterPointOf(form, settingsPanel);
			settingsPanel.Show();
			settingsPanel.BringToFront();
		}

		public void Close(bool saveData) {
			if (saveData) {
				SaveToFile();
			} else {
				LoadFromFie();
			}
			Hide();
		}

		private void SaveToFile() {
			AudioState = sfxCheckBox.Checked;
			MusicState = musicCheckBox.Checked;

			String[] lines = new String[2];
			lines[0] = "audio" + "," + sfxCheckBox.Checked.ToString();
			lines[1] = "music" + "," + musicCheckBox.Checked.ToString();

			string myDocPath = @"..\..\Resources\";
			using(StreamWriter outputFile = new StreamWriter(myDocPath + @"settings.txt")) {
				foreach (string line in lines) {
					outputFile.WriteLine(line);
				}
			}
		}

		private void LoadFromFie() {
			string myDocPath = @"..\..\Resources\";
			int counter = 0;
			string line;
			List<String> lines = new List<string>();
			lines.RemoveRange(0, lines.Count);

			StreamReader file = new StreamReader(myDocPath + @"settings.txt");

			while ((line = file.ReadLine()) != null) {
				lines.Add(line);
				counter++;
			}
			file.Close();

			string[] lineElements = lines[0].Split(',');
			if (lineElements[1] == "true") {
				sfxCheckBox.Checked = true;
				AudioState = true;
			} else {
				sfxCheckBox.Checked = false;
				AudioState = false;
			}

			lineElements = lines[1].Split(',');
			if (lineElements[1] == "true") {
				musicCheckBox.Checked = true;
				MusicState = true;
			} else {
				musicCheckBox.Checked = false;
				MusicState = false;
			}
		}
	}
}

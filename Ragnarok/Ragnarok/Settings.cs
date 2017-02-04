using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Ragnarok {
	class Settings {
		private Form form;
		private Panel mapPanel;
		private Panel settingsPanel;
		private CheckBox sfxCheckBox;
		private CheckBox musicCheckBox;
		public bool AudioState;
		public bool MusicState;
		private RadioButton blueButton;
		private RadioButton blackButton;
		private string color;
		private string _color {
			get {
				return color;
			}
			set {
				color = value;
				if (value == "blue") {
					form.BackColor = Color.Navy;
					mapPanel.BackColor = Color.Navy;
					blueButton.Checked = true;
				} else {
					form.BackColor = Color.Black;
					mapPanel.BackColor = Color.Black;
					blackButton.Checked = true;
				}
			}
		}

		public Settings(Form1 form, Panel mapPanel, Panel settingsPanel, CheckBox sfxCheckBox, CheckBox musicCheckBox, RadioButton blueRadioButton, RadioButton blackRadioButton) {
			this.settingsPanel = settingsPanel;
			this.sfxCheckBox = sfxCheckBox;
			this.musicCheckBox = musicCheckBox;
			this.blueButton = blueRadioButton;
			this.blackButton = blackRadioButton;
			this.mapPanel = mapPanel;
			this.form = form;
			LoadFromFile();
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
				LoadFromFile();
			}
			Hide();
		}

		private void SaveToFile() {
			AudioState = sfxCheckBox.Checked;
			MusicState = musicCheckBox.Checked;
			if (blueButton.Checked) {
				_color = "blue";
			} else {
				_color = "black";
			}

			String[] lines = new String[3];
			lines[0] = "audio" + "," + sfxCheckBox.Checked.ToString();
			lines[1] = "music" + "," + musicCheckBox.Checked.ToString();
			lines[2] = "color" + "," + color;

			string myDocPath = @"..\..\Resources\";
			using(StreamWriter outputFile = new StreamWriter(myDocPath + @"settings.txt")) {
				foreach (string line in lines) {
					outputFile.WriteLine(line);
				}
			}
		}

		private void LoadFromFile() {
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

			lineElements = lines[2].Split(',');
			if (lineElements[1] == "blue") {
				_color = "blue";
			} else {
				_color = "black";
			}
		}
	}
}

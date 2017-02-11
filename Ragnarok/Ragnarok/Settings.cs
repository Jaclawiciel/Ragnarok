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
		private CheckBox musicCheckBox;
		public bool MusicState;
		public bool IsMusicPlaying = false;
		public string Difficulty {
			get {
				if (normalDiff.Checked) {
					return "normal";
				} else {
					return "hardcore";
				}
			}
		}
		private RadioButton blueButton;
		private RadioButton blackButton;
		private RadioButton imageButton;
		private RadioButton normalDiff;
		private RadioButton hardcoreDiff;
		private GroupBox diffGroupBox;
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
				} else if(value == "black") {
					form.BackColor = Color.Black;
					mapPanel.BackColor = Color.Black;
					blackButton.Checked = true;
				} else {
					//form.BackColor = Color.Transparent;
					mapPanel.BackColor = Color.Transparent;
					imageButton.Checked = true;
				}
			}
		}

		public Settings(Form1 form, Panel mapPanel, Panel settingsPanel, CheckBox musicCheckBox, 
			RadioButton blueRadioButton, RadioButton blackRadioButton, RadioButton imageRadioButton,
			RadioButton normalDiff, RadioButton hardcoreDiff, GroupBox diffGroupBox) {
			this.settingsPanel = settingsPanel;
			this.musicCheckBox = musicCheckBox;
			this.blueButton = blueRadioButton;
			this.blackButton = blackRadioButton;
			this.imageButton = imageRadioButton;
			this.normalDiff = normalDiff;
			this.hardcoreDiff = hardcoreDiff;
			this.diffGroupBox = diffGroupBox;
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
			MusicState = musicCheckBox.Checked;

			if (blueButton.Checked) {
				_color = "blue";
			} else if(blackButton.Checked) {
				_color = "black";
			} else {
				_color = "image";
			}

			String[] lines = new String[3];
			lines[0] = "music" + "," + musicCheckBox.Checked.ToString();
			lines[1] = "color" + "," + color;
			lines[2] = "difficulty" + "," + Difficulty;

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
		
			String[] lineElements = lines[0].Split(',');
			if (lineElements[1] == "True") {
				musicCheckBox.Checked = true;
				MusicState = true;
			} else {
				musicCheckBox.Checked = false;
				MusicState = false;
			}

			lineElements = lines[1].Split(',');
			if (lineElements[1] == "blue") {
				_color = "blue";
			} else if(lineElements[1] == "black") {
				_color = "black";
			} else {
				_color = "image";
			}

			lineElements = lines[2].Split(',');
			if (lineElements[1] == "normal") {
				normalDiff.Checked = true;
			} else {
				hardcoreDiff.Checked = true;
			}
		}
	}
}

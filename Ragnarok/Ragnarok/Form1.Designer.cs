namespace Ragnarok
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.mainMenuPanel = new System.Windows.Forms.Panel();
			this.closeMenuButton = new System.Windows.Forms.Button();
			this.menuQuitButton = new System.Windows.Forms.Button();
			this.menuSettingsButton = new System.Windows.Forms.Button();
			this.loadGameButton = new System.Windows.Forms.Button();
			this.startNewGameButton = new System.Windows.Forms.Button();
			this.mainMenuTitle = new System.Windows.Forms.Label();
			this.mapPanel = new System.Windows.Forms.Panel();
			this.basicTowerPanel = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.mainMenuPanel.SuspendLayout();
			this.basicTowerPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenuPanel
			// 
			this.mainMenuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mainMenuPanel.BackColor = System.Drawing.SystemColors.HotTrack;
			this.mainMenuPanel.Controls.Add(this.closeMenuButton);
			this.mainMenuPanel.Controls.Add(this.menuQuitButton);
			this.mainMenuPanel.Controls.Add(this.menuSettingsButton);
			this.mainMenuPanel.Controls.Add(this.loadGameButton);
			this.mainMenuPanel.Controls.Add(this.startNewGameButton);
			this.mainMenuPanel.Controls.Add(this.mainMenuTitle);
			this.mainMenuPanel.Location = new System.Drawing.Point(1098, 12);
			this.mainMenuPanel.Name = "mainMenuPanel";
			this.mainMenuPanel.Size = new System.Drawing.Size(222, 200);
			this.mainMenuPanel.TabIndex = 0;
			this.mainMenuPanel.Visible = false;
			// 
			// closeMenuButton
			// 
			this.closeMenuButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.closeMenuButton.FlatAppearance.BorderSize = 0;
			this.closeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.closeMenuButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.closeMenuButton.Location = new System.Drawing.Point(185, 3);
			this.closeMenuButton.Name = "closeMenuButton";
			this.closeMenuButton.Size = new System.Drawing.Size(34, 30);
			this.closeMenuButton.TabIndex = 5;
			this.closeMenuButton.Text = "X";
			this.closeMenuButton.UseVisualStyleBackColor = false;
			this.closeMenuButton.Click += new System.EventHandler(this.closeMenuButton_Click);
			// 
			// menuQuitButton
			// 
			this.menuQuitButton.Location = new System.Drawing.Point(74, 154);
			this.menuQuitButton.Name = "menuQuitButton";
			this.menuQuitButton.Size = new System.Drawing.Size(75, 23);
			this.menuQuitButton.TabIndex = 4;
			this.menuQuitButton.Text = "Quit";
			this.menuQuitButton.UseVisualStyleBackColor = true;
			this.menuQuitButton.Click += new System.EventHandler(this.menuQuitButton_Click);
			// 
			// menuSettingsButton
			// 
			this.menuSettingsButton.Location = new System.Drawing.Point(74, 125);
			this.menuSettingsButton.Name = "menuSettingsButton";
			this.menuSettingsButton.Size = new System.Drawing.Size(75, 23);
			this.menuSettingsButton.TabIndex = 3;
			this.menuSettingsButton.Text = "Settings";
			this.menuSettingsButton.UseVisualStyleBackColor = true;
			this.menuSettingsButton.Click += new System.EventHandler(this.menuSettingsButton_Click);
			// 
			// loadGameButton
			// 
			this.loadGameButton.Location = new System.Drawing.Point(74, 96);
			this.loadGameButton.Name = "loadGameButton";
			this.loadGameButton.Size = new System.Drawing.Size(75, 23);
			this.loadGameButton.TabIndex = 2;
			this.loadGameButton.Text = "Load Game";
			this.loadGameButton.UseVisualStyleBackColor = true;
			this.loadGameButton.Click += new System.EventHandler(this.loadGameButton_Click);
			// 
			// startNewGameButton
			// 
			this.startNewGameButton.Location = new System.Drawing.Point(74, 67);
			this.startNewGameButton.Name = "startNewGameButton";
			this.startNewGameButton.Size = new System.Drawing.Size(75, 23);
			this.startNewGameButton.TabIndex = 1;
			this.startNewGameButton.Text = "New Game";
			this.startNewGameButton.UseVisualStyleBackColor = true;
			this.startNewGameButton.Click += new System.EventHandler(this.startNewGameButton_Click);
			// 
			// mainMenuTitle
			// 
			this.mainMenuTitle.AutoSize = true;
			this.mainMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mainMenuTitle.Location = new System.Drawing.Point(49, 16);
			this.mainMenuTitle.Name = "mainMenuTitle";
			this.mainMenuTitle.Size = new System.Drawing.Size(119, 25);
			this.mainMenuTitle.TabIndex = 0;
			this.mainMenuTitle.Text = "Main Menu";
			// 
			// mapPanel
			// 
			this.mapPanel.Location = new System.Drawing.Point(0, 0);
			this.mapPanel.Name = "mapPanel";
			this.mapPanel.Size = new System.Drawing.Size(1050, 700);
			this.mapPanel.TabIndex = 1;
			this.mapPanel.Click += new System.EventHandler(this.mapPanel_Click);
			// 
			// basicTowerPanel
			// 
			this.basicTowerPanel.BackColor = System.Drawing.SystemColors.HotTrack;
			this.basicTowerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.basicTowerPanel.Controls.Add(this.button4);
			this.basicTowerPanel.Controls.Add(this.label3);
			this.basicTowerPanel.Controls.Add(this.label2);
			this.basicTowerPanel.Controls.Add(this.label1);
			this.basicTowerPanel.Controls.Add(this.pictureBox1);
			this.basicTowerPanel.Controls.Add(this.button1);
			this.basicTowerPanel.Location = new System.Drawing.Point(1098, 241);
			this.basicTowerPanel.Name = "basicTowerPanel";
			this.basicTowerPanel.Size = new System.Drawing.Size(168, 110);
			this.basicTowerPanel.TabIndex = 2;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.button4.Location = new System.Drawing.Point(131, -1);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(34, 30);
			this.button4.TabIndex = 6;
			this.button4.Text = "X";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.Info;
			this.label3.Location = new System.Drawing.Point(79, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Damage: 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.Info;
			this.label2.Location = new System.Drawing.Point(79, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Range: 1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.Info;
			this.label1.Location = new System.Drawing.Point(79, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cost: $5";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(70, 70);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 79);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Buy basic tower";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.button5);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Location = new System.Drawing.Point(1098, 402);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(168, 111);
			this.panel2.TabIndex = 7;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(76, 79);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(62, 23);
			this.button5.TabIndex = 7;
			this.button5.Text = "Upgrade";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.button2.Location = new System.Drawing.Point(133, -1);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(34, 30);
			this.button2.TabIndex = 6;
			this.button2.Text = "X";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.Info;
			this.label4.Location = new System.Drawing.Point(79, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Damage: 1";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.Info;
			this.label5.Location = new System.Drawing.Point(79, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Range: 1";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.Info;
			this.label6.Location = new System.Drawing.Point(79, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Cost: $10";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(70, 70);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(3, 79);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(62, 23);
			this.button3.TabIndex = 0;
			this.button3.Text = "Sell (+ 2$)";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1362, 701);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.basicTowerPanel);
			this.Controls.Add(this.mapPanel);
			this.Controls.Add(this.mainMenuPanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.mainMenuPanel.ResumeLayout(false);
			this.mainMenuPanel.PerformLayout();
			this.basicTowerPanel.ResumeLayout(false);
			this.basicTowerPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Panel mainMenuPanel;
		private System.Windows.Forms.Button menuQuitButton;
		private System.Windows.Forms.Button menuSettingsButton;
		private System.Windows.Forms.Button loadGameButton;
		private System.Windows.Forms.Button startNewGameButton;
		private System.Windows.Forms.Label mainMenuTitle;
		private System.Windows.Forms.Button closeMenuButton;
		private System.Windows.Forms.Panel mapPanel;

		private System.Windows.Forms.Panel basicTowerPanel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button3;
	}
}


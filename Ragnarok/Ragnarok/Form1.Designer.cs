namespace Ragnarok {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializePictureBoxEvents() {
			//
			// towerSpotsPB
			// 
			this.mainMapPanel.PBTowerSpots[0].Click += new System.EventHandler(this.PBTowerSpots0_Click);
			this.mainMapPanel.PBTowerSpots[1].Click += new System.EventHandler(this.PBTowerSpots1_Click);
			this.mainMapPanel.PBTowerSpots[2].Click += new System.EventHandler(this.PBTowerSpots2_Click);
			this.mainMapPanel.PBTowerSpots[3].Click += new System.EventHandler(this.PBTowerSpots3_Click);
			this.mainMapPanel.PBTowerSpots[4].Click += new System.EventHandler(this.PBTowerSpots4_Click);
			this.mainMapPanel.PBTowerSpots[5].Click += new System.EventHandler(this.PBTowerSpots5_Click);
			this.mainMapPanel.PBTowerSpots[6].Click += new System.EventHandler(this.PBTowerSpots6_Click);
			this.mainMapPanel.PBTowerSpots[7].Click += new System.EventHandler(this.PBTowerSpots7_Click);
			this.mainMapPanel.PBTowerSpots[8].Click += new System.EventHandler(this.PBTowerSpots8_Click);
			this.mainMapPanel.PBTowerSpots[9].Click += new System.EventHandler(this.PBTowerSpots9_Click);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.mainMenuPanel = new System.Windows.Forms.Panel();
			this.closeMenuButton = new System.Windows.Forms.Button();
			this.menuQuitButton = new System.Windows.Forms.Button();
			this.menuSettingsButton = new System.Windows.Forms.Button();
			this.loadGameButton = new System.Windows.Forms.Button();
			this.startNewGameButton = new System.Windows.Forms.Button();
			this.mainMenuTitle = new System.Windows.Forms.Label();
			this.mapPanel = new System.Windows.Forms.Panel();
			this.basicPanel = new System.Windows.Forms.Panel();
			this.basicPanelCloseButton = new System.Windows.Forms.Button();
			this.basicPanelDamageLabel = new System.Windows.Forms.Label();
			this.basicPanelRangeLabel = new System.Windows.Forms.Label();
			this.basicPanelCostLabel = new System.Windows.Forms.Label();
			this.basicPanelTowerImage = new System.Windows.Forms.PictureBox();
			this.buyBasicTowerButton = new System.Windows.Forms.Button();
			this.upgradePanel = new System.Windows.Forms.Panel();
			this.upgradePanelUpgradeButton = new System.Windows.Forms.Button();
			this.upgradePanelCloseButton = new System.Windows.Forms.Button();
			this.upgradePanelDamagelabel = new System.Windows.Forms.Label();
			this.upgradePanelRangeLabel = new System.Windows.Forms.Label();
			this.upgradePanelCostLabel = new System.Windows.Forms.Label();
			this.upgradePanelImage = new System.Windows.Forms.PictureBox();
			this.upgradePanelSellButton = new System.Windows.Forms.Button();
			this.switchPanel = new System.Windows.Forms.Panel();
			this.switchSniper = new System.Windows.Forms.Button();
			this.switchMageButton = new System.Windows.Forms.Button();
			this.switchCrossbowButton = new System.Windows.Forms.Button();
			this.switchCloseButton = new System.Windows.Forms.Button();
			this.switchCostLabel = new System.Windows.Forms.Label();
			this.switchPictureBox = new System.Windows.Forms.PictureBox();
			this.mainMenuPanel.SuspendLayout();
			this.basicPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.basicPanelTowerImage)).BeginInit();
			this.upgradePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.upgradePanelImage)).BeginInit();
			this.switchPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.switchPictureBox)).BeginInit();
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
			this.mapPanel.BackgroundImage = global::Ragnarok.Properties.Resources.MapOnly;
			this.mapPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mapPanel.Location = new System.Drawing.Point(0, 0);
			this.mapPanel.Name = "mapPanel";
			this.mapPanel.Size = new System.Drawing.Size(1050, 700);
			this.mapPanel.TabIndex = 1;
			this.mapPanel.Click += new System.EventHandler(this.mapPanel_Click);
			// 
			// basicPanel
			// 
			this.basicPanel.BackColor = System.Drawing.SystemColors.HotTrack;
			this.basicPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.basicPanel.Controls.Add(this.basicPanelCloseButton);
			this.basicPanel.Controls.Add(this.basicPanelDamageLabel);
			this.basicPanel.Controls.Add(this.basicPanelRangeLabel);
			this.basicPanel.Controls.Add(this.basicPanelCostLabel);
			this.basicPanel.Controls.Add(this.basicPanelTowerImage);
			this.basicPanel.Controls.Add(this.buyBasicTowerButton);
			this.basicPanel.Location = new System.Drawing.Point(1098, 241);
			this.basicPanel.Name = "basicPanel";
			this.basicPanel.Size = new System.Drawing.Size(168, 110);
			this.basicPanel.TabIndex = 2;
			// 
			// basicPanelCloseButton
			// 
			this.basicPanelCloseButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.basicPanelCloseButton.FlatAppearance.BorderSize = 0;
			this.basicPanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.basicPanelCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.basicPanelCloseButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.basicPanelCloseButton.Location = new System.Drawing.Point(131, -1);
			this.basicPanelCloseButton.Name = "basicPanelCloseButton";
			this.basicPanelCloseButton.Size = new System.Drawing.Size(34, 30);
			this.basicPanelCloseButton.TabIndex = 6;
			this.basicPanelCloseButton.Text = "X";
			this.basicPanelCloseButton.UseVisualStyleBackColor = false;
			this.basicPanelCloseButton.Click += new System.EventHandler(this.basicPanelCloseButton_Click);
			// 
			// basicPanelDamageLabel
			// 
			this.basicPanelDamageLabel.AutoSize = true;
			this.basicPanelDamageLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.basicPanelDamageLabel.Location = new System.Drawing.Point(79, 59);
			this.basicPanelDamageLabel.Name = "basicPanelDamageLabel";
			this.basicPanelDamageLabel.Size = new System.Drawing.Size(59, 13);
			this.basicPanelDamageLabel.TabIndex = 4;
			this.basicPanelDamageLabel.Text = "Damage: 1";
			// 
			// basicPanelRangeLabel
			// 
			this.basicPanelRangeLabel.AutoSize = true;
			this.basicPanelRangeLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.basicPanelRangeLabel.Location = new System.Drawing.Point(79, 35);
			this.basicPanelRangeLabel.Name = "basicPanelRangeLabel";
			this.basicPanelRangeLabel.Size = new System.Drawing.Size(51, 13);
			this.basicPanelRangeLabel.TabIndex = 3;
			this.basicPanelRangeLabel.Text = "Range: 1";
			// 
			// basicPanelCostLabel
			// 
			this.basicPanelCostLabel.AutoSize = true;
			this.basicPanelCostLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.basicPanelCostLabel.Location = new System.Drawing.Point(79, 12);
			this.basicPanelCostLabel.Name = "basicPanelCostLabel";
			this.basicPanelCostLabel.Size = new System.Drawing.Size(46, 13);
			this.basicPanelCostLabel.TabIndex = 2;
			this.basicPanelCostLabel.Text = "Cost: $5";
			// 
			// basicPanelTowerImage
			// 
			this.basicPanelTowerImage.Image = ((System.Drawing.Image)(resources.GetObject("basicPanelTowerImage.Image")));
			this.basicPanelTowerImage.Location = new System.Drawing.Point(3, 3);
			this.basicPanelTowerImage.Name = "basicPanelTowerImage";
			this.basicPanelTowerImage.Size = new System.Drawing.Size(70, 70);
			this.basicPanelTowerImage.TabIndex = 1;
			this.basicPanelTowerImage.TabStop = false;
			// 
			// buyBasicTowerButton
			// 
			this.buyBasicTowerButton.Location = new System.Drawing.Point(32, 79);
			this.buyBasicTowerButton.Name = "buyBasicTowerButton";
			this.buyBasicTowerButton.Size = new System.Drawing.Size(99, 23);
			this.buyBasicTowerButton.TabIndex = 0;
			this.buyBasicTowerButton.Text = "Buy basic tower";
			this.buyBasicTowerButton.UseVisualStyleBackColor = true;
			// 
			// upgradePanel
			// 
			this.upgradePanel.BackColor = System.Drawing.SystemColors.HotTrack;
			this.upgradePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.upgradePanel.Controls.Add(this.upgradePanelUpgradeButton);
			this.upgradePanel.Controls.Add(this.upgradePanelCloseButton);
			this.upgradePanel.Controls.Add(this.upgradePanelDamagelabel);
			this.upgradePanel.Controls.Add(this.upgradePanelRangeLabel);
			this.upgradePanel.Controls.Add(this.upgradePanelCostLabel);
			this.upgradePanel.Controls.Add(this.upgradePanelImage);
			this.upgradePanel.Controls.Add(this.upgradePanelSellButton);
			this.upgradePanel.Location = new System.Drawing.Point(1098, 518);
			this.upgradePanel.Name = "upgradePanel";
			this.upgradePanel.Size = new System.Drawing.Size(168, 111);
			this.upgradePanel.TabIndex = 7;
			// 
			// upgradePanelUpgradeButton
			// 
			this.upgradePanelUpgradeButton.Location = new System.Drawing.Point(76, 79);
			this.upgradePanelUpgradeButton.Name = "upgradePanelUpgradeButton";
			this.upgradePanelUpgradeButton.Size = new System.Drawing.Size(62, 23);
			this.upgradePanelUpgradeButton.TabIndex = 7;
			this.upgradePanelUpgradeButton.Text = "Upgrade";
			this.upgradePanelUpgradeButton.UseVisualStyleBackColor = true;
			// 
			// upgradePanelCloseButton
			// 
			this.upgradePanelCloseButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.upgradePanelCloseButton.FlatAppearance.BorderSize = 0;
			this.upgradePanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.upgradePanelCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.upgradePanelCloseButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.upgradePanelCloseButton.Location = new System.Drawing.Point(133, -1);
			this.upgradePanelCloseButton.Name = "upgradePanelCloseButton";
			this.upgradePanelCloseButton.Size = new System.Drawing.Size(34, 30);
			this.upgradePanelCloseButton.TabIndex = 6;
			this.upgradePanelCloseButton.Text = "X";
			this.upgradePanelCloseButton.UseVisualStyleBackColor = false;
			this.upgradePanelCloseButton.Click += new System.EventHandler(this.upgradePanelCloseButton_Click);
			// 
			// upgradePanelDamagelabel
			// 
			this.upgradePanelDamagelabel.AutoSize = true;
			this.upgradePanelDamagelabel.ForeColor = System.Drawing.SystemColors.Info;
			this.upgradePanelDamagelabel.Location = new System.Drawing.Point(79, 59);
			this.upgradePanelDamagelabel.Name = "upgradePanelDamagelabel";
			this.upgradePanelDamagelabel.Size = new System.Drawing.Size(59, 13);
			this.upgradePanelDamagelabel.TabIndex = 4;
			this.upgradePanelDamagelabel.Text = "Damage: 1";
			// 
			// upgradePanelRangeLabel
			// 
			this.upgradePanelRangeLabel.AutoSize = true;
			this.upgradePanelRangeLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.upgradePanelRangeLabel.Location = new System.Drawing.Point(79, 35);
			this.upgradePanelRangeLabel.Name = "upgradePanelRangeLabel";
			this.upgradePanelRangeLabel.Size = new System.Drawing.Size(51, 13);
			this.upgradePanelRangeLabel.TabIndex = 3;
			this.upgradePanelRangeLabel.Text = "Range: 1";
			// 
			// upgradePanelCostLabel
			// 
			this.upgradePanelCostLabel.AutoSize = true;
			this.upgradePanelCostLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.upgradePanelCostLabel.Location = new System.Drawing.Point(79, 12);
			this.upgradePanelCostLabel.Name = "upgradePanelCostLabel";
			this.upgradePanelCostLabel.Size = new System.Drawing.Size(52, 13);
			this.upgradePanelCostLabel.TabIndex = 2;
			this.upgradePanelCostLabel.Text = "Cost: $10";
			// 
			// upgradePanelImage
			// 
			this.upgradePanelImage.Image = ((System.Drawing.Image)(resources.GetObject("upgradePanelImage.Image")));
			this.upgradePanelImage.Location = new System.Drawing.Point(3, 3);
			this.upgradePanelImage.Name = "upgradePanelImage";
			this.upgradePanelImage.Size = new System.Drawing.Size(70, 70);
			this.upgradePanelImage.TabIndex = 1;
			this.upgradePanelImage.TabStop = false;
			// 
			// upgradePanelSellButton
			// 
			this.upgradePanelSellButton.Location = new System.Drawing.Point(3, 79);
			this.upgradePanelSellButton.Name = "upgradePanelSellButton";
			this.upgradePanelSellButton.Size = new System.Drawing.Size(62, 23);
			this.upgradePanelSellButton.TabIndex = 0;
			this.upgradePanelSellButton.Text = "Sell (+ 2$)";
			this.upgradePanelSellButton.UseVisualStyleBackColor = true;
			// 
			// switchPanel
			// 
			this.switchPanel.BackColor = System.Drawing.SystemColors.HotTrack;
			this.switchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.switchPanel.Controls.Add(this.switchSniper);
			this.switchPanel.Controls.Add(this.switchMageButton);
			this.switchPanel.Controls.Add(this.switchCrossbowButton);
			this.switchPanel.Controls.Add(this.switchCloseButton);
			this.switchPanel.Controls.Add(this.switchCostLabel);
			this.switchPanel.Controls.Add(this.switchPictureBox);
			this.switchPanel.Location = new System.Drawing.Point(1098, 370);
			this.switchPanel.Name = "switchPanel";
			this.switchPanel.Size = new System.Drawing.Size(206, 111);
			this.switchPanel.TabIndex = 8;
			// 
			// switchSniper
			// 
			this.switchSniper.Location = new System.Drawing.Point(139, 79);
			this.switchSniper.Name = "switchSniper";
			this.switchSniper.Size = new System.Drawing.Size(62, 23);
			this.switchSniper.TabIndex = 9;
			this.switchSniper.Text = "Sniper";
			this.switchSniper.UseVisualStyleBackColor = true;
			// 
			// switchMageButton
			// 
			this.switchMageButton.Location = new System.Drawing.Point(71, 79);
			this.switchMageButton.Name = "switchMageButton";
			this.switchMageButton.Size = new System.Drawing.Size(62, 23);
			this.switchMageButton.TabIndex = 8;
			this.switchMageButton.Text = "Mage";
			this.switchMageButton.UseVisualStyleBackColor = true;
			// 
			// switchCrossbowButton
			// 
			this.switchCrossbowButton.Location = new System.Drawing.Point(3, 79);
			this.switchCrossbowButton.Name = "switchCrossbowButton";
			this.switchCrossbowButton.Size = new System.Drawing.Size(62, 23);
			this.switchCrossbowButton.TabIndex = 7;
			this.switchCrossbowButton.Text = "Crossbow";
			this.switchCrossbowButton.UseVisualStyleBackColor = true;
			// 
			// switchCloseButton
			// 
			this.switchCloseButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.switchCloseButton.FlatAppearance.BorderSize = 0;
			this.switchCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.switchCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.switchCloseButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.switchCloseButton.Location = new System.Drawing.Point(167, 3);
			this.switchCloseButton.Name = "switchCloseButton";
			this.switchCloseButton.Size = new System.Drawing.Size(34, 30);
			this.switchCloseButton.TabIndex = 6;
			this.switchCloseButton.Text = "X";
			this.switchCloseButton.UseVisualStyleBackColor = false;
			this.switchCloseButton.Click += new System.EventHandler(this.switchCloseButton_Click);
			// 
			// switchCostLabel
			// 
			this.switchCostLabel.AutoSize = true;
			this.switchCostLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.switchCostLabel.Location = new System.Drawing.Point(79, 12);
			this.switchCostLabel.Name = "switchCostLabel";
			this.switchCostLabel.Size = new System.Drawing.Size(52, 13);
			this.switchCostLabel.TabIndex = 2;
			this.switchCostLabel.Text = "Cost: $10";
			// 
			// switchPictureBox
			// 
			this.switchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("switchPictureBox.Image")));
			this.switchPictureBox.Location = new System.Drawing.Point(3, 3);
			this.switchPictureBox.Name = "switchPictureBox";
			this.switchPictureBox.Size = new System.Drawing.Size(70, 70);
			this.switchPictureBox.TabIndex = 1;
			this.switchPictureBox.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1362, 701);
			this.Controls.Add(this.switchPanel);
			this.Controls.Add(this.upgradePanel);
			this.Controls.Add(this.basicPanel);
			this.Controls.Add(this.mapPanel);
			this.Controls.Add(this.mainMenuPanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.mainMenuPanel.ResumeLayout(false);
			this.mainMenuPanel.PerformLayout();
			this.basicPanel.ResumeLayout(false);
			this.basicPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.basicPanelTowerImage)).EndInit();
			this.upgradePanel.ResumeLayout(false);
			this.upgradePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.upgradePanelImage)).EndInit();
			this.switchPanel.ResumeLayout(false);
			this.switchPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.switchPictureBox)).EndInit();
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
		private System.Windows.Forms.Panel basicPanel;
		private System.Windows.Forms.Label basicPanelDamageLabel;
		private System.Windows.Forms.Label basicPanelRangeLabel;
		private System.Windows.Forms.Label basicPanelCostLabel;
		private System.Windows.Forms.PictureBox basicPanelTowerImage;
		private System.Windows.Forms.Button buyBasicTowerButton;
		private System.Windows.Forms.Button basicPanelCloseButton;
		private System.Windows.Forms.Panel upgradePanel;
		private System.Windows.Forms.Button upgradePanelUpgradeButton;
		private System.Windows.Forms.Button upgradePanelCloseButton;
		private System.Windows.Forms.Label upgradePanelDamagelabel;
		private System.Windows.Forms.Label upgradePanelRangeLabel;
		private System.Windows.Forms.Label upgradePanelCostLabel;
		private System.Windows.Forms.PictureBox upgradePanelImage;
		private System.Windows.Forms.Button upgradePanelSellButton;
		private System.Windows.Forms.Panel switchPanel;
		private System.Windows.Forms.Button switchSniper;
		private System.Windows.Forms.Button switchMageButton;
		private System.Windows.Forms.Button switchCrossbowButton;
		private System.Windows.Forms.Button switchCloseButton;
		private System.Windows.Forms.Label switchCostLabel;
		private System.Windows.Forms.PictureBox switchPictureBox;
	}
}


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
			this.mainMenuPanel = new System.Windows.Forms.Panel();
			this.closeMenuButton = new System.Windows.Forms.Button();
			this.menuQuitButton = new System.Windows.Forms.Button();
			this.menuSettingsButton = new System.Windows.Forms.Button();
			this.loadGameButton = new System.Windows.Forms.Button();
			this.startNewGameButton = new System.Windows.Forms.Button();
			this.mainMenuTitle = new System.Windows.Forms.Label();
			this.mapPanel = new System.Windows.Forms.Panel();
			this.ragnarokPanel = new System.Windows.Forms.Panel();
			this.ragnarokPanelLevelLabel = new System.Windows.Forms.Label();
			this.ragnarokPanelTitleLabel = new System.Windows.Forms.Label();
			this.ragnarokPanelCloseButton = new System.Windows.Forms.Button();
			this.ragnarokPanelPowerLabel = new System.Windows.Forms.Label();
			this.ragnarokPanelRangeLabel = new System.Windows.Forms.Label();
			this.ragnarokPanelPictureBox = new System.Windows.Forms.PictureBox();
			this.ragnarokPanelSellButton = new System.Windows.Forms.Button();
			this.switchPanel = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.switchSellButton = new System.Windows.Forms.Button();
			this.switchSniperPowerTower = new System.Windows.Forms.Label();
			this.switchSniperRangeTower = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.switchSniperCostLabel = new System.Windows.Forms.Label();
			this.switchSniperPictureBox = new System.Windows.Forms.PictureBox();
			this.switchMagePowerLabel = new System.Windows.Forms.Label();
			this.switchMageRangeLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.switchMageCostLabel = new System.Windows.Forms.Label();
			this.switchMagePictureBox = new System.Windows.Forms.PictureBox();
			this.switchCrossbowPowerLabel = new System.Windows.Forms.Label();
			this.switchCrossbowRangeLabel = new System.Windows.Forms.Label();
			this.switchTowerLabel = new System.Windows.Forms.Label();
			this.switchCrossbowButton = new System.Windows.Forms.Button();
			this.switchCloseButton = new System.Windows.Forms.Button();
			this.switchCrossbowCostLabel = new System.Windows.Forms.Label();
			this.switchCrossbowPictureBox = new System.Windows.Forms.PictureBox();
			this.settingsPanel = new System.Windows.Forms.Panel();
			this.colorGroupBox = new System.Windows.Forms.GroupBox();
			this.navyColor = new System.Windows.Forms.RadioButton();
			this.blackColor = new System.Windows.Forms.RadioButton();
			this.musicCheckBox = new System.Windows.Forms.CheckBox();
			this.sfxCheckBox = new System.Windows.Forms.CheckBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.basicPanel = new System.Windows.Forms.Panel();
			this.basicTowerLabel = new System.Windows.Forms.Label();
			this.basicPanelCloseButton = new System.Windows.Forms.Button();
			this.basicPanelPowerLabel = new System.Windows.Forms.Label();
			this.basicPanelRangeLabel = new System.Windows.Forms.Label();
			this.basicPanelCostLabel = new System.Windows.Forms.Label();
			this.basicPanelTowerImage = new System.Windows.Forms.PictureBox();
			this.buyBasicTowerButton = new System.Windows.Forms.Button();
			this.upgradePanel = new System.Windows.Forms.Panel();
			this.upgradePanelLevelLabel = new System.Windows.Forms.Label();
			this.upgradePanelTitleLabel = new System.Windows.Forms.Label();
			this.upgradePanelUpgradeButton = new System.Windows.Forms.Button();
			this.upgradePanelCloseButton = new System.Windows.Forms.Button();
			this.upgradePanelPowerLabel = new System.Windows.Forms.Label();
			this.upgradePanelRangeLabel = new System.Windows.Forms.Label();
			this.upgradePanelCostLabel = new System.Windows.Forms.Label();
			this.upgradePanelPictureBox = new System.Windows.Forms.PictureBox();
			this.upgradePanelSellButton = new System.Windows.Forms.Button();
			this.mainMenuPanel.SuspendLayout();
			this.ragnarokPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ragnarokPanelPictureBox)).BeginInit();
			this.switchPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.switchSniperPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.switchMagePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.switchCrossbowPictureBox)).BeginInit();
			this.settingsPanel.SuspendLayout();
			this.colorGroupBox.SuspendLayout();
			this.basicPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.basicPanelTowerImage)).BeginInit();
			this.upgradePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.upgradePanelPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenuPanel
			// 
			this.mainMenuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mainMenuPanel.BackColor = System.Drawing.Color.Maroon;
			this.mainMenuPanel.Controls.Add(this.closeMenuButton);
			this.mainMenuPanel.Controls.Add(this.menuQuitButton);
			this.mainMenuPanel.Controls.Add(this.menuSettingsButton);
			this.mainMenuPanel.Controls.Add(this.loadGameButton);
			this.mainMenuPanel.Controls.Add(this.startNewGameButton);
			this.mainMenuPanel.Controls.Add(this.mainMenuTitle);
			this.mainMenuPanel.Location = new System.Drawing.Point(1052, 0);
			this.mainMenuPanel.Name = "mainMenuPanel";
			this.mainMenuPanel.Size = new System.Drawing.Size(222, 200);
			this.mainMenuPanel.TabIndex = 0;
			this.mainMenuPanel.Visible = false;
			// 
			// closeMenuButton
			// 
			this.closeMenuButton.BackColor = System.Drawing.Color.Maroon;
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
			this.menuQuitButton.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
			this.menuSettingsButton.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
			this.loadGameButton.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
			this.startNewGameButton.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
			this.mainMenuTitle.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mainMenuTitle.ForeColor = System.Drawing.Color.White;
			this.mainMenuTitle.Location = new System.Drawing.Point(43, 16);
			this.mainMenuTitle.Name = "mainMenuTitle";
			this.mainMenuTitle.Size = new System.Drawing.Size(136, 29);
			this.mainMenuTitle.TabIndex = 0;
			this.mainMenuTitle.Text = "Main Menu";
			// 
			// mapPanel
			// 
			this.mapPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mapPanel.Location = new System.Drawing.Point(0, 0);
			this.mapPanel.Name = "mapPanel";
			this.mapPanel.Size = new System.Drawing.Size(1050, 700);
			this.mapPanel.TabIndex = 1;
			// 
			// ragnarokPanel
			// 
			this.ragnarokPanel.BackColor = System.Drawing.Color.Maroon;
			this.ragnarokPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ragnarokPanel.Controls.Add(this.ragnarokPanelLevelLabel);
			this.ragnarokPanel.Controls.Add(this.ragnarokPanelTitleLabel);
			this.ragnarokPanel.Controls.Add(this.ragnarokPanelCloseButton);
			this.ragnarokPanel.Controls.Add(this.ragnarokPanelPowerLabel);
			this.ragnarokPanel.Controls.Add(this.ragnarokPanelRangeLabel);
			this.ragnarokPanel.Controls.Add(this.ragnarokPanelPictureBox);
			this.ragnarokPanel.Controls.Add(this.ragnarokPanelSellButton);
			this.ragnarokPanel.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ragnarokPanel.Location = new System.Drawing.Point(1277, 477);
			this.ragnarokPanel.Name = "ragnarokPanel";
			this.ragnarokPanel.Size = new System.Drawing.Size(155, 244);
			this.ragnarokPanel.TabIndex = 8;
			// 
			// ragnarokPanelLevelLabel
			// 
			this.ragnarokPanelLevelLabel.AutoSize = true;
			this.ragnarokPanelLevelLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ragnarokPanelLevelLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.ragnarokPanelLevelLabel.Location = new System.Drawing.Point(38, 139);
			this.ragnarokPanelLevelLabel.Name = "ragnarokPanelLevelLabel";
			this.ragnarokPanelLevelLabel.Size = new System.Drawing.Size(55, 19);
			this.ragnarokPanelLevelLabel.TabIndex = 9;
			this.ragnarokPanelLevelLabel.Text = "Level: ";
			// 
			// ragnarokPanelTitleLabel
			// 
			this.ragnarokPanelTitleLabel.AutoSize = true;
			this.ragnarokPanelTitleLabel.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ragnarokPanelTitleLabel.ForeColor = System.Drawing.Color.White;
			this.ragnarokPanelTitleLabel.Location = new System.Drawing.Point(13, 36);
			this.ragnarokPanelTitleLabel.Name = "ragnarokPanelTitleLabel";
			this.ragnarokPanelTitleLabel.Size = new System.Drawing.Size(126, 26);
			this.ragnarokPanelTitleLabel.TabIndex = 8;
			this.ragnarokPanelTitleLabel.Text = "RAGNAROK";
			// 
			// ragnarokPanelCloseButton
			// 
			this.ragnarokPanelCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ragnarokPanelCloseButton.BackColor = System.Drawing.Color.Maroon;
			this.ragnarokPanelCloseButton.FlatAppearance.BorderSize = 0;
			this.ragnarokPanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ragnarokPanelCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ragnarokPanelCloseButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.ragnarokPanelCloseButton.Location = new System.Drawing.Point(116, 3);
			this.ragnarokPanelCloseButton.Name = "ragnarokPanelCloseButton";
			this.ragnarokPanelCloseButton.Size = new System.Drawing.Size(34, 30);
			this.ragnarokPanelCloseButton.TabIndex = 6;
			this.ragnarokPanelCloseButton.Text = "X";
			this.ragnarokPanelCloseButton.UseVisualStyleBackColor = false;
			this.ragnarokPanelCloseButton.Click += new System.EventHandler(this.ragnarokPanelCloseButton_Click);
			// 
			// ragnarokPanelPowerLabel
			// 
			this.ragnarokPanelPowerLabel.AutoSize = true;
			this.ragnarokPanelPowerLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.ragnarokPanelPowerLabel.Location = new System.Drawing.Point(39, 188);
			this.ragnarokPanelPowerLabel.Name = "ragnarokPanelPowerLabel";
			this.ragnarokPanelPowerLabel.Size = new System.Drawing.Size(52, 13);
			this.ragnarokPanelPowerLabel.TabIndex = 4;
			this.ragnarokPanelPowerLabel.Text = "Damage: ";
			// 
			// ragnarokPanelRangeLabel
			// 
			this.ragnarokPanelRangeLabel.AutoSize = true;
			this.ragnarokPanelRangeLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.ragnarokPanelRangeLabel.Location = new System.Drawing.Point(39, 167);
			this.ragnarokPanelRangeLabel.Name = "ragnarokPanelRangeLabel";
			this.ragnarokPanelRangeLabel.Size = new System.Drawing.Size(42, 13);
			this.ragnarokPanelRangeLabel.TabIndex = 3;
			this.ragnarokPanelRangeLabel.Text = "Range: ";
			// 
			// ragnarokPanelPictureBox
			// 
			this.ragnarokPanelPictureBox.Image = global::Ragnarok.Properties.Resources.Mage_Tower3;
			this.ragnarokPanelPictureBox.Location = new System.Drawing.Point(42, 65);
			this.ragnarokPanelPictureBox.Name = "ragnarokPanelPictureBox";
			this.ragnarokPanelPictureBox.Size = new System.Drawing.Size(70, 70);
			this.ragnarokPanelPictureBox.TabIndex = 1;
			this.ragnarokPanelPictureBox.TabStop = false;
			// 
			// ragnarokPanelSellButton
			// 
			this.ragnarokPanelSellButton.Location = new System.Drawing.Point(18, 209);
			this.ragnarokPanelSellButton.Name = "ragnarokPanelSellButton";
			this.ragnarokPanelSellButton.Size = new System.Drawing.Size(121, 23);
			this.ragnarokPanelSellButton.TabIndex = 0;
			this.ragnarokPanelSellButton.Text = "Sell (+ $)";
			this.ragnarokPanelSellButton.UseVisualStyleBackColor = true;
			// 
			// switchPanel
			// 
			this.switchPanel.BackColor = System.Drawing.Color.Maroon;
			this.switchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.switchPanel.Controls.Add(this.label11);
			this.switchPanel.Controls.Add(this.label10);
			this.switchPanel.Controls.Add(this.label9);
			this.switchPanel.Controls.Add(this.switchSellButton);
			this.switchPanel.Controls.Add(this.switchSniperPowerTower);
			this.switchPanel.Controls.Add(this.switchSniperRangeTower);
			this.switchPanel.Controls.Add(this.button2);
			this.switchPanel.Controls.Add(this.switchSniperCostLabel);
			this.switchPanel.Controls.Add(this.switchSniperPictureBox);
			this.switchPanel.Controls.Add(this.switchMagePowerLabel);
			this.switchPanel.Controls.Add(this.switchMageRangeLabel);
			this.switchPanel.Controls.Add(this.button1);
			this.switchPanel.Controls.Add(this.switchMageCostLabel);
			this.switchPanel.Controls.Add(this.switchMagePictureBox);
			this.switchPanel.Controls.Add(this.switchCrossbowPowerLabel);
			this.switchPanel.Controls.Add(this.switchCrossbowRangeLabel);
			this.switchPanel.Controls.Add(this.switchTowerLabel);
			this.switchPanel.Controls.Add(this.switchCrossbowButton);
			this.switchPanel.Controls.Add(this.switchCloseButton);
			this.switchPanel.Controls.Add(this.switchCrossbowCostLabel);
			this.switchPanel.Controls.Add(this.switchCrossbowPictureBox);
			this.switchPanel.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.switchPanel.Location = new System.Drawing.Point(1280, 3);
			this.switchPanel.Name = "switchPanel";
			this.switchPanel.Size = new System.Drawing.Size(232, 283);
			this.switchPanel.TabIndex = 8;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(168, 62);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(50, 18);
			this.label11.TabIndex = 26;
			this.label11.Text = "Sniper";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(91, 62);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 18);
			this.label10.TabIndex = 25;
			this.label10.Text = "Mage";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(4, 62);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 18);
			this.label9.TabIndex = 24;
			this.label9.Text = "Crossbow";
			// 
			// switchSellButton
			// 
			this.switchSellButton.Location = new System.Drawing.Point(4, 247);
			this.switchSellButton.Name = "switchSellButton";
			this.switchSellButton.Size = new System.Drawing.Size(222, 23);
			this.switchSellButton.TabIndex = 23;
			this.switchSellButton.Text = "Sell (+ $)";
			this.switchSellButton.UseVisualStyleBackColor = true;
			// 
			// switchSniperPowerTower
			// 
			this.switchSniperPowerTower.AutoSize = true;
			this.switchSniperPowerTower.ForeColor = System.Drawing.SystemColors.Info;
			this.switchSniperPowerTower.Location = new System.Drawing.Point(156, 202);
			this.switchSniperPowerTower.Name = "switchSniperPowerTower";
			this.switchSniperPowerTower.Size = new System.Drawing.Size(36, 13);
			this.switchSniperPowerTower.TabIndex = 22;
			this.switchSniperPowerTower.Text = "Power";
			// 
			// switchSniperRangeTower
			// 
			this.switchSniperRangeTower.AutoSize = true;
			this.switchSniperRangeTower.ForeColor = System.Drawing.SystemColors.Info;
			this.switchSniperRangeTower.Location = new System.Drawing.Point(156, 182);
			this.switchSniperRangeTower.Name = "switchSniperRangeTower";
			this.switchSniperRangeTower.Size = new System.Drawing.Size(42, 13);
			this.switchSniperRangeTower.TabIndex = 21;
			this.switchSniperRangeTower.Text = "Range: ";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(156, 218);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(62, 23);
			this.button2.TabIndex = 20;
			this.button2.Text = "Buy";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// switchSniperCostLabel
			// 
			this.switchSniperCostLabel.AutoSize = true;
			this.switchSniperCostLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.switchSniperCostLabel.Location = new System.Drawing.Point(156, 164);
			this.switchSniperCostLabel.Name = "switchSniperCostLabel";
			this.switchSniperCostLabel.Size = new System.Drawing.Size(34, 13);
			this.switchSniperCostLabel.TabIndex = 19;
			this.switchSniperCostLabel.Text = "Cost: ";
			// 
			// switchSniperPictureBox
			// 
			this.switchSniperPictureBox.Image = global::Ragnarok.Properties.Resources.Sniper_Tower;
			this.switchSniperPictureBox.Location = new System.Drawing.Point(156, 83);
			this.switchSniperPictureBox.Name = "switchSniperPictureBox";
			this.switchSniperPictureBox.Size = new System.Drawing.Size(70, 70);
			this.switchSniperPictureBox.TabIndex = 18;
			this.switchSniperPictureBox.TabStop = false;
			// 
			// switchMagePowerLabel
			// 
			this.switchMagePowerLabel.AutoSize = true;
			this.switchMagePowerLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.switchMagePowerLabel.Location = new System.Drawing.Point(80, 202);
			this.switchMagePowerLabel.Name = "switchMagePowerLabel";
			this.switchMagePowerLabel.Size = new System.Drawing.Size(42, 13);
			this.switchMagePowerLabel.TabIndex = 17;
			this.switchMagePowerLabel.Text = "Power: ";
			// 
			// switchMageRangeLabel
			// 
			this.switchMageRangeLabel.AutoSize = true;
			this.switchMageRangeLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.switchMageRangeLabel.Location = new System.Drawing.Point(80, 182);
			this.switchMageRangeLabel.Name = "switchMageRangeLabel";
			this.switchMageRangeLabel.Size = new System.Drawing.Size(42, 13);
			this.switchMageRangeLabel.TabIndex = 16;
			this.switchMageRangeLabel.Text = "Range: ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 218);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(62, 23);
			this.button1.TabIndex = 15;
			this.button1.Text = "Buy";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// switchMageCostLabel
			// 
			this.switchMageCostLabel.AutoSize = true;
			this.switchMageCostLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.switchMageCostLabel.Location = new System.Drawing.Point(80, 164);
			this.switchMageCostLabel.Name = "switchMageCostLabel";
			this.switchMageCostLabel.Size = new System.Drawing.Size(34, 13);
			this.switchMageCostLabel.TabIndex = 14;
			this.switchMageCostLabel.Text = "Cost: ";
			// 
			// switchMagePictureBox
			// 
			this.switchMagePictureBox.Image = global::Ragnarok.Properties.Resources.Mage_Tower;
			this.switchMagePictureBox.Location = new System.Drawing.Point(80, 83);
			this.switchMagePictureBox.Name = "switchMagePictureBox";
			this.switchMagePictureBox.Size = new System.Drawing.Size(70, 70);
			this.switchMagePictureBox.TabIndex = 13;
			this.switchMagePictureBox.TabStop = false;
			// 
			// switchCrossbowPowerLabel
			// 
			this.switchCrossbowPowerLabel.AutoSize = true;
			this.switchCrossbowPowerLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.switchCrossbowPowerLabel.Location = new System.Drawing.Point(4, 202);
			this.switchCrossbowPowerLabel.Name = "switchCrossbowPowerLabel";
			this.switchCrossbowPowerLabel.Size = new System.Drawing.Size(42, 13);
			this.switchCrossbowPowerLabel.TabIndex = 12;
			this.switchCrossbowPowerLabel.Text = "Power: ";
			// 
			// switchCrossbowRangeLabel
			// 
			this.switchCrossbowRangeLabel.AutoSize = true;
			this.switchCrossbowRangeLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.switchCrossbowRangeLabel.Location = new System.Drawing.Point(4, 182);
			this.switchCrossbowRangeLabel.Name = "switchCrossbowRangeLabel";
			this.switchCrossbowRangeLabel.Size = new System.Drawing.Size(42, 13);
			this.switchCrossbowRangeLabel.TabIndex = 11;
			this.switchCrossbowRangeLabel.Text = "Range: ";
			// 
			// switchTowerLabel
			// 
			this.switchTowerLabel.AutoSize = true;
			this.switchTowerLabel.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.switchTowerLabel.ForeColor = System.Drawing.Color.White;
			this.switchTowerLabel.Location = new System.Drawing.Point(40, 27);
			this.switchTowerLabel.Name = "switchTowerLabel";
			this.switchTowerLabel.Size = new System.Drawing.Size(152, 29);
			this.switchTowerLabel.TabIndex = 10;
			this.switchTowerLabel.Text = "Switch Tower";
			// 
			// switchCrossbowButton
			// 
			this.switchCrossbowButton.Location = new System.Drawing.Point(4, 218);
			this.switchCrossbowButton.Name = "switchCrossbowButton";
			this.switchCrossbowButton.Size = new System.Drawing.Size(62, 23);
			this.switchCrossbowButton.TabIndex = 7;
			this.switchCrossbowButton.Text = "Buy";
			this.switchCrossbowButton.UseVisualStyleBackColor = true;
			// 
			// switchCloseButton
			// 
			this.switchCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.switchCloseButton.BackColor = System.Drawing.Color.Maroon;
			this.switchCloseButton.FlatAppearance.BorderSize = 0;
			this.switchCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.switchCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.switchCloseButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.switchCloseButton.Location = new System.Drawing.Point(193, 3);
			this.switchCloseButton.Name = "switchCloseButton";
			this.switchCloseButton.Size = new System.Drawing.Size(34, 30);
			this.switchCloseButton.TabIndex = 6;
			this.switchCloseButton.Text = "X";
			this.switchCloseButton.UseVisualStyleBackColor = false;
			this.switchCloseButton.Click += new System.EventHandler(this.switchCloseButton_Click);
			// 
			// switchCrossbowCostLabel
			// 
			this.switchCrossbowCostLabel.AutoSize = true;
			this.switchCrossbowCostLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.switchCrossbowCostLabel.Location = new System.Drawing.Point(4, 164);
			this.switchCrossbowCostLabel.Name = "switchCrossbowCostLabel";
			this.switchCrossbowCostLabel.Size = new System.Drawing.Size(34, 13);
			this.switchCrossbowCostLabel.TabIndex = 2;
			this.switchCrossbowCostLabel.Text = "Cost: ";
			// 
			// switchCrossbowPictureBox
			// 
			this.switchCrossbowPictureBox.Image = global::Ragnarok.Properties.Resources.Crossbow_Tower;
			this.switchCrossbowPictureBox.Location = new System.Drawing.Point(4, 83);
			this.switchCrossbowPictureBox.Name = "switchCrossbowPictureBox";
			this.switchCrossbowPictureBox.Size = new System.Drawing.Size(70, 70);
			this.switchCrossbowPictureBox.TabIndex = 1;
			this.switchCrossbowPictureBox.TabStop = false;
			// 
			// settingsPanel
			// 
			this.settingsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.settingsPanel.BackColor = System.Drawing.Color.Maroon;
			this.settingsPanel.Controls.Add(this.colorGroupBox);
			this.settingsPanel.Controls.Add(this.musicCheckBox);
			this.settingsPanel.Controls.Add(this.sfxCheckBox);
			this.settingsPanel.Controls.Add(this.closeButton);
			this.settingsPanel.Controls.Add(this.saveButton);
			this.settingsPanel.Controls.Add(this.label1);
			this.settingsPanel.Location = new System.Drawing.Point(1052, 477);
			this.settingsPanel.Name = "settingsPanel";
			this.settingsPanel.Size = new System.Drawing.Size(222, 230);
			this.settingsPanel.TabIndex = 9;
			this.settingsPanel.Visible = false;
			// 
			// colorGroupBox
			// 
			this.colorGroupBox.Controls.Add(this.navyColor);
			this.colorGroupBox.Controls.Add(this.blackColor);
			this.colorGroupBox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.colorGroupBox.ForeColor = System.Drawing.Color.White;
			this.colorGroupBox.Location = new System.Drawing.Point(29, 127);
			this.colorGroupBox.Name = "colorGroupBox";
			this.colorGroupBox.Size = new System.Drawing.Size(139, 52);
			this.colorGroupBox.TabIndex = 10;
			this.colorGroupBox.TabStop = false;
			this.colorGroupBox.Text = "Background Color";
			// 
			// navyColor
			// 
			this.navyColor.AutoSize = true;
			this.navyColor.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.navyColor.ForeColor = System.Drawing.Color.White;
			this.navyColor.Location = new System.Drawing.Point(16, 18);
			this.navyColor.Name = "navyColor";
			this.navyColor.Size = new System.Drawing.Size(50, 19);
			this.navyColor.TabIndex = 8;
			this.navyColor.TabStop = true;
			this.navyColor.Text = "Blue";
			this.navyColor.UseVisualStyleBackColor = true;
			// 
			// blackColor
			// 
			this.blackColor.AutoSize = true;
			this.blackColor.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.blackColor.ForeColor = System.Drawing.Color.White;
			this.blackColor.Location = new System.Drawing.Point(78, 18);
			this.blackColor.Name = "blackColor";
			this.blackColor.Size = new System.Drawing.Size(56, 19);
			this.blackColor.TabIndex = 9;
			this.blackColor.TabStop = true;
			this.blackColor.Text = "Black";
			this.blackColor.UseVisualStyleBackColor = true;
			// 
			// musicCheckBox
			// 
			this.musicCheckBox.AutoSize = true;
			this.musicCheckBox.Checked = true;
			this.musicCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.musicCheckBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.musicCheckBox.ForeColor = System.Drawing.Color.White;
			this.musicCheckBox.Location = new System.Drawing.Point(33, 101);
			this.musicCheckBox.Name = "musicCheckBox";
			this.musicCheckBox.Size = new System.Drawing.Size(69, 23);
			this.musicCheckBox.TabIndex = 7;
			this.musicCheckBox.Text = "Music";
			this.musicCheckBox.UseVisualStyleBackColor = true;
			// 
			// sfxCheckBox
			// 
			this.sfxCheckBox.AutoSize = true;
			this.sfxCheckBox.Checked = true;
			this.sfxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.sfxCheckBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.sfxCheckBox.ForeColor = System.Drawing.Color.White;
			this.sfxCheckBox.Location = new System.Drawing.Point(33, 66);
			this.sfxCheckBox.Name = "sfxCheckBox";
			this.sfxCheckBox.Size = new System.Drawing.Size(122, 23);
			this.sfxCheckBox.TabIndex = 6;
			this.sfxCheckBox.Text = "Sound Effects";
			this.sfxCheckBox.UseVisualStyleBackColor = true;
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.Maroon;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.closeButton.Location = new System.Drawing.Point(185, 3);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(34, 30);
			this.closeButton.TabIndex = 5;
			this.closeButton.Text = "X";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.saveButton.Location = new System.Drawing.Point(74, 196);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(69, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Settings";
			// 
			// basicPanel
			// 
			this.basicPanel.BackColor = System.Drawing.Color.Maroon;
			this.basicPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.basicPanel.Controls.Add(this.basicTowerLabel);
			this.basicPanel.Controls.Add(this.basicPanelCloseButton);
			this.basicPanel.Controls.Add(this.basicPanelPowerLabel);
			this.basicPanel.Controls.Add(this.basicPanelRangeLabel);
			this.basicPanel.Controls.Add(this.basicPanelCostLabel);
			this.basicPanel.Controls.Add(this.basicPanelTowerImage);
			this.basicPanel.Controls.Add(this.buyBasicTowerButton);
			this.basicPanel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.basicPanel.Location = new System.Drawing.Point(1056, 210);
			this.basicPanel.Name = "basicPanel";
			this.basicPanel.Size = new System.Drawing.Size(160, 260);
			this.basicPanel.TabIndex = 2;
			// 
			// basicTowerLabel
			// 
			this.basicTowerLabel.AutoSize = true;
			this.basicTowerLabel.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.basicTowerLabel.ForeColor = System.Drawing.Color.White;
			this.basicTowerLabel.Location = new System.Drawing.Point(12, 36);
			this.basicTowerLabel.Name = "basicTowerLabel";
			this.basicTowerLabel.Size = new System.Drawing.Size(136, 29);
			this.basicTowerLabel.TabIndex = 7;
			this.basicTowerLabel.Text = "Basic Tower";
			// 
			// basicPanelCloseButton
			// 
			this.basicPanelCloseButton.BackColor = System.Drawing.Color.Maroon;
			this.basicPanelCloseButton.FlatAppearance.BorderSize = 0;
			this.basicPanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.basicPanelCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.basicPanelCloseButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.basicPanelCloseButton.Location = new System.Drawing.Point(121, 3);
			this.basicPanelCloseButton.Name = "basicPanelCloseButton";
			this.basicPanelCloseButton.Size = new System.Drawing.Size(34, 30);
			this.basicPanelCloseButton.TabIndex = 6;
			this.basicPanelCloseButton.Text = "X";
			this.basicPanelCloseButton.UseVisualStyleBackColor = false;
			this.basicPanelCloseButton.Click += new System.EventHandler(this.basicPanelCloseButton_Click);
			// 
			// basicPanelPowerLabel
			// 
			this.basicPanelPowerLabel.AutoSize = true;
			this.basicPanelPowerLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.basicPanelPowerLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.basicPanelPowerLabel.Location = new System.Drawing.Point(50, 188);
			this.basicPanelPowerLabel.Name = "basicPanelPowerLabel";
			this.basicPanelPowerLabel.Size = new System.Drawing.Size(49, 15);
			this.basicPanelPowerLabel.TabIndex = 4;
			this.basicPanelPowerLabel.Text = "Power: ";
			// 
			// basicPanelRangeLabel
			// 
			this.basicPanelRangeLabel.AutoSize = true;
			this.basicPanelRangeLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.basicPanelRangeLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.basicPanelRangeLabel.Location = new System.Drawing.Point(50, 164);
			this.basicPanelRangeLabel.Name = "basicPanelRangeLabel";
			this.basicPanelRangeLabel.Size = new System.Drawing.Size(48, 15);
			this.basicPanelRangeLabel.TabIndex = 3;
			this.basicPanelRangeLabel.Text = "Range: ";
			// 
			// basicPanelCostLabel
			// 
			this.basicPanelCostLabel.AutoSize = true;
			this.basicPanelCostLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.basicPanelCostLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.basicPanelCostLabel.Location = new System.Drawing.Point(50, 141);
			this.basicPanelCostLabel.Name = "basicPanelCostLabel";
			this.basicPanelCostLabel.Size = new System.Drawing.Size(38, 15);
			this.basicPanelCostLabel.TabIndex = 2;
			this.basicPanelCostLabel.Text = "Cost: ";
			// 
			// basicPanelTowerImage
			// 
			this.basicPanelTowerImage.Location = new System.Drawing.Point(43, 68);
			this.basicPanelTowerImage.Name = "basicPanelTowerImage";
			this.basicPanelTowerImage.Size = new System.Drawing.Size(70, 70);
			this.basicPanelTowerImage.TabIndex = 1;
			this.basicPanelTowerImage.TabStop = false;
			// 
			// buyBasicTowerButton
			// 
			this.buyBasicTowerButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buyBasicTowerButton.Location = new System.Drawing.Point(30, 206);
			this.buyBasicTowerButton.Name = "buyBasicTowerButton";
			this.buyBasicTowerButton.Size = new System.Drawing.Size(99, 34);
			this.buyBasicTowerButton.TabIndex = 0;
			this.buyBasicTowerButton.Text = "Buy";
			this.buyBasicTowerButton.UseVisualStyleBackColor = true;
			this.buyBasicTowerButton.Click += new System.EventHandler(this.buyBasicTowerButton_Click);
			// 
			// upgradePanel
			// 
			this.upgradePanel.BackColor = System.Drawing.Color.Maroon;
			this.upgradePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.upgradePanel.Controls.Add(this.upgradePanelLevelLabel);
			this.upgradePanel.Controls.Add(this.upgradePanelTitleLabel);
			this.upgradePanel.Controls.Add(this.upgradePanelUpgradeButton);
			this.upgradePanel.Controls.Add(this.upgradePanelCloseButton);
			this.upgradePanel.Controls.Add(this.upgradePanelPowerLabel);
			this.upgradePanel.Controls.Add(this.upgradePanelRangeLabel);
			this.upgradePanel.Controls.Add(this.upgradePanelCostLabel);
			this.upgradePanel.Controls.Add(this.upgradePanelPictureBox);
			this.upgradePanel.Controls.Add(this.upgradePanelSellButton);
			this.upgradePanel.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.upgradePanel.Location = new System.Drawing.Point(1222, 210);
			this.upgradePanel.Name = "upgradePanel";
			this.upgradePanel.Size = new System.Drawing.Size(159, 265);
			this.upgradePanel.TabIndex = 7;
			// 
			// upgradePanelLevelLabel
			// 
			this.upgradePanelLevelLabel.AutoSize = true;
			this.upgradePanelLevelLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.upgradePanelLevelLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.upgradePanelLevelLabel.Location = new System.Drawing.Point(40, 139);
			this.upgradePanelLevelLabel.Name = "upgradePanelLevelLabel";
			this.upgradePanelLevelLabel.Size = new System.Drawing.Size(51, 19);
			this.upgradePanelLevelLabel.TabIndex = 9;
			this.upgradePanelLevelLabel.Text = "Level:";
			// 
			// upgradePanelTitleLabel
			// 
			this.upgradePanelTitleLabel.AutoSize = true;
			this.upgradePanelTitleLabel.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.upgradePanelTitleLabel.ForeColor = System.Drawing.Color.White;
			this.upgradePanelTitleLabel.Location = new System.Drawing.Point(3, 36);
			this.upgradePanelTitleLabel.Name = "upgradePanelTitleLabel";
			this.upgradePanelTitleLabel.Size = new System.Drawing.Size(149, 26);
			this.upgradePanelTitleLabel.TabIndex = 8;
			this.upgradePanelTitleLabel.Text = "Upgrade Tower";
			// 
			// upgradePanelUpgradeButton
			// 
			this.upgradePanelUpgradeButton.Location = new System.Drawing.Point(79, 230);
			this.upgradePanelUpgradeButton.Name = "upgradePanelUpgradeButton";
			this.upgradePanelUpgradeButton.Size = new System.Drawing.Size(71, 23);
			this.upgradePanelUpgradeButton.TabIndex = 7;
			this.upgradePanelUpgradeButton.Text = "Upgrade";
			this.upgradePanelUpgradeButton.UseVisualStyleBackColor = true;
			// 
			// upgradePanelCloseButton
			// 
			this.upgradePanelCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.upgradePanelCloseButton.BackColor = System.Drawing.Color.Maroon;
			this.upgradePanelCloseButton.FlatAppearance.BorderSize = 0;
			this.upgradePanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.upgradePanelCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.upgradePanelCloseButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.upgradePanelCloseButton.Location = new System.Drawing.Point(120, 3);
			this.upgradePanelCloseButton.Name = "upgradePanelCloseButton";
			this.upgradePanelCloseButton.Size = new System.Drawing.Size(34, 30);
			this.upgradePanelCloseButton.TabIndex = 6;
			this.upgradePanelCloseButton.Text = "X";
			this.upgradePanelCloseButton.UseVisualStyleBackColor = false;
			this.upgradePanelCloseButton.Click += new System.EventHandler(this.upgradePanelCloseButton_Click);
			// 
			// upgradePanelPowerLabel
			// 
			this.upgradePanelPowerLabel.AutoSize = true;
			this.upgradePanelPowerLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.upgradePanelPowerLabel.Location = new System.Drawing.Point(41, 214);
			this.upgradePanelPowerLabel.Name = "upgradePanelPowerLabel";
			this.upgradePanelPowerLabel.Size = new System.Drawing.Size(42, 13);
			this.upgradePanelPowerLabel.TabIndex = 4;
			this.upgradePanelPowerLabel.Text = "Power: ";
			// 
			// upgradePanelRangeLabel
			// 
			this.upgradePanelRangeLabel.AutoSize = true;
			this.upgradePanelRangeLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.upgradePanelRangeLabel.Location = new System.Drawing.Point(41, 190);
			this.upgradePanelRangeLabel.Name = "upgradePanelRangeLabel";
			this.upgradePanelRangeLabel.Size = new System.Drawing.Size(39, 13);
			this.upgradePanelRangeLabel.TabIndex = 3;
			this.upgradePanelRangeLabel.Text = "Range:";
			// 
			// upgradePanelCostLabel
			// 
			this.upgradePanelCostLabel.AutoSize = true;
			this.upgradePanelCostLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.upgradePanelCostLabel.Location = new System.Drawing.Point(41, 167);
			this.upgradePanelCostLabel.Name = "upgradePanelCostLabel";
			this.upgradePanelCostLabel.Size = new System.Drawing.Size(39, 13);
			this.upgradePanelCostLabel.TabIndex = 2;
			this.upgradePanelCostLabel.Text = "Cost: $";
			// 
			// upgradePanelPictureBox
			// 
			this.upgradePanelPictureBox.Image = global::Ragnarok.Properties.Resources.Mage_Tower2;
			this.upgradePanelPictureBox.Location = new System.Drawing.Point(44, 65);
			this.upgradePanelPictureBox.Name = "upgradePanelPictureBox";
			this.upgradePanelPictureBox.Size = new System.Drawing.Size(70, 70);
			this.upgradePanelPictureBox.TabIndex = 1;
			this.upgradePanelPictureBox.TabStop = false;
			// 
			// upgradePanelSellButton
			// 
			this.upgradePanelSellButton.Location = new System.Drawing.Point(7, 230);
			this.upgradePanelSellButton.Name = "upgradePanelSellButton";
			this.upgradePanelSellButton.Size = new System.Drawing.Size(66, 23);
			this.upgradePanelSellButton.TabIndex = 0;
			this.upgradePanelSellButton.Text = "Sell (+ $)";
			this.upgradePanelSellButton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Navy;
			this.ClientSize = new System.Drawing.Size(1354, 733);
			this.Controls.Add(this.ragnarokPanel);
			this.Controls.Add(this.settingsPanel);
			this.Controls.Add(this.switchPanel);
			this.Controls.Add(this.upgradePanel);
			this.Controls.Add(this.basicPanel);
			this.Controls.Add(this.mapPanel);
			this.Controls.Add(this.mainMenuPanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.mainMenuPanel.ResumeLayout(false);
			this.mainMenuPanel.PerformLayout();
			this.ragnarokPanel.ResumeLayout(false);
			this.ragnarokPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ragnarokPanelPictureBox)).EndInit();
			this.switchPanel.ResumeLayout(false);
			this.switchPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.switchSniperPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.switchMagePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.switchCrossbowPictureBox)).EndInit();
			this.settingsPanel.ResumeLayout(false);
			this.settingsPanel.PerformLayout();
			this.colorGroupBox.ResumeLayout(false);
			this.colorGroupBox.PerformLayout();
			this.basicPanel.ResumeLayout(false);
			this.basicPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.basicPanelTowerImage)).EndInit();
			this.upgradePanel.ResumeLayout(false);
			this.upgradePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.upgradePanelPictureBox)).EndInit();
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
		private System.Windows.Forms.Label basicPanelPowerLabel;
		private System.Windows.Forms.Label basicPanelRangeLabel;
		private System.Windows.Forms.Label basicPanelCostLabel;
		private System.Windows.Forms.PictureBox basicPanelTowerImage;
		private System.Windows.Forms.Button buyBasicTowerButton;
		private System.Windows.Forms.Button basicPanelCloseButton;
		private System.Windows.Forms.Panel upgradePanel;
		private System.Windows.Forms.Button upgradePanelUpgradeButton;
		private System.Windows.Forms.Button upgradePanelCloseButton;
		private System.Windows.Forms.Label upgradePanelPowerLabel;
		private System.Windows.Forms.Label upgradePanelRangeLabel;
		private System.Windows.Forms.Label upgradePanelCostLabel;
		private System.Windows.Forms.PictureBox upgradePanelPictureBox;
		private System.Windows.Forms.Button upgradePanelSellButton;
		private System.Windows.Forms.Panel switchPanel;
		private System.Windows.Forms.Button switchCrossbowButton;
		private System.Windows.Forms.Button switchCloseButton;
		private System.Windows.Forms.Label switchCrossbowCostLabel;
		private System.Windows.Forms.PictureBox switchCrossbowPictureBox;
		private System.Windows.Forms.Label basicTowerLabel;
		private System.Windows.Forms.Label upgradePanelLevelLabel;
		private System.Windows.Forms.Label upgradePanelTitleLabel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button switchSellButton;
		private System.Windows.Forms.Label switchSniperPowerTower;
		private System.Windows.Forms.Label switchSniperRangeTower;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label switchSniperCostLabel;
		private System.Windows.Forms.PictureBox switchSniperPictureBox;
		private System.Windows.Forms.Label switchMagePowerLabel;
		private System.Windows.Forms.Label switchMageRangeLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label switchMageCostLabel;
		private System.Windows.Forms.PictureBox switchMagePictureBox;
		private System.Windows.Forms.Label switchCrossbowPowerLabel;
		private System.Windows.Forms.Label switchCrossbowRangeLabel;
		private System.Windows.Forms.Label switchTowerLabel;
		private System.Windows.Forms.Panel ragnarokPanel;
		private System.Windows.Forms.Label ragnarokPanelLevelLabel;
		private System.Windows.Forms.Label ragnarokPanelTitleLabel;
		private System.Windows.Forms.Button ragnarokPanelCloseButton;
		private System.Windows.Forms.Label ragnarokPanelPowerLabel;
		private System.Windows.Forms.Label ragnarokPanelRangeLabel;
		private System.Windows.Forms.PictureBox ragnarokPanelPictureBox;
		private System.Windows.Forms.Button ragnarokPanelSellButton;
		private System.Windows.Forms.Panel settingsPanel;
		private System.Windows.Forms.CheckBox musicCheckBox;
		private System.Windows.Forms.CheckBox sfxCheckBox;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton blackColor;
		private System.Windows.Forms.RadioButton navyColor;
		private System.Windows.Forms.GroupBox colorGroupBox;
	}
}


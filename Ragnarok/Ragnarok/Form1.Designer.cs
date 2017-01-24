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
			this.basicPanel = new System.Windows.Forms.Panel();
			this.basicTowerLabel = new System.Windows.Forms.Label();
			this.basicPanelCloseButton = new System.Windows.Forms.Button();
			this.basicPanelPowerLabel = new System.Windows.Forms.Label();
			this.basicPanelRangeLabel = new System.Windows.Forms.Label();
			this.basicPanelCostLabel = new System.Windows.Forms.Label();
			this.basicPanelTowerImage = new System.Windows.Forms.PictureBox();
			this.buyBasicTowerButton = new System.Windows.Forms.Button();
			this.upgradePanel = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.upgradePanelUpgradeButton = new System.Windows.Forms.Button();
			this.upgradePanelCloseButton = new System.Windows.Forms.Button();
			this.upgradePanelDamagelabel = new System.Windows.Forms.Label();
			this.upgradePanelRangeLabel = new System.Windows.Forms.Label();
			this.upgradePanelCostLabel = new System.Windows.Forms.Label();
			this.upgradePanelImage = new System.Windows.Forms.PictureBox();
			this.upgradePanelSellButton = new System.Windows.Forms.Button();
			this.switchPanel = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.switchTowerLabel = new System.Windows.Forms.Label();
			this.switchCrossbowButton = new System.Windows.Forms.Button();
			this.switchCloseButton = new System.Windows.Forms.Button();
			this.switchCostLabel = new System.Windows.Forms.Label();
			this.switchPictureBox = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.button6 = new System.Windows.Forms.Button();
			this.mainMenuPanel.SuspendLayout();
			this.basicPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.basicPanelTowerImage)).BeginInit();
			this.upgradePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.upgradePanelImage)).BeginInit();
			this.switchPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.switchPictureBox)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
			this.mainMenuPanel.Location = new System.Drawing.Point(1056, 4);
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
			this.basicPanelCostLabel.Size = new System.Drawing.Size(50, 15);
			this.basicPanelCostLabel.TabIndex = 2;
			this.basicPanelCostLabel.Text = "Cost: $5";
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
			// 
			// upgradePanel
			// 
			this.upgradePanel.BackColor = System.Drawing.Color.Maroon;
			this.upgradePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.upgradePanel.Controls.Add(this.label13);
			this.upgradePanel.Controls.Add(this.label12);
			this.upgradePanel.Controls.Add(this.upgradePanelUpgradeButton);
			this.upgradePanel.Controls.Add(this.upgradePanelCloseButton);
			this.upgradePanel.Controls.Add(this.upgradePanelDamagelabel);
			this.upgradePanel.Controls.Add(this.upgradePanelRangeLabel);
			this.upgradePanel.Controls.Add(this.upgradePanelCostLabel);
			this.upgradePanel.Controls.Add(this.upgradePanelImage);
			this.upgradePanel.Controls.Add(this.upgradePanelSellButton);
			this.upgradePanel.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.upgradePanel.Location = new System.Drawing.Point(1222, 210);
			this.upgradePanel.Name = "upgradePanel";
			this.upgradePanel.Size = new System.Drawing.Size(159, 265);
			this.upgradePanel.TabIndex = 7;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label13.ForeColor = System.Drawing.SystemColors.Info;
			this.label13.Location = new System.Drawing.Point(40, 139);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(63, 19);
			this.label13.TabIndex = 9;
			this.label13.Text = "Level: 2";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(3, 36);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(149, 26);
			this.label12.TabIndex = 8;
			this.label12.Text = "Upgrade Tower";
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
			// upgradePanelDamagelabel
			// 
			this.upgradePanelDamagelabel.AutoSize = true;
			this.upgradePanelDamagelabel.ForeColor = System.Drawing.SystemColors.Info;
			this.upgradePanelDamagelabel.Location = new System.Drawing.Point(41, 214);
			this.upgradePanelDamagelabel.Name = "upgradePanelDamagelabel";
			this.upgradePanelDamagelabel.Size = new System.Drawing.Size(55, 13);
			this.upgradePanelDamagelabel.TabIndex = 4;
			this.upgradePanelDamagelabel.Text = "Damage: 1";
			// 
			// upgradePanelRangeLabel
			// 
			this.upgradePanelRangeLabel.AutoSize = true;
			this.upgradePanelRangeLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.upgradePanelRangeLabel.Location = new System.Drawing.Point(41, 190);
			this.upgradePanelRangeLabel.Name = "upgradePanelRangeLabel";
			this.upgradePanelRangeLabel.Size = new System.Drawing.Size(45, 13);
			this.upgradePanelRangeLabel.TabIndex = 3;
			this.upgradePanelRangeLabel.Text = "Range: 1";
			// 
			// upgradePanelCostLabel
			// 
			this.upgradePanelCostLabel.AutoSize = true;
			this.upgradePanelCostLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.upgradePanelCostLabel.Location = new System.Drawing.Point(41, 167);
			this.upgradePanelCostLabel.Name = "upgradePanelCostLabel";
			this.upgradePanelCostLabel.Size = new System.Drawing.Size(48, 13);
			this.upgradePanelCostLabel.TabIndex = 2;
			this.upgradePanelCostLabel.Text = "Cost: $10";
			// 
			// upgradePanelImage
			// 
			this.upgradePanelImage.Image = global::Ragnarok.Properties.Resources.Mage_Tower2;
			this.upgradePanelImage.Location = new System.Drawing.Point(44, 65);
			this.upgradePanelImage.Name = "upgradePanelImage";
			this.upgradePanelImage.Size = new System.Drawing.Size(70, 70);
			this.upgradePanelImage.TabIndex = 1;
			this.upgradePanelImage.TabStop = false;
			// 
			// upgradePanelSellButton
			// 
			this.upgradePanelSellButton.Location = new System.Drawing.Point(7, 230);
			this.upgradePanelSellButton.Name = "upgradePanelSellButton";
			this.upgradePanelSellButton.Size = new System.Drawing.Size(66, 23);
			this.upgradePanelSellButton.TabIndex = 0;
			this.upgradePanelSellButton.Text = "Sell (+ 2$)";
			this.upgradePanelSellButton.UseVisualStyleBackColor = true;
			// 
			// switchPanel
			// 
			this.switchPanel.BackColor = System.Drawing.Color.Maroon;
			this.switchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.switchPanel.Controls.Add(this.label11);
			this.switchPanel.Controls.Add(this.label10);
			this.switchPanel.Controls.Add(this.label9);
			this.switchPanel.Controls.Add(this.button3);
			this.switchPanel.Controls.Add(this.label6);
			this.switchPanel.Controls.Add(this.label7);
			this.switchPanel.Controls.Add(this.button2);
			this.switchPanel.Controls.Add(this.label8);
			this.switchPanel.Controls.Add(this.pictureBox2);
			this.switchPanel.Controls.Add(this.label3);
			this.switchPanel.Controls.Add(this.label4);
			this.switchPanel.Controls.Add(this.button1);
			this.switchPanel.Controls.Add(this.label5);
			this.switchPanel.Controls.Add(this.pictureBox1);
			this.switchPanel.Controls.Add(this.label2);
			this.switchPanel.Controls.Add(this.label1);
			this.switchPanel.Controls.Add(this.switchTowerLabel);
			this.switchPanel.Controls.Add(this.switchCrossbowButton);
			this.switchPanel.Controls.Add(this.switchCloseButton);
			this.switchPanel.Controls.Add(this.switchCostLabel);
			this.switchPanel.Controls.Add(this.switchPictureBox);
			this.switchPanel.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.switchPanel.Location = new System.Drawing.Point(1056, 476);
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
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(4, 247);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(222, 23);
			this.button3.TabIndex = 23;
			this.button3.Text = "Sell (+ 2$)";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.Info;
			this.label6.Location = new System.Drawing.Point(156, 202);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 22;
			this.label6.Text = "Damage: 1";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.SystemColors.Info;
			this.label7.Location = new System.Drawing.Point(156, 182);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "Range: 1";
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
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.SystemColors.Info;
			this.label8.Location = new System.Drawing.Point(156, 164);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "Cost: $10";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Ragnarok.Properties.Resources.Sniper_Tower;
			this.pictureBox2.Location = new System.Drawing.Point(156, 83);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(70, 70);
			this.pictureBox2.TabIndex = 18;
			this.pictureBox2.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.Info;
			this.label3.Location = new System.Drawing.Point(80, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Damage: 1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.Info;
			this.label4.Location = new System.Drawing.Point(80, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Range: 1";
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.Info;
			this.label5.Location = new System.Drawing.Point(80, 164);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Cost: $10";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Ragnarok.Properties.Resources.Mage_Tower;
			this.pictureBox1.Location = new System.Drawing.Point(80, 83);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(70, 70);
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.Info;
			this.label2.Location = new System.Drawing.Point(4, 202);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Damage: 1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.Info;
			this.label1.Location = new System.Drawing.Point(4, 182);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Range: 1";
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
			// switchCostLabel
			// 
			this.switchCostLabel.AutoSize = true;
			this.switchCostLabel.ForeColor = System.Drawing.SystemColors.Info;
			this.switchCostLabel.Location = new System.Drawing.Point(4, 164);
			this.switchCostLabel.Name = "switchCostLabel";
			this.switchCostLabel.Size = new System.Drawing.Size(48, 13);
			this.switchCostLabel.TabIndex = 2;
			this.switchCostLabel.Text = "Cost: $10";
			// 
			// switchPictureBox
			// 
			this.switchPictureBox.Image = global::Ragnarok.Properties.Resources.Crossbow_Tower;
			this.switchPictureBox.Location = new System.Drawing.Point(4, 83);
			this.switchPictureBox.Name = "switchPictureBox";
			this.switchPictureBox.Size = new System.Drawing.Size(70, 70);
			this.switchPictureBox.TabIndex = 1;
			this.switchPictureBox.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Maroon;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.panel1.Location = new System.Drawing.Point(1281, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(155, 244);
			this.panel1.TabIndex = 8;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label14.ForeColor = System.Drawing.SystemColors.Info;
			this.label14.Location = new System.Drawing.Point(38, 139);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(62, 19);
			this.label14.TabIndex = 9;
			this.label14.Text = "Level: 3";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(13, 36);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(126, 26);
			this.label15.TabIndex = 8;
			this.label15.Text = "RAGNAROK";
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button5.BackColor = System.Drawing.Color.Maroon;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.button5.Location = new System.Drawing.Point(116, 3);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(34, 30);
			this.button5.TabIndex = 6;
			this.button5.Text = "X";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.ForeColor = System.Drawing.SystemColors.Info;
			this.label16.Location = new System.Drawing.Point(39, 188);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(55, 13);
			this.label16.TabIndex = 4;
			this.label16.Text = "Damage: 1";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.ForeColor = System.Drawing.SystemColors.Info;
			this.label17.Location = new System.Drawing.Point(39, 167);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(45, 13);
			this.label17.TabIndex = 3;
			this.label17.Text = "Range: 1";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Ragnarok.Properties.Resources.Mage_Tower3;
			this.pictureBox3.Location = new System.Drawing.Point(42, 65);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(70, 70);
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(18, 209);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(121, 23);
			this.button6.TabIndex = 0;
			this.button6.Text = "Sell (+ 2$)";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Navy;
			this.ClientSize = new System.Drawing.Size(1362, 741);
			this.Controls.Add(this.panel1);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.switchPictureBox)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
		private System.Windows.Forms.Label upgradePanelDamagelabel;
		private System.Windows.Forms.Label upgradePanelRangeLabel;
		private System.Windows.Forms.Label upgradePanelCostLabel;
		private System.Windows.Forms.PictureBox upgradePanelImage;
		private System.Windows.Forms.Button upgradePanelSellButton;
		private System.Windows.Forms.Panel switchPanel;
		private System.Windows.Forms.Button switchCrossbowButton;
		private System.Windows.Forms.Button switchCloseButton;
		private System.Windows.Forms.Label switchCostLabel;
		private System.Windows.Forms.PictureBox switchPictureBox;
		private System.Windows.Forms.Label basicTowerLabel;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label switchTowerLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button button6;
	}
}


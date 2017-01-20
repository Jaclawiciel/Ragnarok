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
			this.mainMenuPanel = new System.Windows.Forms.Panel();
			this.mainMenuTitle = new System.Windows.Forms.Label();
			this.startNewGameButton = new System.Windows.Forms.Button();
			this.loadGameButton = new System.Windows.Forms.Button();
			this.menuSettingsButton = new System.Windows.Forms.Button();
			this.menuQuitButton = new System.Windows.Forms.Button();
			this.mainMenuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuPanel
			// 
			this.mainMenuPanel.BackColor = System.Drawing.SystemColors.HotTrack;
			this.mainMenuPanel.Controls.Add(this.menuQuitButton);
			this.mainMenuPanel.Controls.Add(this.menuSettingsButton);
			this.mainMenuPanel.Controls.Add(this.loadGameButton);
			this.mainMenuPanel.Controls.Add(this.startNewGameButton);
			this.mainMenuPanel.Controls.Add(this.mainMenuTitle);
			this.mainMenuPanel.Location = new System.Drawing.Point(143, 93);
			this.mainMenuPanel.Name = "mainMenuPanel";
			this.mainMenuPanel.Size = new System.Drawing.Size(222, 200);
			this.mainMenuPanel.TabIndex = 0;
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
			// startNewGameButton
			// 
			this.startNewGameButton.Location = new System.Drawing.Point(74, 67);
			this.startNewGameButton.Name = "startNewGameButton";
			this.startNewGameButton.Size = new System.Drawing.Size(75, 23);
			this.startNewGameButton.TabIndex = 1;
			this.startNewGameButton.Text = "New Game";
			this.startNewGameButton.UseVisualStyleBackColor = true;
			// 
			// loadGameButton
			// 
			this.loadGameButton.Location = new System.Drawing.Point(74, 96);
			this.loadGameButton.Name = "loadGameButton";
			this.loadGameButton.Size = new System.Drawing.Size(75, 23);
			this.loadGameButton.TabIndex = 2;
			this.loadGameButton.Text = "Load Game";
			this.loadGameButton.UseVisualStyleBackColor = true;
			// 
			// menuSettingsButton
			// 
			this.menuSettingsButton.Location = new System.Drawing.Point(74, 125);
			this.menuSettingsButton.Name = "menuSettingsButton";
			this.menuSettingsButton.Size = new System.Drawing.Size(75, 23);
			this.menuSettingsButton.TabIndex = 3;
			this.menuSettingsButton.Text = "Settings";
			this.menuSettingsButton.UseVisualStyleBackColor = true;
			// 
			// menuQuitButton
			// 
			this.menuQuitButton.Location = new System.Drawing.Point(74, 154);
			this.menuQuitButton.Name = "menuQuitButton";
			this.menuQuitButton.Size = new System.Drawing.Size(75, 23);
			this.menuQuitButton.TabIndex = 4;
			this.menuQuitButton.Text = "Quit";
			this.menuQuitButton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(523, 414);
			this.Controls.Add(this.mainMenuPanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.mainMenuPanel.ResumeLayout(false);
			this.mainMenuPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainMenuPanel;
		private System.Windows.Forms.Button menuQuitButton;
		private System.Windows.Forms.Button menuSettingsButton;
		private System.Windows.Forms.Button loadGameButton;
		private System.Windows.Forms.Button startNewGameButton;
		private System.Windows.Forms.Label mainMenuTitle;
	}
}


namespace Halso_Hub
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.moodTab = new System.Windows.Forms.TabPage();
			this.moodButtonPanel = new System.Windows.Forms.TableLayoutPanel();
			this.lonelyButton3 = new System.Windows.Forms.Button();
			this.lonelyButton2 = new System.Windows.Forms.Button();
			this.tiredButton3 = new System.Windows.Forms.Button();
			this.sadButton1 = new System.Windows.Forms.Button();
			this.tiredButton1 = new System.Windows.Forms.Button();
			this.stressedButton1 = new System.Windows.Forms.Button();
			this.sadButton2 = new System.Windows.Forms.Button();
			this.sadButton3 = new System.Windows.Forms.Button();
			this.sadButton4 = new System.Windows.Forms.Button();
			this.tiredButton2 = new System.Windows.Forms.Button();
			this.tiredButton4 = new System.Windows.Forms.Button();
			this.stressedButton2 = new System.Windows.Forms.Button();
			this.stressedButton3 = new System.Windows.Forms.Button();
			this.stressedButton4 = new System.Windows.Forms.Button();
			this.lonelyButton1 = new System.Windows.Forms.Button();
			this.lonelyButton4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.activityTab = new System.Windows.Forms.TabPage();
			this.activityPictureBox = new System.Windows.Forms.PictureBox();
			this.startActivityButton = new System.Windows.Forms.Button();
			this.activityDescriptionBox = new System.Windows.Forms.RichTextBox();
			this.activitiesListbox = new System.Windows.Forms.ListBox();
			this.activitiesLabel = new System.Windows.Forms.Label();
			this.timeLeftText = new System.Windows.Forms.Label();
			this.timerText = new System.Windows.Forms.Label();
			this.challengeTab = new System.Windows.Forms.TabPage();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.trophiesTab = new System.Windows.Forms.TabPage();
			this.tabControl.SuspendLayout();
			this.moodTab.SuspendLayout();
			this.moodButtonPanel.SuspendLayout();
			this.activityTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.activityPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.moodTab);
			this.tabControl.Controls.Add(this.activityTab);
			this.tabControl.Controls.Add(this.challengeTab);
			this.tabControl.Controls.Add(this.trophiesTab);
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.Padding = new System.Drawing.Point(10, 10);
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(786, 460);
			this.tabControl.TabIndex = 0;
			// 
			// moodTab
			// 
			this.moodTab.Controls.Add(this.moodButtonPanel);
			this.moodTab.Controls.Add(this.label1);
			this.moodTab.Location = new System.Drawing.Point(4, 36);
			this.moodTab.Name = "moodTab";
			this.moodTab.Padding = new System.Windows.Forms.Padding(3);
			this.moodTab.Size = new System.Drawing.Size(778, 420);
			this.moodTab.TabIndex = 0;
			this.moodTab.Text = "Mood";
			this.moodTab.UseVisualStyleBackColor = true;
			// 
			// moodButtonPanel
			// 
			this.moodButtonPanel.BackColor = System.Drawing.Color.Transparent;
			this.moodButtonPanel.ColumnCount = 4;
			this.moodButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.moodButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.moodButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.moodButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.moodButtonPanel.Controls.Add(this.lonelyButton3, 0, 3);
			this.moodButtonPanel.Controls.Add(this.lonelyButton2, 0, 3);
			this.moodButtonPanel.Controls.Add(this.tiredButton3, 2, 1);
			this.moodButtonPanel.Controls.Add(this.sadButton1, 0, 0);
			this.moodButtonPanel.Controls.Add(this.tiredButton1, 0, 1);
			this.moodButtonPanel.Controls.Add(this.stressedButton1, 0, 2);
			this.moodButtonPanel.Controls.Add(this.sadButton2, 1, 0);
			this.moodButtonPanel.Controls.Add(this.sadButton3, 2, 0);
			this.moodButtonPanel.Controls.Add(this.sadButton4, 3, 0);
			this.moodButtonPanel.Controls.Add(this.tiredButton2, 1, 1);
			this.moodButtonPanel.Controls.Add(this.tiredButton4, 3, 1);
			this.moodButtonPanel.Controls.Add(this.stressedButton2, 1, 2);
			this.moodButtonPanel.Controls.Add(this.stressedButton3, 2, 2);
			this.moodButtonPanel.Controls.Add(this.stressedButton4, 3, 2);
			this.moodButtonPanel.Controls.Add(this.lonelyButton1, 0, 3);
			this.moodButtonPanel.Controls.Add(this.lonelyButton4, 3, 3);
			this.moodButtonPanel.Location = new System.Drawing.Point(13, 39);
			this.moodButtonPanel.Name = "moodButtonPanel";
			this.moodButtonPanel.RowCount = 4;
			this.moodButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.moodButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.moodButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.moodButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.moodButtonPanel.Size = new System.Drawing.Size(755, 374);
			this.moodButtonPanel.TabIndex = 9;
			// 
			// lonelyButton3
			// 
			this.lonelyButton3.Location = new System.Drawing.Point(378, 281);
			this.lonelyButton3.Margin = new System.Windows.Forms.Padding(2);
			this.lonelyButton3.Name = "lonelyButton3";
			this.lonelyButton3.Size = new System.Drawing.Size(184, 89);
			this.lonelyButton3.TabIndex = 21;
			this.lonelyButton3.Text = "Sociable";
			this.lonelyButton3.UseVisualStyleBackColor = true;
			this.lonelyButton3.Click += new System.EventHandler(this.lonelyButton3_Click);
			// 
			// lonelyButton2
			// 
			this.lonelyButton2.Location = new System.Drawing.Point(190, 281);
			this.lonelyButton2.Margin = new System.Windows.Forms.Padding(2);
			this.lonelyButton2.Name = "lonelyButton2";
			this.lonelyButton2.Size = new System.Drawing.Size(184, 89);
			this.lonelyButton2.TabIndex = 18;
			this.lonelyButton2.Text = "Lonely";
			this.lonelyButton2.UseVisualStyleBackColor = true;
			this.lonelyButton2.Click += new System.EventHandler(this.lonelyButton2_Click);
			// 
			// tiredButton3
			// 
			this.tiredButton3.Location = new System.Drawing.Point(378, 95);
			this.tiredButton3.Margin = new System.Windows.Forms.Padding(2);
			this.tiredButton3.Name = "tiredButton3";
			this.tiredButton3.Size = new System.Drawing.Size(184, 89);
			this.tiredButton3.TabIndex = 14;
			this.tiredButton3.Text = "Energetic";
			this.tiredButton3.UseVisualStyleBackColor = true;
			this.tiredButton3.Click += new System.EventHandler(this.tiredButton3_Click);
			// 
			// sadButton1
			// 
			this.sadButton1.Location = new System.Drawing.Point(2, 2);
			this.sadButton1.Margin = new System.Windows.Forms.Padding(2);
			this.sadButton1.Name = "sadButton1";
			this.sadButton1.Size = new System.Drawing.Size(184, 89);
			this.sadButton1.TabIndex = 7;
			this.sadButton1.Text = "Very sad";
			this.sadButton1.UseVisualStyleBackColor = true;
			this.sadButton1.Click += new System.EventHandler(this.sadButton1_Click);
			// 
			// tiredButton1
			// 
			this.tiredButton1.Location = new System.Drawing.Point(2, 95);
			this.tiredButton1.Margin = new System.Windows.Forms.Padding(2);
			this.tiredButton1.Name = "tiredButton1";
			this.tiredButton1.Size = new System.Drawing.Size(184, 89);
			this.tiredButton1.TabIndex = 8;
			this.tiredButton1.Text = "Very Tired";
			this.tiredButton1.UseVisualStyleBackColor = true;
			this.tiredButton1.Click += new System.EventHandler(this.tiredButton1_Click);
			// 
			// stressedButton1
			// 
			this.stressedButton1.Location = new System.Drawing.Point(2, 188);
			this.stressedButton1.Margin = new System.Windows.Forms.Padding(2);
			this.stressedButton1.Name = "stressedButton1";
			this.stressedButton1.Size = new System.Drawing.Size(184, 89);
			this.stressedButton1.TabIndex = 9;
			this.stressedButton1.Text = "Very Stressed";
			this.stressedButton1.UseVisualStyleBackColor = true;
			this.stressedButton1.Click += new System.EventHandler(this.stressedButton1_Click);
			// 
			// sadButton2
			// 
			this.sadButton2.Location = new System.Drawing.Point(190, 2);
			this.sadButton2.Margin = new System.Windows.Forms.Padding(2);
			this.sadButton2.Name = "sadButton2";
			this.sadButton2.Size = new System.Drawing.Size(184, 89);
			this.sadButton2.TabIndex = 11;
			this.sadButton2.Text = "Sad";
			this.sadButton2.UseVisualStyleBackColor = true;
			this.sadButton2.Click += new System.EventHandler(this.sadButton2_Click);
			// 
			// sadButton3
			// 
			this.sadButton3.Location = new System.Drawing.Point(378, 2);
			this.sadButton3.Margin = new System.Windows.Forms.Padding(2);
			this.sadButton3.Name = "sadButton3";
			this.sadButton3.Size = new System.Drawing.Size(184, 89);
			this.sadButton3.TabIndex = 10;
			this.sadButton3.Text = "Happy";
			this.sadButton3.UseVisualStyleBackColor = true;
			this.sadButton3.Click += new System.EventHandler(this.sadButton3_Click);
			// 
			// sadButton4
			// 
			this.sadButton4.Location = new System.Drawing.Point(566, 2);
			this.sadButton4.Margin = new System.Windows.Forms.Padding(2);
			this.sadButton4.Name = "sadButton4";
			this.sadButton4.Size = new System.Drawing.Size(187, 89);
			this.sadButton4.TabIndex = 12;
			this.sadButton4.Text = "Very Happy";
			this.sadButton4.UseVisualStyleBackColor = true;
			this.sadButton4.Click += new System.EventHandler(this.sadButton4_Click);
			// 
			// tiredButton2
			// 
			this.tiredButton2.Location = new System.Drawing.Point(190, 95);
			this.tiredButton2.Margin = new System.Windows.Forms.Padding(2);
			this.tiredButton2.Name = "tiredButton2";
			this.tiredButton2.Size = new System.Drawing.Size(184, 89);
			this.tiredButton2.TabIndex = 13;
			this.tiredButton2.Text = "Tired";
			this.tiredButton2.UseVisualStyleBackColor = true;
			this.tiredButton2.Click += new System.EventHandler(this.tiredButton2_Click);
			// 
			// tiredButton4
			// 
			this.tiredButton4.Location = new System.Drawing.Point(566, 95);
			this.tiredButton4.Margin = new System.Windows.Forms.Padding(2);
			this.tiredButton4.Name = "tiredButton4";
			this.tiredButton4.Size = new System.Drawing.Size(187, 89);
			this.tiredButton4.TabIndex = 15;
			this.tiredButton4.Text = "Very Energetic";
			this.tiredButton4.UseVisualStyleBackColor = true;
			this.tiredButton4.Click += new System.EventHandler(this.tiredButton4_Click);
			// 
			// stressedButton2
			// 
			this.stressedButton2.Location = new System.Drawing.Point(190, 188);
			this.stressedButton2.Margin = new System.Windows.Forms.Padding(2);
			this.stressedButton2.Name = "stressedButton2";
			this.stressedButton2.Size = new System.Drawing.Size(184, 89);
			this.stressedButton2.TabIndex = 14;
			this.stressedButton2.Text = "Stressed";
			this.stressedButton2.UseVisualStyleBackColor = true;
			this.stressedButton2.Click += new System.EventHandler(this.stressedButton2_Click);
			// 
			// stressedButton3
			// 
			this.stressedButton3.Location = new System.Drawing.Point(378, 188);
			this.stressedButton3.Margin = new System.Windows.Forms.Padding(2);
			this.stressedButton3.Name = "stressedButton3";
			this.stressedButton3.Size = new System.Drawing.Size(184, 89);
			this.stressedButton3.TabIndex = 16;
			this.stressedButton3.Text = "Calm";
			this.stressedButton3.UseVisualStyleBackColor = true;
			this.stressedButton3.Click += new System.EventHandler(this.stressedButton3_Click);
			// 
			// stressedButton4
			// 
			this.stressedButton4.Location = new System.Drawing.Point(566, 188);
			this.stressedButton4.Margin = new System.Windows.Forms.Padding(2);
			this.stressedButton4.Name = "stressedButton4";
			this.stressedButton4.Size = new System.Drawing.Size(187, 89);
			this.stressedButton4.TabIndex = 17;
			this.stressedButton4.Text = "Very Calm";
			this.stressedButton4.UseVisualStyleBackColor = true;
			this.stressedButton4.Click += new System.EventHandler(this.stressedButton4_Click);
			// 
			// lonelyButton1
			// 
			this.lonelyButton1.Location = new System.Drawing.Point(2, 281);
			this.lonelyButton1.Margin = new System.Windows.Forms.Padding(2);
			this.lonelyButton1.Name = "lonelyButton1";
			this.lonelyButton1.Size = new System.Drawing.Size(184, 89);
			this.lonelyButton1.TabIndex = 19;
			this.lonelyButton1.Text = "Very Lonely";
			this.lonelyButton1.UseVisualStyleBackColor = true;
			this.lonelyButton1.Click += new System.EventHandler(this.lonelyButton1_Click);
			// 
			// lonelyButton4
			// 
			this.lonelyButton4.Location = new System.Drawing.Point(566, 281);
			this.lonelyButton4.Margin = new System.Windows.Forms.Padding(2);
			this.lonelyButton4.Name = "lonelyButton4";
			this.lonelyButton4.Size = new System.Drawing.Size(187, 89);
			this.lonelyButton4.TabIndex = 20;
			this.lonelyButton4.Text = "Very Sociable";
			this.lonelyButton4.UseVisualStyleBackColor = true;
			this.lonelyButton4.Click += new System.EventHandler(this.lonelyButton4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 25);
			this.label1.TabIndex = 8;
			this.label1.Text = "Select your mood";
			// 
			// activityTab
			// 
			this.activityTab.Controls.Add(this.activityPictureBox);
			this.activityTab.Controls.Add(this.startActivityButton);
			this.activityTab.Controls.Add(this.activityDescriptionBox);
			this.activityTab.Controls.Add(this.activitiesListbox);
			this.activityTab.Controls.Add(this.activitiesLabel);
			this.activityTab.Controls.Add(this.timeLeftText);
			this.activityTab.Controls.Add(this.timerText);
			this.activityTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.activityTab.Location = new System.Drawing.Point(4, 36);
			this.activityTab.Name = "activityTab";
			this.activityTab.Padding = new System.Windows.Forms.Padding(3);
			this.activityTab.Size = new System.Drawing.Size(778, 420);
			this.activityTab.TabIndex = 1;
			this.activityTab.Text = "Activity";
			this.activityTab.UseVisualStyleBackColor = true;
			// 
			// activityPictureBox
			// 
			this.activityPictureBox.Location = new System.Drawing.Point(221, 16);
			this.activityPictureBox.Name = "activityPictureBox";
			this.activityPictureBox.Size = new System.Drawing.Size(317, 393);
			this.activityPictureBox.TabIndex = 13;
			this.activityPictureBox.TabStop = false;
			// 
			// startActivityButton
			// 
			this.startActivityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startActivityButton.Location = new System.Drawing.Point(8, 378);
			this.startActivityButton.Name = "startActivityButton";
			this.startActivityButton.Size = new System.Drawing.Size(162, 33);
			this.startActivityButton.TabIndex = 12;
			this.startActivityButton.Text = "Start";
			this.startActivityButton.UseVisualStyleBackColor = true;
			this.startActivityButton.Click += new System.EventHandler(this.startActivityButton_Click);
			// 
			// activityDescriptionBox
			// 
			this.activityDescriptionBox.Location = new System.Drawing.Point(544, 16);
			this.activityDescriptionBox.Name = "activityDescriptionBox";
			this.activityDescriptionBox.Size = new System.Drawing.Size(224, 361);
			this.activityDescriptionBox.TabIndex = 11;
			this.activityDescriptionBox.Text = "";
			// 
			// activitiesListbox
			// 
			this.activitiesListbox.FormattingEnabled = true;
			this.activitiesListbox.ItemHeight = 16;
			this.activitiesListbox.Location = new System.Drawing.Point(8, 44);
			this.activitiesListbox.Name = "activitiesListbox";
			this.activitiesListbox.Size = new System.Drawing.Size(203, 324);
			this.activitiesListbox.TabIndex = 10;
			this.activitiesListbox.SelectedIndexChanged += new System.EventHandler(this.activitiesListbox_SelectedIndexChanged);
			// 
			// activitiesLabel
			// 
			this.activitiesLabel.AutoSize = true;
			this.activitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.activitiesLabel.Location = new System.Drawing.Point(8, 16);
			this.activitiesLabel.Name = "activitiesLabel";
			this.activitiesLabel.Size = new System.Drawing.Size(207, 25);
			this.activitiesLabel.TabIndex = 9;
			this.activitiesLabel.Text = "Suggested Activities";
			// 
			// timeLeftText
			// 
			this.timeLeftText.AutoSize = true;
			this.timeLeftText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLeftText.Location = new System.Drawing.Point(555, 385);
			this.timeLeftText.Name = "timeLeftText";
			this.timeLeftText.Size = new System.Drawing.Size(87, 22);
			this.timeLeftText.TabIndex = 3;
			this.timeLeftText.Text = "Time Left";
			// 
			// timerText
			// 
			this.timerText.AutoSize = true;
			this.timerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.timerText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timerText.Location = new System.Drawing.Point(648, 385);
			this.timerText.Name = "timerText";
			this.timerText.Size = new System.Drawing.Size(120, 24);
			this.timerText.TabIndex = 1;
			this.timerText.Text = "00 min 00 sec";
			// 
			// challengeTab
			// 
			this.challengeTab.Location = new System.Drawing.Point(4, 36);
			this.challengeTab.Name = "challengeTab";
			this.challengeTab.Padding = new System.Windows.Forms.Padding(3);
			this.challengeTab.Size = new System.Drawing.Size(778, 420);
			this.challengeTab.TabIndex = 2;
			this.challengeTab.Text = "Challenge";
			this.challengeTab.UseVisualStyleBackColor = true;
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// trophiesTab
			// 
			this.trophiesTab.Location = new System.Drawing.Point(4, 36);
			this.trophiesTab.Name = "trophiesTab";
			this.trophiesTab.Padding = new System.Windows.Forms.Padding(3);
			this.trophiesTab.Size = new System.Drawing.Size(778, 420);
			this.trophiesTab.TabIndex = 3;
			this.trophiesTab.Text = "Trophies";
			this.trophiesTab.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.tabControl);
			this.Name = "MainForm";
			this.Text = "Hälso Hub";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl.ResumeLayout(false);
			this.moodTab.ResumeLayout(false);
			this.moodTab.PerformLayout();
			this.moodButtonPanel.ResumeLayout(false);
			this.activityTab.ResumeLayout(false);
			this.activityTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.activityPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage activityTab;
		private System.Windows.Forms.TabPage moodTab;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button sadButton1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button tiredButton1;
		private System.Windows.Forms.TableLayoutPanel moodButtonPanel;
		private System.Windows.Forms.Button stressedButton1;
		private System.Windows.Forms.Button sadButton3;
		private System.Windows.Forms.Button tiredButton2;
		private System.Windows.Forms.Button sadButton2;
		private System.Windows.Forms.Button sadButton4;
		private System.Windows.Forms.Button tiredButton3;
		private System.Windows.Forms.Button stressedButton2;
		private System.Windows.Forms.Button tiredButton4;
		private System.Windows.Forms.TabPage challengeTab;
		private System.Windows.Forms.Button stressedButton3;
		private System.Windows.Forms.Button lonelyButton2;
		private System.Windows.Forms.Button stressedButton4;
		private System.Windows.Forms.Button lonelyButton1;
		private System.Windows.Forms.Button lonelyButton3;
		private System.Windows.Forms.Button lonelyButton4;
		private System.Windows.Forms.Label timerText;
		private System.Windows.Forms.Label timeLeftText;
		private System.Windows.Forms.Label activitiesLabel;
		private System.Windows.Forms.ListBox activitiesListbox;
		private System.Windows.Forms.RichTextBox activityDescriptionBox;
		private System.Windows.Forms.Button startActivityButton;
		private System.Windows.Forms.PictureBox activityPictureBox;
		private System.Windows.Forms.TabPage trophiesTab;
	}
}
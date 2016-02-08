namespace Halso_Hub
{
	partial class ActivityMain
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
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.timerText = new System.Windows.Forms.Label();
			this.timeLeftText = new System.Windows.Forms.Label();
			this.moodButtonLayout = new System.Windows.Forms.TableLayoutPanel();
			this.moodButton4 = new System.Windows.Forms.Button();
			this.moodButton3 = new System.Windows.Forms.Button();
			this.moodButton2 = new System.Windows.Forms.Button();
			this.moodButton1 = new System.Windows.Forms.Button();
			this.activityDescriptionBox = new System.Windows.Forms.RichTextBox();
			this.startButton = new System.Windows.Forms.Button();
			this.activityDecriptionLabel = new System.Windows.Forms.Label();
			this.activitiesListbox = new System.Windows.Forms.ListBox();
			this.activitiesLabel = new System.Windows.Forms.Label();
			this.moodLabel = new System.Windows.Forms.Label();
			this.moodButtonLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// timerText
			// 
			this.timerText.AutoSize = true;
			this.timerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.timerText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timerText.Location = new System.Drawing.Point(679, 433);
			this.timerText.Name = "timerText";
			this.timerText.Size = new System.Drawing.Size(93, 19);
			this.timerText.TabIndex = 0;
			this.timerText.Text = "00 min 00 sec";
			this.timerText.Click += new System.EventHandler(this.timerText_Click);
			// 
			// timeLeftText
			// 
			this.timeLeftText.AutoSize = true;
			this.timeLeftText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLeftText.Location = new System.Drawing.Point(607, 433);
			this.timeLeftText.Name = "timeLeftText";
			this.timeLeftText.Size = new System.Drawing.Size(66, 17);
			this.timeLeftText.TabIndex = 2;
			this.timeLeftText.Text = "Time Left";
			// 
			// moodButtonLayout
			// 
			this.moodButtonLayout.ColumnCount = 4;
			this.moodButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.moodButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.moodButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.moodButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.moodButtonLayout.Controls.Add(this.moodButton4, 3, 0);
			this.moodButtonLayout.Controls.Add(this.moodButton3, 2, 0);
			this.moodButtonLayout.Controls.Add(this.moodButton2, 1, 0);
			this.moodButtonLayout.Controls.Add(this.moodButton1, 0, 0);
			this.moodButtonLayout.Location = new System.Drawing.Point(12, 92);
			this.moodButtonLayout.Name = "moodButtonLayout";
			this.moodButtonLayout.RowCount = 1;
			this.moodButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.moodButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.moodButtonLayout.Size = new System.Drawing.Size(400, 100);
			this.moodButtonLayout.TabIndex = 3;
			// 
			// moodButton4
			// 
			this.moodButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moodButton4.Location = new System.Drawing.Point(303, 3);
			this.moodButton4.Name = "moodButton4";
			this.moodButton4.Size = new System.Drawing.Size(94, 94);
			this.moodButton4.TabIndex = 3;
			this.moodButton4.Text = "button2";
			this.moodButton4.UseVisualStyleBackColor = true;
			// 
			// moodButton3
			// 
			this.moodButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moodButton3.Location = new System.Drawing.Point(203, 3);
			this.moodButton3.Name = "moodButton3";
			this.moodButton3.Size = new System.Drawing.Size(94, 94);
			this.moodButton3.TabIndex = 2;
			this.moodButton3.Text = "button2";
			this.moodButton3.UseVisualStyleBackColor = true;
			// 
			// moodButton2
			// 
			this.moodButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moodButton2.Location = new System.Drawing.Point(103, 3);
			this.moodButton2.Name = "moodButton2";
			this.moodButton2.Size = new System.Drawing.Size(94, 94);
			this.moodButton2.TabIndex = 1;
			this.moodButton2.Text = "button2";
			this.moodButton2.UseVisualStyleBackColor = true;
			// 
			// moodButton1
			// 
			this.moodButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moodButton1.Location = new System.Drawing.Point(3, 3);
			this.moodButton1.Name = "moodButton1";
			this.moodButton1.Size = new System.Drawing.Size(94, 94);
			this.moodButton1.TabIndex = 0;
			this.moodButton1.Text = "button1";
			this.moodButton1.UseVisualStyleBackColor = true;
			// 
			// activityDescriptionBox
			// 
			this.activityDescriptionBox.Location = new System.Drawing.Point(418, 41);
			this.activityDescriptionBox.Name = "activityDescriptionBox";
			this.activityDescriptionBox.Size = new System.Drawing.Size(354, 336);
			this.activityDescriptionBox.TabIndex = 4;
			this.activityDescriptionBox.Text = "";
			// 
			// startButton
			// 
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.Location = new System.Drawing.Point(610, 383);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(162, 33);
			this.startButton.TabIndex = 5;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// activityDecriptionLabel
			// 
			this.activityDecriptionLabel.AutoSize = true;
			this.activityDecriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.activityDecriptionLabel.Location = new System.Drawing.Point(498, 9);
			this.activityDecriptionLabel.Name = "activityDecriptionLabel";
			this.activityDecriptionLabel.Size = new System.Drawing.Size(202, 29);
			this.activityDecriptionLabel.TabIndex = 6;
			this.activityDecriptionLabel.Text = "Activity Decription";
			// 
			// activitiesListbox
			// 
			this.activitiesListbox.FormattingEnabled = true;
			this.activitiesListbox.Items.AddRange(new object[] {
            ""});
			this.activitiesListbox.Location = new System.Drawing.Point(15, 256);
			this.activitiesListbox.Name = "activitiesListbox";
			this.activitiesListbox.Size = new System.Drawing.Size(394, 121);
			this.activitiesListbox.TabIndex = 7;
			this.activitiesListbox.SelectedIndexChanged += new System.EventHandler(this.activitiesList_SelectedIndexChanged);
			// 
			// activitiesLabel
			// 
			this.activitiesLabel.AutoSize = true;
			this.activitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.activitiesLabel.Location = new System.Drawing.Point(7, 228);
			this.activitiesLabel.Name = "activitiesLabel";
			this.activitiesLabel.Size = new System.Drawing.Size(98, 25);
			this.activitiesLabel.TabIndex = 8;
			this.activitiesLabel.Text = "Activities";
			// 
			// moodLabel
			// 
			this.moodLabel.AutoSize = true;
			this.moodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moodLabel.Location = new System.Drawing.Point(10, 64);
			this.moodLabel.Name = "moodLabel";
			this.moodLabel.Size = new System.Drawing.Size(66, 25);
			this.moodLabel.TabIndex = 9;
			this.moodLabel.Text = "Mood";
			// 
			// ActivityMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.moodLabel);
			this.Controls.Add(this.activitiesLabel);
			this.Controls.Add(this.activitiesListbox);
			this.Controls.Add(this.activityDecriptionLabel);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.activityDescriptionBox);
			this.Controls.Add(this.moodButtonLayout);
			this.Controls.Add(this.timeLeftText);
			this.Controls.Add(this.timerText);
			this.Name = "ActivityMain";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.moodButtonLayout.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label timerText;
		private System.Windows.Forms.Label timeLeftText;
        private System.Windows.Forms.TableLayoutPanel moodButtonLayout;
        private System.Windows.Forms.Button moodButton1;
        private System.Windows.Forms.Button moodButton2;
        private System.Windows.Forms.Button moodButton3;
        private System.Windows.Forms.Button moodButton4;
        private System.Windows.Forms.RichTextBox activityDescriptionBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label activityDecriptionLabel;
        private System.Windows.Forms.ListBox activitiesListbox;
        private System.Windows.Forms.Label activitiesLabel;
        private System.Windows.Forms.Label moodLabel;
    }
}


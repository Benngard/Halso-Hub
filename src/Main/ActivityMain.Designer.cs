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
            // ActivityMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.timeLeftText);
            this.Controls.Add(this.timerText);
            this.Name = "ActivityMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label timerText;
		private System.Windows.Forms.Label timeLeftText;


	}
}


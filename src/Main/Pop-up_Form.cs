using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halso_Hub.Main
{
    public partial class Pop_up : Form
    {
        Presenter Presenter;

        public Pop_up(Presenter presenter)
        {
            this.Presenter = presenter;
            InitializeComponent();
        }

        private StarRatingControl starRatingControl;
        public TextBox textBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Button cancel_button;
        private Button submit_button;
        private RichTextBox richTextBox1;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;


        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.cancel_button = new System.Windows.Forms.Button();
			this.submit_button = new System.Windows.Forms.Button();
			this.starRatingControl = new Halso_Hub.StarRatingControl();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Control;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(128, 45);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(130, 13);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "Give this activity a rating!";
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
			// 
			// cancel_button
			// 
			this.cancel_button.Location = new System.Drawing.Point(193, 153);
			this.cancel_button.Name = "cancel_button";
			this.cancel_button.Size = new System.Drawing.Size(75, 23);
			this.cancel_button.TabIndex = 4;
			this.cancel_button.Text = "Cancel";
			this.cancel_button.UseVisualStyleBackColor = true;
			this.cancel_button.Click += new System.EventHandler(this.cancel_Click);
			// 
			// submit_button
			// 
			this.submit_button.Location = new System.Drawing.Point(105, 153);
			this.submit_button.Name = "submit_button";
			this.submit_button.Size = new System.Drawing.Size(75, 23);
			this.submit_button.TabIndex = 4;
			this.submit_button.Text = "Submit";
			this.submit_button.UseVisualStyleBackColor = true;
			this.submit_button.Click += new System.EventHandler(this.submit_Click);
			// 
			// starRatingControl
			// 
			this.starRatingControl.BottomMargin = 2;
			this.starRatingControl.HoverColor = System.Drawing.Color.Yellow;
			this.starRatingControl.LeftMargin = 2;
			this.starRatingControl.Location = new System.Drawing.Point(105, 82);
			this.starRatingControl.Name = "starRatingControl";
			this.starRatingControl.OutlineColor = System.Drawing.Color.DarkGray;
			this.starRatingControl.OutlineThickness = 1;
			this.starRatingControl.RightMargin = 2;
			this.starRatingControl.SelectedColor = System.Drawing.Color.Yellow;
			this.starRatingControl.Size = new System.Drawing.Size(163, 38);
			this.starRatingControl.StarCount = 5;
			this.starRatingControl.StarSpacing = 8;
			this.starRatingControl.TabIndex = 1;
			this.starRatingControl.TopMargin = 2;
			this.starRatingControl.Click += new System.EventHandler(this.starRatingControl_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 198);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(313, 96);
			this.richTextBox1.TabIndex = 9;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// Pop_up
			// 
			this.ClientSize = new System.Drawing.Size(367, 317);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.submit_button);
			this.Controls.Add(this.cancel_button);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.starRatingControl);
			this.Name = "Pop_up";
			this.Text = "Congratulations you finished your activity!";
			this.Load += new System.EventHandler(this.Pop_up_Load);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private void starRatingControl_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Pop_up_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            // Closes the window 
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Presenter.SubmitComment(starRatingControl.SelectedStar, richTextBox1.Text);
            //textBox2.Text = "" + starRatingControl.SelectedStar;
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

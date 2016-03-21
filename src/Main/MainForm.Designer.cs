using System.Windows.Forms;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.MainTab = new System.Windows.Forms.TabPage();
			this.QuitButton = new System.Windows.Forms.Button();
			this.Headline = new System.Windows.Forms.Label();
			this.Page0Layout = new System.Windows.Forms.TableLayoutPanel();
			this.ChallengeButton = new System.Windows.Forms.Button();
			this.ActivityButton = new System.Windows.Forms.Button();
			this.ActivityTab = new System.Windows.Forms.TabPage();
			this.ActivitesBackButton = new System.Windows.Forms.Button();
			this.CancelActivityButton = new System.Windows.Forms.Button();
			this.CompleteActivityButton = new System.Windows.Forms.Button();
			this.SelectedActivityLabel = new System.Windows.Forms.Label();
			this.timeLeftText = new System.Windows.Forms.Label();
			this.timerText = new System.Windows.Forms.Label();
			this.startActivityButton = new System.Windows.Forms.Button();
			this.ActivitiesLabel = new System.Windows.Forms.Label();
			this.MoodHeadline = new System.Windows.Forms.Label();
			this.ResetButton = new System.Windows.Forms.Button();
			this.MoodButtonLayout = new System.Windows.Forms.TableLayoutPanel();
			this.MoodButton4 = new System.Windows.Forms.Button();
			this.MoodButton3 = new System.Windows.Forms.Button();
			this.MoodButton2 = new System.Windows.Forms.Button();
			this.MoodButton1 = new System.Windows.Forms.Button();
			this.ChallengeTab = new System.Windows.Forms.TabPage();
			this.startActivityForChallengeButton = new System.Windows.Forms.Button();
			this.ChallengesLabel = new System.Windows.Forms.Label();
			this.ChallengesCancelButton = new System.Windows.Forms.Button();
			this.SelectedChallengeDescription = new System.Windows.Forms.Label();
			this.ActivitiesForChallengeListbox = new System.Windows.Forms.ListBox();
			this.ActivityForChallengeDescriptionBox = new System.Windows.Forms.RichTextBox();
			this.ChallengeUpdateButton = new System.Windows.Forms.Button();
			this.ChallengeStartButton = new System.Windows.Forms.Button();
			this.SelectedChallengeLabel = new System.Windows.Forms.Label();
			this.ChallengesListbox = new System.Windows.Forms.ListBox();
			this.ChallengeDescriptionBox = new System.Windows.Forms.RichTextBox();
			this.TrophiesTab = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.trophiesEarnedListView = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.trophyImageList = new System.Windows.Forms.ImageList(this.components);
			this.trophiesNotEarnedListView = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pointsLabel = new System.Windows.Forms.Label();
			this.nrBronzeLabel = new System.Windows.Forms.Label();
			this.bronzePictureBox = new System.Windows.Forms.PictureBox();
			this.nrSilverLabel = new System.Windows.Forms.Label();
			this.silverPictureBox = new System.Windows.Forms.PictureBox();
			this.nrGoldLabel = new System.Windows.Forms.Label();
			this.goldPictureBox = new System.Windows.Forms.PictureBox();
			this.trophiesNotEarnedList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.trophiesNotEarnedLabel = new System.Windows.Forms.Label();
			this.trophiesEarnedList = new System.Windows.Forms.ListView();
			this.trophyImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.trophyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.trophiesEarnedLabel = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.activityPictureBox = new System.Windows.Forms.PictureBox();
			this.activityDescriptionBox = new System.Windows.Forms.RichTextBox();
			this.activitiesListbox = new System.Windows.Forms.ListBox();
			this.tabControl.SuspendLayout();
			this.MainTab.SuspendLayout();
			this.Page0Layout.SuspendLayout();
			this.ActivityTab.SuspendLayout();
			this.MoodButtonLayout.SuspendLayout();
			this.ChallengeTab.SuspendLayout();
			this.TrophiesTab.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bronzePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.silverPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.goldPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.activityPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.MainTab);
			this.tabControl.Controls.Add(this.ActivityTab);
			this.tabControl.Controls.Add(this.ChallengeTab);
			this.tabControl.Controls.Add(this.TrophiesTab);
			this.tabControl.Location = new System.Drawing.Point(-1, -1);
			this.tabControl.Name = "tabControl";
			this.tabControl.Padding = new System.Drawing.Point(10, 10);
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(787, 461);
			this.tabControl.TabIndex = 0;
			// 
			// MainTab
			// 
			this.MainTab.Controls.Add(this.QuitButton);
			this.MainTab.Controls.Add(this.Headline);
			this.MainTab.Controls.Add(this.Page0Layout);
			this.MainTab.Location = new System.Drawing.Point(4, 36);
			this.MainTab.Name = "MainTab";
			this.MainTab.Padding = new System.Windows.Forms.Padding(3);
			this.MainTab.Size = new System.Drawing.Size(779, 421);
			this.MainTab.TabIndex = 0;
			this.MainTab.Text = "Main";
			this.MainTab.UseVisualStyleBackColor = true;
			// 
			// QuitButton
			// 
			this.QuitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QuitButton.Location = new System.Drawing.Point(310, 380);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(124, 37);
			this.QuitButton.TabIndex = 10;
			this.QuitButton.Text = "Quit";
			this.QuitButton.UseVisualStyleBackColor = true;
			this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
			// 
			// Headline
			// 
			this.Headline.AutoSize = true;
			this.Headline.Font = new System.Drawing.Font("Arial", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Headline.Location = new System.Drawing.Point(261, 57);
			this.Headline.Name = "Headline";
			this.Headline.Size = new System.Drawing.Size(227, 47);
			this.Headline.TabIndex = 8;
			this.Headline.Text = "Health Hub";
			// 
			// Page0Layout
			// 
			this.Page0Layout.ColumnCount = 2;
			this.Page0Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.Page0Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.Page0Layout.Controls.Add(this.ChallengeButton, 1, 0);
			this.Page0Layout.Controls.Add(this.ActivityButton, 0, 0);
			this.Page0Layout.Location = new System.Drawing.Point(110, 163);
			this.Page0Layout.Name = "Page0Layout";
			this.Page0Layout.RowCount = 1;
			this.Page0Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.Page0Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
			this.Page0Layout.Size = new System.Drawing.Size(524, 141);
			this.Page0Layout.TabIndex = 9;
			// 
			// ChallengeButton
			// 
			this.ChallengeButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChallengeButton.Location = new System.Drawing.Point(265, 3);
			this.ChallengeButton.Name = "ChallengeButton";
			this.ChallengeButton.Size = new System.Drawing.Size(256, 135);
			this.ChallengeButton.TabIndex = 2;
			this.ChallengeButton.Text = "Challenge";
			this.ChallengeButton.UseVisualStyleBackColor = true;
			this.ChallengeButton.Click += new System.EventHandler(this.ChallengeButton_Click);
			// 
			// ActivityButton
			// 
			this.ActivityButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ActivityButton.Location = new System.Drawing.Point(3, 3);
			this.ActivityButton.Name = "ActivityButton";
			this.ActivityButton.Size = new System.Drawing.Size(256, 135);
			this.ActivityButton.TabIndex = 3;
			this.ActivityButton.Text = "Activity";
			this.ActivityButton.UseVisualStyleBackColor = true;
			this.ActivityButton.Click += new System.EventHandler(this.ActivityButton_Click);
			// 
			// ActivityTab
			// 
			this.ActivityTab.Controls.Add(this.activityDescriptionBox);
			this.ActivityTab.Controls.Add(this.activitiesListbox);
			this.ActivityTab.Controls.Add(this.ActivitesBackButton);
			this.ActivityTab.Controls.Add(this.CancelActivityButton);
			this.ActivityTab.Controls.Add(this.CompleteActivityButton);
			this.ActivityTab.Controls.Add(this.SelectedActivityLabel);
			this.ActivityTab.Controls.Add(this.timeLeftText);
			this.ActivityTab.Controls.Add(this.timerText);
			this.ActivityTab.Controls.Add(this.startActivityButton);
			this.ActivityTab.Controls.Add(this.ActivitiesLabel);
			this.ActivityTab.Controls.Add(this.MoodHeadline);
			this.ActivityTab.Controls.Add(this.ResetButton);
			this.ActivityTab.Controls.Add(this.MoodButtonLayout);
			this.ActivityTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ActivityTab.Location = new System.Drawing.Point(4, 36);
			this.ActivityTab.Name = "ActivityTab";
			this.ActivityTab.Padding = new System.Windows.Forms.Padding(3);
			this.ActivityTab.Size = new System.Drawing.Size(779, 421);
			this.ActivityTab.TabIndex = 1;
			this.ActivityTab.Text = "Activity";
			this.ActivityTab.UseVisualStyleBackColor = true;
			// 
			// ActivitesBackButton
			// 
			this.ActivitesBackButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ActivitesBackButton.Location = new System.Drawing.Point(439, 391);
			this.ActivitesBackButton.Name = "ActivitesBackButton";
			this.ActivitesBackButton.Size = new System.Drawing.Size(75, 23);
			this.ActivitesBackButton.TabIndex = 14;
			this.ActivitesBackButton.Text = "Back";
			this.ActivitesBackButton.UseVisualStyleBackColor = true;
			this.ActivitesBackButton.Visible = false;
			this.ActivitesBackButton.Click += new System.EventHandler(this.ActivitesBackButton_Click);
			// 
			// CancelActivityButton
			// 
			this.CancelActivityButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelActivityButton.Location = new System.Drawing.Point(493, 391);
			this.CancelActivityButton.Name = "CancelActivityButton";
			this.CancelActivityButton.Size = new System.Drawing.Size(75, 23);
			this.CancelActivityButton.TabIndex = 13;
			this.CancelActivityButton.Text = "Cancel";
			this.CancelActivityButton.UseVisualStyleBackColor = true;
			this.CancelActivityButton.Visible = false;
			this.CancelActivityButton.Click += new System.EventHandler(this.CancelActivityButton_Click);
			// 
			// CompleteActivityButton
			// 
			this.CompleteActivityButton.Enabled = false;
			this.CompleteActivityButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CompleteActivityButton.Location = new System.Drawing.Point(189, 389);
			this.CompleteActivityButton.Name = "CompleteActivityButton";
			this.CompleteActivityButton.Size = new System.Drawing.Size(75, 23);
			this.CompleteActivityButton.TabIndex = 12;
			this.CompleteActivityButton.Text = "Complete";
			this.CompleteActivityButton.UseVisualStyleBackColor = true;
			this.CompleteActivityButton.Visible = false;
			this.CompleteActivityButton.Click += new System.EventHandler(this.CompleteActivityButton_Click);
			// 
			// SelectedActivityLabel
			// 
			this.SelectedActivityLabel.AutoSize = true;
			this.SelectedActivityLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectedActivityLabel.Location = new System.Drawing.Point(368, 59);
			this.SelectedActivityLabel.Name = "SelectedActivityLabel";
			this.SelectedActivityLabel.Size = new System.Drawing.Size(42, 16);
			this.SelectedActivityLabel.TabIndex = 11;
			this.SelectedActivityLabel.Text = "label1";
			this.SelectedActivityLabel.Visible = false;
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
			// timerText
			// 
			this.timerText.AutoSize = true;
			this.timerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.timerText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timerText.Location = new System.Drawing.Point(675, 389);
			this.timerText.Name = "timerText";
			this.timerText.Size = new System.Drawing.Size(94, 22);
			this.timerText.TabIndex = 0;
			this.timerText.Text = "00 min 00 sec";
			// 
			// startActivityButton
			// 
			this.startActivityButton.Location = new System.Drawing.Point(271, 390);
			this.startActivityButton.Name = "startActivityButton";
			this.startActivityButton.Size = new System.Drawing.Size(75, 23);
			this.startActivityButton.TabIndex = 0;
			this.startActivityButton.Text = "Start";
			this.startActivityButton.Visible = false;
			this.startActivityButton.Click += new System.EventHandler(this.startActivityButton_Click);
			// 
			// ActivitiesLabel
			// 
			this.ActivitiesLabel.AutoSize = true;
			this.ActivitiesLabel.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ActivitiesLabel.Location = new System.Drawing.Point(313, 21);
			this.ActivitiesLabel.Name = "ActivitiesLabel";
			this.ActivitiesLabel.Size = new System.Drawing.Size(144, 38);
			this.ActivitiesLabel.TabIndex = 6;
			this.ActivitiesLabel.Text = "Activities";
			this.ActivitiesLabel.Visible = false;
			// 
			// MoodHeadline
			// 
			this.MoodHeadline.AutoSize = true;
			this.MoodHeadline.Font = new System.Drawing.Font("Arial", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MoodHeadline.Location = new System.Drawing.Point(204, 114);
			this.MoodHeadline.Name = "MoodHeadline";
			this.MoodHeadline.Size = new System.Drawing.Size(132, 47);
			this.MoodHeadline.TabIndex = 4;
			this.MoodHeadline.Text = "label1";
			// 
			// ResetButton
			// 
			this.ResetButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResetButton.Location = new System.Drawing.Point(320, 391);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(75, 23);
			this.ResetButton.TabIndex = 5;
			this.ResetButton.Text = "Reset";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// MoodButtonLayout
			// 
			this.MoodButtonLayout.ColumnCount = 4;
			this.MoodButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.MoodButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.MoodButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.MoodButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.MoodButtonLayout.Controls.Add(this.MoodButton4, 3, 0);
			this.MoodButtonLayout.Controls.Add(this.MoodButton3, 2, 0);
			this.MoodButtonLayout.Controls.Add(this.MoodButton2, 1, 0);
			this.MoodButtonLayout.Controls.Add(this.MoodButton1, 0, 0);
			this.MoodButtonLayout.Location = new System.Drawing.Point(168, 200);
			this.MoodButtonLayout.Name = "MoodButtonLayout";
			this.MoodButtonLayout.RowCount = 1;
			this.MoodButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MoodButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.MoodButtonLayout.Size = new System.Drawing.Size(400, 100);
			this.MoodButtonLayout.TabIndex = 3;
			// 
			// MoodButton4
			// 
			this.MoodButton4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MoodButton4.Location = new System.Drawing.Point(303, 3);
			this.MoodButton4.Name = "MoodButton4";
			this.MoodButton4.Size = new System.Drawing.Size(94, 94);
			this.MoodButton4.TabIndex = 3;
			this.MoodButton4.Text = "Moodbutton4";
			this.MoodButton4.UseVisualStyleBackColor = true;
			this.MoodButton4.Click += new System.EventHandler(this.MoodButton4_Click);
			// 
			// MoodButton3
			// 
			this.MoodButton3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MoodButton3.Location = new System.Drawing.Point(203, 3);
			this.MoodButton3.Name = "MoodButton3";
			this.MoodButton3.Size = new System.Drawing.Size(94, 94);
			this.MoodButton3.TabIndex = 2;
			this.MoodButton3.Text = "Moodbutton3";
			this.MoodButton3.UseVisualStyleBackColor = true;
			this.MoodButton3.Click += new System.EventHandler(this.MoodButton3_Click);
			// 
			// MoodButton2
			// 
			this.MoodButton2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MoodButton2.Location = new System.Drawing.Point(103, 3);
			this.MoodButton2.Name = "MoodButton2";
			this.MoodButton2.Size = new System.Drawing.Size(94, 94);
			this.MoodButton2.TabIndex = 1;
			this.MoodButton2.Text = "Moodbutton2";
			this.MoodButton2.UseVisualStyleBackColor = true;
			this.MoodButton2.Click += new System.EventHandler(this.MoodButton2_Click);
			// 
			// MoodButton1
			// 
			this.MoodButton1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MoodButton1.Location = new System.Drawing.Point(3, 3);
			this.MoodButton1.Name = "MoodButton1";
			this.MoodButton1.Size = new System.Drawing.Size(94, 94);
			this.MoodButton1.TabIndex = 0;
			this.MoodButton1.Text = "Moodbutton1";
			this.MoodButton1.UseVisualStyleBackColor = true;
			this.MoodButton1.Click += new System.EventHandler(this.MoodButton1_Click);
			// 
			// ChallengeTab
			// 
			this.ChallengeTab.Controls.Add(this.startActivityForChallengeButton);
			this.ChallengeTab.Controls.Add(this.ChallengesLabel);
			this.ChallengeTab.Controls.Add(this.ChallengesCancelButton);
			this.ChallengeTab.Controls.Add(this.SelectedChallengeDescription);
			this.ChallengeTab.Controls.Add(this.ActivitiesForChallengeListbox);
			this.ChallengeTab.Controls.Add(this.ActivityForChallengeDescriptionBox);
			this.ChallengeTab.Controls.Add(this.ChallengeUpdateButton);
			this.ChallengeTab.Controls.Add(this.ChallengeStartButton);
			this.ChallengeTab.Controls.Add(this.SelectedChallengeLabel);
			this.ChallengeTab.Controls.Add(this.ChallengesListbox);
			this.ChallengeTab.Controls.Add(this.ChallengeDescriptionBox);
			this.ChallengeTab.Location = new System.Drawing.Point(4, 36);
			this.ChallengeTab.Name = "ChallengeTab";
			this.ChallengeTab.Padding = new System.Windows.Forms.Padding(3);
			this.ChallengeTab.Size = new System.Drawing.Size(779, 421);
			this.ChallengeTab.TabIndex = 2;
			this.ChallengeTab.Text = "Challenge";
			this.ChallengeTab.UseVisualStyleBackColor = true;
			// 
			// startActivityForChallengeButton
			// 
			this.startActivityForChallengeButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startActivityForChallengeButton.Location = new System.Drawing.Point(278, 390);
			this.startActivityForChallengeButton.Name = "startActivityForChallengeButton";
			this.startActivityForChallengeButton.Size = new System.Drawing.Size(75, 23);
			this.startActivityForChallengeButton.TabIndex = 19;
			this.startActivityForChallengeButton.Text = "Start";
			this.startActivityForChallengeButton.Visible = false;
			this.startActivityForChallengeButton.Click += new System.EventHandler(this.startActivityForChallengeButton_Click);
			// 
			// ChallengesLabel
			// 
			this.ChallengesLabel.AutoSize = true;
			this.ChallengesLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChallengesLabel.Location = new System.Drawing.Point(317, 12);
			this.ChallengesLabel.Name = "ChallengesLabel";
			this.ChallengesLabel.Size = new System.Drawing.Size(185, 40);
			this.ChallengesLabel.TabIndex = 18;
			this.ChallengesLabel.Text = "Challenges";
			// 
			// ChallengesCancelButton
			// 
			this.ChallengesCancelButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChallengesCancelButton.Location = new System.Drawing.Point(440, 390);
			this.ChallengesCancelButton.Name = "ChallengesCancelButton";
			this.ChallengesCancelButton.Size = new System.Drawing.Size(75, 23);
			this.ChallengesCancelButton.TabIndex = 17;
			this.ChallengesCancelButton.Text = "Cancel";
			this.ChallengesCancelButton.UseVisualStyleBackColor = true;
			this.ChallengesCancelButton.Visible = false;
			this.ChallengesCancelButton.Click += new System.EventHandler(this.ChallengesCancelButton_Click);
			// 
			// SelectedChallengeDescription
			// 
			this.SelectedChallengeDescription.AutoSize = true;
			this.SelectedChallengeDescription.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectedChallengeDescription.Location = new System.Drawing.Point(377, 62);
			this.SelectedChallengeDescription.Name = "SelectedChallengeDescription";
			this.SelectedChallengeDescription.Size = new System.Drawing.Size(35, 14);
			this.SelectedChallengeDescription.TabIndex = 16;
			this.SelectedChallengeDescription.Text = "label1";
			this.SelectedChallengeDescription.Visible = false;
			// 
			// ActivitiesForChallengeListbox
			// 
			this.ActivitiesForChallengeListbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ActivitiesForChallengeListbox.FormattingEnabled = true;
			this.ActivitiesForChallengeListbox.ItemHeight = 16;
			this.ActivitiesForChallengeListbox.Location = new System.Drawing.Point(67, 78);
			this.ActivitiesForChallengeListbox.Name = "ActivitiesForChallengeListbox";
			this.ActivitiesForChallengeListbox.Size = new System.Drawing.Size(327, 292);
			this.ActivitiesForChallengeListbox.TabIndex = 15;
			this.ActivitiesForChallengeListbox.Visible = false;
			this.ActivitiesForChallengeListbox.SelectedIndexChanged += new System.EventHandler(this.ActivitiesForChallengeListbox_SelectedIndexChanged);
			// 
			// ActivityForChallengeDescriptionBox
			// 
			this.ActivityForChallengeDescriptionBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ActivityForChallengeDescriptionBox.Location = new System.Drawing.Point(400, 78);
			this.ActivityForChallengeDescriptionBox.Name = "ActivityForChallengeDescriptionBox";
			this.ActivityForChallengeDescriptionBox.ReadOnly = true;
			this.ActivityForChallengeDescriptionBox.Size = new System.Drawing.Size(327, 292);
			this.ActivityForChallengeDescriptionBox.TabIndex = 3;
			this.ActivityForChallengeDescriptionBox.Text = "";
			this.ActivityForChallengeDescriptionBox.Visible = false;
			// 
			// ChallengeUpdateButton
			// 
			this.ChallengeUpdateButton.Location = new System.Drawing.Point(440, 390);
			this.ChallengeUpdateButton.Name = "ChallengeUpdateButton";
			this.ChallengeUpdateButton.Size = new System.Drawing.Size(75, 23);
			this.ChallengeUpdateButton.TabIndex = 12;
			this.ChallengeUpdateButton.Text = "Update";
			this.ChallengeUpdateButton.UseVisualStyleBackColor = true;
			this.ChallengeUpdateButton.Click += new System.EventHandler(this.ChallengeUpdateButton_Click);
			// 
			// ChallengeStartButton
			// 
			this.ChallengeStartButton.Location = new System.Drawing.Point(278, 391);
			this.ChallengeStartButton.Name = "ChallengeStartButton";
			this.ChallengeStartButton.Size = new System.Drawing.Size(75, 23);
			this.ChallengeStartButton.TabIndex = 11;
			this.ChallengeStartButton.Text = "Start";
			this.ChallengeStartButton.UseVisualStyleBackColor = true;
			this.ChallengeStartButton.Click += new System.EventHandler(this.ChallengeStartButton_Click);
			// 
			// SelectedChallengeLabel
			// 
			this.SelectedChallengeLabel.AutoSize = true;
			this.SelectedChallengeLabel.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectedChallengeLabel.Location = new System.Drawing.Point(60, 14);
			this.SelectedChallengeLabel.Name = "SelectedChallengeLabel";
			this.SelectedChallengeLabel.Size = new System.Drawing.Size(177, 38);
			this.SelectedChallengeLabel.TabIndex = 6;
			this.SelectedChallengeLabel.Text = "Challenges";
			this.SelectedChallengeLabel.Visible = false;
			// 
			// ChallengesListbox
			// 
			this.ChallengesListbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChallengesListbox.FormattingEnabled = true;
			this.ChallengesListbox.ItemHeight = 16;
			this.ChallengesListbox.Location = new System.Drawing.Point(67, 78);
			this.ChallengesListbox.Name = "ChallengesListbox";
			this.ChallengesListbox.Size = new System.Drawing.Size(327, 292);
			this.ChallengesListbox.TabIndex = 10;
			this.ChallengesListbox.SelectedIndexChanged += new System.EventHandler(this.ChallengesListbox_SelectedIndexChanged);
			// 
			// ChallengeDescriptionBox
			// 
			this.ChallengeDescriptionBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChallengeDescriptionBox.Location = new System.Drawing.Point(400, 78);
			this.ChallengeDescriptionBox.Name = "ChallengeDescriptionBox";
			this.ChallengeDescriptionBox.ReadOnly = true;
			this.ChallengeDescriptionBox.Size = new System.Drawing.Size(327, 292);
			this.ChallengeDescriptionBox.TabIndex = 0;
			this.ChallengeDescriptionBox.Text = "";
			// 
			// TrophiesTab
			// 
			this.TrophiesTab.Controls.Add(this.tableLayoutPanel1);
			this.TrophiesTab.Controls.Add(this.pointsLabel);
			this.TrophiesTab.Controls.Add(this.nrBronzeLabel);
			this.TrophiesTab.Controls.Add(this.bronzePictureBox);
			this.TrophiesTab.Controls.Add(this.nrSilverLabel);
			this.TrophiesTab.Controls.Add(this.silverPictureBox);
			this.TrophiesTab.Controls.Add(this.nrGoldLabel);
			this.TrophiesTab.Controls.Add(this.goldPictureBox);
			this.TrophiesTab.Controls.Add(this.trophiesNotEarnedList);
			this.TrophiesTab.Controls.Add(this.trophiesNotEarnedLabel);
			this.TrophiesTab.Controls.Add(this.trophiesEarnedList);
			this.TrophiesTab.Controls.Add(this.trophiesEarnedLabel);
			this.TrophiesTab.Location = new System.Drawing.Point(4, 36);
			this.TrophiesTab.Name = "TrophiesTab";
			this.TrophiesTab.Padding = new System.Windows.Forms.Padding(3);
			this.TrophiesTab.Size = new System.Drawing.Size(779, 421);
			this.TrophiesTab.TabIndex = 3;
			this.TrophiesTab.Text = "Trophies";
			this.TrophiesTab.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.trophiesEarnedListView, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.trophiesNotEarnedListView, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 39);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 342);
			this.tableLayoutPanel1.TabIndex = 20;
			// 
			// trophiesEarnedListView
			// 
			this.trophiesEarnedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
			this.trophiesEarnedListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trophiesEarnedListView.LargeImageList = this.trophyImageList;
			this.trophiesEarnedListView.Location = new System.Drawing.Point(3, 3);
			this.trophiesEarnedListView.MultiSelect = false;
			this.trophiesEarnedListView.Name = "trophiesEarnedListView";
			this.trophiesEarnedListView.Size = new System.Drawing.Size(380, 336);
			this.trophiesEarnedListView.TabIndex = 1;
			this.trophiesEarnedListView.UseCompatibleStateImageBehavior = false;
			// 
			// trophyImageList
			// 
			this.trophyImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("trophyImageList.ImageStream")));
			this.trophyImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.trophyImageList.Images.SetKeyName(0, "bronze");
			this.trophyImageList.Images.SetKeyName(1, "silver");
			this.trophyImageList.Images.SetKeyName(2, "gold");
			// 
			// trophiesNotEarnedListView
			// 
			this.trophiesNotEarnedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
			this.trophiesNotEarnedListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trophiesNotEarnedListView.LargeImageList = this.trophyImageList;
			this.trophiesNotEarnedListView.Location = new System.Drawing.Point(389, 3);
			this.trophiesNotEarnedListView.MultiSelect = false;
			this.trophiesNotEarnedListView.Name = "trophiesNotEarnedListView";
			this.trophiesNotEarnedListView.Size = new System.Drawing.Size(380, 336);
			this.trophiesNotEarnedListView.TabIndex = 2;
			this.trophiesNotEarnedListView.UseCompatibleStateImageBehavior = false;
			// 
			// pointsLabel
			// 
			this.pointsLabel.AutoSize = true;
			this.pointsLabel.BackColor = System.Drawing.Color.Transparent;
			this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pointsLabel.Location = new System.Drawing.Point(670, 392);
			this.pointsLabel.Name = "pointsLabel";
			this.pointsLabel.Size = new System.Drawing.Size(66, 18);
			this.pointsLabel.TabIndex = 19;
			this.pointsLabel.Text = "Points: 0";
			this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nrBronzeLabel
			// 
			this.nrBronzeLabel.AutoSize = true;
			this.nrBronzeLabel.Location = new System.Drawing.Point(160, 392);
			this.nrBronzeLabel.Name = "nrBronzeLabel";
			this.nrBronzeLabel.Size = new System.Drawing.Size(13, 13);
			this.nrBronzeLabel.TabIndex = 18;
			this.nrBronzeLabel.Text = "0";
			// 
			// bronzePictureBox
			// 
			this.bronzePictureBox.BackgroundImage = global::Halso_Hub.Properties.Resources.bronze;
			this.bronzePictureBox.Location = new System.Drawing.Point(122, 382);
			this.bronzePictureBox.Name = "bronzePictureBox";
			this.bronzePictureBox.Size = new System.Drawing.Size(32, 32);
			this.bronzePictureBox.TabIndex = 17;
			this.bronzePictureBox.TabStop = false;
			// 
			// nrSilverLabel
			// 
			this.nrSilverLabel.AutoSize = true;
			this.nrSilverLabel.Location = new System.Drawing.Point(103, 392);
			this.nrSilverLabel.Name = "nrSilverLabel";
			this.nrSilverLabel.Size = new System.Drawing.Size(13, 13);
			this.nrSilverLabel.TabIndex = 16;
			this.nrSilverLabel.Text = "0";
			// 
			// silverPictureBox
			// 
			this.silverPictureBox.BackgroundImage = global::Halso_Hub.Properties.Resources.silver;
			this.silverPictureBox.Location = new System.Drawing.Point(65, 382);
			this.silverPictureBox.Name = "silverPictureBox";
			this.silverPictureBox.Size = new System.Drawing.Size(32, 32);
			this.silverPictureBox.TabIndex = 15;
			this.silverPictureBox.TabStop = false;
			// 
			// nrGoldLabel
			// 
			this.nrGoldLabel.AutoSize = true;
			this.nrGoldLabel.Location = new System.Drawing.Point(46, 392);
			this.nrGoldLabel.Name = "nrGoldLabel";
			this.nrGoldLabel.Size = new System.Drawing.Size(13, 13);
			this.nrGoldLabel.TabIndex = 14;
			this.nrGoldLabel.Text = "0";
			// 
			// goldPictureBox
			// 
			this.goldPictureBox.BackgroundImage = global::Halso_Hub.Properties.Resources.gold;
			this.goldPictureBox.ErrorImage = null;
			this.goldPictureBox.InitialImage = null;
			this.goldPictureBox.Location = new System.Drawing.Point(8, 382);
			this.goldPictureBox.Name = "goldPictureBox";
			this.goldPictureBox.Size = new System.Drawing.Size(32, 32);
			this.goldPictureBox.TabIndex = 13;
			this.goldPictureBox.TabStop = false;
			// 
			// trophiesNotEarnedList
			// 
			this.trophiesNotEarnedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.trophiesNotEarnedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trophiesNotEarnedList.Location = new System.Drawing.Point(395, 40);
			this.trophiesNotEarnedList.MultiSelect = false;
			this.trophiesNotEarnedList.Name = "trophiesNotEarnedList";
			this.trophiesNotEarnedList.Size = new System.Drawing.Size(380, 336);
			this.trophiesNotEarnedList.TabIndex = 12;
			this.trophiesNotEarnedList.UseCompatibleStateImageBehavior = false;
			// 
			// trophiesNotEarnedLabel
			// 
			this.trophiesNotEarnedLabel.AutoSize = true;
			this.trophiesNotEarnedLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trophiesNotEarnedLabel.Location = new System.Drawing.Point(391, 15);
			this.trophiesNotEarnedLabel.Name = "trophiesNotEarnedLabel";
			this.trophiesNotEarnedLabel.Size = new System.Drawing.Size(195, 22);
			this.trophiesNotEarnedLabel.TabIndex = 11;
			this.trophiesNotEarnedLabel.Text = "Incompleted Trophies";
			// 
			// trophiesEarnedList
			// 
			this.trophiesEarnedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trophyImage,
            this.trophyName});
			this.trophiesEarnedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trophiesEarnedList.Location = new System.Drawing.Point(6, 40);
			this.trophiesEarnedList.MultiSelect = false;
			this.trophiesEarnedList.Name = "trophiesEarnedList";
			this.trophiesEarnedList.Size = new System.Drawing.Size(380, 336);
			this.trophiesEarnedList.TabIndex = 10;
			this.trophiesEarnedList.UseCompatibleStateImageBehavior = false;
			// 
			// trophiesEarnedLabel
			// 
			this.trophiesEarnedLabel.AutoSize = true;
			this.trophiesEarnedLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trophiesEarnedLabel.Location = new System.Drawing.Point(6, 14);
			this.trophiesEarnedLabel.Name = "trophiesEarnedLabel";
			this.trophiesEarnedLabel.Size = new System.Drawing.Size(150, 22);
			this.trophiesEarnedLabel.TabIndex = 9;
			this.trophiesEarnedLabel.Text = "Trophies Earned";
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// activityPictureBox
			// 
			this.activityPictureBox.Location = new System.Drawing.Point(0, 0);
			this.activityPictureBox.Name = "activityPictureBox";
			this.activityPictureBox.Size = new System.Drawing.Size(100, 50);
			this.activityPictureBox.TabIndex = 0;
			this.activityPictureBox.TabStop = false;
			// 
			// activityDescriptionBox
			// 
			this.activityDescriptionBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.activityDescriptionBox.Location = new System.Drawing.Point(395, 62);
			this.activityDescriptionBox.Name = "activityDescriptionBox";
			this.activityDescriptionBox.ReadOnly = true;
			this.activityDescriptionBox.Size = new System.Drawing.Size(374, 292);
			this.activityDescriptionBox.TabIndex = 0;
			this.activityDescriptionBox.Text = "";
			this.activityDescriptionBox.Visible = false;
			// 
			// activitiesListbox
			// 
			this.activitiesListbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.activitiesListbox.FormattingEnabled = true;
			this.activitiesListbox.ItemHeight = 16;
			this.activitiesListbox.Location = new System.Drawing.Point(9, 62);
			this.activitiesListbox.Name = "activitiesListbox";
			this.activitiesListbox.Size = new System.Drawing.Size(374, 292);
			this.activitiesListbox.TabIndex = 10;
			this.activitiesListbox.Visible = false;
			this.activitiesListbox.SelectedIndexChanged += new System.EventHandler(this.activitiesListbox_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.tabControl);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hälso Hub";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl.ResumeLayout(false);
			this.MainTab.ResumeLayout(false);
			this.MainTab.PerformLayout();
			this.Page0Layout.ResumeLayout(false);
			this.ActivityTab.ResumeLayout(false);
			this.ActivityTab.PerformLayout();
			this.MoodButtonLayout.ResumeLayout(false);
			this.ChallengeTab.ResumeLayout(false);
			this.ChallengeTab.PerformLayout();
			this.TrophiesTab.ResumeLayout(false);
			this.TrophiesTab.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bronzePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.silverPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.goldPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.activityPictureBox)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ActivityTab;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.TabPage TrophiesTab;
        private System.Windows.Forms.TabPage ChallengeTab;
        private System.Windows.Forms.TableLayoutPanel Page0Layout;
        private System.Windows.Forms.TableLayoutPanel MoodButtonLayout;
        private System.Windows.Forms.ListBox ChallengesListbox;
        private System.Windows.Forms.ListBox ActivitiesForChallengeListbox;
        private System.Windows.Forms.RichTextBox ChallengeDescriptionBox;
        private System.Windows.Forms.RichTextBox ActivityForChallengeDescriptionBox;
        private System.Windows.Forms.PictureBox activityPictureBox;
        private System.Windows.Forms.Button ChallengeButton;
        private System.Windows.Forms.Button ActivityButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button MoodButton1;
        private System.Windows.Forms.Button MoodButton2;
        private System.Windows.Forms.Button MoodButton3;
        private System.Windows.Forms.Button MoodButton4;
        private System.Windows.Forms.Button startActivityButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label MoodHeadline;
        private System.Windows.Forms.Label ActivitiesLabel;
        private System.Windows.Forms.Label SelectedActivityLabel;
        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Label timeLeftText;
        private System.Windows.Forms.Label Headline;
        private System.Windows.Forms.Label SelectedChallengeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button CancelActivityButton;
        private System.Windows.Forms.Button CompleteActivityButton;
        private System.Windows.Forms.Button ChallengeUpdateButton;
        private System.Windows.Forms.Button ChallengeStartButton;
        private Label SelectedChallengeDescription;
        private Button ActivitesBackButton;
        private Button ChallengesCancelButton;
		private Label ChallengesLabel;
		private Label nrGoldLabel;
		private PictureBox goldPictureBox;
		private ListView trophiesNotEarnedList;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private Label trophiesNotEarnedLabel;
		private ListView trophiesEarnedList;
		private ColumnHeader trophyImage;
		private ColumnHeader trophyName;
		private Label trophiesEarnedLabel;
		private PictureBox silverPictureBox;
		private TableLayoutPanel tableLayoutPanel1;
		private Label pointsLabel;
		private Label nrBronzeLabel;
		private PictureBox bronzePictureBox;
		private Label nrSilverLabel;
		private ImageList trophyImageList;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader3;
		private ListView trophiesEarnedListView;
		private ListView trophiesNotEarnedListView;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader5;
		private Button startActivityForChallengeButton;
		private ListBox activitiesListbox;
		private RichTextBox activityDescriptionBox;
	}
}
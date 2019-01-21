namespace NewGame
{
    partial class FrmQ1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQ1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoreTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToWindowsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Question1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.timingBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.questionNo = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.timerQ1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.Question1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.highscoreToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.saveGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Next Question";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editProfileToolStripMenuItem.Text = "Edit profile";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // highscoreToolStripMenuItem
            // 
            this.highscoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highscoreTableToolStripMenuItem});
            this.highscoreToolStripMenuItem.Name = "highscoreToolStripMenuItem";
            this.highscoreToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.highscoreToolStripMenuItem.Text = "Highscore";
            // 
            // highscoreTableToolStripMenuItem
            // 
            this.highscoreTableToolStripMenuItem.Name = "highscoreTableToolStripMenuItem";
            this.highscoreTableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.highscoreTableToolStripMenuItem.Text = "Highscore table";
            this.highscoreTableToolStripMenuItem.Click += new System.EventHandler(this.highscoreTableToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToWindowsToolStripMenuItem,
            this.quitToWindowsToolStripMenuItem1});
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // quitToWindowsToolStripMenuItem
            // 
            this.quitToWindowsToolStripMenuItem.Name = "quitToWindowsToolStripMenuItem";
            this.quitToWindowsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToWindowsToolStripMenuItem.Text = "Quit to launcher";
            this.quitToWindowsToolStripMenuItem.Click += new System.EventHandler(this.quitToWindowsToolStripMenuItem_Click);
            // 
            // quitToWindowsToolStripMenuItem1
            // 
            this.quitToWindowsToolStripMenuItem1.Name = "quitToWindowsToolStripMenuItem1";
            this.quitToWindowsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.quitToWindowsToolStripMenuItem1.Text = "Quit to windows";
            this.quitToWindowsToolStripMenuItem1.Click += new System.EventHandler(this.quitToWindowsToolStripMenuItem1_Click);
            // 
            // Question1
            // 
            this.Question1.Controls.Add(this.pictureBox1);
            this.Question1.Controls.Add(this.radioButton4);
            this.Question1.Controls.Add(this.radioButton3);
            this.Question1.Controls.Add(this.radioButton2);
            this.Question1.Controls.Add(this.radioButton1);
            this.Question1.Controls.Add(this.label3);
            this.Question1.Location = new System.Drawing.Point(206, 27);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(512, 430);
            this.Question1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 128);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(53, 311);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(198, 28);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Manufactured Board";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(306, 311);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(106, 28);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Softwood";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(306, 234);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 28);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Blockboard";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(53, 234);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 28);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hardwood";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Q1. What type of material is plywood?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.timingBar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.questionNo);
            this.panel1.Controls.Add(this.picUser);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 430);
            this.panel1.TabIndex = 17;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(34, 197);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(89, 29);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score: ";
            // 
            // timingBar
            // 
            this.timingBar.ForeColor = System.Drawing.Color.Lime;
            this.timingBar.Location = new System.Drawing.Point(12, 311);
            this.timingBar.Name = "timingBar";
            this.timingBar.Size = new System.Drawing.Size(178, 23);
            this.timingBar.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Next Question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // questionNo
            // 
            this.questionNo.AutoSize = true;
            this.questionNo.Location = new System.Drawing.Point(42, 295);
            this.questionNo.Name = "questionNo";
            this.questionNo.Size = new System.Drawing.Size(116, 13);
            this.questionNo.TabIndex = 2;
            this.questionNo.Text = "Question {0} out of {1}.";
            // 
            // picUser
            // 
            this.picUser.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picUser.ErrorImage")));
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(32, 57);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(128, 128);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(34, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 29);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // timerQ1
            // 
            this.timerQ1.Enabled = true;
            this.timerQ1.Interval = 1000;
            this.timerQ1.Tick += new System.EventHandler(this.timerQ1_Tick);
            // 
            // FrmQ1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 458);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQ1";
            this.Text = "FrmQ1";
            this.Load += new System.EventHandler(this.FrmQ1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Question1.ResumeLayout(false);
            this.Question1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highscoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highscoreTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToWindowsToolStripMenuItem1;
        private System.Windows.Forms.Panel Question1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ProgressBar timingBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label questionNo;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Timer timerQ1;
    }
}
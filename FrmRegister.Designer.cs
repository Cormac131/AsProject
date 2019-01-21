namespace NewGame
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.registerText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regPassword2 = new System.Windows.Forms.TextBox();
            this.regUsername2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbAvartar6 = new System.Windows.Forms.PictureBox();
            this.pbAvartar5 = new System.Windows.Forms.PictureBox();
            this.pbAvartar4 = new System.Windows.Forms.PictureBox();
            this.pbAvartar3 = new System.Windows.Forms.PictureBox();
            this.pbAvartar2 = new System.Windows.Forms.PictureBox();
            this.pbAvartar1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.regAge = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar1)).BeginInit();
            this.SuspendLayout();
            // 
            // registerText
            // 
            this.registerText.AutoSize = true;
            this.registerText.ForeColor = System.Drawing.Color.Red;
            this.registerText.Location = new System.Drawing.Point(138, 25);
            this.registerText.Name = "registerText";
            this.registerText.Size = new System.Drawing.Size(0, 13);
            this.registerText.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Re-enter Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // regPassword2
            // 
            this.regPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPassword2.Location = new System.Drawing.Point(176, 181);
            this.regPassword2.Name = "regPassword2";
            this.regPassword2.PasswordChar = '*';
            this.regPassword2.Size = new System.Drawing.Size(100, 24);
            this.regPassword2.TabIndex = 8;
            this.regPassword2.Text = "Password";
            this.regPassword2.UseSystemPasswordChar = true;
            this.regPassword2.TextChanged += new System.EventHandler(this.regPassword2_TextChanged);
            // 
            // regUsername2
            // 
            this.regUsername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUsername2.Location = new System.Drawing.Point(176, 97);
            this.regUsername2.Name = "regUsername2";
            this.regUsername2.Size = new System.Drawing.Size(100, 24);
            this.regUsername2.TabIndex = 7;
            this.regUsername2.Text = "Username";
            this.regUsername2.TextChanged += new System.EventHandler(this.regUsername2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Re-enter Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // regUsername
            // 
            this.regUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUsername.Location = new System.Drawing.Point(176, 69);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(100, 24);
            this.regUsername.TabIndex = 2;
            this.regUsername.Text = "Username";
            this.regUsername.TextChanged += new System.EventHandler(this.regUsername_TextChanged);
            // 
            // regPassword
            // 
            this.regPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPassword.Location = new System.Drawing.Point(176, 153);
            this.regPassword.Name = "regPassword";
            this.regPassword.PasswordChar = '*';
            this.regPassword.Size = new System.Drawing.Size(100, 24);
            this.regPassword.TabIndex = 3;
            this.regPassword.Text = "Password";
            this.regPassword.UseSystemPasswordChar = true;
            this.regPassword.TextChanged += new System.EventHandler(this.regPassword_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnRegister.Location = new System.Drawing.Point(422, 229);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(96, 32);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Age";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbAvartar6);
            this.groupBox1.Controls.Add(this.pbAvartar5);
            this.groupBox1.Controls.Add(this.pbAvartar4);
            this.groupBox1.Controls.Add(this.pbAvartar3);
            this.groupBox1.Controls.Add(this.pbAvartar2);
            this.groupBox1.Controls.Add(this.pbAvartar1);
            this.groupBox1.Location = new System.Drawing.Point(299, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 163);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avatar Selection";
            // 
            // pbAvartar6
            // 
            this.pbAvartar6.BackColor = System.Drawing.Color.Blue;
            this.pbAvartar6.Image = ((System.Drawing.Image)(resources.GetObject("pbAvartar6.Image")));
            this.pbAvartar6.Location = new System.Drawing.Point(147, 90);
            this.pbAvartar6.Name = "pbAvartar6";
            this.pbAvartar6.Size = new System.Drawing.Size(64, 64);
            this.pbAvartar6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvartar6.TabIndex = 5;
            this.pbAvartar6.TabStop = false;
            this.pbAvartar6.Tag = "Avartar6";
            this.pbAvartar6.Click += new System.EventHandler(this.avatarClick);
            // 
            // pbAvartar5
            // 
            this.pbAvartar5.BackColor = System.Drawing.Color.Blue;
            this.pbAvartar5.Image = ((System.Drawing.Image)(resources.GetObject("pbAvartar5.Image")));
            this.pbAvartar5.Location = new System.Drawing.Point(77, 90);
            this.pbAvartar5.Name = "pbAvartar5";
            this.pbAvartar5.Size = new System.Drawing.Size(64, 64);
            this.pbAvartar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvartar5.TabIndex = 4;
            this.pbAvartar5.TabStop = false;
            this.pbAvartar5.Tag = "Avatar5";
            this.pbAvartar5.Click += new System.EventHandler(this.avatarClick);
            // 
            // pbAvartar4
            // 
            this.pbAvartar4.BackColor = System.Drawing.Color.Blue;
            this.pbAvartar4.Image = ((System.Drawing.Image)(resources.GetObject("pbAvartar4.Image")));
            this.pbAvartar4.Location = new System.Drawing.Point(7, 90);
            this.pbAvartar4.Name = "pbAvartar4";
            this.pbAvartar4.Size = new System.Drawing.Size(64, 64);
            this.pbAvartar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvartar4.TabIndex = 3;
            this.pbAvartar4.TabStop = false;
            this.pbAvartar4.Tag = "Avatar4";
            this.pbAvartar4.Click += new System.EventHandler(this.avatarClick);
            // 
            // pbAvartar3
            // 
            this.pbAvartar3.BackColor = System.Drawing.Color.Blue;
            this.pbAvartar3.Image = ((System.Drawing.Image)(resources.GetObject("pbAvartar3.Image")));
            this.pbAvartar3.Location = new System.Drawing.Point(147, 20);
            this.pbAvartar3.Name = "pbAvartar3";
            this.pbAvartar3.Size = new System.Drawing.Size(64, 64);
            this.pbAvartar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvartar3.TabIndex = 2;
            this.pbAvartar3.TabStop = false;
            this.pbAvartar3.Tag = "Avatar3";
            this.pbAvartar3.Click += new System.EventHandler(this.avatarClick);
            // 
            // pbAvartar2
            // 
            this.pbAvartar2.BackColor = System.Drawing.Color.Blue;
            this.pbAvartar2.Image = ((System.Drawing.Image)(resources.GetObject("pbAvartar2.Image")));
            this.pbAvartar2.Location = new System.Drawing.Point(77, 20);
            this.pbAvartar2.Name = "pbAvartar2";
            this.pbAvartar2.Size = new System.Drawing.Size(64, 64);
            this.pbAvartar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvartar2.TabIndex = 1;
            this.pbAvartar2.TabStop = false;
            this.pbAvartar2.Tag = "Avatar2";
            this.pbAvartar2.Click += new System.EventHandler(this.avatarClick);
            // 
            // pbAvartar1
            // 
            this.pbAvartar1.BackColor = System.Drawing.Color.Blue;
            this.pbAvartar1.Image = ((System.Drawing.Image)(resources.GetObject("pbAvartar1.Image")));
            this.pbAvartar1.Location = new System.Drawing.Point(7, 20);
            this.pbAvartar1.Name = "pbAvartar1";
            this.pbAvartar1.Size = new System.Drawing.Size(64, 64);
            this.pbAvartar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvartar1.TabIndex = 0;
            this.pbAvartar1.TabStop = false;
            this.pbAvartar1.Tag = "Avatar1";
            this.pbAvartar1.Click += new System.EventHandler(this.avatarClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Register";
            // 
            // regAge
            // 
            this.regAge.DropDownHeight = 80;
            this.regAge.FormattingEnabled = true;
            this.regAge.IntegralHeight = false;
            this.regAge.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.regAge.Location = new System.Drawing.Point(176, 124);
            this.regAge.Name = "regAge";
            this.regAge.Size = new System.Drawing.Size(49, 21);
            this.regAge.TabIndex = 19;
            this.regAge.Text = "Age";
            this.regAge.SelectedIndexChanged += new System.EventHandler(this.regAge_SelectedIndexChanged);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 270);
            this.Controls.Add(this.regAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.registerText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regUsername);
            this.Controls.Add(this.regPassword2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regUsername2);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regPassword2;
        private System.Windows.Forms.TextBox regUsername2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regUsername;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbAvartar6;
        private System.Windows.Forms.PictureBox pbAvartar5;
        private System.Windows.Forms.PictureBox pbAvartar4;
        private System.Windows.Forms.PictureBox pbAvartar3;
        private System.Windows.Forms.PictureBox pbAvartar2;
        private System.Windows.Forms.PictureBox pbAvartar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox regAge;
        private System.Windows.Forms.Timer timer1;
    }
}
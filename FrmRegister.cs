using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGame
{
    public partial class FrmRegister : Form
    {
        #region Vars
        public const string binaryFileName = "PlayerProfiles.bin";
        public const string textFileName = "PlayerCount.txt";

        private string inputUsername;
        private string confirmUsername;
        private int inputAge;
        private string inputPassword;
        private string confirmPassword;
        private string errors;

        //checked username & password
        private string checkedUsername;
        private string checkedPassword;

        //private int newUser = Program.UserCount + 1;

        private bool usernameCorrect = false;
        private bool passwordCorrect = false;
        private bool registered = false;

        private bool avatar1Selected = false;
        private bool avatar2Selected = false;
        private bool avatar3Selected = false;
        private bool avatar4Selected = false;
        private bool avatar5Selected = false;
        private bool avatar6Selected = false;
        private string avatarSelected;
        #endregion

        public FrmRegister()
        {
            InitializeComponent();
        }

        #region Validation
        private void validate()
        {
            while (true)
            {
                //check length of username
                if (regUsername.TextLength <= 6)
                {
                    usernameCorrect = false;
                    errors = "Username must be more than 6 characters!";
                }
                else
                {
                    errors = " ";
                }

                //check if usernames match
                if (!regUsername.ToString().Equals(regUsername2.ToString()))
                {
                    usernameCorrect = false;
                    errors = "Usernames do not match!";
                }
                else
                {
                    checkedUsername = inputUsername;
                    usernameCorrect = true;
                    errors = " ";
                }

                //check length of password
                if (regPassword.TextLength <= 6)
                {
                    passwordCorrect = false;
                    errors = "Password must be more than 6 characters!";
                }
                else
                {
                    errors = " ";
                }

                //check if passwords match
                if (!regPassword.ToString().Equals(regPassword2.ToString()))
                {
                    passwordCorrect = false;
                    errors = "Passwords do not match!";
                }
                else
                {
                    checkedPassword = inputPassword;
                    passwordCorrect = true;
                    errors = " ";
                }

                //check age of player
                if (regAge.SelectedItem != null)
                {
                    if (int.Parse(this.regAge.GetItemText(this.regAge.SelectedItem)) <= 12)
                    {
                        passwordCorrect = false;
                        usernameCorrect = false;
                        errors = "You are not old enough to play this game!";
                    }
                    else
                    {
                        errors = " ";
                        break;
                    }
                }
            }
        }
        #endregion

        #region Setting variables
        private void regUsername_TextChanged(object sender, EventArgs e)
        {
            inputUsername = this.regUsername.Text;
        }

        private void regUsername2_TextChanged(object sender, EventArgs e)
        {
            confirmUsername = this.regUsername2.Text;
        }

        private void regPassword_TextChanged(object sender, EventArgs e)
        {
            inputPassword = this.regPassword.Text;
        }

        private void regPassword2_TextChanged(object sender, EventArgs e)
        {
            confirmPassword = this.regPassword2.Text;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerPlayer();
            if (registered == true)
            {
                this.Close();
            }
        }

        private void regAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputAge = int.Parse(this.regAge.GetItemText(this.regAge.SelectedItem));
        }
        #endregion

        private void registerPlayer()
        {

            validate();
            registerText.Text = errors;

            if ((usernameCorrect == true) && (passwordCorrect == true)) 
            {
                Player nP = new Player();
                nP.Age = inputAge;
                nP.Highscore = 0;
                nP.Score = 0;
                nP.Username = checkedUsername;
                nP.Password = checkedPassword;
                nP.Avatar = avatarSelected;

                using (BinaryWriter writer = new BinaryWriter(File.Open(binaryFileName, FileMode.Append)))
                {
                    writer.Write("_" + nP.Username + "/" + nP.Password + "/" + nP.Age.ToString() + "/" + nP.Highscore.ToString() + "/" + nP.Score.ToString() + "/" + nP.Avatar);
                    
                    writer.Close();
                }

                StreamWriter changePlayerCount = new StreamWriter(textFileName);
                changePlayerCount.Write(Program.UserCount++);
                changePlayerCount.Close();

                registered = true;
            }
        }       

        private void avatarClick(object sender, EventArgs e)
        {
            ResetAvatarFlagsAndStyles();

            PictureBox picture = sender as PictureBox;

            picture.BorderStyle = BorderStyle.Fixed3D;

            string tagString = (string)picture.Tag;

            switch (tagString)
            {
                case "Avatar1":
                    avatarSelected = "avatar1.jpg";
                    break;
                case "Avatar2":
                    avatarSelected = "avatar2.jpg";
                    break;
                case "Avatar3":
                    avatarSelected = "avatar3.jpg";
                    break;
                case "Avatar4":
                    avatarSelected = "avatar4.jpg";
                    break;
                case "Avatar5":
                    avatarSelected = "avatar5.jpg";
                    break;
                case "Avatar6":
                    avatarSelected = "avatar6.jpg";
                    break;
            }
        }

        private void ResetAvatarFlagsAndStyles()
        {
            avatar1Selected = false;
            avatar2Selected = false;
            avatar3Selected = false;
            avatar4Selected = false;
            avatar5Selected = false;
            avatar6Selected = false;

            pbAvartar1.BorderStyle = BorderStyle.None;
            pbAvartar2.BorderStyle = BorderStyle.None;
            pbAvartar3.BorderStyle = BorderStyle.None;
            pbAvartar4.BorderStyle = BorderStyle.None;
            pbAvartar5.BorderStyle = BorderStyle.None;
            pbAvartar6.BorderStyle = BorderStyle.None;
        }
    }
}

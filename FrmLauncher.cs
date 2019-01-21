using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGame
{
    public partial class FrmLauncher : Form
    {
        #region Vars
        private static string username;
        private static string password;
        private static string userCheck;
        private static string passCheck;

        private static bool userTrue = false;
        private static bool passTrue = false;

        public static bool stop = false;

        public static bool SplashScreenLoad = false;
        public static bool CloseToWindows = false;
        public static bool ExitGame = false;
        #endregion

        public FrmLauncher()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();

            while (!SplashScreenLoad)
            {
                if (SplashScreenLoad)
                {
                    Thread.Sleep(800);
                    break;
                }
            }

            InitializeComponent();

            t.Abort();

            welcomeText.Text = "Please login.";
        }

        public void SplashScreen()
        {
            Application.Run(new FrmSplashScreen());
        }

        private static void getAccountInfo()
        {
            using (BinaryReader userReader = new BinaryReader(File.Open(FrmRegister.binaryFileName, FileMode.Open)))
            {
                // splitting characters
                char[] delimiterChars1 = { '_' };
                char[] delimiterChars2 = { '/' };

                char[] text = userReader.ReadChars(10000000 * Program.UserCount); // reads in all the data

                string textToString = new string(text);

                string[] words = textToString.Split(delimiterChars1); // string array with each split player data.

                string[] records = new string[Program.UserCount];

                int q = 1;
                int g = 0;

                for (int i = 0; i < Program.UserCount; i++)
                {
                    records[g] = words[q];
                    q++;
                    g++;
                }

                int j = 0;

                foreach (string s in records)
                {
                    string test = records[j];

                    String[] splitData = test.Split(delimiterChars2);

                    PlayersOnSystem.PlayersOnSystemArray[j, 0] = splitData[0];
                    PlayersOnSystem.PlayersOnSystemArray[j, 1] = splitData[1];
                    PlayersOnSystem.PlayersOnSystemArray[j, 2] = splitData[2];
                    PlayersOnSystem.PlayersOnSystemArray[j, 3] = splitData[3];
                    PlayersOnSystem.PlayersOnSystemArray[j, 4] = splitData[4];
                    PlayersOnSystem.PlayersOnSystemArray[j, 5] = splitData[5];

                    userCheck = PlayersOnSystem.PlayersOnSystemArray[j, 0];
                    passCheck = PlayersOnSystem.PlayersOnSystemArray[j, 1];


                    if (userCheck == username)
                    {
                        userTrue = true;
                    }
                    else
                    {
                        userTrue = false;
                    }

                    if (passCheck == password)
                    {
                        passTrue = true;
                    }
                    else
                    {
                        passTrue = false;
                    }

                    if ((userTrue == true) && (passTrue == true))
                    {
                        SessionPlayer.Username = PlayersOnSystem.PlayersOnSystemArray[j, 0];
                        SessionPlayer.Password = PlayersOnSystem.PlayersOnSystemArray[j, 1];
                        SessionPlayer.Age = int.Parse(PlayersOnSystem.PlayersOnSystemArray[j, 2]);
                        SessionPlayer.Highscore = int.Parse(PlayersOnSystem.PlayersOnSystemArray[j, 3]);
                        SessionPlayer.Score = 0;
                        SessionPlayer.PreviousScore = int.Parse(PlayersOnSystem.PlayersOnSystemArray[j, 4]);
                        SessionPlayer.Avatar = PlayersOnSystem.PlayersOnSystemArray[j, 5];

                        PlayersOnSystem.CurrentPlayerArrayValue = j;
                        break;
                    }

                    j++;
                }
            }
        }

        //Opens form when called
        public void OpenWhenClosed()
        {
            try
            {
                this.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.ToString());
                throw;
            }
        }

        //Closes form when called
        public void CloseAll()
        {
            try
            {
                this.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.ToString());
                throw;
            }
        }

        #region Events
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            username = this.txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password = this.txtPassword.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            getAccountInfo();

            if (userTrue == false)
            {
                loginMessage.Text = "Username not recognised!";
            }
            else if (passTrue == false)
            {
                loginMessage.Text = "Password not recognised!";
            }



            if ((userTrue == true) && (passTrue == true))
            {
                welcomeText.Text = "Welcome " + username + ".";
                gbLogin.Hide();
            }
            else
            {
                welcomeText.Text = "Please login.";
                gbLogin.Show();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if ((userTrue == true) && (passTrue == true))
            {

                while (loadingBar.Value != 100)
                {
                    loadingBar.Value++;
                    Thread.Sleep(4);
                }

                FrmQ1 frmGame = new FrmQ1();
                frmGame.Show();

                this.Hide();

                FrmLauncher frmLauncher = new FrmLauncher();

                if (ExitGame == true)
                {
                    frmLauncher.Show();
                }
                else if (CloseToWindows == true)
                {
                    frmLauncher.Close();
                }
 
                loadingBar.Value = 0;
            }
            else
            {
                MessageBox.Show("Something went wrong! Please try again!");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //FrmHelp hlp = new FrmHelp();
            //hlp.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister register = new FrmRegister();
            register.Show();
        }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGame
{
    public partial class FrmQ1 : Form
    {
        #region Vars
        Image as1 = Image.FromFile(@"D:\Cormac\Documents\Memory Pen\Other Stuff\SSD\AS CourseWork CMcGrath\NewGame\Avatars\avatar1.jpg");
        Image as2 = Image.FromFile(@"D:\Cormac\Documents\Memory Pen\Other Stuff\SSD\AS CourseWork CMcGrath\NewGame\Avatars\avatar2.jpg");
        Image as3 = Image.FromFile(@"D:\Cormac\Documents\Memory Pen\Other Stuff\SSD\AS CourseWork CMcGrath\NewGame\Avatars\avatar3.jpg");
        Image as4 = Image.FromFile(@"D:\Cormac\Documents\Memory Pen\Other Stuff\SSD\AS CourseWork CMcGrath\NewGame\Avatars\avatar4.jpg");
        Image as5 = Image.FromFile(@"D:\Cormac\Documents\Memory Pen\Other Stuff\SSD\AS CourseWork CMcGrath\NewGame\Avatars\avatar5.jpg");
        Image as6 = Image.FromFile(@"D:\Cormac\Documents\Memory Pen\Other Stuff\SSD\AS CourseWork CMcGrath\NewGame\Avatars\avatar6.jpg");

        FrmLauncher launcher = new FrmLauncher();

        public static bool correctAnswer = false;
        #endregion

        public FrmQ1()
        {
            InitializeComponent();

            lblUsername.Text = SessionPlayer.Username;
            lblScore.Text = "Score: " + SessionPlayer.Score.ToString();

            picUser.SizeMode = PictureBoxSizeMode.Zoom;

            questionNo.Text = "Question 1 out of 6.";

            switch (SessionPlayer.Avatar)
            {
                case "avatar1.jpg":
                    picUser.Image = as1;
                    break;
                case "avatar2.jpg":
                    picUser.Image = as2;
                    break;
                case "avatar3.jpg":
                    picUser.Image = as3;
                    break;
                case "avatar4.jpg":
                    picUser.Image = as4;
                    break;
                case "avatar5.jpg":
                    picUser.Image = as5;
                    break;
                case "avatar6.jpg":
                    picUser.Image = as6;
                    break;
            }
        }

        #region Answer 1
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer = false;
        }
        #endregion

        #region Answer 4
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer = true;
        }
        #endregion

        #region Answer 2
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer = false;
        }
        #endregion

        #region Answer 3
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer = false;
        }
        #endregion

        //Next button pressed
        private void button1_Click(object sender, EventArgs e)
        {
            if (correctAnswer == true)
            {
                //add 1 to score
                lblScore.Text = "Score: " + SessionPlayer.Score++;

                //go to next question
                FrmQ2 q2 = new FrmQ2();
                q2.Show();
                this.Hide();
            }
        }

        //Quit to launcher menu strip
        private void quitToWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            launcher.OpenWhenClosed();
            this.Close();
        }

        //Quit to windows menu strip
        private void quitToWindowsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            launcher.CloseAll();
            this.Close();
        }

        //Open Edit Profile tab
        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfile Profile = new FrmProfile();
            Profile.Show();
        }

        //Open Highscore tap
        private void highscoreTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHighScore hsTable = new FrmHighScore();
            hsTable.Show();
        }

        //Closes form when called
        public void CloseAll()
        {
            this.Close();
        }

        private void timerQ1_Tick(object sender, EventArgs e)
        {
            if(timingBar.Value == 98) 
            {
                timerQ1.Stop();

                FrmQ2 moveQ2 = new FrmQ2();
                moveQ2.Show();
                this.Hide();
            }
            else
            {
                timingBar.Value++;
            }
        }

        private void FrmQ1_Load(object sender, EventArgs e)
        {
            timerQ1.Enabled = true;
            timerQ1.Interval = 500;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralMethods.SaveGame();
        }
    }
}

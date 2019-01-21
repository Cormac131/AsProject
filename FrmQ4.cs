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
    public partial class FrmQ4 : Form
    {
        #region Vars
        Image as1 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar1.jpg");
        Image as2 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar2.jpg");
        Image as3 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar3.jpg");
        Image as4 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar4.jpg");
        Image as5 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar5.jpg");
        Image as6 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar6.jpg");

        FrmLauncher launcher = new FrmLauncher();

        public static int correctAnswer = 0;
        #endregion

        public FrmQ4()
        {
            InitializeComponent();

            lblUsername.Text = SessionPlayer.Username;
            lblScore.Text = "Score: " + SessionPlayer.Score.ToString();

            picUser.SizeMode = PictureBoxSizeMode.Zoom;

            questionNo.Text = "Question 3 out of 6.";

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

            timingBar.Value = Program.totalTime;
            
        }

        #region Answers

        //Answer 1
        private void AnsBox1_TextChanged(object sender, EventArgs e)
        {
            if ((AnsBox1.Text == "Band saw") || (AnsBox1.Text == "bandsaw") || (AnsBox1.Text == "band saw")) 
            {
                correctAnswer++;
            }
        }

        //Answer 2
        private void AnsBox2_TextChanged(object sender, EventArgs e)
        {
            if ((AnsBox1.Text == "CNC Milling machine") || (AnsBox1.Text == "cnc milling machine"))
            {
                correctAnswer++;
            }
        }

        //Answer 3
        private void AnsBox3_TextChanged(object sender, EventArgs e)
        {
            if ((AnsBox1.Text == "Belt sander") || (AnsBox1.Text == "Linisher") || (AnsBox1.Text == "belt sander") || (AnsBox1.Text == "linisher"))
            {
                correctAnswer++;
            }
        }

        //Answer 4
        private void AnsBox4_TextChanged(object sender, EventArgs e)
        {
            if ((AnsBox1.Text == "Pillar drill") || (AnsBox1.Text == "pillar drill"))
            {
                correctAnswer++;
            }
        }

        //Answer 5
        private void AnsBox5_TextChanged(object sender, EventArgs e)
        {
            if ((AnsBox1.Text == "Scroll Saw") || (AnsBox1.Text == "scroll saw"))
            {
                correctAnswer++;
            }
        }

        //Answer 6
        private void AnsBox6_TextChanged(object sender, EventArgs e)
        {
            if ((AnsBox1.Text == "Wood lathe") || (AnsBox1.Text == "wood lathe"))
            {
                correctAnswer++;
            }
        }
        #endregion

        //Quit to launcher menu strip
        private void quitToWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLauncher.ExitGame = true;
            this.Close();
        }

        //Quit to windows menu strip
        private void quitToWindowsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLauncher.CloseToWindows = true;
            this.Close();
        }

        //Open the edit profile tab
        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfile Profile = new FrmProfile();
            Profile.Show();
        }


        private void FrmGame_Load(object sender, EventArgs e)
        {
            timingBar.Maximum = 600;
        }

        //Open highscore tab
        private void highscoreTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHighScore hsTable = new FrmHighScore();
            hsTable.Show();
        }

        //Next button pressed
        private void button1_Click(object sender, EventArgs e)
        {
            //increse score
            lblScore.Text = "Score: " + (SessionPlayer.Score + correctAnswer);
            

            //go to next form
            FrmQ5 q5 = new FrmQ5();
            q5.Show();
            this.Hide();
        }

        //Closes form when called
        public void CloseAll()
        {
            this.Close();
        }
    }
}

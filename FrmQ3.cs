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
    public partial class FrmQ3 : Form
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
        string[] answers = new string[] {"Alloy", "Hardwood", "Manufactured Board", "Alloy", "Non-ferrous", "Softwood"};
        #endregion

        public FrmQ3()
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

        //Next button pressed
        private void button1_Click(object sender, EventArgs e)
        {

            //Add one to the score
            lblScore.Text = "Score: " + (SessionPlayer.Score + correctAnswer);


            //Go to next question
            FrmQ4 q4 = new FrmQ4();
            q4.Show();
            this.Hide();
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

        #region Answer Checking
        //check answer 1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qAns = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            if (qAns == answers[0])
            {
                correctAnswer++;
            }
        }

        //check answer 2
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qAns = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);

            if (qAns == answers[1])
            {
                correctAnswer++;
            }
        }

        //check answer 3
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qAns = this.comboBox4.GetItemText(this.comboBox4.SelectedItem);

            if (qAns == answers[3])
            {
                correctAnswer++;
            }
        }

        //check answer 4
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qAns = this.comboBox3.GetItemText(this.comboBox3.SelectedItem);

            if (qAns == answers[2])
            {
                correctAnswer++;
            }
        }

        //check answer 5
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qAns = this.comboBox6.GetItemText(this.comboBox6.SelectedItem);

            if (qAns == answers[5])
            {
                correctAnswer++;
            }
        }

        //check answer 6
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qAns = this.comboBox5.GetItemText(this.comboBox5.SelectedItem);

            if (qAns == answers[4])
            {
                correctAnswer++;
            }
        }
        #endregion

        //Closes form when called
        public void CloseAll()
        {
            this.Close();
        }
    }
}
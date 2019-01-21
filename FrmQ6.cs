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
    public partial class FrmQ6 : Form
    {
        #region Vars
        Image as1 = Image.FromFile(@"F:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar1.jpg");
        Image as2 = Image.FromFile(@"F:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar2.jpg");
        Image as3 = Image.FromFile(@"F:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar3.jpg");
        Image as4 = Image.FromFile(@"F:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar4.jpg");
        Image as5 = Image.FromFile(@"F:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar5.jpg");
        Image as6 = Image.FromFile(@"F:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar6.jpg");

        FrmLauncher launcher = new FrmLauncher();

        public static int correctAnswer = 0;
        #endregion

        public FrmQ6()
        {
            InitializeComponent();

            lblUsername.Text = SessionPlayer.Username;
            lblScore.Text = "Score: " + SessionPlayer.Score.ToString();

            picUser.SizeMode = PictureBoxSizeMode.Zoom;

            questionNo.Text = "Question 6 out of 6.";

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

        #region Answers
        //Answer 2
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer++;
        }

        //Answer 3
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer++;
        }

        //Answer 8
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer++;
        }

        //Answer 7
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer++;
        }

        //Answer 5
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer++;
        }

        //Answer 6
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer++;
        }

        //Answer 1
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer--;
        }

        //Answer 4
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer--;
        }
        #endregion

        //Finish button pressed
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

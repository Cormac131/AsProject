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
    public partial class FrmQ2 : Form
    {
        #region Vars
        Image as1 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar1.jpg");
        Image as2 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar2.jpg");
        Image as3 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar3.jpg");
        Image as4 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar4.jpg");
        Image as5 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar5.jpg");
        Image as6 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar6.jpg");
        

        FrmLauncher launcher = new FrmLauncher();

        public static bool correctAnswer1 = false;
        public static bool correctAnswer2 = false;
        public static bool correctAnswer3 = false;
        public static bool correctAnswer4 = false;
        public static bool correctAnswer5 = false;
        public static bool correctAnswer6 = false;
        #endregion

        public FrmQ2()
        {

            InitializeComponent();

            lblUsername.Text = SessionPlayer.Username;
            lblScore.Text = "Score: " + SessionPlayer.Score.ToString();

            picUser.SizeMode = PictureBoxSizeMode.Zoom;

            questionNo.Text = "Question 2 out of 6.";

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
            //increse score
            if (correctAnswer1 == true)
                lblScore.Text = "Score: " + SessionPlayer.Score++;
            if (correctAnswer2 == true)
                lblScore.Text = "Score: " + SessionPlayer.Score++;
            if (correctAnswer3 == true)
                lblScore.Text = "Score: " + SessionPlayer.Score++;
            if (correctAnswer4 == true)
                lblScore.Text = "Score: " + SessionPlayer.Score++;
            if (correctAnswer5 == true)
                lblScore.Text = "Score: " + SessionPlayer.Score++;
            if (correctAnswer6 == true)
                lblScore.Text = "Score: " + SessionPlayer.Score++;

            //go to next question
            FrmQ3 q3 = new FrmQ3();
            q3.Show();
            this.Hide();
        }

        //Open edit profile tab
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

        #region Drag & Drop

        #region Drag and Drop 1
        private void lblAns1_MouseDown(object sender, MouseEventArgs e)
        {
            //start drag if left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                //copy the text of lblAns1
                lblAns1.DoDragDrop(lblAns1.Text, DragDropEffects.Copy);
            }
        }

        private void lblAnsBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                //allow this
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                //dont allow any other drop
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblAnsBox1_DragDrop(object sender, DragEventArgs e)
        {
            //accept the drop
            lblAnsBox1.Text = (string)e.Data.GetData(DataFormats.Text);
            //depending on the answer dragged, hide it and add score if it is in the correct place
            //as well as making sure people arent guessing
            if (lblAnsBox1.Text == "Joints")
            {
                lblAns1.Hide();
                correctAnswer1 = true;
            }
            else if (lblAnsBox1.Text == "Screws")
            {
                lblAns2.Hide();
            }
            else if (lblAnsBox1.Text == "Welding")
            {
                lblAns3.Hide();
            }
            else if (lblAnsBox1.Text == "Rivets")
            {
                lblAns4.Hide();
            }
            else if (lblAnsBox1.Text == "Components")
            {
                lblAns5.Hide();
            }
            else if (lblAnsBox1.Text == "Cake")
            {
                lblAns6.Hide();
            }
            else if (lblAnsBox1.Text == "Jig")
            {
                lblAns7.Hide();
            }
        }
        #endregion

        #region Drag and Drop 2
        private void lblAns2_MouseDown(object sender, MouseEventArgs e)
        {
            //start drag if left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                //copy the text of lblAns1
                lblAns2.DoDragDrop(lblAns2.Text, DragDropEffects.Copy);
            }
        }

        private void lblAnsBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                //allow this
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                //dont allow any other drop
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblAnsBox2_DragDrop(object sender, DragEventArgs e)
        {
            //accept the drop
            lblAnsBox2.Text = (string)e.Data.GetData(DataFormats.Text);
            //depending on the answer dragged, hide it and add score if it is in the correct place
            //as well as making sure people arent guessing
            if (lblAnsBox2.Text == "Joints")
            {
                lblAns1.Hide();

            }
            else if (lblAnsBox2.Text == "Screws")
            {
                lblAns2.Hide();

            }
            else if (lblAnsBox2.Text == "Welding")
            {
                lblAns3.Hide();
            }
            else if (lblAnsBox2.Text == "Rivets")
            {
                correctAnswer2 = true;
                lblAns4.Hide();
            }
            else if (lblAnsBox2.Text == "Components")
            {
                lblAns5.Hide();
            }
            else if (lblAnsBox2.Text == "Cake")
            {
                lblAns6.Hide();
            }
            else if (lblAnsBox2.Text == "Jig")
            {
                lblAns7.Hide();
            }
        }
        #endregion

        #region Drag and Drop 3
        private void lblAns3_MouseDown(object sender, MouseEventArgs e)
        {
            //start drag if left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                //copy the text of lblAns1
                lblAns3.DoDragDrop(lblAns3.Text, DragDropEffects.Copy);
            }
        }

        private void lblAnsBox3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                //allow this
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                //dont allow any other drop
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblAnsBox3_DragDrop(object sender, DragEventArgs e)
        {
            //accept the drop
            lblAnsBox3.Text = (string)e.Data.GetData(DataFormats.Text);
            //depending on the answer dragged, hide it and add score if it is in the correct place
            //as well as making sure people arent guessing
            if (lblAnsBox3.Text == "Joints")
            {
                lblAns1.Hide();
            }
            else if (lblAnsBox3.Text == "Screws")
            {
                lblAns2.Hide();
            }
            else if (lblAnsBox3.Text == "Welding")
            {
                correctAnswer3 = true;
                lblAns3.Hide();
            }
            else if (lblAnsBox3.Text == "Rivets")
            {
                lblAns4.Hide();
            }
            else if (lblAnsBox3.Text == "Components")
            {
                lblAns5.Hide();
            }
            else if (lblAnsBox3.Text == "Cake")
            {
                lblAns6.Hide();
            }
            else if (lblAnsBox3.Text == "Jig")
            {
                lblAns7.Hide();
            }
        }
        #endregion

        #region Drag and Drop 4
        private void lblAns4_MouseDown(object sender, MouseEventArgs e)
        {
            //start drag if left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                //copy the text of lblAns1
                lblAns4.DoDragDrop(lblAns4.Text, DragDropEffects.Copy);
            }
        }

        private void lblAnsBox4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                //allow this
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                //dont allow any other drop
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblAnsBox4_DragDrop(object sender, DragEventArgs e)
        {
            //accept the drop
            lblAnsBox4.Text = (string)e.Data.GetData(DataFormats.Text);
            //depending on the answer dragged, hide it and add score if it is in the correct place
            //as well as making sure people arent guessing
            if (lblAnsBox4.Text == "Joints")
            {
                lblAns1.Hide();
            }
            else if (lblAnsBox4.Text == "Screws")
            {
                correctAnswer4 = true;
                lblAns2.Hide();
            }
            else if (lblAnsBox4.Text == "Welding")
            {
                lblAns3.Hide();
            }
            else if (lblAnsBox4.Text == "Rivets")
            {
                lblAns4.Hide();
            }
            else if (lblAnsBox4.Text == "Components")
            {
                lblAns5.Hide();
            }
            else if (lblAnsBox4.Text == "Cake")
            {
                lblAns6.Hide();
            }
            else if (lblAnsBox4.Text == "Jig")
            {
                lblAns7.Hide();
            }
        }
        #endregion

        #region Drag and Drop 5
        private void lblAns5_MouseDown(object sender, MouseEventArgs e)
        {
            //start drag if left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                //copy the text of lblAns1
                lblAns5.DoDragDrop(lblAns5.Text, DragDropEffects.Copy);
            }
        }

        private void lblAnsBox5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                //allow this
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                //dont allow any other drop
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblAnsBox5_DragDrop(object sender, DragEventArgs e)
        {
            //accept the drop
            lblAnsBox5.Text = (string)e.Data.GetData(DataFormats.Text);
            //depending on the answer dragged, hide it and add score if it is in the correct place
            //as well as making sure people arent guessing
            if (lblAnsBox5.Text == "Joints")
            {
                lblAns1.Hide();
            }
            else if (lblAnsBox5.Text == "Screws")
            {
                lblAns2.Hide();
            }
            else if (lblAnsBox5.Text == "Welding")
            {
                lblAns3.Hide();
            }
            else if (lblAnsBox5.Text == "Rivets")
            {
                lblAns4.Hide();
            }
            else if (lblAnsBox5.Text == "Components")
            {
                lblAns5.Hide();
                correctAnswer5 = true;
            }
            else if (lblAnsBox5.Text == "Cake")
            {
                lblAns6.Hide();
            }
            else if (lblAnsBox5.Text == "Jig")
            {
                lblAns7.Hide();
            }
        }
        #endregion

        #region Drag and Drop 6
        private void lblAns6_MouseDown(object sender, MouseEventArgs e)
        {
            //start drag if left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                //copy the text of lblAns1
                lblAns6.DoDragDrop(lblAns6.Text, DragDropEffects.Copy);
            }
        }

        private void lblAnsBox6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                //allow this
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                //dont allow any other drop
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblAnsBox6_DragDrop(object sender, DragEventArgs e)
        {
            //accept the drop
            lblAnsBox6.Text = (string)e.Data.GetData(DataFormats.Text);
            //depending on the answer dragged, hide it and add score if it is in the correct place
            //as well as making sure people arent guessing
            if (lblAnsBox6.Text == "Joints")
            {
                lblAns1.Hide();

            }
            else if (lblAnsBox6.Text == "Screws")
            {
                lblAns2.Hide();

            }
            else if (lblAnsBox6.Text == "Welding")
            {
                lblAns3.Hide();
            }
            else if (lblAnsBox6.Text == "Rivets")
            {
                lblAns4.Hide();
            }
            else if (lblAnsBox6.Text == "Components")
            {
                lblAns5.Hide();
            }
            else if (lblAnsBox6.Text == "Cake")
            {
                lblAns6.Hide();
            }
            else if (lblAnsBox6.Text == "Jig")
            {
                lblAns7.Hide();
                correctAnswer6 = true;
            }
        }
        #endregion

        private void lblAns7_MouseDown(object sender, MouseEventArgs e)
        {
            //start drag if left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                //copy the text of lblAns1
                lblAns7.DoDragDrop(lblAns7.Text, DragDropEffects.Copy);
            }
        }
        #endregion

        //Closes form when called
        public void CloseAll()
        {
            this.Close();
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralMethods.SaveGame();
        }
    }
}

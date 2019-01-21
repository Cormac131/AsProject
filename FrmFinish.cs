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
    public partial class FrmFinish : Form
    {
        #region Vars
        Image as1 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar1.jpg");
        Image as2 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar2.jpg");
        Image as3 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar3.jpg");
        Image as4 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar4.jpg");
        Image as5 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar5.jpg");
        Image as6 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar6.jpg");

        FrmLauncher launcher = new FrmLauncher();
        #endregion

        public FrmFinish()
        {
            InitializeComponent();

            lblUsername.Text = SessionPlayer.Username;
            lblScore.Text = SessionPlayer.Score.ToString();
            lblHighScore.Text = SessionPlayer.Highscore.ToString();

            picUser.SizeMode = PictureBoxSizeMode.Zoom;

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

        //To highscore table 
        private void button2_Click(object sender, EventArgs e)
        {
            FrmHighScore hsForm = new FrmHighScore();
            hsForm.Show();
        }

        //To launcher form
        private void button1_Click(object sender, EventArgs e)
        {
            FrmLauncher launcher = new FrmLauncher();
            launcher.Show();
            this.Close();
        }
    }
}

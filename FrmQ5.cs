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
    public partial class FrmQ5 : Form
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

        public FrmQ5()
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

            AnsPbx1.AllowDrop = true;
            AnsPbx1.DragEnter += AnsPbx1_DragEnter;
            AnsPbx1.DragDrop += AnsPbx1_DragDrop;
            AnsPbx1.MouseDown += AnsPbx1_MouseDown;
            AnsPbx2.AllowDrop = true;
            AnsPbx2.DragEnter += AnsPbx2_DragEnter;
            AnsPbx2.DragDrop += AnsPbx2_DragDrop;
            AnsPbx2.MouseDown += AnsPbx2_MouseDown;
            AnsPbx3.AllowDrop = true;
            AnsPbx3.DragEnter += AnsPbx3_DragEnter;
            AnsPbx3.DragDrop += AnsPbx3_DragDrop;
            AnsPbx3.MouseDown += AnsPbx3_MouseDown;
        }


        private void AnsPbx1_MouseDown(object sender, MouseEventArgs e)
        {
            var img = AnsPbx1.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                AnsPbx1.Image = null;
            }
        }

        void AnsPbx1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        void AnsPbx1_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            AnsPbx1.Image = bmp;
        }

        private void AnsPbx2_MouseDown(object sender, MouseEventArgs e)
        {
            var img = AnsPbx2.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                AnsPbx2.Image = null;
            }
        }

        void AnsPbx2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        void AnsPbx2_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            AnsPbx2.Image = bmp;
        }

        private void AnsPbx3_MouseDown(object sender, MouseEventArgs e)
        {
            var img = AnsPbx3.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                AnsPbx3.Image = null;
            }
        }

        void AnsPbx3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        void AnsPbx3_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            AnsPbx3.Image = bmp;
        }

        //Next button pressed
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Closes form when called
        public void CloseAll()
        {
            this.Close();
        }
    }
}

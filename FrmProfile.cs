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
    public partial class FrmProfile : Form
    {
        bool isSelecting;

        bool avatar1Selected = false;
        bool avatar2Selected = false;
        bool avatar3Selected = false;
        bool avatar4Selected = false;
        bool avatar5Selected = false;
        bool avatar6Selected = false;

        Image as1 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar1.jpg");
        Image as2 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar2.jpg");
        Image as3 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar3.jpg");
        Image as4 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar4.jpg");
        Image as5 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar5.jpg");
        Image as6 = Image.FromFile(@"D:\SSD\Quiz Versions\Game\NewGame\Avatars\avatar6.jpg");

        public FrmProfile()
        {
            InitializeComponent();

            picSelected.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            isSelecting = false;
        }

        private void pbxColor_MouseDown(object sender, MouseEventArgs e)
        {
            isSelecting = true;
        }

        private void pbxColor_MouseUp(object sender, MouseEventArgs e)
        {
            isSelecting = false;
        }

        private void pbxColor_MouseMove(object sender, MouseEventArgs e)
        {
            if ((isSelecting == true) && (e.X <= 225) && (e.X >= 0) && (e.Y <= 155) && (e.Y >= 0))
            {
                Bitmap bmpImage = (Bitmap)pbxColor.Image;
                Color clr = bmpImage.GetPixel(e.X, e.Y);

                txtRed.Text = clr.R.ToString();
                txtGreen.Text = clr.G.ToString();
                txtBlue.Text = clr.B.ToString();

                pnlPreview.BackColor = clr;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            avatar1Selected = true;
            avatar2Selected = false;
            avatar3Selected = false;
            avatar4Selected = false;
            avatar5Selected = false;
            avatar6Selected = false;

            if (avatar1Selected == true)
            {
                pbAvartar1.BorderStyle = BorderStyle.Fixed3D;
                pbAvartar2.BorderStyle = BorderStyle.None;
                pbAvartar3.BorderStyle = BorderStyle.None;
                pbAvartar4.BorderStyle = BorderStyle.None;
                pbAvartar5.BorderStyle = BorderStyle.None;
                pbAvartar6.BorderStyle = BorderStyle.None;

                picSelected.Image = as1;
                
            }
            else
            {
                pbAvartar1.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            avatar1Selected = false;
            avatar2Selected = true;
            avatar3Selected = false;
            avatar4Selected = false;
            avatar5Selected = false;
            avatar6Selected = false;

            if (avatar2Selected == true)
            {
                pbAvartar1.BorderStyle = BorderStyle.None;
                pbAvartar2.BorderStyle = BorderStyle.Fixed3D;
                pbAvartar3.BorderStyle = BorderStyle.None;
                pbAvartar4.BorderStyle = BorderStyle.None;
                pbAvartar5.BorderStyle = BorderStyle.None;
                pbAvartar6.BorderStyle = BorderStyle.None;

                picSelected.Image = as2;
            }
            else
            {
                pbAvartar2.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            avatar1Selected = false;
            avatar2Selected = false;
            avatar3Selected = true;
            avatar4Selected = false;
            avatar5Selected = false;
            avatar6Selected = false;

            if (avatar3Selected == true)
            {
                pbAvartar1.BorderStyle = BorderStyle.None;
                pbAvartar2.BorderStyle = BorderStyle.None;
                pbAvartar3.BorderStyle = BorderStyle.Fixed3D;
                pbAvartar4.BorderStyle = BorderStyle.None;
                pbAvartar5.BorderStyle = BorderStyle.None;
                pbAvartar6.BorderStyle = BorderStyle.None;

                picSelected.Image = as3;
            }
            else
            {
                pbAvartar3.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            avatar1Selected = false;
            avatar2Selected = false;
            avatar3Selected = false;
            avatar4Selected = true;
            avatar5Selected = false;
            avatar6Selected = false;

            if (avatar4Selected == true)
            {
                pbAvartar1.BorderStyle = BorderStyle.None;
                pbAvartar2.BorderStyle = BorderStyle.None;
                pbAvartar3.BorderStyle = BorderStyle.None;
                pbAvartar4.BorderStyle = BorderStyle.Fixed3D;
                pbAvartar5.BorderStyle = BorderStyle.None;
                pbAvartar6.BorderStyle = BorderStyle.None;

                picSelected.Image = as4;
            }
            else
            {
                pbAvartar4.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            avatar1Selected = false;
            avatar2Selected = false;
            avatar3Selected = false;
            avatar4Selected = false;
            avatar5Selected = true;
            avatar6Selected = false;

            if (avatar5Selected == true)
            {
                pbAvartar1.BorderStyle = BorderStyle.None;
                pbAvartar2.BorderStyle = BorderStyle.None;
                pbAvartar3.BorderStyle = BorderStyle.None;
                pbAvartar4.BorderStyle = BorderStyle.None;
                pbAvartar5.BorderStyle = BorderStyle.Fixed3D;
                pbAvartar6.BorderStyle = BorderStyle.None;

                picSelected.Image = as5;
            }
            else
            {
                pbAvartar5.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            avatar1Selected = false;
            avatar2Selected = false;
            avatar3Selected = false;
            avatar4Selected = false;
            avatar5Selected = false;
            avatar6Selected = true;

            if (avatar6Selected == true)
            {
                pbAvartar1.BorderStyle = BorderStyle.None;
                pbAvartar2.BorderStyle = BorderStyle.None;
                pbAvartar3.BorderStyle = BorderStyle.None;
                pbAvartar4.BorderStyle = BorderStyle.None;
                pbAvartar5.BorderStyle = BorderStyle.None;
                pbAvartar6.BorderStyle = BorderStyle.Fixed3D;

                picSelected.Image = as6;
            }
            else
            {
                pbAvartar6.BorderStyle = BorderStyle.None;
            }
        }
    }
}

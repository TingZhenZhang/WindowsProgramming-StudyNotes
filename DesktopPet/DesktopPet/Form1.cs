using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPet
{
    public partial class Form1 : Form
    {
        bool isMouseDown;
        int downX;
        int downY;

        int movingOffset = 15;

        public Form1()
        {
            InitializeComponent();
        }

        private void gravityTimer_Tick(object sender, EventArgs e)
        {
            int offset = 15;
            petLabel.Top += offset;

            if (petLabel.Top + petLabel.Height >= this.Height)
            {
                int bottomPadding = 30;

                petLabel.Top = this.Height - petLabel.Height - bottomPadding; // 不站低於工具列
                gravityTimer.Enabled = false;
                movingTimer.Enabled = true;
            }
        }

        private void petLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.downX = e.X;
                this.downY = e.Y;
                this.isMouseDown = true;

                gravityTimer.Enabled = false;
                movingTimer.Enabled = false;
                petLabel.Image = (Image)Properties.Resources.ResourceManager.GetObject("gifman_drag_small");
                petLabel.Tag = "DRAG";
            }
        }

        private void petLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isMouseDown == true)
            {
                petLabel.Left += e.X - this.downX;
                petLabel.Top += e.Y - this.downY;
            }
        }

        private void petLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.isMouseDown = false;
                gravityTimer.Enabled = true;
            }
        }

        private void movingTimer_Tick(object sender, EventArgs e)
        {
            int leftPadding = 35;
            int rightPadding = 35;

            if (movingOffset < 0 && !"LEFT".Equals(petLabel.Tag)) // Equals部分，左右兩邊反著寫以避免錯誤
            {
                petLabel.Image = (Image)Properties.Resources.ResourceManager.GetObject("gifman_run_left_small");
                petLabel.Tag = "LEFT";
            }
            else if (movingOffset >= 0 && !"RIGHT".Equals(petLabel.Tag))
            {
                petLabel.Image = (Image)Properties.Resources.ResourceManager.GetObject("gifman_run_right_small");
                petLabel.Tag = "RIGHT";

            }

            petLabel.Left += movingOffset;

            if (petLabel.Left <= 0 - leftPadding)
            {
                petLabel.Left = 0 - leftPadding;
                movingOffset *= -1;
            }
            else if (petLabel.Right >= this.Width + rightPadding)
            {
                petLabel.Left = this.Width - petLabel.Width + rightPadding;
                movingOffset *= -1;
            }
        }
    }
}

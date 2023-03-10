using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame_II
{
    public partial class Form1 : Form
    {
        bool firstPlay = true;
        bool startPlay = false;
        bool clickOnce = false;
        bool constraint = false;
        bool reverse = false;
        double moveX, moveY;
        int originX, originY;
        int ballStep = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Visible = false;
            if (firstPlay)
            {
                originX = ballPic.Left;
                originY = ballPic.Top;
                barBack.Visible = true;
                powerBarPic.Visible = true;
                myPanel.Visible = true;
                ballPic.Visible = true;
                ringPic.Visible = true;
                firstPlay = false;
                playButton.Text = "PLAY AGAIN";
            }
            else
            {
                consoleLabel.Visible = false;
                clickOnce = false;
                constraint = false;
                reverse = false;
                ballPic.Left = originX;
                ballPic.Top = originY;
                ballStep = 0;
            }
            startPlay = true;
            powerBarPic.Width = 0;
            hintLabel.Text = "Click panel once to start power bar.";
        }

        private void myPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (startPlay && !clickOnce)
            {
                hintLabel.Text = "Click panel again to stop power bar.";
                clickOnce = true;
                powerBarTimer.Start();
            }
            else if (clickOnce && !constraint)
            {
                hintLabel.Visible = false;
                hintLabel.Text = "Click button to replay.";
                constraint = true;
                powerBarTimer.Stop();
                ballAct();
                startPlay = false;
            }
        }
       
        private void ballAct()
        {
            double range = (double)powerBarPic.Width / powerBarPic.MaximumSize.Width;
            moveX = (myPanel.Width-ballPic.Right) * range / 10;
            moveY = ballPic.Top * range / 5;
            ballActingTimer.Start();
        }

        private void powerBarTimer_Tick(object sender, EventArgs e)
        {
            int step = 5 * (reverse ? -1 : 1);
            powerBarPic.Width += step;
            if (powerBarPic.Width == powerBarPic.MinimumSize.Width || 
                powerBarPic.Width == powerBarPic.MaximumSize.Width)
            {
                reverse = !reverse;
            }
        }

        private void ballActingTimer_Tick(object sender, EventArgs e)
        {
            if (ballStep < 5)
            {
                ballPic.Top -= (int)moveY;
                moveY *= 0.9;
            }
            else
            {
                moveY /= 0.9;
                ballPic.Top += (int)moveY;
            }
            ballPic.Left += (int)moveX;
            ballStep++;
            if (ballStep >= 10)
            {
                showConsole();
            }
        }


        private void showConsole()
        {
            ballActingTimer.Stop();
            if (ballPic.Left > ringPic.Left-10 && 
                ballPic.Right < ringPic.Right+10)
            {
                consoleLabel.Text = "STRIKE!!";
            }
            else
            {
                consoleLabel.Text = "Try Again :)";
            }
            consoleLabel.Visible = true;
            hintLabel.Visible = true;
            playButton.Visible = true;
        }
    }
}

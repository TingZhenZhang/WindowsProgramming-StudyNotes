using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form1 : Form
    {
        bool startPlay = false;
        bool isKeyDown = false;
        bool reverse = false;
        bool lockPowerBar = false;
        double moveX;
        double moveY;
        int ballActCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            startPlay = true;

            hintLabel.Visible = true;
            powerBar.Visible = true;
            ballPanel.Visible = true;
            ballPic.Visible = true;
            ringPic.Visible = true;

            playButton.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (startPlay && e.KeyCode == Keys.Space)
            {
                hintLabel.Visible = false;
                
                if (!isKeyDown)
                {
                    isKeyDown = true;
                    powerTimer.Start();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (startPlay && e.KeyCode == Keys.Space && !lockPowerBar)
            {
                lockPowerBar = true;
                powerTimer.Stop();

                ballAct();
            }
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            startPlay = true;
            isKeyDown = false;
            reverse = false;
            lockPowerBar = false;
            ballActCount = 0;

            showLabel.Visible = false;
            replayButton.Visible = false;
            replayButton.Enabled = false;
            
            powerBar.Value = 0;
            ballPic.Left = 20;
            ballPic.Top = ballPanel.Height-120;           
        }

        private void ballAct()
        {
            moveX = (ringPic.Left - ballPic.Left) * ((double)powerBar.Value / powerBar.Maximum) / 10;
            moveY = ballPic.Top * ((double)powerBar.Value / powerBar.Maximum) / 5;
            ballActingTimer.Enabled = true;
        }

        private void powerTimer_Tick(object sender, EventArgs e)
        {
            if (!lockPowerBar)
            {
                int offset = 1 * (reverse ? -1 : 1);

                powerBar.Value += offset;
                
                if (powerBar.Value == powerBar.Maximum || powerBar.Value == powerBar.Minimum)
                {
                    reverse = !reverse;
                }
            }
        }

        private void ballActingTimer_Tick(object sender, EventArgs e)
        {
            if (startPlay)
            {
                if (ballActCount > 10)
                {
                    startPlay = false;
                    ballActingTimer.Enabled = false;
                    showConsole();
                }
                if (ballActCount <= 5)
                {
                    ballPic.Top -= (int)moveY;
                    moveY *= 0.9; // 拋物線
                }
                else
                {
                    moveY /= 0.9; // 拋物線
                    ballPic.Top += (int)moveY;
                }
                ballPic.Left += (int)moveX;
                ballActCount++;
            }            
        }

        public void showConsole()
        {
            if (!ballActingTimer.Enabled)
            {
                if (ballPic.Left > ringPic.Left * 0.895 &&
                    ballPic.Left < ringPic.Left * 0.965)
                    showLabel.Text = "STRIKE!!";
                else
                    showLabel.Text = "Try Again :)";
                
                showLabel.Visible = true;
                replayButton.Visible = true;
                replayButton.Enabled = true;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW02_09156146
{
    public partial class HW02_09156146 : Form
    {
        public HW02_09156146()
        {
            InitializeComponent();
        }

        double n = 0.01;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            n = 0.01;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            n = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelOut.Text = "";
            double h = Convert.ToDouble(textBoxHeight.Text);
            double w = Convert.ToDouble(textBoxWeight.Text);
            double BMI = Math.Round(w / Math.Pow((h * n), 2), 2);
            if (h * n > 2.72)
            {
                labelOut.Text = "身高刷新世界紀錄！\n";
            }
            if (w > 635)
            {
                labelOut.Text += "體重刷新世界紀錄！\n";
            }
            if (BMI < 18.5)
            {
                pictureBox1.Image = Properties.Resources.bmi_level_01;
                labelOut.Text += BMI.ToString()+" (過輕)";
            }
            else if (BMI >= 18.5 && BMI < 24)
            {
                pictureBox1.Image = Properties.Resources.bmi_level_02;
                labelOut.Text += BMI.ToString() + " (正常)";
            }
            else if (BMI >= 24 && BMI < 27)
            {
                pictureBox1.Image = Properties.Resources.bmi_level_03;
                labelOut.Text += BMI.ToString() + " (過重)";
            }
            else if (BMI >= 27 && BMI < 30)
            {
                pictureBox1.Image = Properties.Resources.bmi_level_04;
                labelOut.Text += BMI.ToString() + " (肥胖)";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.bmi_level_05;
                labelOut.Text += BMI.ToString() + " (太胖啦)";
            }
        }
    }
}

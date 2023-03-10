using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW03_09156146
{
    public partial class Form1 : Form
    {
        List<String> pic = new List<string>();
        int i = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Start();
            CheckPic();
        }
        
        private void CheckPic()
        {
            pic.Clear();
            if (checkBox1.Checked)
            {
                pic.Add("movie_001");
            }
            if (checkBox2.Checked)
            {
                pic.Add("movie_002");
            }
            if (checkBox3.Checked)
            {
                pic.Add("movie_003");
            }
            if (checkBox4.Checked)
            {
                pic.Add("movie_004");
            }
            if (checkBox5.Checked)
            {
                pic.Add("movie_005");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pic.Count() != 0)
            {
                if (i >= pic.Count())
                    i = 0;
                showPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(pic[i++]);                
            }
            else
            {
                showPictureBox.Image = null;
            }           
        }
        
        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = Convert.ToInt32(secondTextBox.Text)*1000;
            timer1.Start();
            CheckPic();
        }
    }
}

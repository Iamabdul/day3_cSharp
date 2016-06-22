using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_demo2
{
    public partial class Form1 : Form
    {
        int timeLeft = 30;
        


        public Form1()
        {
            InitializeComponent();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            if (timeLeft > 0)
            {
                label6.Text = timeLeft + " of 30 seconds left";
                timeLeft--;

            }
            //else
            //{
            //    timer1.Stop;
            //    label6.Text = "you lost";
            //}
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
            }
        }
    }
}

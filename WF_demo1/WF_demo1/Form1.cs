using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_demo1
{
    //it feels like Form1 is a derivative of the From class in the background???
    public partial class Form1 : Form
    {
        //declared all the values to be used in the form
        string name = "";
        int day = 0;
        string month = "";
        int year = 0;

        //first point of entry after the other first point of entry
        public Form1()
        {
            InitializeComponent();
        }

        //highlighting the actions of the buttons clicked 
        private void button1_Click(object sender, EventArgs e)
        {
            //GET NAME FROM TEXT BOX
            name = textBox1.Text;
            //get date from the datetime picker
            day = dateTimePicker1.Value.Day;
            month = dateTimePicker1.Value.ToString("MMMM");
            year = dateTimePicker1.Value.Year;

            //connecting the variable/object label 3 and defining it for the moment the button is clicked.
            label3.Text = "hello " + name + ", your appointment is at " + day + month + year;

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace listadeevenimente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //reversed stack
        //LILO

        public int intrari = 0;
        public int maxim = 100;

        private void button1_Click(object sender, EventArgs e)
        {
            if (intrari < maxim)
            {
                intrari+=1;
                if (textBox1.Text == "...")
                {
                    // textBox1.Text = intrari.ToString(); 
                    listBox1.Items.Add(intrari.ToString());
                }
                else
                {


                    listBox1.Items.Add(textBox1.Text);
                }
            }
            textBox1.Text = "...";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (intrari > 0)
            {
                listBox1.Items.RemoveAt(intrari - 1);
                intrari-=1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelGuide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string lowertext;
            lowertext = textBox1.Text.ToLower();
            lowertext = textBox2.Text.ToLower();

            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                MessageBox.Show("Welcome to Local Guide!");
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid entry, please try again..");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}

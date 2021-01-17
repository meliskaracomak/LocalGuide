using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TravelGuide
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           string[] array = new string[] {"Adıyaman", "Batman", "Diyarbakır", "Gaziantep",
            "Mardin", "Şanlıurfa"};
            for (int i = 0; i < array.Length; i++)
            {
                comboBox1.Items.Add(array[i]);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Adiyaman ady = new Adiyaman();
                ady.Show();
                this.Hide();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                Batman bat = new Batman();
                bat.Show();
                this.Hide();
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                Diyarbakır db = new Diyarbakır();
                db.Show();
                this.Hide();
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                Gaziantep gzt = new Gaziantep();
                gzt.Show();
                this.Hide();
            }
            else if(comboBox1.SelectedIndex == 4)
            {
                Mardin mrd = new Mardin();
                mrd.Show();
                this.Hide();
            }
            else if(comboBox1.SelectedIndex == 5)
            {
                Sanliurfa snl = new Sanliurfa();
                snl.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}


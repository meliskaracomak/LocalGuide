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
    public partial class Gaziantep : Form
    {
        public Gaziantep()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Gaziantep_Load(object sender, EventArgs e)
        {
            Place pl = new Place();
            pl.CityName = "Gaziantep";
            pl.HisPlace = "Zeugma Museum";
            pl.CityRegion = "South East Anatolian Region";
            pl.PlaceDate = "MO 300";
            pl.PlaceAddress = "Hacı Sani Konukoğlu Blv., 27500 Şehitkamil/Gaziantep";

            label2.Text = pl.CityName.ToUpper().ToString();
            label3.Text = pl.HisPlace.ToString();
            label4.Text = pl.CityRegion.ToString();
            label5.Text = pl.PlaceDate.ToString();
            label6.Text = pl.PlaceAddress.ToString();
        }
    }
}

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
    public partial class Mardin : Form
    {
        public Mardin()
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

        private void Mardin_Load(object sender, EventArgs e)
        {
            City ct = new City();
            ct.CityName = "Mardin";
            ct.HisPlace = "Dara Ruins";
            ct.CityRegion = "South East Anatolian Region";

            string CityName = ct.ShowCity();

            label2.Text = ct.CityName.ToUpper().ToString();
            label3.Text = ct.HisPlace.ToString();
            label4.Text = ct.CityRegion.ToString();

            Place pl = new Place();
            pl.PlaceDate = "MO 530";
            pl.PlaceAddress = "Dara Mardin Nusaybin, Karayolu üzeri, 47100 Artuklu/Mardin";

            label5.Text = pl.PlaceDate.ToString();
            label6.Text = pl.PlaceAddress.ToString();
        }
    }
}

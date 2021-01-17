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
    public partial class Adiyaman : Form
    {
        public Adiyaman()
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

        private void Adiyaman_Load(object sender, EventArgs e)
        {
            City ct = new City();
            ct.CityName = "Adıyaman";
            ct.CityRegion = "South East Anatolia Region";
            ct.HisPlace = "Nemrut Mountain";

            string CityName = ct.ShowCity();

            label2.Text = ct.CityName.ToString().ToUpper();
            label3.Text = ct.CityRegion.ToString();
            label4.Text = ct.HisPlace.ToString();

            Place pl = new Place();
            pl.PlaceDate = "M.O 162";
            pl.PlaceAddress = "Road to Nemrut Mountain, Kahta/Kâhta/Adıyaman";

            label5.Text = pl.PlaceDate.ToString();
            label6.Text = pl.PlaceAddress.ToString();
        }
    }
}

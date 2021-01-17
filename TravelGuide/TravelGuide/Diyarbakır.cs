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
    public partial class Diyarbakır : Form
    {
        public Diyarbakır()
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

        private void Diyarbakır_Load(object sender, EventArgs e)
        {
            City ct = new City();
            ct.CityName = "Diyarbakır";
            ct.CityRegion = "South East Anatolian Region";
            ct.HisPlace = "Malabadi Bridge";

            string CityName = ct.ShowCity();

            label2.Text = ct.CityName.ToString().ToUpper();
            label3.Text = ct.CityRegion.ToString();
            label4.Text = ct.HisPlace.ToString();

            Place pl = new Place();
            pl.PlaceDate = "MS 1147";
            pl.PlaceAddress = "Çatakköprü, 21640 Silvan/Diyarbakır";

            label5.Text = pl.PlaceDate.ToString();
            label6.Text = pl.PlaceAddress.ToString();
        }
    }
}

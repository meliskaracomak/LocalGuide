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
    public partial class Batman : Form
    {
        public Batman()
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

        private void Batman_Load(object sender, EventArgs e)
        {
            Place pl = new Place();
            pl.CityName = "Batman";
            pl.CityRegion = "South East Anatolian Region";
            pl.HisPlace = "Hasankeyf Castle";
            pl.PlaceDate = "Historical Antiquity";
            pl.PlaceAddress = "Tigris River/Hasankeyf";

            label2.Text = pl.CityName.ToString().ToUpper();
            label3.Text = pl.CityRegion.ToString();
            label4.Text = pl.HisPlace.ToString();
            label5.Text = pl.PlaceDate.ToString();
            label6.Text = pl.PlaceAddress.ToString();
        }

       
    }
}

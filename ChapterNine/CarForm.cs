using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapterNine
{
    public partial class CarForm : Form
    {
        Car car = new Car();
        public CarForm()
        {
            InitializeComponent();
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            car.brakeCar();

            lblSpeed.Text = car.Speed.ToString();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            if (!car.Start)
            {
                label2.Text = "Start the car";
            }
            car.accelerate();
            lblSpeed.Text =  car.Speed.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            car.Make = "China";
            car.Year = "2023";
            car.Start = true;
            label2.Text = "";
        }
    }
}

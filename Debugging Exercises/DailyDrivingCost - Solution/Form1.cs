using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DailyDrivingCostForm
{
    public partial class Form1 : Form
    {
        public  double parkingFees; // parking fees per day
        public double tolls; // tolls per day
        public double KMsDriven;
        public double costPerLitre;
        public double averageKMsperLitre;

        public Form1()
        {
            InitializeComponent();
        }

        public void GetInput()
        {
            try
            {
                KMsDriven = Convert.ToDouble(txtKMsDriven.Text);
                costPerLitre = Convert.ToDouble(txtCostPerLitre.Text);
                averageKMsperLitre = Convert.ToDouble(txtAverageKMsPerLitre.Text);
                parkingFees = Convert.ToDouble(txtParkingFees.Text);
                tolls = Convert.ToDouble(txtTolls.Text);
            }
            catch { MessageBox.Show("Error"); }
        }
        public string CalculateOutput()
        {
            // calculate and display daily driving cost
            return ("Your daily driving cost is " + (costPerLitre / 100.0 * KMsDriven / averageKMsperLitre +
               parkingFees / 100.0 + tolls / 100.0).ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetInput();
            MessageBox.Show(CalculateOutput());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetYearToListBox_Click(object sender, EventArgs e)
        {
            int i_StartYear;
            int i_Year;
            int i_NumberOfYear = 10;

            int.TryParse(txtStartYear.Text, out i_StartYear);   //convert into int and store in variable i_StartYear

            lstYear.Items.Clear();      //to clear items in the list

            for (i_Year = i_StartYear; i_Year <= i_StartYear + i_NumberOfYear; i_Year++)
            {
                lstYear.Items.Add(i_Year.ToString());   //add item into the list
            }


            int i_Day;

            cbbDay.Items.Clear();
            for (i_Day = 1; i_Day<=31; i_Day++)
            {
                cbbDay.Items.Add(i_Day.ToString());
            }

            //lstYear.Items.Add("Hello");
            //lstYear.Items.Add("Good day!");
            //lstYear.Items.Add(txtStartYear.Text);     //add text in textbook into the list
        }

        private void btnGetItem_Click(object sender, EventArgs e)
        {
            string s_Year;
            string s_Day;

            s_Year = lstYear.SelectedItem.ToString();
            s_Day = cbbDay.SelectedItem.ToString();

            MessageBox.Show(s_Year + ", " + s_Day);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            lstYear.Items.RemoveAt(lstYear.SelectedIndex);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_4___Loop___Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstLeft.Items.Clear();
            lstRight.Items.Clear();
            
            lstRight.Items.Add("Nick");
            lstRight.Items.Add("John");
            lstRight.Items.Add("Sam");
            lstRight.Items.Add("Paul");
            lstRight.Items.Add("Rob");
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            lstLeft.Items.Add(txtAddName.Text);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (lstLeft.SelectedItem.ToString() == lstRight.SelectedItem.ToString())
            { MessageBox.Show("Match"); }
            else { MessageBox.Show("Mismatch"); }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string s_SearchName;
            bool b_isFound = false;
            int i_counter;

            s_SearchName = txtSearchName.Text;

            //if (lstLeft.Items.Contains(s_SearchName) == true)
            //{ b_isFound = true; }

            //if (lstRight.Items.Contains(s_SearchName) == true)
            //{ b_isFound = true; }

            for (i_counter = 0; i_counter <= lstLeft.Items.Count - 1; i_counter++)
            {
                if (s_SearchName == lstLeft.Items[i_counter].ToString())
                { b_isFound = true; }
            }

            for (i_counter = 0; i_counter <= lstRight.Items.Count - 1; i_counter++)
            {
                if (s_SearchName == lstRight.Items[i_counter].ToString())
                { b_isFound = true; }
            }

            if (b_isFound == true) { MessageBox.Show("Found"); }
            else { MessageBox.Show("Not found"); };
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Good morning! You all are awesome.");

            ////This is to show tab index
            //MessageBox.Show(txtOne.TabIndex.ToString());

            txtTwo.Text = txtOne.Text;

            lblListOne.Text = cboOne.Text;
            lblListTwo.Text = cboTwo.Text;
            lblListThree.Text = cboThree.Text;
            lblListFour.Text = lstFour.Text;

            lblOne.ForeColor=Color.Blue;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOne.Text = "";
            txtTwo.Text = "";
        }

        private void GetDataFromUser()
        {

        }
    }
}

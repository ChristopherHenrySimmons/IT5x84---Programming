using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //m_Demo();
        }

        private void m_Demo()
        {
            //Some codes go here
            txtCopy.Text = "Hello " + txtGrade.Text;

        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {
            //m_Demo();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //txtGrade.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            m_Demo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGrade.Text = "";
            txtCopy.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i_number = Convert.ToInt32(txtGrade.Text);
            txtCopy.Text = (i_number + 5).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            string ab;
            string s_Name;
            //The following code does encryption
            //Source: thehackers.org
            //all the codes you copied

        }
    }
}

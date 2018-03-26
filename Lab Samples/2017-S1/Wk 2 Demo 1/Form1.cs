using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk_3_Demo_1
{
    public partial class Form1 : Form
    {
        string s_name;
        int i_age;
        string s_gender;
        string s_ethnic;
        public Form1()
        {
            InitializeComponent();
        }

        private void m_GetInputFromForm()
        {
            s_name = txtName.Text;
            int.TryParse(txtAge.Text, out i_age);
            s_gender = txtGender.Text;
            s_ethnic = txtEthnic.Text;

        }
        private void m_DisplayMessage()
        {
            string s_msg;
            //s_msg = "Name: " + s_name;
            //s_msg = s_msg + "Age: " + i_age.ToString();
            //s_msg = s_msg + "Gender: " + s_gender;

            s_msg = "Name: " + s_name + Environment.NewLine +
                "Age: " + i_age.ToString() + Environment.NewLine +
                "Gender: " + s_gender + Environment.NewLine +
                "Ethnicity: " + s_ethnic + Environment.NewLine +
                "Category: " + m_CheckAge();

            MessageBox.Show(s_msg, "Details", MessageBoxButtons.YesNoCancel);
        }

        private string m_CheckAge()
        {
            string s_result="";

            if (i_age < 18) { s_result = "underage"; }
            else { s_result = "adult"; }

            return s_result;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            m_GetInputFromForm();
            m_DisplayMessage();
        }
    }
}

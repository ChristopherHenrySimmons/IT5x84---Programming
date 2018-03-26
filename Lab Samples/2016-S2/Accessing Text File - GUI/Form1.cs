using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accessing_Text_File___GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            m_LoadFile();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            m_ReadFile();
        }

        private void m_ReadFile()
        {
            txtFileContent.Text = System.IO.File.ReadAllText(lblSelectedFile.Text);
        }

        private void m_LoadFile()
        {
            dlg_OpenFile.ShowDialog();

            lblSelectedFile.Text = dlg_OpenFile.FileName;

            m_ReadFile();
        }
    }
}

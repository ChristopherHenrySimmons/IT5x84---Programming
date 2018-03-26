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

        private void m_ClearLists()
        {
            lstLeft.Items.Clear();
            lstRight.Items.Clear();
        }

        private void m_AddListInitialItems()
        {
            lstRight.Items.Add("Nick");
            lstRight.Items.Add("John");
            lstRight.Items.Add("Sam");
            lstRight.Items.Add("Paul");
            lstRight.Items.Add("Rob");
        }

        private void m_AddNameToList(string NameToAdd, ref ListBox ListBoxToAdd)
        {
            ListBoxToAdd.Items.Add(NameToAdd);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            m_ClearLists();
            m_AddListInitialItems();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            m_AddNameToList(txtAddName.Text, ref lstLeft);
        }

        private string m_CompareListBoxes(ListBox FirstListbox, ListBox SecondListBox)
        {
            if (FirstListbox.SelectedItem.ToString() == SecondListBox.SelectedItem.ToString())
            { return "Match"; }
            else { return "Mismatch"; }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m_CompareListBoxes(lstLeft, lstRight));
        }

        private Boolean m_SearchForName (ListBox ListBoxToSearch, string NameToSearch)
        {
            return ListBoxToSearch.Items.Contains(NameToSearch);
        }
        private void btnSearchName_Click(object sender, EventArgs e)
        {
            if ((m_SearchForName(lstLeft, txtSearchName.Text)) || 
                m_SearchForName(lstRight,txtSearchName.Text)) 
                { MessageBox.Show("Found"); }
            else { MessageBox.Show("Not found"); };
        }
    }
}

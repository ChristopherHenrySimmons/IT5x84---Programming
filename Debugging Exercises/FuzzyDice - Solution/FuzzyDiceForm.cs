// Exercise 14.9 Solution: FuzzyDiceForm.cs
// Application that allows user to order fuzzy dice,
// specifying the type and amount of dice.
using System;
using System.Windows.Forms;

namespace FuzzyDice
{
   public partial class FuzzyDiceForm : Form
   {
        public void m_MessageCheckItemToPurchase()
        {
            MessageBox.Show(
               "Please check item you wish to purchase",
               "No Item Selected", MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);
        }

        public void m_MessageFillAllInfo()
        {
            MessageBox.Show(
               "Please fill out all information fields.",
               "Empty Fields", MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);
        }

        public void m_MessagePositiveNumber()
        {
            MessageBox.Show(
               "Please enter a positive quantity",
               "Bad Input", MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);
        }

        public Boolean m_CheckIfEmpty()
        {
            if (string.IsNullOrEmpty(orderNumberTextBox.Text) ||
                string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrEmpty(addressLine1TextBox.Text) ||
                string.IsNullOrEmpty(addressLine2TextBox.Text) )
            { return true; }
            else { return false; }
        }

        public void m_CheckValue()
        {
            if (string.IsNullOrWhiteSpace(txtManagerDiscount.Text)) { txtManagerDiscount.Text = "0"; }
            if (string.IsNullOrWhiteSpace(whiteBlackTextBox.Text)) { whiteBlackTextBox.Text = "0"; }
            if (string.IsNullOrWhiteSpace(redBlackTextBox.Text)) { redBlackTextBox.Text = "0"; }
            if (string.IsNullOrWhiteSpace(blueBlackTextBox.Text)) { blueBlackTextBox.Text = "0"; }
        }

        public void m_TextChanged(string SelectedColor)
        {
            try
            {
                switch (SelectedColor)
                {
                    case "White/Black":
                        int numberOfWhiteBlack = Convert.ToInt32(whiteBlackTextBox.Text);

                        if (numberOfWhiteBlack != 0 && whiteBlackCheckBox.Checked == false)
                        { whiteBlackTextBox.Text = "0"; m_MessageCheckItemToPurchase(); }
                        else if (m_CheckIfEmpty())
                        { m_MessageFillAllInfo(); }
                        else if (numberOfWhiteBlack < 0)
                        { whiteBlackTextBox.Text = "0"; m_MessagePositiveNumber(); }
                        else { CalculateAndDisplayTotals(); }
                        break;

                    case "Red/Black":
                        int numberOfRedBlack = Convert.ToInt32(redBlackTextBox.Text);

                        if (numberOfRedBlack != 0 && redBlackCheckBox.Checked == false)
                        { redBlackTextBox.Text = "0"; m_MessageCheckItemToPurchase(); }
                        else if (m_CheckIfEmpty())
                        { m_MessageFillAllInfo(); }
                        else if (numberOfRedBlack < 0)
                        { redBlackTextBox.Text = "0"; m_MessagePositiveNumber(); }
                        else { CalculateAndDisplayTotals(); }
                        break;

                    case "Blue/Black":
                        int numberOfBlueBlack = Convert.ToInt32(blueBlackTextBox.Text);

                        if (numberOfBlueBlack != 0 && blueBlackCheckBox.Checked == false)
                        { blueBlackTextBox.Text = "0"; m_MessageCheckItemToPurchase(); }
                        else if (m_CheckIfEmpty())
                        { m_MessageFillAllInfo(); }
                        else if (numberOfBlueBlack < 0)
                        { blueBlackTextBox.Text = "0"; m_MessagePositiveNumber(); }
                        else { CalculateAndDisplayTotals(); }
                        break;
                }
            }
            catch { }
        }

      public FuzzyDiceForm()
      {
         InitializeComponent();
      } 

      private void whiteBlackTextBox_TextChanged(object sender, EventArgs e )
      {
            m_TextChanged("White/Black");
      }

      private void redBlackTextBox_TextChanged(object sender, EventArgs e )
      {
            m_TextChanged("White/Black");
      } 

      private void blueBlackTextBox_TextChanged(object sender, EventArgs e )
      {
            m_TextChanged("Blue/Black");
      }

      private void clearButton_Click( object sender, EventArgs e )
      {
         orderNumberTextBox.Text = "0";
         nameTextBox.Text = "Enter name here";
         addressLine1TextBox.Text = "Address Line 1";
         addressLine2TextBox.Text = "Address Line 2";
         cityStateZipTextBox.Text = "City, State, zip";
         whiteBlackTextBox.Text = "0";
         redBlackTextBox.Text = "0";
         blueBlackTextBox.Text = "0";
         whiteBlackLabel.Text = "$0.00";
         redBlackLabel.Text = "$0.00";
         blueBlackLabel.Text = "$0.00";
         subtotalLabel.Text = "$0.00";
         taxLabel.Text = "$0.00";
         shippingLabel.Text = "$0.00";
         totalLabel.Text = "$0.00";
         whiteBlackCheckBox.Checked = false;
         redBlackCheckBox.Checked = false;
         blueBlackCheckBox.Checked = false;

            txtManagerDiscount.Text = "0";
      } 

      private void whiteBlackCheckBox_CheckedChanged(object sender, EventArgs e )
      {
         whiteBlackTextBox.Text = "0";
         whiteBlackLabel.Text = "0";
         CalculateAndDisplayTotals();
      } 

      private void redBlackCheckBox_CheckedChanged(object sender, EventArgs e )
      {
         redBlackTextBox.Text = "0";
         redBlackLabel.Text = "0";
         CalculateAndDisplayTotals();
      } 

      private void blueBlackCheckBox_CheckedChanged(object sender, EventArgs e )
      {
         blueBlackTextBox.Text = "0";
         blueBlackLabel.Text = "0";
         CalculateAndDisplayTotals();
      }

      private void CalculateAndDisplayTotals()
        {
            try {
                m_CheckValue();

                decimal whiteBlackTotals = Convert.ToDecimal(whiteBlackTextBox.Text) * 6.25M;
                decimal redBlackTotals = Convert.ToDecimal(redBlackTextBox.Text) * 5M;
                decimal blueBlackTotals = Convert.ToDecimal(blueBlackTextBox.Text) * 7.5M;

                whiteBlackLabel.Text = string.Format("{0:C}", whiteBlackTotals);
                redBlackLabel.Text = string.Format("{0:C}", redBlackTotals);
                blueBlackLabel.Text = string.Format("{0:C}", blueBlackTotals);

                decimal subtotal = whiteBlackTotals + redBlackTotals + blueBlackTotals;
                decimal managerDiscount = Convert.ToDecimal(txtManagerDiscount.Text);

                subtotal = subtotal * (1 - managerDiscount / 100M);
                subtotalLabel.Text = string.Format("{0:C}", subtotal);

                decimal tax = subtotal * 0.05M;
                taxLabel.Text = string.Format("{0:C}", tax);

                decimal shippingCost = 0M;
                if (subtotal < 100M) { shippingCost = 1.5M; }
                shippingLabel.Text = string.Format("{0:C}", shippingCost);

                decimal totalCharge = subtotal + tax + shippingCost;
                totalLabel.Text = string.Format("{0:C}", totalCharge);
            }
        catch{ }
        }

      private void txtManagerDiscount_TextChanged(object sender, EventArgs e)
        {
                CalculateAndDisplayTotals();
        }
    }
}
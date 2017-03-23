/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Comments by the prof:
*
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Project 2 Fuzzy Dice Order Form
*Created by Ryu Muthui
*Date 11/15/2013
*Class: CS 218
*Time: 4 hours 30 minutes
*Platform: PC, Windows 7, C#.NET 2010
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*This application is an invoice order form that allows the user
*to input quantities of dice that they wish to order from the
*Fuzzy Dice Company. The user can select to enter 0-99 for each
*type of order. It calculates the total order according to the
*set prices. For orders of $500 or more a discount of 7% is applied
*before taxes (at a rate of 8.25%). For orders greater than 20 items
*the shipping is free. The user can also select from a dropdown
*menu to choose other shipping options and charged accordingly.

*Required input:
*   1.  Number of Each Item Purchased.
*   2.  Customer name, shipping destination.
*  Customer Name
*  SubTotal
*  Discount Amount
*  Applicable Tax Amount
*  Shipping charge
*  Total cost of order
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Comments by the student:
*
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FuzzyDiceOrderForm
{
    public partial class frmFuzzyDiceOrderForm : Form
    {
        //Class level constants declaration.
        const decimal PRICE_WHITE_BLACK_DICE = 6.25m,
                      PRICE_RED_WHITE_DICE = 5.00m,
                      PRICE_BLUE_BLACK_DICE = 7.50m,
                      PRICE_UPS_GROUND = 2.95m,
                      PRICE_UPS_THEEDAY = 6.95m,
                      PRICE_UPS_NEXTDAY = 15.95m;

        const double TAX_RATE = 0.0825,
                     DISCOUNT = 0.07;

        const int MAX_ORDER_NUMBER = 10000, 
                  QUALIFYING_DISCOUNT_AMOUNT = 500;

        /**
         * Create a random object and assign it between 1-9999 for order number.
         * Set approprite price to item price labels via constants variables.
         * Set Selected index to default to 0.
         **/
        public frmFuzzyDiceOrderForm()
        {

            InitializeComponent();
            Random randOrderNumber = new Random();
            int randomOrderNumber = randOrderNumber.Next(0, MAX_ORDER_NUMBER);
            lblActualOrderNumber.Text = randomOrderNumber.ToString();

            lblWhiteBlackPrice.Text = PRICE_WHITE_BLACK_DICE.ToString("c");
            lblBlueBlackPrice.Text = PRICE_BLUE_BLACK_DICE.ToString("c");
            lblRedWhitePrice.Text = PRICE_RED_WHITE_DICE.ToString("c");

            cboShippingType.SelectedIndex = 0;

        }

        /**
         *Exits the application when selected
         **/
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         *Calls the button exit event handler to exit program
         **/
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            btnExit.PerformClick();
        }

        /**
         *First clears the lstDisplay (for any previous entries) and displays the customer's shipping information.
         *Calls all the Calculate Methods to set amounts into the approprite variables that are then used
         *to display all of the shipping information.
         **/
        private void btnDisplayBill_Click(object sender, EventArgs e)
        {

            string strCustomerName = txtName.Text;
            decimal decSubTotal = CalculateSubTotal(),
                    decDiscount = CalculateDiscount(),
                    decTax = CalculateTax(),
                    decShipping = CalculateShippingCharges(),
                    decTotal= CalculateTotal();

            if (txtName.Text.Length <= 0)
            {
                MessageBox.Show("Enter Customer Information", "Missing Information");
                txtName.Focus();
            }
            else
            {
                lstDisplay.Items.Clear();
                String strFormatter = "{0,-8} {1, 33}";

                lstDisplay.Items.Add(String.Format(strFormatter, "Customer", strCustomerName));
                lstDisplay.Items.Add(String.Format(strFormatter, "Subtotal", decSubTotal.ToString("c")));
                lstDisplay.Items.Add(String.Format(strFormatter, "Discount", "-" + decDiscount.ToString("c")));
                lstDisplay.Items.Add(String.Format(strFormatter, "Tax", decTax.ToString("c")));
                lstDisplay.Items.Add(String.Format(strFormatter, "Shipping", decShipping.ToString("c")));
                lstDisplay.Items.Add("------------------------------------------");
                lstDisplay.Items.Add(String.Format(strFormatter, "Total", decTotal.ToString("c")));
            }
        }

        /**
         * Clears all the customer information text boxes and calls
         * the button Clear to clear the lstDisplay and resets the form
         * so that the user can enter a new order.
         * */
        private void btnNewOrder_Click(object sender, EventArgs e)
        {

            //increment the order # by one, if at maximum, set it to 0
            int intOrderNumber = Convert.ToInt16(lblActualOrderNumber.Text);

            if (intOrderNumber < MAX_ORDER_NUMBER)
            {
                lblActualOrderNumber.Text = (intOrderNumber + 1).ToString();
            }
            else
            {
                lblActualOrderNumber.Text = 0.ToString();
            }

            //clear text fields
            txtCity.Clear();
            txtName.Clear();
            txtState.Clear();
            txtAddress.Clear();
            txtBlueBlackQuantity.Clear();
            txtRedWhiteQuantity.Clear();
            txtWhiteBlackQuantity.Clear();
            btnClear.PerformClick();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            //Print the entier GUI form
            pfFuzzyDiceOrderForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            pfFuzzyDiceOrderForm.Print();
        }

        /**
         *Clears the lstDisplay box of any text and resets the checkbox's
         *state back to default.
         **/
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            chkWhiteBlack.Checked = false;
            chkRedWhite.Checked = false;
            chkBlueBlack.Checked = false;
        }

        /**
         * Create an object of the about form and 
         * Displays the about form when selected.
         **/
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutFuzzyDice AboutForm = new AboutFuzzyDice();
            AboutForm.Visible = true;
        }


        /**
         * Sycronizes the White Black Check box with the file Menu type.
         * Enables the White Black Text box so that user can input entry.
         * If unchecked clear the text box and disable entry.
         **/
        private void chkWhiteBlack_CheckedChanged(object sender, EventArgs e)
        {
            mnuTypeWhiteBlack.Checked = !mnuTypeWhiteBlack.Checked;
            if (chkWhiteBlack.Checked)
            {
                txtWhiteBlackQuantity.Enabled = true;
                txtWhiteBlackQuantity.Focus();
                txtWhiteBlackQuantity.SelectAll();
            }
            else
            {
                txtWhiteBlackQuantity.Enabled = false;
                txtWhiteBlackQuantity.Clear();
            }
        }


        /**
         * Sycronizes the Red White Check box with the file Menu type.
         * Enables the Red White Text box so that user can input entry.
         * If unchecked clear the text box and disable entry.
         **/
        private void chkRedWhite_CheckedChanged(object sender, EventArgs e)
        {
            mnuTypeRedWhite.Checked = !mnuTypeRedWhite.Checked;
            if (chkRedWhite.Checked)
            {
                txtRedWhiteQuantity.Enabled = true;
                txtRedWhiteQuantity.Focus();
                txtRedWhiteQuantity.SelectAll();
            }
            else
            {
                txtRedWhiteQuantity.Enabled = false;
                txtRedWhiteQuantity.Clear();
            }
        }

        /**
         * Sycronizes the Bluck Black Check box with the file Menu type.
         * Enables the Blue Black Text box so that user can input entry.
         * If unchecked clear the text box and disable entry.
         **/
        private void chkBlueBlack_CheckedChanged(object sender, EventArgs e)
        {
            mnuTypeBlueBlack.Checked = !mnuTypeBlueBlack.Checked;
            if (chkBlueBlack.Checked)
            {
                txtBlueBlackQuantity.Enabled = true;
                txtBlueBlackQuantity.Focus();
                txtBlueBlackQuantity.SelectAll();
            }
            else
            {
                txtBlueBlackQuantity.Enabled = false;
                txtBlueBlackQuantity.Clear();
            }
        }

        /**
         * Triggers the mnuWhiteBlack chcked property which in turn also
         * triggers the chkWhiteBlack checked property back and forth.
         **/
        private void mnuTypeWhiteBlack_Click(object sender, EventArgs e)
        {
            chkWhiteBlack.Checked = !chkWhiteBlack.Checked;
        }

        /**
         * Triggers the mnuRedWhite chcked property which in turn also
         * triggers the chkRedWhite checked property back and forth.
         **/
        private void mnuTypeRedWhite_Click(object sender, EventArgs e)
        {
            chkRedWhite.Checked = !chkRedWhite.Checked;
        }

        /**
         * Triggers the mnuBlueBlack checked property which in turn also
         * triggers the chkBlueBlack checked property back and forth.
         **/
        private void mnuTypeBlueBlack_Click(object sender, EventArgs e)
        {
            chkBlueBlack.Checked = !chkBlueBlack.Checked;
        }


        // Calculate the tax from the value gained through subtotal method
        /**
         * A decimal Method to calculate the tax amount of the order form.
         * Returns a decimal value in the variable decTaxAmount.
         * Called by btnDisplayBill.click.
         **/
        private decimal CalculateTax()
        {
            decimal decSubTotal = CalculateSubTotal(),
                    decDiscount = CalculateDiscount();
            decimal decTaxAmount = (decSubTotal - decDiscount) * Convert.ToDecimal(TAX_RATE);
            return decTaxAmount;
        }


        /**
         * A decimal Method to calculate the subtotal of the order form.
         * Returns a decimal value in the variable subtotal.
         * Called by btnDisplayBill.click.
         **/
        private decimal CalculateSubTotal()
        {
            //variables used to calculate subtotal value of order.
            decimal decWhiteBlack = 0m,
                    decBlueBlack = 0m,
                    decRedWhite = 0m,
                    decSubTotal = 0m;

            //check any of the quantity textbox has values in them.
            //If greater than 1, calculate the amount otherwise do nothing.

            if (txtWhiteBlackQuantity.Text.Length > 0)
            {
                decWhiteBlack = Convert.ToDecimal(txtWhiteBlackQuantity.Text) * PRICE_WHITE_BLACK_DICE;
            }

            if (txtRedWhiteQuantity.Text.Length > 0)
            {
                decRedWhite = Convert.ToDecimal(txtWhiteBlackQuantity.Text) * PRICE_RED_WHITE_DICE;
            }

            if (txtBlueBlackQuantity.Text.Length > 0)
            {
                decBlueBlack = Convert.ToDecimal(txtWhiteBlackQuantity.Text) * PRICE_BLUE_BLACK_DICE;
            }

            //Add all the order types to get a subtotal and return this value.
            decSubTotal = decWhiteBlack + decBlueBlack + decRedWhite;
            return decSubTotal;
        }

        /**
         * A decimal Method to calculate the discount of the order form.
         * Returns a decimal value in the variable decDiscountAmount.
         * Called by btnDisplayBill.click.
         **/
        private decimal CalculateDiscount()
        {
            //variables used to calculate discount value of order.
            decimal decDiscountAmount = 0m,
                    decSubtotal = CalculateSubTotal();

            //Calculate discount
            if (decSubtotal > QUALIFYING_DISCOUNT_AMOUNT)
            {
                decDiscountAmount = (decSubtotal * Convert.ToDecimal(DISCOUNT));
            }

            return decDiscountAmount;
        }


        /**
         * A decimal Method to calculate the total cost of the order form.
         * Returns a decimal value in the variable decTotal.
         * Called by btnDisplayBill.click.
         **/
        private decimal CalculateTotal()
        {
            decimal decTotal = CalculateSubTotal() - CalculateDiscount() + CalculateTax() + CalculateShippingCharges();
            return decTotal;
        }

        /**
         * A decimal Method to calculate the shipping charges of the order form.
         * Returns a decimal value in the variable decShippingCharges.
         * Called by btnDisplayBill.click.
         **/
        private decimal CalculateShippingCharges()
        {
            //variable used to hold shipping charge amount.
            decimal decShippingCharge = 0m;

            //variable used to determine if shipping discount applys or not.
            int amountOrdered = CalculateShippingQuantity();


            if (cboShippingType.SelectedIndex == 0)
            {
                if (amountOrdered == 0)
                {
                    decShippingCharge = 0m;
                }
                else if (amountOrdered < 20 && amountOrdered > 1)
                {
                    decShippingCharge = PRICE_UPS_GROUND;
                }
            }
            else if (cboShippingType.SelectedIndex == 1)
            {
                decShippingCharge = PRICE_UPS_THEEDAY;
            }
            else
            {
                decShippingCharge = PRICE_UPS_NEXTDAY;
            }

            return decShippingCharge;
        }




        /**
         * A integer Method to calculate the shipping quantity amount of the order form.
         * Returns a integer value in the variable intTotalAmount used for calculating Shipping Charges.
         * Called by btnDisplayBill.click.
         **/

        private int CalculateShippingQuantity()
        {
            //variables used to calculate shipping amount quantity value of order.
            int intWhiteBlack = 0,
                intBlueBlack = 0,
                intRedWhite = 0,
                intTotalAmount = 0;

            //check any of the quantity textbox has values in them.
            //If greater than 1, calculate the amount otherwise do nothing.

            if (txtWhiteBlackQuantity.Text.Length > 0)
            {
                intWhiteBlack = Convert.ToInt16(txtWhiteBlackQuantity.Text);
            }

            if (txtRedWhiteQuantity.Text.Length > 0)
            {
                intRedWhite = Convert.ToInt16(txtWhiteBlackQuantity.Text);
            }


            if (txtBlueBlackQuantity.Text.Length > 0)
            {
                intBlueBlack = Convert.ToInt16(txtWhiteBlackQuantity.Text);
            }

            //Add all the order types to get a total quantity  and return this value.
            intTotalAmount = intWhiteBlack + intBlueBlack + intRedWhite;
            return intTotalAmount;
        }



        /**
        * A private void method to limit the user's entry into the textbox as numerical digits
        * only and the back space to delete in hopes of avoiding a try catch method of error handling.
        * Called by each dice quantity entry text box.
        **/
        private void AllowedEntry(KeyPressEventArgs e)
        {
            string allowedCharacterSet = "0123456789\b";

            if (allowedCharacterSet.Contains(e.KeyChar.ToString()))
            {
                //if they are valid entry do nothing.
            }
            else
            {
                e.Handled = true;
            }
        }

        /**
         * Calls the AllowdEntry Method to limit user input in text box to 
         * numerical values only.
         **/
        private void txtWhiteBlack_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowedEntry(e);
        }

        /**
         * Calls the AllowdEntry Method to limit user input in text box to 
         * numerical values only.
         **/
        private void txtRedWhite_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowedEntry(e);
        }

        /**
         * Calls the AllowdEntry Method to limit user input in text box to 
         * numerical values only.
         **/
        private void txtBlueBlack_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowedEntry(e);
        }

        /**
         * Calls the btnClear click to clear the form.
         **/
        private void mnuFileClear_Click(object sender, EventArgs e)
        {
            btnClear.PerformClick();
        }

        /**
        *Calls the button print event handler to print GUI.
        **/
        private void mnuFilePrintInvoice_Click(object sender, EventArgs e)
        {
            btnPrintInvoice.PerformClick();
        }

        /**
        *Calls the button Display event handler to display order.
        **/
        private void mnuFileDisplayBill_Click(object sender, EventArgs e)
        {
            btnDisplayBill.PerformClick();
        }

        /**
        *Calls the button New Order event handler to clear form for new order entry.
        **/
        private void mnuFileNewOrder_Click(object sender, EventArgs e)
        {
            btnNewOrder.PerformClick();
        }

        //Makes the cboShipping dynamic if there is items in the lstDisplay.
        private void cboShippingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDisplay.Items.Count > 0)
            {
                btnDisplayBill.PerformClick();
            }
        }


    }
}

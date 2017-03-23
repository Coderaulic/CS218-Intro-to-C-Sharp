/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Comments by the prof:
*
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Project #1-- Gini's Quilt Works
*Created by Ryu Muthui
*Date: 10/16/2013
*Project Name: QuiltWorks
*Time: 3 hour 30 minutes
*Version:	1.01
*Platform: PC, Window 7, Visual Studios 2010
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Description:	
*This porgram is an invoice sample program for Gini's Quilt Works company. 
*It provides calculation for purchasing quilt works with tax rate applied.
*Currently there are 3 sample item products and it calculates the subtotal
*of all selected items, applies the tax rate, and displays the total cost.
*Required input:
*4 digit invoice number, selection of item quantity.
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Comments by the student:
*
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GiniQuiltWorks
{
    public partial class frmQuiltWorks : Form
    {
        public frmQuiltWorks()
        {
            InitializeComponent();
            //set the current date to the form and prices
            lblCurrentDate.Text = DateTime.Now.ToString("d");
            lblPriceQuiltOne.Text = "$950.00";
            lblPriceQuiltTwo.Text = "$480.00";
            lblPriceQuiltThree.Text = "$315.00";
        }

        //variable and const declaration
        const decimal TAX_RATE = 0.098m;
        const decimal QUILT_ONE_PRICE = 950m;
        const decimal QUILT_TWO_PRICE = 480m;
        const decimal QUILT_THEE_PRICE = 315m;
        decimal decQuiltOneTotalPrice = 0m;
        decimal decQuiltTwoTotalPrice = 0m;
        decimal decQuiltThreeTotalPrice = 0m;

        int invoiceNumber = 0;

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }

        private void mnuFileQuit_Click(object sender, EventArgs e)
        {
            //Calls the Quit button function to exit application
            btnQuit_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears the form to default state
            mtxtInvoiceID.Text = null;
            updQuiltOne.Value = 0;
            updQuiltTwo.Value = 0;
            updQuiltThree.Value = 0;
            lblQuiltOneSubTotal.Text = "$0.00";
            lblQuiltTwoSubTotal.Text = "$0.00";
            lblQuiltThreeSubTotal.Text = "$0.00";
            lblQuiltSubTotal.Text = "$0.00";
            lblQuiltTax.Text = "$0.00";
            lblTotalCost.Text = "$0.00";
            mtxtInvoiceID.Focus();

            // make sure to set the variables to 0 value
            decQuiltOneTotalPrice = 0m;
        }

        private void mnuFileClear_Click(object sender, EventArgs e)
        {
            //Call the Clear button to clear form
            btnClear.PerformClick();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //Declared variables for calculations
            decimal decTaxAmount = 0m;
            decimal decTotalCost = 0m;
            decimal decSubTotal = 0m;

            //Check to see if user has entered an invoice number or if already proceed to calculations
            if (mtxtInvoiceID.Text == "")
            {
                MessageBox.Show("Please Enter an Invoic Number.", "Invalid Invoice Number");
                mtxtInvoiceID.SelectAll();
                mtxtInvoiceID.Focus();
            }
            else
            {

                //Calculation
                decSubTotal = decQuiltOneTotalPrice + decQuiltTwoTotalPrice + decQuiltThreeTotalPrice;
                decTaxAmount = decSubTotal * TAX_RATE;
                decTotalCost = decSubTotal + decTaxAmount;


                if (decTotalCost == 0m)
                {
                    invoiceNumber = int.Parse(mtxtInvoiceID.Text);
                    mtxtInvoiceID.Text = invoiceNumber.ToString();
                }
                else
                {
                    //Output calculation
                    lblQuiltSubTotal.Text = decSubTotal.ToString("C");
                    lblQuiltTax.Text = decTaxAmount.ToString("C");
                    lblTotalCost.Text = decTotalCost.ToString("C");

                    invoiceNumber = int.Parse(mtxtInvoiceID.Text);
                    invoiceNumber++;
                    mtxtInvoiceID.Text = invoiceNumber.ToString();
                }
            }

        }

        private void updQuiltOne_ValueChanged(object sender, EventArgs e)
        {
           //Get the value of the spinner and store its value to the variable
           decQuiltOneTotalPrice = QUILT_ONE_PRICE * Convert.ToDecimal(updQuiltOne.Value);

           //Display the quilt1's value in the appropriate lable
           lblQuiltOneSubTotal.Text = decQuiltOneTotalPrice.ToString("C");

           ClearCalculations();
        }

        private void updQuiltTwo_ValueChanged(object sender, EventArgs e)
        {
            //Get the value of the spinner and store its value to the variable
            decQuiltTwoTotalPrice = QUILT_TWO_PRICE * Convert.ToDecimal(updQuiltTwo.Value);

            //Display the quilt1's value in the appropriate lable
            lblQuiltTwoSubTotal.Text = decQuiltTwoTotalPrice.ToString("C");

            ClearCalculations();
        }

        private void updQuiltThree_ValueChanged(object sender, EventArgs e)
        {
            //Get the value of the spinner and store its value to the variable
            decQuiltThreeTotalPrice = QUILT_THEE_PRICE * Convert.ToDecimal(updQuiltThree.Value);

            //Display the quilt1's value in the appropriate lable
            lblQuiltThreeSubTotal.Text = decQuiltThreeTotalPrice.ToString("C");

            ClearCalculations();
        }

        //This method is called each time updSpinner's state is changed,
        //so that if it already has a total bill dispalyed, it is cleared for user benefit
        private void ClearCalculations()
        {
            //Private method to clear calculatioin lebels
            lblQuiltSubTotal.Text = "$0.00";
            lblQuiltTax.Text = "$0.00";
            lblTotalCost.Text = "$0.00";
            //decQuiltOneTotalPrice = 0m;
            mtxtInvoiceID.Focus();
        }

        private void mnuGenerateCalculate_Click(object sender, EventArgs e)
        {
            //Call the button calculate
            btnCalculate.PerformClick();
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            //Create a new instance of an About form object to display the about form
            frmAbout myAbout = new frmAbout();
            myAbout.Visible = true;

        }
    }
}

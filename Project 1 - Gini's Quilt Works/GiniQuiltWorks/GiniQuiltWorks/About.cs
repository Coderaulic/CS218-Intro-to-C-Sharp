/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Comments by the prof:
*
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Project #1-- Gini's Quilt Works
*Created by Ryu Muthui
*Date: 10/16/2013
*Project Name: QuiltWorks (About Form)
*Time: 0 hour 30 minutes
*Version:	1.01
*Platform: PC, Window 7, Visual Studios 2010
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Description:	
*This is an about form to display more information on this program.
*For full details refer to the main form.
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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            //Set the information text
            lblInformation.Text = ("This porgram is an invoice sample program for Gini's Quilt " +
            "Works company. It provides calculation for purchasing quilt works with tax rate " +
            "applied. Currently there are 3 sample item products and it calculates the subtotal " +
            "of all selected items, applies the tax rate, and displays the total cost. " + 
            "(C) Ryu Muthui Production Co. Ltd");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Dispose();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MMAccountingSystems
{
    partial class frmAboutForm : Form
    {
        public frmAboutForm()
        {
            InitializeComponent();
        }

        /*======================================================================
         * Closes the About Form when selected.
         *====================================================================*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

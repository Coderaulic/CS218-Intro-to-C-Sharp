/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Comments by the prof:
*
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Project 3 M & M Crafters Payroll Accounting Systems
*Created by Ryu Muthui
*Date 12/02/2013
*Class: CS 218
*Time: 10 hours 30 minutes
*Platform: PC, Windows 7, C#.NET 2010
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
* Employees at M && M Crafters are grouped in the following 
* five departments with respective hourly wages per hour:
* Sales employees get $15 per hour, 
* Production employees get $25 per hour, 
* Design employees get $40 per hour, 
* Shipping employees get $10 per hour,
* and Other employees get $12 per hour.
* These hourly rates are for a regular 40-hours workweek and 
* all employees are paid time and a half for overtime.  
* Withholdings from the gross pay include federal tax = 20% x
* (gross – dependents x 48.60) and state tax = 3.2% x gross pay.
* Net weekly pay is the gross pay minus the federal and state taxes.
* Additional features including printing the form, just the list
* area and search feature to find already entered employee. 
* Future versioins may include additional search features, 
* remove features, as well as open and save functions of 
* payroll records.
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
using System.Threading;

namespace MMAccountingSystems
{
    public partial class frmMMPayroll : Form
    {
        //Class level constant declaration.
        //Hourly rates for each department.
        const decimal SALES_HOURLY_RATE = 15.0m,
                      PRODUCTION_HOURLY_RATE = 25.0m,
                      DESIGN_HOURLY_RATE = 40.0m,
                      SHIPPING_HOURLY_RATE = 10.0m,
                      OTHER_HOURLY_RATE = 12.0m;

        const int MIN_NAME_LENGTH = 3,
                  MIN_HOURS = 1,
                  MAX_HOURS = 168;

        decimal decHourlyRate = 0m;
        decimal decTotalNetPay = 0m;
        bool blnTotalisDisplayed = false;
        List<string> EmployeeNameList = new List<string>();

        /*======================================================================
         * A public method of form load that loads essential components of the
         * program on launch. It initializes all objects on the form, reads the
         * departments into cboDepartments. Activates and stops the Splash Screen.
         * Sets the headers to the lstDisplay and sets the focus to appropriate
         * textbox on start up.
         * 
         * Calls: SplashStart(), InitializeComponent(), ReadDepartmentList(),
         *        DisplayHeaders()
         *====================================================================*/
        public frmMMPayroll()
        {
            Thread splashThread = new Thread(SplashStart);
            splashThread.Start();
            Thread.Sleep(5000);
            splashThread.Abort();
            InitializeComponent();
            DisplayHeaders();
            ReadDepartmentList();
            txtEmployeeName.Focus();
        }

        /*======================================================================
         * ////////////////////         METHODS             ////////////////////
         *====================================================================*/

        /*======================================================================
         * A public void method to start displaying the frmSplash.
         * 
         * Called by frmMMPayroll()
         *====================================================================*/
        public void SplashStart()
        {
            Application.Run(new frmSplash());
        }

        /*======================================================================
         * A private void method to read the departments from an external text
         * file and populate it into the cboDepartments for user selection.
         * 
         * Called by frmMMPayroll()
         *====================================================================*/
        private void ReadDepartmentList()
        {
            //variable to hold contents of file.
            string strLine;

            StreamReader departmentFile = new StreamReader("Departments.txt");

            //Add contents of file to cboDepartments.
            while ((strLine = departmentFile.ReadLine()) != null)
            {
                cboDepartments.Items.Add(strLine);
            }

            //Close the file.
            departmentFile.Close();

            //Set selected index to the first so it does not start on blank.
            cboDepartments.SelectedIndex = 0;
        }

        /*======================================================================
         * A private void method to display headers in the lstDisplay
         * 
         * Called by frmMMPayroll(), btnClear_Click, mnuClear_Click
         *====================================================================*/
        private void DisplayHeaders()
        {
            string strPadSpaces = "          "; //10 spaces
            string strPadSpaces2 = "            "; //11 spaces
            string displayHeaders = "Employee:" + strPadSpaces2 + "Department:" + strPadSpaces +
                                    "Hours:" + "       " + " Net Pay:";
            lstDisplay.Items.Add(displayHeaders);
            lstDisplay.Items.Add("-------------------------------------------------------------------");
        }

        /*======================================================================
        * A private decimal method to return the hourly rate used to calculate
        * weekly net pay.
        * 
        * Called by GetNetPay()
        *====================================================================*/
        private decimal GetHourlyRate()
        {

            switch (cboDepartments.SelectedIndex)
            {
                case 0:
                    decHourlyRate = SALES_HOURLY_RATE;
                    break;
                case 1:
                    decHourlyRate = PRODUCTION_HOURLY_RATE;
                    break;
                case 2:
                    decHourlyRate = DESIGN_HOURLY_RATE;
                    break;
                case 3:
                    decHourlyRate = SHIPPING_HOURLY_RATE;
                    break;
                default:
                    decHourlyRate = OTHER_HOURLY_RATE;
                    break;
            }
            return decHourlyRate;
        }

        /*======================================================================
        * A private string method to check for valid user input of hours entered.
        * 
        * Called by: btnAddEmployee_Click
        *====================================================================*/
        private string ValidHours()
        {
            if (txtHours.Text.Equals(""))
            {
                return "You must input number of hours worked before adding.\n";
            }

            int hoursWorked = int.Parse(txtHours.Text);
            if (hoursWorked > MAX_HOURS || hoursWorked < MIN_HOURS)
            {
                return "The hours entered are not valid.\n" +
                    "It must be a number between " + MIN_HOURS + " and " +
                    MAX_HOURS + ".\n\n";
            }

            return "";
        }

        /*======================================================================
        * A private string method to check for valid user input of employee name
        * entry. It also checks for duplication of names.
        * 
        * Called by: btnAddEmployee_Click
        *====================================================================*/
        private string ValidName()
        {
            if (txtEmployeeName.Text.Length < MIN_NAME_LENGTH)
            {
                return "You must input a name before adding. \n";
            }

            for (int i = 0; i < EmployeeNameList.Count; i++)
            {
                if (txtEmployeeName.Text.ToLower().Trim().Equals(EmployeeNameList[i].ToLower()))
                    return "The name you have entered already exists. \n";
            }
            return "";
        }

        /*======================================================================
        * A private decimal method to calculate and return the weekly net pay.
        * 
        * Calls: GetHourlyRate()
        * Called by: btnAddEmployee_Click
        *====================================================================*/
        private decimal GetNetPay()
        {

            //variable declarations
            int intHoursWorked = 0;
            int intOverTimeHours = 0;
            int intNumberOfDependents = 0;

            decimal decNetPay = 0m;
            decimal decHourlyRate = GetHourlyRate();
            decimal decGrossPay = 0m;
            decimal decFederalTaxWithHeld = 0m;
            decimal decStateTaxWithHeld = 0m;

            const int MAX_REGULAR_HOURS = 40;
            const int MIN_REGULAR_HOURS = 1;

            const double FEDERAL_TAX_RATE = 0.2;
            const double STATE_TAX_RATE = 0.032;
            const double DEPENDENT_DEDUCTION_RATE = 48.6;
            const double OVERTIME_RATE = 1.5;

            //Get inputs of number of hours worked from txtHours
            //and number of dependents.
            intHoursWorked = int.Parse(txtHours.Text);
            intNumberOfDependents = Convert.ToInt16(updDependents.Value);

            //Calculate gross pay based on total hours.
            //if total hours is between 1 and 40, multiply only with hourly rate.
            if (intHoursWorked <= MAX_REGULAR_HOURS && intHoursWorked >= MIN_REGULAR_HOURS)
            {
                decGrossPay = decHourlyRate * intHoursWorked;
            }
            //if total hours is greater than 40, calculate gross pay with over time included.
            else if (intHoursWorked > MAX_REGULAR_HOURS)
            {
                intOverTimeHours = intHoursWorked - MAX_REGULAR_HOURS;

                decGrossPay = (decHourlyRate * MAX_REGULAR_HOURS) +
                            (decHourlyRate * (intOverTimeHours * (decimal)OVERTIME_RATE));
            }

            //Calcualte Federal and state tax withholdings amount.
            decFederalTaxWithHeld = (decimal)FEDERAL_TAX_RATE *
                                 (decGrossPay - (decimal)(intNumberOfDependents * DEPENDENT_DEDUCTION_RATE));
            decStateTaxWithHeld = decGrossPay * (decimal)STATE_TAX_RATE;

            //Calculate the net pay with Fedral and State tax amount subtracted.
            decNetPay = decGrossPay - (decFederalTaxWithHeld + decStateTaxWithHeld);

            return decNetPay;
        }

        /*======================================================================
         * A private void method to clear the form and reset it to default state.
         * 
         * Called by: btnClear_Click
         *====================================================================*/
        private void ClearFields()
        {
            txtEmployeeName.Clear();
            txtHours.Clear();
            txtSearch.Clear();
            cboDepartments.SelectedIndex = 0;
            updDependents.Value = 0;
            blnTotalisDisplayed = false;
        }

        /*======================================================================
         * A private void method to enable menu and buttons accordingly to
         * program state.
         * 
         * Called by: btnAddEmployee_Click
         *====================================================================*/
        private void Menu_Button_Sync_Enabled()
        {
            btnDisplayTotal.Enabled = true;
            mnuFunctionsDisplayTotal.Enabled = true;

            btnSearch.Enabled = true;
            mnuFunctionsSearch.Enabled = true;
            txtSearch.Enabled = true;

            btnClear.Enabled = true;
            mnuFileClear.Enabled = true;
        }

        /*======================================================================
         * A private void method to disable menu and buttons accordingly to
         * program state.
         * 
         * Called by: btnClear_Click
         *====================================================================*/
        private void Menu_Button_Sync_Disabled()
        {
            btnDisplayTotal.Enabled = false;
            mnuFunctionsDisplayTotal.Enabled = false;

            btnSearch.Enabled = false;
            mnuFunctionsSearch.Enabled = false;
            txtSearch.Enabled = false;

            btnPrint.Enabled = false;
            mnuFilePrint.Enabled = false;
            mnuFilePrintForm.Enabled = false;

            btnClear.Enabled = false;
            mnuFileClear.Enabled = false;
        }

        /*======================================================================
         * ////////////////////      CLICK EVENTS        //////////////////////
         *====================================================================*/

        /*======================================================================
        * Check for valid user input before performing display actions. Takes
        * all the valid inputs and passes it along to appropriate display
        * actions. Adds employee names to the list as well as keep a accumilati-
        * ve total of weekly net pay of all the added employees.
        * 
        * Calls: ValidName(), ValidHours(), GetNetPay(), Menu_Button_Sync_Enabled
        *====================================================================*/
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

            //Validation
            string strValidName = this.ValidName();
            string strValidHours = this.ValidHours();
            string strValidationErrorMessage = strValidName + strValidHours;
            lstDisplay.ClearSelected();

            //Check to see if the total has been displayed, if so remove the last
            //2 lines from the lstDisplay so that the user can continue to add more.
            if (blnTotalisDisplayed == true)
            {
                lstDisplay.Items.RemoveAt(lstDisplay.Items.Count - 1);
                lstDisplay.Items.RemoveAt(lstDisplay.Items.Count - 1);
                blnTotalisDisplayed = false;
            }

            //if there are no errors perform display actions.
            if (strValidationErrorMessage == "")
            {
                string strEmployeeName = txtEmployeeName.Text;
                string strHoursWorked = txtHours.Text;
                string strDepartment = cboDepartments.SelectedItem.ToString();
                decimal decNetPay = this.GetNetPay();

                string strFormatter = "{0,-21}{1,-21}{2,6}{3,16:C}";

                lstDisplay.Items.Add(String.Format(strFormatter, strEmployeeName, strDepartment, strHoursWorked, decNetPay));

                //Add employee name to the list for tracking and duplication check.
                EmployeeNameList.Add(strEmployeeName);

                Menu_Button_Sync_Enabled();

                txtHours.Clear();
                txtEmployeeName.Clear();
                txtEmployeeName.Focus();
                updDependents.Value = 0;
                decTotalNetPay += decNetPay;
            }
            //else inform the user of error.
            else
            {
                MessageBox.Show(strValidationErrorMessage, "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeName.Focus();
            }
        }

        /*======================================================================
         * Calls the btnAddEmployee.click event to also add employees.
         *====================================================================*/
        private void mnuFunctionsAddEmployee_Click(object sender, EventArgs e)
        {
            btnAddEmployee.PerformClick();
        }

        /*======================================================================
        * Displays the accumilative weekly net pay of all the employees.
        *====================================================================*/
        private void btnDisplayTotal_Click(object sender, EventArgs e)
        {
            string strFormatter = "{0,-21}{1,-21}{2,6}{3,16:C}";
            lstDisplay.Items.Add("-------------------------------------------------------------------");
            lstDisplay.Items.Add(String.Format(strFormatter, "", "", "Total:", decTotalNetPay));
            blnTotalisDisplayed = true;
            btnDisplayTotal.Enabled = false;
            mnuFunctionsDisplayTotal.Enabled = false;
            btnPrint.Enabled = true;
            mnuFilePrint.Enabled = true;
            mnuFilePrintForm.Enabled = true;
        }

        /*======================================================================
         * Calls the btnDisplayTotal.click event to also display the total.
         *====================================================================*/
        private void mnuFunctionsDisplayTotal_Click(object sender, EventArgs e)
        {
            btnDisplayTotal.PerformClick();
        }

        /*======================================================================
         * A private method to only allow the user to enter digits and back space
         * in the txtHours entry for hours input.
         *====================================================================*/
        private void txtHours_KeyPress(object sender, KeyPressEventArgs e)
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

        /*======================================================================
         * Exit the application when selected.
         *====================================================================*/
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*======================================================================
         * Exit the application when selected.
         *====================================================================*/
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*======================================================================
         * Clear the appropriate items on the form to reset it to default state.
         * 
         * Calls: ClearFields(), Menu_Button_Sync_Disabled()
         *====================================================================*/
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            ClearFields();
            DisplayHeaders();
            Menu_Button_Sync_Disabled();
            txtEmployeeName.Focus();
            decTotalNetPay = 0m;
            EmployeeNameList.Clear();
        }

        /*======================================================================
         * Calls the btnClear.click event to also clear the form.
         *====================================================================*/
        private void mnuFileClear_Click(object sender, EventArgs e)
        {
            btnClear.PerformClick();
        }

        /*======================================================================
         * A private void method to search through the lstDisplay and attempt to
         * find a matching employee name's entry. If found, highlight and select
         * the entry, if not displays a message stating no user found. Accounts
         * for multiple finds and doesn't include the top 2 lines of the
         * lstDisplay.
         *====================================================================*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Check to see if user has entered a name, if not inform them they need
            //to enter a name first.
            if (txtSearch.Text.Trim().Equals(""))
            {
                MessageBox.Show("You must enter an employee name before searching.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //Clear selection if already something is selected in the lstDisplay.
            lstDisplay.ClearSelected();
            lstDisplay.SelectedItems.Clear();

            //Variable used to notify if an employee was found or not.
            bool blnUserFound = false;

            //An off set of 2, since we do not need to search the first 2 lines of the lstDisplay.
            const int OFFSET = 2;

            //Search the entire lstDisplay from bottom to top not including the first 2 lines.
            for (int i = lstDisplay.Items.Count - 1; i >= OFFSET; i--)
            {
                if (lstDisplay.Items[i].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    lstDisplay.SetSelected(i, true);
                    blnUserFound = true;
                }
            }

            //If an employee is found, do nothing.
            if (blnUserFound == true)
            { }
            //Else inform them that no employee was found.
            else
            {
                MessageBox.Show("No employee by that name was found.", "Search Results:",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.SelectAll();
                txtSearch.Focus();
            }
        }

        /*======================================================================
         * Calls the btnSearch.click event to also search for names.
         *====================================================================*/
        private void mnuFunctionsSearch_Click(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        /*======================================================================
         * Display the about form when selected.
         *====================================================================*/
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            frmAboutForm frmAboutMMPayroll = new frmAboutForm();
            frmAboutMMPayroll.Visible = true;
        }

        /*======================================================================
         * Print the entire GUI form when selected.
         *====================================================================*/
        private void btnPrint_Click(object sender, EventArgs e)
        {
            pfMMPayroll.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            pfMMPayroll.Print();
        }

        /*======================================================================
         * Calls the btnPrint_Click to print the GUI.
         *====================================================================*/
        private void mnuFilePrintForm_Click(object sender, EventArgs e)
        {
            btnPrint.PerformClick();
        }

        /*====================================================================
         * Creates a document of the display box for printing.
         * 
         * Calls: pdMMPayroll_PrintPageEvent
         *==================================================================*/
        private void mnuFilePrint_Click(object sender, EventArgs e)
        {
            ppdMMPayroll.ShowDialog();
        }

        /*====================================================================
         * Creates the print document for printing only the lstDisplay.
         * 
         * Call by: mnuFilePrint_Click
         *==================================================================*/
        private void pdMMPayroll_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print content of Output list box
            int i = 0; //counter

            // Create string to draw.
            String drawString = "M & M Payroll Accounting Systems";

            // Create font and brush.
            Font drawFont = new Font("Arial", 18);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);

            // Create rectangle for drawing.
            float x = 100.0F;
            float y = 100.0F;

            drawFont = new Font("Courier New", 12);

            // Draw string to page.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);

            drawBrush = new SolidBrush(Color.Black);
            y += 22;

            for (i = 0; i < lstDisplay.Items.Count; i++)
                e.Graphics.DrawString(lstDisplay.Items[i].ToString(), drawFont, drawBrush, x, y + i * 20);
        }
    }
}

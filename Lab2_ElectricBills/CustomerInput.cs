using CustomerData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


/// <summary>
/// This program is designed to add customer info and display on a listbox 
/// The electricity bill is calculated based on number of kWh for each customer
/// It will display the Number of customers processed, Total number of kWh used
/// and Average bill amount at the bottom
/// 
/// Date: April 28, 2021
/// Author: Cecilia Santiago    
/// </summary>

namespace Lab2_ElectricBills
{
    public partial class FrmCustomerInput : Form
    {

        int count, cnttot = 0;                  //count is used for counting the number of customers added
                                                //cnttot is used for counting the number of customers with
                                                //bill amount > $0
        decimal totkwh = 0.0m;                  //how many total kHw for all customers added
        decimal totbill = 0.0m;                 //total of bill amounts for all customers
        decimal avgkwh = 0.0m;                  //average total of all bill amounts greater than 0
        string[] heading = new string[5];       //placeholder for headers
        decimal tmpkhw = 0.0m;                  //used to validate negative number entry
        String frmdet = "{0, -15}{1, -25}{2, -25}{3, -15}{4, -15}";     // used for headers and is formatted in columns

        public FrmCustomerInput()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When "Add" is clicked on the menu, it opens up the customer portion
        /// on the right hand side of the form to be able to enter  all 
        /// necessary customer info
        /// </summary>       
        private void MnuAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            BackColor = Color.DarkGray;
        }

        /// <summary>
        /// Create an object for the Customer to access all property
        /// </summary>
        /// <returns>Customer object is ready to use</returns>
        private Customer CallCustomerData()
        {
            Customer cust = new Customer("0", "First", "Last", 0.0m) // all values are defaults
            {
                AccountNo = lblTextAccntNo.Text,
                First = TxtTextFirstName.Text,
                Last = txtTextLastName.Text,
                KiloWH = tmpkhw
            };
            return cust;
        }

        /// <summary>
        /// This adds the customer data in the list file and displayed
        /// at the same time
        /// It also calculates the total number of kHw of all customers
        /// and totals all the bill amounts, then
        /// calculates the average greater than 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            Size = new Size(1286, 700);

            lstClientInfo.Enabled = true;

            //check if all entries are valid before processing
            if (IsValidData())
            {
                count++;                                        //counter for customer being added on the list

                Customer cust = CallCustomerData();             //Creates the customer object

                lblTextAccntNo.Text = cust.AccountNo;           //Auto generated account number

                List<Customer> Allclient = new List<Customer>(); // makes an empty list
                Allclient.Add(cust);                             // adds a customer to the list of customers
                foreach (Customer client in Allclient)           // adds a customer to the listbox
                    lstClientInfo.Items.Add(client);
             
                totkwh += cust.KiloWH;                              //calculate all of customers' kWh
                totbill += cust.CalculateCharge();                  //total all of customers' bill amount
                if (cust.KiloWH != 0.0m)                            //get the average of bill amounts 
                {                                                   //greater than 0
                    cnttot++;
                    avgkwh = totbill / cnttot;
                }

                /// <summary>
                /// Keep tracks of the customer statistics
                /// which displays the total number of customers,
                /// the total of kHw used,
                /// and the average of all bill amounts entered
                /// <summary>
                lblNumCustText.Text = count.ToString();            
                lblNumkwhText.Text = totkwh.ToString("n2");        
                lblTotBillAmtText.Text = avgkwh.ToString("c2");    

            }

        }

        /// <summary>
        /// Validates the ff:
        /// if First Name is empty
        /// if First name is longer than 25 characters
        /// if Last Name is empty
        /// if Last Name is longer than 25 characters
        /// if kHw is empty
        /// if kHw is contains an alpha
        /// if kHw is negative
        /// </summary>
        /// <returns>invalid if above condition is met otherwise data input is valid</returns>
        private bool IsValidData()
        {

            if (TxtTextFirstName.Text == "")
            {
                lblFnamevalidate.Text = lblFirstName.Text + " is a required field.";
                lblFnamevalidate.Visible = true;
                return false;
            }
            else
            {
                lblFnamevalidate.Visible = false;
            }

            if (TxtTextFirstName.Text.Length > 25)
            {
                lblFnamevalidate.Text = lblFirstName.Text + " cannot be more than 25 characters";
                lblFnamevalidate.Visible = true;
                return false;
            }
            else
            {
                lblFnamevalidate.Visible = false;
            }


            if (txtTextLastName.Text == "")
            {
                lblLastValidate.Text = lblLastName.Text + " is a required field.";
                lblLastValidate.Visible = true;
                return false;
            }
            else
            {
                lblLastValidate.Visible = false;
            }


            if (txtTextLastName.Text.Length > 25)
            {
                lblLastValidate.Text = lblLastName.Text + " cannot be more than 25 character";
                lblLastValidate.Visible = true;
                return false;
            }
            else
            {
                lblLastValidate.Visible = false;
            }

            if (txtTextkWh.Text == "")
            {
                lblkwhValidate.Text = lblkWh.Text + " Cannot be empty.";
                lblkwhValidate.Visible = true;
                return false;
            }
            else
            {
                lblkwhValidate.Visible = false;
            }

            try
            {
                tmpkhw = Convert.ToDecimal(txtTextkWh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");

                lblkwhValidate.Text = "Please enter numbers only.";
                lblkwhValidate.Visible = true;

                return false;
            }

            if (tmpkhw < 0)
            {
                lblkwhValidate.Text = lblkWh.Text + " cannot have negative value";
                lblkwhValidate.Visible = true;
                return false;
            }
            else
            {
                lblkwhValidate.Visible = false;
                return true;
            }


        }

        /// <summary>
        /// Display the headers once form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCustomerInput_Load(object sender, EventArgs e)
        {
            lstClientInfo.Enabled = false;
            heading[0] = "Account No.";
            heading[1] = "First Name";
            heading[2] = "Last Name";
            heading[3] = "kWh used";
            heading[4] = "Bill Amount";


            lblHeadingText.Text = String.Format(frmdet, heading[0], heading[1], heading[2], heading[3], heading[4]);
            Size = new Size(750, 691);
            BackColor = Color.LightSteelBlue;

        }

        /// <summary>
        /// When "Display" is clicked on the menu, it shows the listbox
        /// and the statistics box
        /// </summary>
        private void MnuDisplay_Click(object sender, EventArgs e)
        {
            Size = new Size(796, 691);
            pnlAdd.Visible = false;
            BackColor = Color.LightSteelBlue;

        }

        // Initializes all entry field to blank or 0 when double clicked
        private void TxtTextFirstName_DoubleClick(object sender, EventArgs e)
        {
            TxtTextFirstName.Text = "";
            txtTextkWh.Text = "";
            txtTextLastName.Text = "";
            lblTextAccntNo.Text = "0";
        }

        // Exit all application, all data is lost
        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

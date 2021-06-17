using System;

/// <summary>
/// Library of Customer that holds the Customer info
/// 
/// Author: Cecilia Santiago
/// </summary>
namespace CustomerData
{
    public class Customer
    {        
        
        private string _first, _last;               // placeholder for Firstname // _last = placeholder for Lastname 
        private decimal _kwh = 0.0m;                // placeholder for kilowatt
        private Random genacct = new Random();      // used for random numbering
        private string _acctno;                     // generated account number
        private const decimal ADMINCHRG = 12;       // administration charge of $12
        private const decimal PERKWH = .07m;        // charge of $.07 per kHw used
        private decimal custbill = 0.0m;            // bill amount calculated per customer
        private String frmdet = "{0, -15}{1, -25}{2, -25}{3, -15}{4, -15}";     // customer data is formatted in columns

        /// <summary>
        /// Constructor for CustomerData coming from customer input
        /// </summary>
        /// <param name="acct">account number input</param>
        /// <param name="fname">firstname input</param>
        /// <param name="lname">lastname input</param>
        /// <param name="kilowatts">kHw input</param>        
        public Customer(string acct, string fname, string lname, decimal kilowatts)
        {
            _acctno = acct;
            _first = fname;
            _last = lname;
            _kwh = kilowatts;
        }

        // First Name Property
        public string First { get; set; }

        // Last Name Property
        public string Last { get; set; }

        // Kilowatt Property
        public decimal KiloWH
        {
            get
            {
                return _kwh;
            }
            set
            {
                _kwh = value;
            }
        }

        /// <summary>
        /// Account Number Property returns a generated Random number
        /// </summary>
        public string AccountNo
        {
            get
            {
                return _acctno;
            }

            set
            {

                int num = genacct.Next(200);
                _acctno = Convert.ToString(num);
            }
        }

        /// <summary>
        /// a Method to calculate the bill amount per customer
        /// a charge of 0.07 per kHw used plus 
        /// an administration fee of $12
        /// </summary>
        /// <returns>Returns the calculated amount or $0 if kHw is 0</returns>
        public decimal CalculateCharge()
        {            
            if (KiloWH != 0.0m)
                custbill = Math.Round((KiloWH * PERKWH) + ADMINCHRG, 2);
            
            return custbill;
        }

        /// <summary>
        /// Concatenate account number, firstname, lastname, kHw and bill amount into
        /// one string and formatted into columns
        /// </summary>
        /// <returns>One whole string that will go on the listbox</returns>
        public override string ToString()
        {
            return String.Format(frmdet, String.Format(AccountNo, "0"), First, Last,
                   KiloWH.ToString("n2"), CalculateCharge().ToString("c2"));
        }
    }
}

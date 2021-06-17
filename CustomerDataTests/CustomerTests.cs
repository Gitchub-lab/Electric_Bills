using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// Unit testing for CalculateCharge()
/// 
/// Author: Cecilia Santiago
/// </summary>
namespace CustomerData.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        // Test input of integer
        [TestMethod()]
        public void CalculateChargeTestInteger()
        {
            // Arrange
            Customer custdata;
            string fn = "Joe";
            string ln = "Doe";
            string ac = "0";
            decimal testkhw = 200;

            // Act            
            custdata = new Customer(ac, fn, ln, testkhw);
            decimal actual = custdata.CalculateCharge();

            // Assert
            decimal expected = 26;
            Assert.AreEqual(expected, actual);            

        }

        //Test input of Decimal
        [TestMethod()]
        public void CalculateChargeTestDecimal()
        {
            // Arrange
            Customer custdata;
            string fn = "Sam";
            string ln = "S";
            string ac = "0";
            decimal testkhw = 700.3m;

            // Act            
            custdata = new Customer(ac, fn, ln, testkhw);
            custdata.First = ac;
            decimal actual = custdata.CalculateCharge();

            // Assert            
            decimal expected = 61.02m;
            Assert.AreEqual(expected, actual);

        }

        //Test input of 0
        [TestMethod()]
        public void CalculateChargeTestZeroValue()
        {
            // Arrange
            Customer custdata;
            string fn = "Sam";
            string ln = "S";
            string ac = "0";
            decimal testkhw = 0.0m;

            // Act            
            custdata = new Customer(ac, fn, ln, testkhw);
            decimal actual = custdata.CalculateCharge();

            // Assert            
            decimal expected = 0.0m;
            Assert.AreEqual(expected, actual);

        }
    }
}
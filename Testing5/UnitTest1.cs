using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStock

    {
        
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }

        [TestMethod]

        // ===================================================================

        public void ProductCatogeryPropertyOK()
        {

            clsStock AStock = new clsStock();

            string ProductCategory = "Snickers";
            AStock.ProductCategory = ProductCategory; 

            Assert.AreEqual(AStock.ProductCategory, ProductCategory); 
        
        }

        //====================================================================

        [TestMethod]
        public void DatePropertyOK()
        {

            clsStock AStock = new clsStock();
            string Date = "12/12/22";
            AStock.Date = Date;
            Assert.AreEqual(AStock.Date, Date);
           
        }
        // ===================================================================

        [TestMethod]
        public void AvailablePropertyOK()
        {

            clsStock AStock = new clsStock();
            Boolean Available = true;
            AStock.Available = Available;
            Assert.AreEqual(AStock.Available, Available);

        }
        //==================================================================== 
        [TestMethod]
        public void ProductNamePropertyOK()
        {

            clsStock AStock = new clsStock();

            string ProductName = "Air Force 101";
            AStock.ProductName = ProductName;

            Assert.AreEqual(AStock.ProductName, ProductName);

        }
    }
}

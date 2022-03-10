using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StockTesting
{
    [TestClass]
    public class tstStock
    {

        //=========



        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }


        //====================================================
        [TestMethod]
        public void StockIdPropertyOK()
        {

            clsStock AStock = new clsStock();

            string StockId = "1101";
            AStock.StockId = StockId;

            Assert.AreEqual(AStock.StockId, StockId);

        }

        //=====================================================

        [TestMethod]

        public void ProductCatogeryPropertyOK()
        {

            clsStock AStock = new clsStock();

            string ProductCategory = "Beverage";
            AStock.ProductCategory = ProductCategory;

            Assert.AreEqual(AStock.ProductCategory, ProductCategory);

        }

        //====================================================================

        [TestMethod]
        public void QuantityPropertyOK()
        {

            clsStock AStock = new clsStock();

            string Quantity = "";
            AStock.Quantity = Quantity;

            Assert.AreEqual(AStock.Quantity, Quantity);

        }

        //===========================================================
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

            string Available = "true";
            AStock.Available = Available;
            Assert.AreEqual(AStock.Available, Available);

        }
        //==================================================================== 
        [TestMethod]
        public void ProductNamePropertyOK()
        {

            clsStock AStock = new clsStock();

            string ProductName = "Coke";
            AStock.ProductName = ProductName;

            Assert.AreEqual(AStock.ProductName, ProductName);

        }
    }
}
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

            string StockId = "1001";
            AStock.StockId = StockId;

            Assert.AreEqual(AStock.StockId, StockId);

        }

        //=====================================================

        [TestMethod]

        public void ProductCatogeryPropertyOK()
        {

            clsStock AStock = new clsStock();

            string ProductCategory = "Nike Air Max 90";
            AStock.ProductCategory = ProductCategory;

            Assert.AreEqual(AStock.ProductCategory, ProductCategory);

        }

        //====================================================================

        [TestMethod]
        public void QuantityPropertyOK()
        {

            clsStock AStock = new clsStock();

            string Quantity = "12";
            AStock.Quantity = Quantity;

            Assert.AreEqual(AStock.Quantity, Quantity);

        }

        //===========================================================
        [TestMethod]
        public void DatePropertyOK()
        {

            clsStock AStock = new clsStock();
            string Date = "09/03/2022";
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

            string ProductName = "Nike";
            AStock.ProductName = ProductName;

            Assert.AreEqual(AStock.ProductName, ProductName);

        }
    //=============================================================
   //==============================================================
        [TestMethod]
        public void FindMethodOK()
        {

            clsStock AStock = new clsStock();
            Boolean Found = false; 
            string ProductName = "Coke";
            AStock.ProductName = ProductName;

            Assert.AreEqual(AStock.ProductName, ProductName);

        }
    }
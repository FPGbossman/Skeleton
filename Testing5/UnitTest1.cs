using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

{
    [TestClass]
    public class tstStock

    {
        //=====================================================================
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }

        // ===================================================================
        [TestMethod]
        public void StockIdOK()
        {

            clsStock AStock = new clsStock();
            int TestData = 1001;
            AStock.StockId = TestData;
            Assert.AreEqual(AStock.StockId, TestData);

        }

        // ===================================================================
        [TestMethod]
        public void ProductCatogeryPropertyOK()
        {

            clsStock AStock = new clsStock();
            String TestData = "Nike Air Max 90";
            AStock.ProductCategory = TestData; 
            Assert.AreEqual(AStock.ProductCategory, TestData); 
        
        }

        //====================================================================
        [TestMethod]
        public void QuanityOK()
        {

            clsStock AStock = new clsStock();
            Int32 TestData = 12;
            AStock.Quantity = TestData;
            Assert.AreEqual(AStock.Quantity, TestData);

        }

        //====================================================================

        [TestMethod]
        public void DatePropertyOK()
        {

            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.Date = TestData;
            Assert.AreEqual(AStock.Date, TestData);
           
        }
        // ===================================================================

        [TestMethod]
        public void AvailablePropertyOK()
        {

            clsStock AStock = new clsStock();
            Boolean TestDate = true;
            AStock.Available = TestDate; 
            Assert.AreEqual(AStock.Available, TestDate);

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
        //=====================================================================

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            int StockId = 1001;
            Found = AStock.Find(StockId);
            Assert.IsTrue(Found);
        }

        //=====================================================================

        [TestMethod]
        public void TestStockIdFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;
            Boolean OK = true;
            Int32 StockId = 1001;
            Found = AStock.Find(StockId);
            if (AStock.StockId != 1001)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //====================================================================

        [TestMethod]
        public void TestQuanityFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;
            Boolean OK = true;
            Int32 StockId = 1001;
            Found = AStock.Find(StockId);
            if (AStock.Quantity != 12)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //=====================================================================

        [TestMethod]
        public void TestDateFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;
            Boolean OK = true;
            Int32 StockId = 1001;
            Found = AStock.Find(StockId);
            if (AStock.Date != Convert.ToDateTime("09/03/2022")) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //=====================================================================

        [TestMethod]
        public void TestAvailableFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;
            Boolean OK = true;
            Int32 StockId = 1001;
            Found = AStock.Find(StockId);
            if (AStock.Available != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //==========================================================================


        [TestMethod]
        public void TestProductCategoryFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;
            Boolean OK = true;
            Int32 StockId = 1001;
            Found = AStock.Find(StockId);
            if (AStock.ProductCategory != "Nike Air Max 90")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //=====================================================================

        [TestMethod]
        public void TestProductNameFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;
            Boolean OK = true;
            Int32 StockId = 1001;
            Found = AStock.Find(StockId);
            if (AStock.ProductName != "Nike")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

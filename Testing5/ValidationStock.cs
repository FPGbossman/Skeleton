using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;


namespace ValidationStock
{


    [TestClass]
    public class tstStock
    {

       
        string ProductCategory = "Nike Air Max 90";
        string Quantity = "";
        string Date = DateTime.Now.Date.ToString();
        string ProductName = "Nike";



        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, ""); 
        }
        // ========================================== ProductCategory Validation Testing =========================
        [TestMethod]
        public void ProductCategoryMin_1_minus()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = ""; 
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ProductCategoryMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "a";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductCategoryMin_1_Plus()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "aa";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductCategoryMax_1_minus()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "";
            ProductCategory = ProductCategory.PadRight(49, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductCategoryMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "";
            ProductCategory = ProductCategory.PadRight(50, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductCategoryMax_1_Plus()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "";
            ProductCategory = ProductCategory.PadRight(50, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductCategoryMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "";
            ProductCategory = ProductCategory.PadRight(25, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        // ========================================== Quantity Validation Testing =========================

        [TestMethod]
        public void QuantityMin_1_minus()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "aaa";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "a";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax_1_Minus()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "aaaaa";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "aaaaa";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "aaa";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax_1_Plus()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "aaaaaaa";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        // ========================================== Date Validation Testing =========================

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string Date = TestDate.ToString();
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string Date = TestDate.ToString();
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {

            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string Date = TestDate.ToString();
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()

        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string Date = TestDate.ToString();
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {

            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string Date = TestDate.ToString();
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreNotEqual(Error, "");
        }

        // ========================================== ProductName Validation Testing =========================

        [TestMethod]
        public void ProductNameMin_1_minus()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "a";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameMin_1_Plus()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "aa";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameyMax_1_minus()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(49, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(50, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameyMax_1_Plus()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(50, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(25, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }
    }
}
       
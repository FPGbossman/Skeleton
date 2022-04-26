using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace ValidationStock
{


    [TestClass]
    public class tstStock
    {
        string ProductCategory = "Nike Air Max 90";
        string Quantity = "12";
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


        // ================================================================================================================================== //
       //                                                      ProductCategory Validation Testing                                            //
      // ================================================================================================================================== //

        [TestMethod]
        public void ProductCategoryMin_1_minus()  // To cheek 1 less than Minimum value. 
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ProductCategoryMin()         // To check Minimum value.
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "a";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductCategoryMin_1_Plus()   // To check 1 more than Minimum value.
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "aa";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductCategoryMax_1_minus()  // To check 1 less than Maximum value. 
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "";
            ProductCategory = ProductCategory.PadRight(49, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductCategoryMax()          // To check Maximum value. 
        { 
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "";
            ProductCategory = ProductCategory.PadRight(50, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductCategoryMax_1_Plus()   // To check Maximum value. 
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "";
            ProductCategory = ProductCategory.PadRight(50, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductCategoryMid()        // To check Medium value
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductCategory = "";
            ProductCategory = ProductCategory.PadRight(25, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        // ================================================================================================================================== //
       //                                                      Quantity Validation Testing                                                   //
      // ================================================================================================================================== //


        [TestMethod]
        public void QuantityMin_1_minus()       // To cheek 1 less than Minimum value. 

        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMin()               // To check Minimum value.
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "b";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMax_1_Minus()       // To check 1 less than Maximum value.
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(5, 'b');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMax()               //To check Maximum value. 
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "aaaaa";
            Quantity = Quantity.PadRight(5, 'b');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMid()               // To check Medium value. 
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(3, 'b');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMax_1_Plus()        // To check 1 more than Minimum value.
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(5, 'b');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        // ================================================================================================================================== //
       //                                                          Date Validation Testing                                                   //
      // ================================================================================================================================== //


        [TestMethod]
        public void DateExtremeMin()            // To check Extreme Minimum value. 
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
        public void DateMinLessOne()           // To check 1 less than Minimum value. 
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
        public void DateMin()                  // To check Minimum value.

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
        public void DateMinPlusOne()           // To check 1 more than Minumum value. 

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
        public void DateExtremeMax()           // To check Extreme Maximum value
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

        // ================================================================================================================================== //
       //                                                       ProductName Validation Testing                                               //
      // ================================================================================================================================== //


        [TestMethod]
        public void ProductNameMin_1_minus()        // To cheek 1 less than Minimum value. 
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()                // To check Minimum value.
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "a";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin_1_Plus()        // To check 1 more than Minimum value. 
        {  
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "aa";
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax_1_minus()      // To check 1 less than Maximum value.  
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(49, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()            // To check Maximum value. 
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(50, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax_1_Plus()     // To check 1 more less than Maximum value. 
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(50, 'a');
            Error = AStock.Validation(ProductCategory, Quantity, Date, ProductName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()           //To check Medium value. 
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

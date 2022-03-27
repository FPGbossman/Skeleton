using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            clssupplier ASupplier = new clssupplier();
            Assert.IsNotNull(ASupplier);
        }

        // ======================================================================

        [TestMethod]
        public void SupplierSinceOK()
        {
            clssupplier ASupplier = new clssupplier();
            DateTime TestData = DateTime.Now.Date;
            ASupplier.SupplierSince = TestData;
            Assert.AreEqual(ASupplier.SupplierSince, TestData);
        }

        // ======================================================================

        [TestMethod]
        public void SupplierNameOK()
        {
            clssupplier ASupplier = new clssupplier();
            string SupplierName = "Nike";
            ASupplier.SupplierName = SupplierName;
            Assert.AreEqual(ASupplier.SupplierName, "Nike");
        }

        // ======================================================================

        [TestMethod]
        public void CurrentSupplierOK()
        {
            clssupplier ASupplier = new clssupplier();
            Boolean CurrentSupplier = true;
            ASupplier.CurrentSupplier = CurrentSupplier;
            Assert.AreEqual(ASupplier.CurrentSupplier, true);
        }

        // ======================================================================

        [TestMethod]
        public void SupplierAddressOK()
        {
            clssupplier ASupplier = new clssupplier();
            string SupplierAddress = "test address";
            ASupplier.SupplierAddress = SupplierAddress;
            Assert.AreEqual(ASupplier.SupplierAddress, "test address");
        }

        // ======================================================================

        [TestMethod]
        public void ContactNumberOK()
        {
            clssupplier ASupplier = new clssupplier();
            string ContactNumber = "7647766891";
            ASupplier.ContactNumber = ContactNumber;
            Assert.AreEqual(ASupplier.ContactNumber, "7647766891");
        }

        // ======================================================================

        [TestMethod]
        public void FindMethodOK()
        {
            clssupplier ASupplier = new clssupplier();
            Boolean Found = false;
            Int32 SupplierID = 4;
            Found = ASupplier.Find(SupplierID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierIDFound()
        {
            clssupplier ASupplier = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 4;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierID != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierSince()
        {
            clssupplier ASupplier = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 4;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierSince != Convert.ToDateTime("2022-02-22"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierName()
        {
            clssupplier ASupplier = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 4;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierName != "TheTrainerPeople")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestCurrentSupplier()
        {
            clssupplier ASupplier = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 4;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.CurrentSupplier != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierAddress()
        {
            clssupplier ASupplier = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 4;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierAddress != "12 Lane")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactNumber()
        {
            clssupplier ASupplier = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 4;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.ContactNumber != "68543865")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        // ======================================================================

        //Good data to pass to the method:
        string SupplierSince = DateTime.Now.Date.ToString();
        string SupplierName = "Nike";
        //string CurrentSupplier = "false";
        string SupplierAddress = "12 Street";
        string ContactNumber = "12345678";

        [TestMethod]
        public void ValidMethodOK()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        // ======================================================================
        // All Tests For Supplier Name:
        [TestMethod]
        public void SupplierNameLessOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierName = "";
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierName = "a"; //this should pass
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierName = "aa"; //this should pass
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(25, 'a'); // this should pass
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(49, 'a');// this should pass
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(50, 'a');// this should pass
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(51, 'a'); // this should fail
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a'); //this should fail
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        // All Tests For Supplier Since:
         [TestMethod]
        public void SupplierSinceExtremeMin()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string SupplierSince = TestDate.ToString();
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierSinceMinLessOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string  SupplierSince = TestDate.ToString();
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierSinceMin()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string SupplierSince = TestDate.ToString();
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierSinceMinPlusOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string SupplierSince = TestDate.ToString();
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SupplierSinceExtremeMax()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string SupplierSince = TestDate.ToString();
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        } 

        [TestMethod]
        public void SupplierSinceInvalidDate()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierSince = "That is not a date";
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        // All Tests for SupplierAddress
        [TestMethod]
        public void SupplierAddressLessOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierAddress = "";
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMin()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierAddress = "a"; //this should pass
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMinPlusOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierAddress = "aa"; //this should pass
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMid()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(25, 'a'); // this should pass
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierAddressMaxLessOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(49, 'a');// this should pass
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMax()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(50, 'a');// this should pass
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMaxPlusOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(51, 'a'); // this should fail
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressExtremeMax()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(500, 'a'); //this should fail
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }


        // All Tests for ContactNumber
        [TestMethod]
        public void ContactNumberLessOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string ContactNumber = "";
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMin()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string ContactNumber = "1"; //this should pass
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMinPlusOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string ContactNumber = "12"; //this should pass
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMid()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string ContactNumber = "12345";
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContactNumberMaxLessOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string ContactNumber = "123456789";
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMax()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string ContactNumber = "0123456789";
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMaxPlusOne()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(12, '0');
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberExtremeMax()
        {
            clssupplier ASupplier = new clssupplier();
            string Error = "";
            string SupplierAddress = "";
            ContactNumber = ContactNumber.PadRight(100, '0'); //this should fail
            Error = ASupplier.Valid(SupplierSince, SupplierName, SupplierAddress, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }
    }
}







          
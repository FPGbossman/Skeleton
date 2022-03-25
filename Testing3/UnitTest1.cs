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
            ASupplier.SupplierSince =  TestData;
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
            if (ASupplier.SupplierName != "TheTrainerPeople"){
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
            if (ASupplier.CurrentSupplier != false )
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

    }
}



          
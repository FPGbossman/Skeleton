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
            string SupplierSince = "12/12/22";
            ASupplier.SupplierSince = SupplierSince;
            Assert.AreEqual(ASupplier.SupplierSince, "12/12/22");
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
            long TestData = 7647766891;
            ASupplier.ContactNumber = TestData;
            Assert.AreEqual(ASupplier.ContactNumber, TestData);
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
            if (ASupplier.SupplierSince != "2022-02-22")
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
                if (ASupplier.ContactNumber != 68543865)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
    }
}



          
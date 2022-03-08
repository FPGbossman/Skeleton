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
            ASupplier.SupplierAddress = "test address";
            Assert.AreEqual(ASupplier.SupplierAddress, "test address");
        }

        // ======================================================================

        [TestMethod]
        public void SupplierContactNumberOK()
        {
            clssupplier ASupplier = new clssupplier();
            long TestData = 7647766891;
            ASupplier.ContactNumber = TestData;
            Assert.AreEqual(ASupplier.ContactNumber, TestData);
        }

    }
}



          
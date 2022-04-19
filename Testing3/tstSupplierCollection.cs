using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clssupplier> TestList = new List<clssupplier>();
            clssupplier TestItem = new clssupplier();
            TestItem.CurrentSupplier = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Test";
            TestItem.SupplierSince = DateTime.Now.Date;
            TestItem.SupplierAddress = "12 Street";
            TestItem.ContactNumber = "12345678";

            TestList.Add(TestItem); //Add item to the test list
            AllSuppliers.SupplierList = TestList; //Assign the data to the property
            Assert.AreEqual(AllSuppliers.SupplierList, TestList); //Ensure the values are the same
        }


        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clssupplier TestSupplier = new clssupplier();
            TestSupplier.CurrentSupplier = true;
            TestSupplier.SupplierID = 1;
            TestSupplier.SupplierName = "Nike";
            TestSupplier.SupplierSince = DateTime.Now.Date;
            TestSupplier.SupplierAddress = "11 Stret";
            TestSupplier.ContactNumber= "098765432";

            AllSuppliers.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clssupplier> TestList = new List<clssupplier>();
            clssupplier TestItem = new clssupplier();

            TestItem.CurrentSupplier = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Nike";
            TestItem.SupplierSince = DateTime.Now.Date;
            TestItem.SupplierAddress = "11 Stret";
            TestItem.ContactNumber = "098765432";

            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clssupplier TestItem = new clssupplier();
            Int32 PrimaryKey = 0;

            TestItem.CurrentSupplier = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Nike";
            TestItem.SupplierSince = DateTime.Now.Date;
            TestItem.SupplierAddress = "11 Stret";
            TestItem.ContactNumber = "098765432";

            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierID = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);

        }
    }

}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;


namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection gg = new clsCustomerCollection();

            Assert.IsNotNull(gg);
        }

        [TestMethod]
        public void CustomerListOK()
        {

            clsCustomerCollection gg = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerID = 1;
            TestItem.CustomerFirstname = "Fred";
            TestItem.CustomerSurname = "Son";
            TestItem.CustomerEmail = "fredson22@gmail.com";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.Gender = "Male";


            TestList.Add(TestItem);
            gg.CustomerList = TestList;
            Assert.AreEqual(gg.CustomerList, TestList);
        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection gg = new clsCustomerCollection();

            clsCustomer test = new clsCustomer();

            test.CustomerID = 1;
            test.CustomerFirstname = "Fred";
            test.CustomerSurname = "Son";
            test.CustomerEmail = "fredson22@gmail.com";
            test.CustomerDOB = DateTime.Now.Date;
            test.Gender = "Male";


            gg.ThisCustomer = test;

            Assert.AreEqual(gg.ThisCustomer, test);
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            clsCustomerCollection gg = new clsCustomerCollection();

            List<clsCustomer> test = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();


            TestItem.CustomerID = 1;
            TestItem.CustomerFirstname = "Fred";
            TestItem.CustomerSurname = "Son";
            TestItem.CustomerEmail = "fredson22@gmail.com";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.Gender = "Male";

            test.Add(TestItem);

            gg.CustomerList = test;

            Assert.AreEqual(gg.Count, test.Count);

        }

        [TestMethod]

        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestItem.CustomerID = 1;
            TestItem.CustomerFirstname = "Fred";
            TestItem.CustomerSurname = "Son";
            TestItem.CustomerEmail = "fredson22@gmail.com";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.Gender = "Male";         
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerEmail = "Jackmoney22@gmail.com";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerFirstname = " Jack";
            TestItem.CustomerSurname = "Son";
            TestItem.Gender = "male";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();

            TestItem.CustomerEmail = "Jackmoney22@gmail.com";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerFirstname = "Jack";
            TestItem.CustomerSurname = "Money";
            TestItem.Gender = "Male";

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethod()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 1;
            TestItem.CustomerEmail = "Jackmoney22@gmail.com";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerFirstname = "Jack";
            TestItem.CustomerSurname = "Money";
            TestItem.Gender = "male";

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            AllCustomers.Delete();

            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerNameTestDataFound()
        {
            clsCustomerCollection FilteredNames = new clsCustomerCollection();

            Boolean ok = true;

            FilteredNames.ReportByCustomername("Sparrow Finch");

            if (FilteredNames.Count == 2)
            {

                if (FilteredNames.CustomerList[0].CustomerID != 12)
                {
                    ok = false;
                }
                if (FilteredNames.CustomerList[1].CustomerID != 18)
                {
                    ok = false;
                }
            }
            else
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
    }
}


    
using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test data 
        //Create some test data to pass the Method 
        string CustomerFirstname = "Fred";
        string CustomerSurname = "Son";
        string CustomerEmail = "fredson22@gmail.com";
        string CustomerDOB  = DateTime.Now.Date.ToString();
        string Gender = "Male";
        

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer Ancustomer = new clsCustomer();

            Int32 gt = 9;

            Ancustomer.CustomerID = gt;

            Assert.AreEqual(Ancustomer.CustomerID, gt);
        }
        [TestMethod]
        public void CustomerFirstnamePropertyOk()
        {
            clsCustomer Ancustomer = new clsCustomer();

            String gt = "Fred";

            Ancustomer.CustomerFirstname = gt;

            Assert.AreEqual(Ancustomer.CustomerFirstname, gt);
        }
        [TestMethod]
        public void CustomerSurnamePropertyOk()
        {
            clsCustomer Ancustomer = new clsCustomer();

            String gt = "Son";

            Ancustomer.CustomerSurname = gt;

            Assert.AreEqual(Ancustomer.CustomerSurname, gt);
        }

        [TestMethod]
        public void CustomerEmailPropertyOk()
        {
            clsCustomer Ancustomer = new clsCustomer();

            String gt = "fredson22@gmail.com";

            Ancustomer.CustomerEmail = gt;

            Assert.AreEqual(Ancustomer.CustomerEmail, gt);
        }


        [TestMethod]
        public void CustomerDOBPropertyOK()
        {
            clsCustomer Ancustomer = new clsCustomer();

            DateTime gt = DateTime.Now.Date;

            Ancustomer.CustomerDOB = gt;

            Assert.AreEqual(Ancustomer.CustomerDOB, gt);
        }

        [TestMethod]
        public void GenderPropertyOk()
        {
            clsCustomer Ancustomer = new clsCustomer();

            String gt = "male";

            Ancustomer.Gender = gt;

            Assert.AreEqual(Ancustomer.Gender, gt);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer Ancustomer = new clsCustomer();

            Boolean Found = false;

            Int32 CustomerID = 1;

            Found = Ancustomer.Find(CustomerID);

            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer gg = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = gg.Find(CustomerID);

            if (gg.CustomerID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerFirstnameFound()
        {
            clsCustomer gg = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerId = 1;

            Found = gg.Find(CustomerId);

            if (gg.CustomerFirstname != "Fred")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerSurnameFound()
        {
            clsCustomer gg = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerId = 1;

            Found = gg.Find(CustomerId);

            if (gg.CustomerSurname != "Son")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer gg = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerId = 1;

            Found = gg.Find(CustomerId);

            if (gg.CustomerEmail != "Fredson22@gmail.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerDOBFound()
        {
            clsCustomer gg = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerId = 1;

            Found = gg.Find(CustomerId);

            if (gg.CustomerDOB != Convert.ToDateTime("03/05/1999"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestGenderFound()
        {
            clsCustomer gg = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerId = 1;

            Found = gg.Find(CustomerId);

            if (gg.Gender != "Male")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);
            if (Error == "")
            
                Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstnameMinLessOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerFirstname = "";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstnameMin()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerFirstname = "g";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstnameMinPlusOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerFirstname = "gg";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstnameMaxLessOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerFirstname = "ggggg";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstnameMax()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerFirstname = "gggggg";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerSurnameMaxPlusOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerSurname = "ggggggg";


            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFistnameMid()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerFirstname, CustomerSurname = "ggg";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstnameExtremeMax()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string CustomerFirstname = "";
            CustomerFirstname = CustomerFirstname.PadRight(500, 'g');

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBExtremeMin()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            string CustomerDOB = TestDate.ToString();

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustomerDOBMinLessOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(-1);

            string CustomerDOB = TestDate.ToString();

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBMin()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;


            string CustomerDOB = TestDate.ToString();

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBMinPlusOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(1);

            string CustomerDOB = TestDate.ToString();

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBExtremeMax()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            string CustomerDOB = TestDate.ToString();

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBInvalidData()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";



            string CustomerDOB = "this is not a date";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMinLessOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMin()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "g";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMinPlusOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "gg";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMaxLessOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "ggggg";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMax()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "gggggg";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMaxPlusOne()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "ggggggg";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMid()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "ggg";

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderExtremeMax()
        {
            clsCustomer gg = new clsCustomer();

            String Error = "";

            string Gender = "";
            Gender = Gender.PadRight(500, 'g');

            Error = gg.Valid(CustomerFirstname, CustomerSurname, CustomerEmail, CustomerDOB, Gender);

            Assert.AreNotEqual(Error, "");
        }
    }

}


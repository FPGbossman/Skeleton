using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        private int staffId;

        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);
        }


        [TestMethod]
        public void StaffIdPropertyOK()
        {     //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data
            int TestData = 1;
            //assign the data to the property
            AnStaff.staffId = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(AnStaff.staffId, TestData);
        }

        [TestMethod]
        public void StaffFullnamePropertyOK()
        {     //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data
            String TestData = "";
            //assign the data to the property
            AnStaff.staffFullname = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(AnStaff.staffFullname, TestData);
        }

        [TestMethod]
        public void startDatePropertyOK()
        {     //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.startDate = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(AnStaff.startDate, TestData);
        }

        [TestMethod]
        public void staffRolePropertyOK()
        {     //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data
            String TestData = "";
            //assign the data to the property
            AnStaff.staffRole = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(AnStaff.staffRole, TestData);
        }

        [TestMethod]
        public void availabilityPropertyOK()
        {     //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data
            bool TestData = true;
            //assign the data to the property
            AnStaff.availability = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(AnStaff.availability, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            int StaffId = 1;
            Found = AnStaff.Find(StaffId);
            Assert.IsTrue(Found);

        }
        

        
                [TestMethod]
    public void TestStaffNoFound()
    {
        //create an instance of the class we want to create
        clsStaff AnStaff = new clsStaff();
        //boolean variable to store the result of the search
        Boolean Found = false;
        //boolean variable to record if data is OK (assume it is)
        Boolean OK = true;
        //create some test data to use with the method
        int staffId = 1;
        //invoke the method
        Found = AnStaff.Find(staffId);
        //check the address no
        if (AnStaff.staffId != 1)
        {
            OK = false;
        }
        //test to see that the result is correct
        Assert.IsTrue(OK);
    }
        [TestMethod]
        public void TestStaffFullnameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int staffId = 1;
            //invoke the method
            Found = AnStaff.Find(staffId);
            //check the property
            if (AnStaff.staffFullname != "")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStartDate()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int staffId = 1;
            //invoke the method
            Found = AnStaff.Find(staffId);
            //check the property
            if (AnStaff.startDate !=Convert.ToDateTime(""))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffRoleFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int staffId = 1;
            //invoke the method
            Found = AnStaff.Find(staffId);
            //check the property
            if (AnStaff.staffRole != "")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int staffId = 1;
            //invoke the method
            Found = AnStaff.Find(staffId);
            //check the property
            if (AnStaff.availability != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}



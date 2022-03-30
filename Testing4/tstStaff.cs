using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        private int staffId;
        public string Valid(string staffId,
                            string staffFullname,
                            string staffRole,
                            string availability,
                            string startDate,
                            string customerId)
            public class tstStaff
        {

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
                startDate TestData = startDate.Now.Date;
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
                if (AnStaff.startDate != Convert.ToDateTime(""))
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
            [TestMethod]

            public void ValidMethodOK()
            {
                clsstaff = Anstaff = new clsstaff();
                string Error = "";
                Error = Anstaff.Valid(StaffId, staffFullname, staffRole, availability, startDate);
                //test to see that the result is correct 
                Assert.AreEqual(Error, "");

            }
            public void StaffIdMin()
            {
                //create an instance of the class we want to create
                clsStaff Anstaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create some test data to pass to the method
                string StaffId = "a"; //this should be ok
                                      //invoke the method
                Error = AnStaff.Valid(StaffId, staffFullname, staffRole, startDate, availability);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffIdMinPlusOne()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create some test data to pass to the method
                string StaffId = "aa"; //this should be ok
                                       //invoke the method
                Error = AnStaff.Valid(StaffId, StaffFullname, StaffRole, StartDate, Availability);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffIdMaxLessOne()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create some test data to pass to the method
                string StaffId = "aaaaa"; //this should be ok
                                          //invoke the method
                Error = AnStaff.Valid(StaffId, staffFullname, staffRole, startDate, availability);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void StaffIdMax()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create some test data to pass to the method
                string StaffId = "aaaaaa"; //this should be ok
                                           //invoke the method
                Error = AnStaff.Valid(StaffId, staffFullname, staffRole, startDate, availability);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffIdMid()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create some test data to pass to the method
                string StaffId = "aaa"; //this should be ok
                                        //invoke the method
                Error = AnStaff.Valid(StaffId, StaffFullname, StaffRole, StartDate, Availability);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]

            public void StartDateExtremeMin()
            {
                clsStaff AnStaff = new clsStaff();
                string Error = "";
                DateTime TestDate;
                TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddYears(-100);
                string StartDate = TestDate.ToString();
                Error = AnStaff.Valid(staffId, StaffFullname, staffRole, StartDate, availability);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StartDateMinLessOne()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create a variable to store the test date data
                StartDate TestDate;
                //set the date totodays date
                TestDate = StartDate.Now.Date;
                //change the date to whatever the date is less 1 day
                TestDate = TestDate.AddDays(-1);
                //convert the date variable to a string variable
                string StartDate = TestDate.ToString();
                //invoke the method
                Error = AnStaff.Valid(staffId, staffFullname, staffRole, StartDate, availability);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StartDateMin()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create a variable to store the test date data
                StartDate TestDate;
                //set the date totodays date
                TestDate = StartDate.Now.Date;
                //convert the date variable to a string variable
                string StartDate = TestDate.ToString();
                //invoke the method
                Error = AnStaff.Valid(staffId, staffFullname, staffRole, StartDate, availability);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void StartDateMinPlusOne()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create a variable to store the test date data
                startDate TestDate;
                //set the date totodays date
                TestDate = startDate.Now.Date;
                //change the date to whatever the date is plus 1 day
                TestDate = TestDate.AddDays(1);
                //convert the date variable to a string variable
                string StartDate = TestDate.ToString();
                //invoke the method
                Error = AnStaff.Valid(staffId, staffFullname, staffRole, StartDate, availability);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StartDateExtremeMax()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //string variable to store any error message
                String Error = "";
                //create a variable to store the test date data
                StartDate TestDate;
                //set the date totodays date
                TestDate = DateTime.Now.Date;
                //change the date to whatever the date is plus 100 years
                TestDate = TestDate.AddYears(100);
                //convert the date variable to a string variable
                string StartDate = TestDate.ToString();
                //invoke the method
                Error = AnStaff.Valid(staffId, staffRole, staffFullname, startDate, availability);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            {
            public void StartDateInvalidData()
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffId = "101";
            string staffFullname = "Hakim Ziyech";
            string staffRole = "admin";
            string startDate = "this is not a date!";
            string availability = "yes";
            Error = Anstaff.Valid(staffId, staffFullname, staffRole, availability, startDate);
            Assert.ArenNotEqual(Error, "");
        }
public string Valid(string staffId, string staffFullname, string staffRole, string availability, string startDate)
        {
            String Error = "";
            startDate DateTemp;
            if (staffId.Length == 0)
            {
                Error = Error + "The staff id may not be blank : ";
            }
            if (staffId.Length > 6)
            {
                Error = Error + "The staff id must be less than 6 characters : ";
            }
            //copy the startDate value to the DateTemp variable
            DateTemp = Convert.ToDateTime(startDate);
            if (DateTemp < startDate.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }
            if (DateTemp > startDate.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future : ";
            }
            //return any error messages
            return Error;
        }


    }
}



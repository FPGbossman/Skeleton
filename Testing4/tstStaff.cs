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
        {

            [TestMethod]
            public void InstanceOK()
            {
                clsStaff AnStaff = new clsStaff();
                Assert.IsNotNull(AnStaff);
            }


            [TestMethod]
            public void StaffIdPropertyOK()
            { 
                clsStaff AnStaff = new clsStaff();
                int AnStaff = 101;
                //assign the data to the property
                AnStaff.staffId = TestData;
                Assert.AreEqual(AnStaff.staffId, TestData);
            }

            [TestMethod]
            public void StaffFullnamePropertyOK()
        { 
                clsStaff AnStaff = new clsStaff();
                String TestData = "";
                AnStaff.staffFullname = TestData;
                Assert.AreEqual(AnStaff.staffFullname, TestData);
            }

            [TestMethod]
            public void startDatePropertyOK()
                clsStaff AnStaff = new clsStaff();
                startDate TestData = startDate.Now.Date;
                AnStaff.startDate = TestData;
                Assert.AreEqual(AnStaff.startDate, TestData);
            }

            [TestMethod]
            public void staffRolePropertyOK()
                clsStaff AnStaff = new clsStaff();
                String TestData = "";
                AnStaff.staffRole = TestData;
                Assert.AreEqual(AnStaff.staffRole, TestData);
            }

            [TestMethod]
            public void availabilityPropertyOK()
                clsStaff AnStaff = new clsStaff();
                bool TestData = true;
                AnStaff.availability = TestData;
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
                clsStaff AnStaff = new clsStaff();
                Boolean Found = false;
                Boolean OK = true;
                int staffId = 1;
                Found = AnStaff.Find(staffId);
                if (AnStaff.staffId != 1)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestStaffFullnameFound()
            {
                clsStaff AnStaff = new clsStaff();
                Boolean Found = false;
                Boolean OK = true;
                int staffId = 1;
                Found = AnStaff.Find(staffId);
                if (AnStaff.staffFullname != "")
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestStartDate()
            {
                clsStaff AnStaff = new clsStaff();
                Boolean Found = false;
                Boolean OK = true;
                int staffId = 1;
                Found = AnStaff.Find(staffId);
                if (AnStaff.startDate != Convert.ToDateTime(""))
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }


            [TestMethod]
            public void TestStaffRoleFound()
            {
                clsStaff AnStaff = new clsStaff();
                Boolean Found = false;
                Boolean OK = true;
                int staffId = 1;
                Found = AnStaff.Find(staffId);
                if (AnStaff.staffRole != "")
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestAvailabilityFound()
            {
                clsStaff AnStaff = new clsStaff();
                Boolean Found = false;
                Boolean OK = true;
                int staffId = 1;
                Found = AnStaff.Find(staffId);
                if (AnStaff.availability != true)
                {
                    OK = false;
                
                Assert.IsTrue(OK);
            }
            [TestMethod]

            public void ValidMethodOK()
            {
                clsstaff = Anstaff = new clsstaff();
                string Error = "";
                Error = Anstaff.Valid(StaffId, staffFullname, staffRole, availability, startDate);
                Assert.AreEqual(Error, "");

            }
            public void StaffIdMin()
            {
                clsStaff Anstaff = new clsStaff();
                String Error = "";
                string StaffId = "a"; //this should be ok
                Error = AnStaff.Valid(StaffId, staffFullname, staffRole, startDate, availability);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffIdMinPlusOne()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                string StaffId = "aa";
                Error = AnStaff.Valid(StaffId, StaffFullname, StaffRole, StartDate, Availability);
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffIdMaxLessOne()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                string StaffId = "aaaaa"; //this should be ok
                Error = AnStaff.Valid(StaffId, staffFullname, staffRole, startDate, availability);
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void StaffIdMax()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                string StaffId = "aaaaaa"; //this should be ok
                Error = AnStaff.Valid(StaffId, staffFullname, staffRole, startDate, availability);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffIdMid()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                string StaffId = "aaa"; //this should be ok
                Error = AnStaff.Valid(StaffId, StaffFullname, StaffRole, StartDate, Availability);
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
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                StartDate TestDate;
                TestDate = StartDate.Now.Date;
                TestDate = TestDate.AddDays(-1);
                string StartDate = TestDate.ToString();
                Error = AnStaff.Valid(staffId, staffFullname, staffRole, StartDate, availability);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StartDateMin()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                StartDate TestDate;
                TestDate = StartDate.Now.Date;
                string StartDate = TestDate.ToString();
                //invoke the method
                Error = AnStaff.Valid(staffId, staffFullname, staffRole, StartDate, availability);
                Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void StartDateMinPlusOne()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                startDate TestDate;
                TestDate = startDate.Now.Date;
                TestDate = TestDate.AddDays(1);
                string StartDate = TestDate.ToString();
                Error = AnStaff.Valid(staffId, staffFullname, staffRole, StartDate, availability);
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StartDateExtremeMax()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                StartDate TestDate;
                TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddYears(100);
                string StartDate = TestDate.ToString();
                Error = AnStaff.Valid(staffId, staffRole, staffFullname, startDate, availability);
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
            return Error;
        }
        [TestMethod]
        public void StaffRoleMinLessOne()
        {
            clsAddress AnAddress = new clsAddress();
            String Error = "";
            string staffRole = "";
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffRole = "o"
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffRole = "oo";
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffRole = "oooooooo";
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffRole = "ooooooooo";
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffRole = "oooooooooo";
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMid()
        {
            clsStaff AnStaff = new clsStaff()
            String Error = "";
            string staffRole = "oooo";
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullnameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffFullname = "";
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullnameMin()
        {
            clsStaff AnStaff = new clsStaff
            String Error = "";
            string staffFullname = "a";
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffFullnameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff
            String Error = "";
            //this should pass
            string staffFullname = "aa";
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullnameMaxLessOne()
        {
            clsAddress AnAddress = new clsAddress();
            //string variable to store any error message
            String Error = "";
            string staffFullname = "";
            staffFullname = staffFullname.PadRight(50, 'a');
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullnameMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffFullname = "";
            staffFullname = staffFullname.PadRight(49, 'a');
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffFullname = "";
            Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
            Assert.AreEqual(Error, "");

            [TestMethod]
        public void StaffFullnameMid()
        {
            clsAddress AnAddress = new clsAddress();
            String Error = "";
                string staffFullname = "";
                staffFullname = staffFullname.PadRight(25, 'a');
                Error = AnStaff.Valid(staffId, staffRole, staffFullname, availability, startDate);
                Assert.AreEqual(Error, "");
            }




    }
}



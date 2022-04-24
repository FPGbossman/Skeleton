using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        String StaffFullname = "John Smith";
        String StaffRole = "User";
        string StartDate = DateTime.Now.Date.ToString();

        public tstStaff(string startDate)
        {
            StartDate = startDate;
        }

        int StaffId = 1;

          
        

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
                int TestData = 101;
                //assign the data to the property
                AnStaff.StaffId = TestData;
                Assert.AreEqual(AnStaff.StaffId, TestData);
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
            { 
                clsStaff AnStaff = new clsStaff();
                DateTime TestData = DateTime.Now.Date;
                AnStaff.startDate = TestData;
                Assert.AreEqual(AnStaff.startDate, TestData);
            }

            [TestMethod]
            public void staffRolePropertyOK()
            { 
                clsStaff AnStaff = new clsStaff();
                String TestData = "";
                AnStaff.staffRole = TestData;
                Assert.AreEqual(AnStaff.staffRole, TestData);
            }

            [TestMethod]
            public void availabilityPropertyOK()
            { 
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
                if (AnStaff.StaffId != 1)
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
                if (AnStaff.staffFullname != "Micheal Jordan")
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
                if (AnStaff.startDate != Convert.ToDateTime("17/02/2022"))
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
                if (AnStaff.staffRole != "Owner")
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
            if (AnStaff.availability != false)
            {
                OK = false;
            }
                Assert.IsTrue(OK);
            }
            [TestMethod]

            public void ValidMethodOK()
            {
                clsStaff Anstaff = new clsStaff();
                string Error = "";
                Error = Anstaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
                Assert.AreEqual(Error, "");

            }
            public void StaffIdMin()
            {
                clsStaff Anstaff = new clsStaff();
                String Error = "";
                string StaffId = "a"; //this should be ok
                Error = Anstaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffIdMinPlusOne()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                string StaffId = "aa";
                Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffIdMaxLessOne()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                string StaffId = "aaaaa"; //this should be ok
                Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void StaffIdMax()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                string StaffId = "aaaaaa"; //this should be ok
                Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void StaffIdMid()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                string StaffId = "aaa"; //this should be ok
                Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
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
                Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StartDateMinLessOne()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                DateTime TestDate;
                TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddDays(-1);
                string StartDate = TestDate.ToString();
                Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StartDateMin()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                DateTime TestDate;
                TestDate = DateTime.Now.Date;
                string StartDate = TestDate.ToString();
                //invoke the method
                Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
            }
            [TestMethod]
            public void StartDateMinPlusOne()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                DateTime TestDate;
                TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddDays(1);
                string StartDate = TestDate.ToString();
                Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void StartDateExtremeMax()
            {
                clsStaff AnStaff = new clsStaff();
                String Error = "";
                DateTime TestDate;
                TestDate = DateTime.Now.Date;
                TestDate = TestDate.AddYears(100);
                string StartDate = TestDate.ToString();
                Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            
            public void StartDateInvalidData()
        { 
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string JoinDate = "this is not a date!";
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, JoinDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffRoleX = "";
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, staffRoleX, StartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffRoleX = "";
            staffRoleX.PadRight(51, 'x');
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, staffRoleX, StartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullnameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullnameMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffFullnameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            //this should pass
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullnameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            string staffFullname = "";
            staffFullname = staffFullname.PadRight(50, 'a');
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullnameMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffFullname = "";
            staffFullname = staffFullname.PadRight(49, 'a');
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffFullnameMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string staffFullname = "";
            staffFullname = staffFullname.PadRight(25, 'a');
            Error = AnStaff.Valid(Convert.ToString(StaffId), StaffFullname, StaffRole, StartDate); ;
            Assert.AreEqual(Error, "");
        }

    }
}



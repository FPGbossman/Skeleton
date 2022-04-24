using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing4
{
    public class tstStaffCollection
    {
    
    [TestClass]
    public class TstStaffCollection        {
            public object AllStaff { get; private set; }

            [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.availability = true;
            TestItem.staffId = 1001;
            TestItem.staffFullname = "Joe Bloggs";
            TestItem.startDate = DateTime.Now.Date;
            TestItem.staffRole = "admin";
            

            TestList.Add(TestItem); //Add item to the test list
            AllStaff.StaffList = TestList; //Assign the data to the property
            Assert.AreEqual(AllStaff.StaffList, TestList); //Ensure the values are the same
        }


        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.availability = true;
            TestStaff.staffId = 1001;
            TestStaff.staffFullname = "Joe Bloggs";
            TestStaff.startDate = DateTime.Now.Date;
            TestStaff.staffRole = "admin";


                AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
                clsStaffCollection AllStaff = new clsStaffCollection();
                List<clsStaff> TestList = new List<clsStaff>();
                clsStaff TestItem = new clsStaff();

                clsStaffCollection AllSuppliers = new clsStaffCollection();
                clsStaff TestStaff = new clsStaff();
                TestStaff.availability = true;
                TestStaff.staffId = 1001;
                TestStaff.staffFullname = "Joe Bloggs";
                TestStaff.startDate = DateTime.Now.Date;
                TestStaff.staffRole = "admin";


                AllStaff.ThisStaff = TestStaff;
                Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
            }

        [TestMethod]
        public void AddMethodOK()
        {
                clsStaffCollection AllStaff = new clsStaffCollection();
                List<clsStaff> TestList = new List<clsStaff>();
                clsStaff TestItem = new clsStaff();
                Int32 PrimaryKey = 0;

                clsStaffCollection AllSuppliers = new clsStaffCollection();
                clsStaff TestStaff = new clsStaff();
                TestStaff.availability = true;
                TestStaff.staffId = 1001;
                TestStaff.staffFullname = "Joe Bloggs";
                TestStaff.startDate = DateTime.Now.Date;
                TestStaff.staffRole = "admin";


                AllStaff.ThisStaff = TestStaff;
                Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

                AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            AllSuppliers.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }
            
    }

}

}

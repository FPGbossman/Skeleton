using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        [TestMethod]
        public void InstanceOk()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            Assert.IsNotNull(AllStaffs);

        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.availability = true;
            TestItem.staffId = 5;
            TestItem.startDate = DateTime.Now.Date;
            TestItem.staffRole = "Owner";
            TestItem.staffFullname = "Alex Jordan";
            TestList.Add(TestItem);
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs.StaffList, TestList);

        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.availability = true;
            TestStaff.staffId = 1;
            TestStaff.startDate = DateTime.Now.Date;
            TestStaff.staffRole = "Admin";
            TestStaff.staffFullname = "Alehandro Junior";
            AllStaffs.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.availability = true;
            TestItem.staffId = 1;
            TestItem.startDate = DateTime.Now.Date;
            TestItem.staffRole = "User";
            TestItem.staffFullname = "Robert Smiths";
            TestList.Add(TestItem);
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.availability = false;
            TestItem.staffId = 20;
            TestItem.startDate = DateTime.Now.Date;
            TestItem.staffRole = "Admin";
            TestItem.staffFullname = "Alessia Sanguini";
            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.staffId = PrimaryKey;
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.availability = true;
            TestItem.staffId = 20;
            TestItem.startDate = DateTime.Now.Date;
            TestItem.staffRole = "Administrator";
            TestItem.staffFullname = "MO Seller";
            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.staffId = PrimaryKey;
            TestItem.availability = false;
            TestItem.staffId = 12;
            TestItem.startDate = DateTime.Now.Date;
            TestItem.staffRole = "User";
            TestItem.staffFullname = "Mo Sow";
            AllStaffs.ThisStaff = TestItem;
            AllStaffs.Update();
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.availability = true;
            TestItem.staffId = 20;
            TestItem.startDate = DateTime.Now.Date;
            TestItem.staffRole = "Administrator";
            TestItem.staffFullname = " Rida Seller";
            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.staffId = PrimaryKey;
            AllStaffs.ThisStaff.Find(PrimaryKey);
            AllStaffs.Delete();
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void ReportByStaffNameMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            FilteredStaffs.ReportByStaffName("");
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);

        }
        [TestMethod]
        public void ReportByStaffIDNoneFound()
        {
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            FilteredStaffs.ReportByStaffName("xxx xxx");
            Assert.AreEqual(0, FilteredStaffs.Count);
        }
        [TestMethod]
        public void ReportByStaffNameTestDataFound()
        {
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaffs.ReportByStaffName("yyy yyy");
            if (FilteredStaffs.Count == 2)
            {
                if (FilteredStaffs.StaffList[0].staffId != 13)
                {
                    OK = false;
                }
                if (FilteredStaffs.StaffList[1].staffId != 15)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }







    }
}
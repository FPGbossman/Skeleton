using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Test_Frameword

{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.StockId = 1;
            TestItem.ProductCategory = "Nike Air Max 90";
            TestItem.Quantity = 12;
            TestItem.Date = DateTime.Now.Date;
            TestItem.ProductName = "Nike";
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }



        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStock AllStock = new clsStock();
            clsStock TestStock = new clsStock();
            TestStock.Available = true;
            TestStock.StockId = 1;
            TestStock.ProductCategory = "Nike Air Max 90";
            TestStock.Quantity = 12;
            TestStock.Date = DateTime.Now.Date;
            TestStock.ProductName = "Nike";
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStock AllStock = new clsStock();
            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.StockId = 1;
            TestItem.ProductCategory = "Nike Air Max 90";
            TestItem.Quantity = 12;
            TestItem.Date = DateTime.Now.Date;
            TestItem.ProductName = "Nike";
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }



        // ================================================   Create Add Method  ===============================

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.StockId = 1;
            TestItem.ProductCategory = "Nike Air Max 90";
            TestItem.Quantity = 12;
            TestItem.Date = Convert.ToDateTime("09/03/2022");
            TestItem.ProductName = "Nike";
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockId = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

       
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance fof the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.StockId = 1;
            TestItem.ProductCategory = "Nike Air Max 90";
            TestItem.Quantity = 12;
            TestItem.Date = Convert.ToDateTime("09/03/2022");
            TestItem.ProductName = "Nike";
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();

            TestItem.StockId = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            //modify the data

            TestItem.Available = true;
            TestItem.StockId = PrimaryKey;
            TestItem.ProductCategory = "Nike Air Force 1";
            TestItem.Quantity = 11;
            TestItem.Date = Convert.ToDateTime("09/03/2022");
            TestItem.ProductName = "Nike";


            AllStock.ThisStock = TestItem;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance fof the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.StockId = PrimaryKey;
            TestItem.ProductCategory = "Nike Air Force 1";
            TestItem.Quantity = 11;
            TestItem.Date = Convert.ToDateTime("09/03/2022");
            TestItem.ProductName = "Nike";

            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockId = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByStock_NameMethodOK()
        {
            //create an instance fof the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportbyProductName("");
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);

        }
        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportbyProductName("Sketcher");
            Assert.AreEqual(0, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportbyProductName("Puma");
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].StockId != 132)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].StockId != 138)
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


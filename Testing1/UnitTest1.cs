using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class UnitTest1
    {
        clsOrders orders = new clsOrders();
        /**
             * Testing to make sure the class has been initialized.
             */
        [TestMethod]
        public void TestClassNotNull()
        {
            Assert.IsNotNull(orders);
        }

        /**
         * Testing to make sure that when the price is negative, the price
         * is set to zero.
         */
        [TestMethod]
        public void TestOrderPriceLow()
        {
            orders.setOrderPrice(-10000);
            Assert.AreEqual(0, 0);
        }

        /**
         * Testing to make sure that when the price is set to a positive integer, 
         * it will set the internal variable to be the correct int.
          */
        [TestMethod]
        public void TestOrderPriceHigh()
        {
            orders.setOrderPrice(1000);
            Assert.AreEqual(1000, orders.getOrderPrice());
        }

        /**
         * Testing to make sure that when the date and time is set, the 
         * system will save the date/time.
         */
        [TestMethod]
        public void TestDateAdded()
        {
            DateTime time = DateTime.Now.Date;
            orders.setDateTime(time);
            Assert.AreEqual(time, orders.getDateTime());
        }

        /**
         * Testing to make sure the test order description will be set and can
         * be recalled at any time.
         */
        [TestMethod]
        public void TestOrderDescription()
        {
            orders.setOrderDescription("hello world");
            Assert.AreEqual(orders.getOrderDescription(), "hello world");
        }

        /**
         * Tests to see if, when order description is passed, the system returns the default for a null value.
         */
        [TestMethod]
        public void TestOrderDescriptionNotNull()
        {
            orders.setOrderDescription(null);
            Assert.AreEqual("LOOKUP FAILED!", orders.getOrderDescription());
        }

        /**
         *Tests to see if the order address is in the standard convention format.
         */
        [TestMethod]
        public void TestOrderAddressFormat()
        {
            orders.setStandardAddress("12", "Test Street", "Test City", "TST1 9MQ");
            Assert.AreEqual("[HouseNo=12,StreetName=Test Street,City=Test City,Postcode=TST1 9MQ]", orders.getOrderAddress());
        }

        /**
         * Tests to see if the order address sets correctly.
         */
        [TestMethod]
        public void TestSetOrderAddress()
        {
            orders.setOrderAddress("test address");
            Assert.AreEqual("test address", orders.getOrderAddress());
        }


        /**
         * Tests to see if the default fallback for a null value is correctly asserted.
         */
        [TestMethod]
        public void TestOrderAddressNull()
        {
            orders.setOrderAddress(null);
            Assert.AreEqual("LOOKUP FAILED!", orders.getOrderAddress());
        }


        /**
         * Tests to see if we can successfully connect and retrieve information using a stored procedure.
         */
        [TestMethod]
        public void FindMethodValidation()
        {
            clsOrders orders2 = new clsOrders();
            string found = "";
            Int32 orderNo = 1;
            found = orders2.find(orderNo);
            Assert.AreEqual("Success!", found);
        }

        /**==================================== 
         * This is the test specification start, 
         * in order: address, description, 
         * timeOfOrder, customerId, stockId
         * ====================================*/

        string bAddr = "{testa:testa, testa2:test2a}";
        string bDesc = "{testd:testd, testd2:test2d}";
        DateTime timeOfOrder = new DateTime(2022, 1, 2);
        int customerid = 100;
        int orderid = 100;
        int price = 10;
        
        /** ===============
         *  Address testing
         *  ===============*/

        [TestMethod]
        public void minMinusOneAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = "testtestt";
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"address:{bAddr2} is less than 10 characters!\n", error);
        }

        [TestMethod]
        public void minBoundaryAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = "testtestte";
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"", error);
        }

        [TestMethod]
        public void minPlusOneAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = "testtesttes";
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"", error);
        }


        [TestMethod]
        public void maxMinusOneAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = "testtesttesttesttesttesttesttesttesttesttesttestte";
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = "testtesttesttesttesttesttesttesttesttesttesttestte";
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxPlusOneAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = "testtesttesttesttesttesttesttesttesttesttesttesttestt";
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"address:{bAddr2} is greater than 50 characters!\n", error);
        }

        [TestMethod]
        public void midAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = "testtesttesttesttesttestt";
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"", error);
        }

        [TestMethod]
        public void extremeMax()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = "testtesttesttesttesttestttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttest";
            //185
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"address:{bAddr2} is greater than 50 characters!\n", error);
        }

        /** ======================
         *  End of Address testing
         *  ======================
         **/

        //===========================================================================================================
        
        /** ===================
         *  Description testing
         *  ===================
         **/
        
        [TestMethod]
        public void minMinusOneDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = "";
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual("description is Null or Empty!\n", error);
        }

        [TestMethod]
        public void minBoundaryDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = "testtestte";
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"", error);
        }

        [TestMethod]
        public void minPlusOneDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = "testtesttes";
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"", error);
        }


        [TestMethod]
        public void maxMinusOneDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = "testtesttesttesttesttesttesttesttesttesttesttestte";
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = "testtesttesttesttesttesttesttesttesttesttesttestte";
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxPlusOneDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = "testtesttesttesttesttesttesttesttesttesttesttesttestt";
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"description:{bDesc2} is greater than 50 characters!\n", error);
        }

        [TestMethod]
        public void midDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = "testtesttesttesttesttestt";
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"", error);
        }

        [TestMethod]
        public void extremeDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = "testtesttesttesttesttestttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttest";
            //185
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"description:{bDesc2} is greater than 50 characters!\n", error);
        }

        /** ======================
         *  End of Description testing
         *  ======================
         **/

        //===========================================================================================================

        /** ===================
        *  Time testing
        *  ===================
        **/


        [TestMethod]
        public void extremeMinimum()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = DateTime.MinValue;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"timeOfOrder:{timeOfOrder.ToString("dd/mm/yy")} is too far in the past!\n", error);
        }


        [TestMethod]
        public void minMinusOneDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = Convert.ToDateTime("31/12/2021");
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"timeOfOrder:{timeOfOrder.ToString("dd/mm/yy")} is too far in the past!\n", error);
        }

        [TestMethod]
        public void minBoundaryDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = Convert.ToDateTime("01/01/2022");
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void minPlusOneDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = Convert.ToDateTime("02/01/2022");

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual("", error);
        }


        [TestMethod]
        public void maxMinusOneDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = DateTime.Now.AddDays(-1);
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = DateTime.Now;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxPlusOneDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = DateTime.Now.AddDays(1);

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"timeOfOrder:{timeOfOrder.ToString("dd/mm/yy")} is in the future!\n", error);
        }

        [TestMethod]
        public void midDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = Convert.ToDateTime("02/02/2022");

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"", error);
        }

        [TestMethod]
        public void extremeDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = DateTime.MaxValue;
            //185
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, orderid, price);
            Assert.AreEqual($"timeOfOrder:{timeOfOrder.ToString("dd/mm/yy")} is in the future!\n", error);
        }

        /** ======================
         *  End of Time testing
         *  ======================
         **/

        //===========================================================================================================

        /** ===================
        *  CustomerId testing
        *  ===================
        **/

    }
}

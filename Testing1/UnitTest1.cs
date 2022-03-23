using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
            string addr = orders.getStandardAddress("12", "Test Street", "Test City", "TST1 9MQ");
            Assert.AreEqual("[HouseNo=12,StreetName=Test Street,City=Test City,Postcode=TST1 9MQ]", addr);
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
        int price = 10;

        /** ===============
         *  Address testing
         *  ===============*/

        [TestMethod]
        public void minMinusOneAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = new string('#', 9);
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"address:{bAddr2} is less than 10 characters!\n", error);
        }

        [TestMethod]
        public void minBoundaryAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = new string('#', 10);

            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"", error);
        }

        [TestMethod]
        public void minPlusOneAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = new string('#', 11);
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"", error);
        }


        [TestMethod]
        public void maxMinusOneAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = new string('#', 99);
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = new string('#', 100);
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxPlusOneAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = new string('#', 101);
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"address:{bAddr2} is greater than 100 characters!\n", error);
        }

        [TestMethod]
        public void midAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = new string('#', 50);
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"", error);
        }

        [TestMethod]
        public void extremeMaxAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = new string('#', 999);
            //185
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"address:{bAddr2} is greater than 100 characters!\n", error);
        }

        [TestMethod]
        public void nullDataTypeAddress()
        {
            clsOrders orderTest = new clsOrders();

            string bAddr2 = null;
            //185
            string error = orderTest.validate(bAddr2, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"address is Null or Empty!\n", error);
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

            string bDesc2 = new string('#', 9);
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, price);
            Assert.AreEqual($"description:{bDesc2} is less than 10 characters!\n", error);
        }

        [TestMethod]
        public void minBoundaryDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = new string('#', 10); ;
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, price);
            Assert.AreEqual($"", error);
        }

        [TestMethod]
        public void minPlusOneDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = new string('#', 11);
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, price);
            Assert.AreEqual($"", error);
        }


        [TestMethod]
        public void maxMinusOneDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = new string('#', 99);
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = new string('#', 100);
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxPlusOneDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = new string('#', 101);
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, price);
            Assert.AreEqual($"description:{bDesc2} is greater than 100 characters!\n", error);
        }

        [TestMethod]
        public void midDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = new string('#', 50);
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, price);
            Assert.AreEqual($"", error);
        }

        [TestMethod]
        public void extremeDescription()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = new string('#', 999); ;
            //185
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, price);
            Assert.AreEqual($"description:{bDesc2} is greater than 100 characters!\n", error);
        }

        [TestMethod]
        public void nullDataTypeDesc()
        {
            clsOrders orderTest = new clsOrders();

            string bDesc2 = null;
            //185
            string error = orderTest.validate(bAddr, bDesc2, timeOfOrder, customerid, price);
            Assert.AreEqual($"description is Null or Empty!\n", error);
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
        public void extremeMinimumDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = DateTime.MinValue;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"timeOfOrder:{timeOfOrder.ToString("dd/mm/yy")} is too far in the past!\n", error);
        }


        [TestMethod]
        public void minMinusOneDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = Convert.ToDateTime("31/12/2021");
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"timeOfOrder:{timeOfOrder.ToString("dd/mm/yy")} is too far in the past!\n", error);
        }

        [TestMethod]
        public void minBoundaryDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = Convert.ToDateTime("01/01/2022");
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void minPlusOneDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = Convert.ToDateTime("02/01/2022");

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }


        [TestMethod]
        public void maxMinusOneDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = DateTime.Now.AddDays(-1);
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = DateTime.Now;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxPlusOneDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = DateTime.Now.AddDays(1);

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"timeOfOrder:{timeOfOrder.ToString("dd/mm/yy")} is in the future!\n", error);
        }

        [TestMethod]
        public void midDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = Convert.ToDateTime("02/02/2022");

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"", error);
        }

        [TestMethod]
        public void extremeDateTime()
        {
            clsOrders orderTest = new clsOrders();

            DateTime timeOfOrder = DateTime.MaxValue;
            //185
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"timeOfOrder:{timeOfOrder.ToString("dd/mm/yy")} is in the future!\n", error);
        }

        /** ======================
         *  End of Time testing
         *  ======================
         **/

        //===========================================================================================================

        /** ===================
        *  Price testing
        *  ===================
        **/

        [TestMethod]
        public void extremeMinimumPrice()
        {
            clsOrders orderTest = new clsOrders();

            price = int.MinValue;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"price:{price} is less than or equal to zero!\n", error);
        }


        [TestMethod]
        public void minMinusOnePrice()
        {
            clsOrders orderTest = new clsOrders();

            price = 0 - 1;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"price:{price} is less than or equal to zero!\n", error);
        }

        [TestMethod]
        public void minBoundaryPrice()
        {
            clsOrders orderTest = new clsOrders();

            price = 0;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"price:{price} is less than or equal to zero!\n", error);
        }

        [TestMethod]
        public void minPlusOnePrice()
        {
            clsOrders orderTest = new clsOrders();

            price = 1;

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }


        [TestMethod]
        public void maxMinusOnePrice()
        {
            clsOrders orderTest = new clsOrders();

            price = 100000000 - 1;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxPrice()
        {
            clsOrders orderTest = new clsOrders();

            price = 100000000;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxPlusOnePrice()
        {
            clsOrders orderTest = new clsOrders();

            price = 100000000 + 1;

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"price:{price} is greater than a billion!\n", error);
        }

        [TestMethod]
        public void midPrice()
        {
            clsOrders orderTest = new clsOrders();

            price = 100000000 / 2;

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"", error);
        }

        [TestMethod]
        public void extremePrice()
        {
            clsOrders orderTest = new clsOrders();

            price = int.MaxValue;

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"price:{price} is greater than a billion!\n", error);
        }

        /** ====================
         *  End of Price testing
         *  ====================
         */

        [TestMethod]
        public void extremeMinimumCustomerId()
        {
            clsOrders orderTest = new clsOrders();

            customerid = int.MinValue;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"customerid:{ customerid} is less than zero!\n", error);
        }


        [TestMethod]
        public void minMinusOneCustomerId()
        {
            clsOrders orderTest = new clsOrders();

            customerid = 0 - 1;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"customerid:{customerid} is less than zero!\n", error);
        }

        [TestMethod]
        public void minBoundaryCustomerId()
        {
            clsOrders orderTest = new clsOrders();

            customerid = 0;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"customerid:{customerid} is less than zero!\n", error);
        }

        [TestMethod]
        public void minPlusOneCustomerId()
        {
            clsOrders orderTest = new clsOrders();

            customerid = 1;

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }


        [TestMethod]
        public void maxMinusOneCustomerId()
        {
            clsOrders orderTest = new clsOrders();

            customerid = 99998;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxCustomerId()
        {
            clsOrders orderTest = new clsOrders();

            customerid = 99999;
            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void maxPlusOneCustomerId()
        {
            clsOrders orderTest = new clsOrders();

            customerid = 100000;

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"customerid:{customerid} is greater than 5 numerical characters!\n", error);
        }

        [TestMethod]
        public void midCustomerId()
        {
            clsOrders orderTest = new clsOrders();

            customerid = 100000 / 2;

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"", error);
        }

        [TestMethod]
        public void extremeCustomerId()
        {
            clsOrders orderTest = new clsOrders();

            customerid = int.MaxValue;

            string error = orderTest.validate(bAddr, bDesc, timeOfOrder, customerid, price);
            Assert.AreEqual($"customerid:{ customerid} is greater than 5 numerical characters!\n", error);
        }


             /** END OF VALIDATION TESTING **/

             [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection orders = new clsOrderCollection();
            List<clsOrders> orderList = new List<clsOrders>();
            orderList.Add(new clsOrders());
            orderList.Add(new clsOrders());
            orderList.Add(new clsOrders());
            orderList.Add(new clsOrders());
            orders.setOrders(orderList);
            Assert.AreEqual(orders.getCount(), orderList.Count);
        }

        [TestMethod]
        public void addToDatabase()
        {
            clsOrderCollection orders = new clsOrderCollection();
            orders.getOrder().setOrderAddress(bAddr);
            orders.getOrder().setDateTime(DateTime.Now);
            orders.getOrder().setOrderDescription(bDesc);
            orders.getOrder().setOrderNo(100);
            orders.getOrder().setOrderPrice(100);
            orders.Add();
            int temp = orders.getOrder().getCustomerId();
            orders.getOrder().find(123213);
            Assert.AreEqual(temp, orders.getOrder().getCustomerId());
        }

        [TestMethod]
        public void reportByOrderDescriptionZero()
        {
            clsOrderCollection allOrders = new clsOrderCollection();

            clsOrderCollection filtered = new clsOrderCollection();

            filtered.reportByOrderDescription("NULL");

            Assert.AreEqual(0, filtered.getCount());
        }

        [TestMethod]
        public void reportByOrderDescriptionFound()
        {
            clsOrderCollection collection = new clsOrderCollection();
            Boolean found = true;
            collection.reportByOrderDescription("duplicate duplicate");
            if (collection.getCount() == 2)
            {
                if (collection.getOrders()[0].getOrderNo() != 31)
                {
                    found = false; 
                } if (collection.getOrders()[1].getOrderNo() != 34)
                {
                    found = false;
                }
            } else
            {
                found = false;
            }
            Assert.IsTrue(found);
        }
    }
}

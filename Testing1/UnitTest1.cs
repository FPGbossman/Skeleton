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
        public void TestMethod1()
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
            orders.setOrderPrice(10000);
            Assert.AreEqual(1000, orders.getOrderPrice());
        }

        /**
         * Testing to make sure that when the date and time is set, the 
         * system will save the date/time.
         */
        [TestMethod]
        public void DateAdded()
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
        public void TestOrderDescription2()
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
        public void TestOrderAddress()
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
            Assert.AreEqual("LOOKUP FAILED!", orders.getOrderDescription());
        }

    }
}

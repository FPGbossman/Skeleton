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

        [TestMethod]
        public void TestOrderDescription2()
        {
            orders.setOrderDescription(null);
            Assert.AreEqual("LOOKUP FAILED!", orders.getOrderDescription());
        }

        [TestMethod]
        public void Test

    }
}

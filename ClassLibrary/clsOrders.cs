using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ClassLibrary
{  
    public class clsOrders {

        private ArrayList orders;
        private string orderDescription;
        private string orderAddress;
        private int orderPrice;
        private DateTime dateTime;
        private int stockID;
        private int customerId;
        private string[] operands;

        public void setOrderPrice(int orderPrice)
        {
            if (orderPrice < 0)
            {
                this.orderPrice = orderPrice;
            }
            else
            {
                this.orderPrice = 0;
            }
        }

        public int getOrderPrice()
        {
            return this.orderPrice;
        }

        public String getOrderDescription()
        {
            return this.orderDescription;
        }

        public void setOrderDescription(String orderDescription)
        {
            if (!String.IsNullOrEmpty(orderDescription))
            {
                this.orderDescription = orderDescription;

            }
            else
            {
                this.orderDescription = "LOOKUP FAILED!";
            }
        }

        public void setOrderAddress(String orderAddress)
        {
            if (!String.IsNullOrEmpty(orderAddress))
            {
                this.orderAddress = orderAddress;

            }
            else
            {
                this.orderAddress = "LOOKUP FAILED!";
            }
        }

        public string getOrderAddress()
        {
            return this.orderAddress;
        }

        public void setDateTime(DateTime dateTime)
        {
            this.dateTime = dateTime.Date;
        }

        public DateTime getDateTime()
        {
            return this.dateTime;
        }

        public void getStockId()
        {
            
        }

        public void getCustomerId()
        {

        }

        public void deleteOrder()
        {

        }

        /// <summary>
        /// standardizeAddress takes an input and standardizes it into a string where the system can process it. Stored in [X=Y,A=B] style.
        /// </summary>
        /// <param name="houseNo"> Number of the house</param>
        /// <param name="strtName">Name of the street</param>
        /// <param name="city">Name of the city</param>
        /// <param name="postcode">Postcode of the customer</param>
        public void setStandardAddress(string houseNo, string strtName, string city, string postcode)
        {   
            this.setOrderAddress($"[HouseNo={houseNo},StreetName={strtName},City={city},Postcode={postcode}]");
        }

        public void breakupOrder(string order)
        {
            //string regex = "((.*?))|(.+?(?=<|$))";
            //Regex tag = new Regex(regex);
            //List<string> list = tag.Split(order).ToList();

            //for (int i = 0; i < order.Length; i++)
            //{
            //    string[] operands = Regex.Split(order, @"(?<=<.*?>)");
            //}

            this.setOrderDescription(order);
            //this.setOrderDescription(operands.ToString());
        }
    }
}
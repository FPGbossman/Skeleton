using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ClassLibrary
{  
    public class clsOrders {

        private ArrayList orders;
        private int orderNo;
        private string orderDescription;
        private string orderAddress;
        private int orderPrice;
        private DateTime dateTime;
        private int stockID;
        private int customerId;

        /// <summary>
        /// This method will return a success state depending on if the order id could be found, 
        /// and set the tables values to internal values.
        /// 
        /// </summary>
        public string find(int orderId)
        {
            try
            {
                clsDataConnection db = new clsDataConnection();
                if (db != null)
                {
                    db.AddParameter("@orderid", orderId);
                    db.Execute("proc_Order_Search");
                    if (db.Count == 1)
                    {
                        orderNo = Convert.ToInt32(db.DataTable.Rows[0]["OrderNo"]);
                        orderDescription = Convert.ToString(db.DataTable.Rows[0]["OrderDescription"]);
                        orderAddress = Convert.ToString(db.DataTable.Rows[0]["Address"]);
                        orderPrice = Convert.ToInt32(db.DataTable.Rows[0]["OrderPrice"]);
                        //customerId = Convert.ToInt32(db.DataTable.Rows[0]["CustomerId"]);
                        dateTime = Convert.ToDateTime(db.DataTable.Rows[0]["OrderDate"]);
                        return "Success!";
                    } else
                    {
                        return "ERROR: Tables returned 0! The query you have selected does not exist.";
                    }
                } else
                {
                    return "ERROR: DB connection failed!";
                }
            } catch (Exception e)
            {
                Console.WriteLine("====");
                Console.WriteLine(e.Message);
                return e.Message;
            }
        }

        public void setOrderPrice(int orderPrice)
        {
            if (orderPrice >= 0)
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

        public int getOrderNo()
        {
            return this.orderNo;
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
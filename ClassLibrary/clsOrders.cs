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
                        customerId = Convert.ToInt32(db.DataTable.Rows[0]["CustomerId"]);
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


        /** ===========
         *  Order Price
         *  ===========
         */
        public int getOrderPrice()
        {
            return this.orderPrice;
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

        /** =================
         *  Order Description
         *  =================
         */

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
        public String getOrderDescription()
        {
            return this.orderDescription;
        }

        public int getOrderNo()
        {
            return this.orderNo;
        }

        public void setCustomerId(int custid)
        {
            this.customerId = custid;
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

        public string validate(string address, string description, DateTime timeOfOrder, int customerid, int price)
        {
            string error = "";
            try
            {
                //Addresses
                if (string.IsNullOrEmpty(address))
                {
                    error += $"address is Null or Empty!\n";
                } else
                {
                    if (address.Length < 10)
                    {
                        error += $"address:{address} is less than 10 characters!\n";

                    }
                    if (address.Length > 100)
                    {
                        error += $"address:{address} is greater than 50 characters!\n";
                    }
                }

                //Description
                if (string.IsNullOrEmpty(description))
                {
                    error += $"description is Null or Empty!\n";
                }
                else
                {
                    if (description.Length < 10)
                    {
                        error += $"description:{description} is less than 10 characters!\n";

                    }
                    if (description.Length > 50)
                    {
                        error += $"description:{description} is greater than 50 characters!\n";
                    }
                }


                //DateTime
                if (timeOfOrder.GetType() != new DateTime().GetType())
                {
                    error += $"timeOfOrder is not the correct data type.";
                } else
                {
                    if (DateTime.Now < timeOfOrder)
                    {
                        error += $"timeOfOrder:{timeOfOrder.ToString("dd/mm/yy")} is in the future!\n";
                    }
                    if (timeOfOrder < Convert.ToDateTime("1/1/2022"))
                    {
                        error += $"timeOfOrder:{timeOfOrder.ToString("dd/mm/yy")} is too far in the past!\n";
                    }
                }
                {

                }

                if (customerid < 0)
                {
                    error += $"customerid:{customerid} is less than zero!\n";
                }

                int testInt = 0;
                if (price.GetType() != testInt.GetType())
                {
                    error += $"timeOfOrder is not the correct data type.";
                } else { 
                    if (price <= 0)
                    {
                        error += $"price:{price} is less than or equal to zero!\n";
                    }
                    if (price > 100000000)
                    {
                        error += $"price:{price} is greater than a billion!\n";
                    }
                }

            } catch (Exception e)
            {
                error += $"Critical error!: {e.Message}";
            }

            return error;
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

        public int getCustomerId()
        {
            return this.customerId;
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
        public string getStandardAddress(string houseNo, string strtName, string city, string postcode)
        {   
            return $"[HouseNo={houseNo},StreetName={strtName},City={city},Postcode={postcode}]";
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
using System;
using System.Collections;

namespace ClassLibrary
{  
    public class clsOrders {

        private ArrayList orders;
        private string orderDescription;
        private int orderPrice;
        private DateTime dateTime;
        private int stockID;
        private int customerId;

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
                this.orderDescription = "null";
            }
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
    }
}
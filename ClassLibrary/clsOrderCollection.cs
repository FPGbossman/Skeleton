using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrders> orderList = new List<clsOrders>();
        clsOrders orders = new clsOrders();

        public clsOrders getOrder()
        {
            return orders;
        }

        public void setOrder(clsOrders orders)
        {
            this.orders = orders;
        }

        public List<clsOrders> getOrders()
        {
            return this.orderList;
        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderDescription", orders.getOrderDescription());
            DB.AddParameter("@OrderDate", orders.getDateTime());
            DB.AddParameter("@OrderPrice", orders.getOrderPrice());
            DB.AddParameter("@CustomerID", orders.getCustomerId());
            DB.AddParameter("@orderPrice", orders.getOrderPrice());
            return DB.Execute("proc_Order_Insert");
        }
    }
}

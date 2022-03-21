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

            DB.AddParameter("@orderDescription", orders.getOrderDescription());
            DB.AddParameter("@orderDate", orders.getDateTime());
            DB.AddParameter("@orderPrice", orders.getOrderPrice());
            DB.AddParameter("@customerID", orders.getCustomerId());
            DB.AddParameter("@orderPrice", orders.getOrderPrice());
            return DB.Execute("proc_Order_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@orderdescription", orders.getOrderDescription());
            DB.AddParameter("@orderdate", orders.getDateTime());
            DB.AddParameter("@orderprice", orders.getOrderPrice());
            DB.AddParameter("@customeriD", orders.getCustomerId());
            DB.AddParameter("@orderprice", orders.getOrderPrice());
            DB.AddParameter("@orderid", orders.getOrderNo());
            DB.Execute("proc_Order_Update");

        }
    }
}

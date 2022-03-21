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
        int count;

        public clsOrderCollection() {
            //Instantiation of orderlist
            int index = 0;
            int recordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("proc_Order_SelectAll");
            recordCount = DB.Count;

            while (index < recordCount)
            {
                clsOrders tempOrders = new clsOrders();

                tempOrders.setCustomerId(Convert.ToInt32(DB.DataTable.Rows[index]["CustomerID"]));
                tempOrders.setDateTime(Convert.ToDateTime(DB.DataTable.Rows[index]["OrderDate"]));
                tempOrders.setOrderAddress(Convert.ToString(DB.DataTable.Rows[index]["Address"]));
                tempOrders.setOrderDescription(Convert.ToString(DB.DataTable.Rows[index]["OrderDescription"]));
                tempOrders.setOrderNo(Convert.ToInt32(DB.DataTable.Rows[index]["OrderNo"]));
                tempOrders.setOrderPrice(Convert.ToInt32(DB.DataTable.Rows[index]["OrderPrice"]));

                orderList.Add(tempOrders);
                index++;
            }
        }



        public clsOrders getOrder()
        {
            return orders;
        }

        public void setOrder(clsOrders orders)
        {
            this.orders = orders;
        }


        public void setOrders(List<clsOrders> orderList)
        {
            this.orderList = orderList;
        }
        public List<clsOrders> getOrders()
        {
            return this.orderList;
        }

        public int getCount()
        {
            return this.orderList.Count;
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
            DB.AddParameter("@address", orders.getOrderAddress());
            DB.AddParameter("@orderno", orders.getOrderNo());
            DB.Execute("proc_Order_Update");

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int orderNo = Session["Order"];
        if (IsPostBack == false)
        {
            if (orderNo != -1)
            {
                DisplayAddress();
                clsOrders orders = new 
                collection.
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsOrders orders = new clsOrders();

        try
        {
            int orderid = Convert.ToInt32(OrderIDSub.Text);
            string v = orders.find(orderid);

            QueryInfo.Text = v;

            if (!String.IsNullOrEmpty(v))
            {
                OrderIDReq.Text = Convert.ToString(orders.getOrderNo());
                OrderAddressReq.Text = orders.getOrderAddress();
                OrderDescReq.Text = orders.getOrderDescription();
                OrderTimeReq.Text = Convert.ToString(orders.getDateTime());
                OrderPriceReq.Text = Convert.ToString(orders.getOrderPrice());
                CustomerIDReq.Text = Convert.ToString(orders.getCustomerId());

            }

        }
        catch
        {
            QueryInfo.Text = "Conversion Failed. Mistype of OrderID. Must be integer.";
        }
    }


    protected void OrderIDSub_TextChanged(object sender, EventArgs e)
    {

    }

    protected void OrderAddressReq_TextChanged(object sender, EventArgs e)
    {

    }

    protected void OrderPriceReq_TextChanged(object sender, EventArgs e)
    {

    }

    protected void OrderDescReq_TextChanged(object sender, EventArgs e)
    {

    }

    protected void OrderIDReq_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CustomerIDReq_TextChanged(object sender, EventArgs e)
    {

    }
}
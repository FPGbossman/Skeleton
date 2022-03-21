using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    clsOrders orders = new clsOrders();

    protected void Page_Load(object sender, EventArgs e)
    {
        int orderNo = Convert.ToInt32(Session["Order"]);
        if (IsPostBack == false)
        {
            if (orderNo != -1)
            {
                DisplayAddress(orderNo);
            }
        }
    }

    protected void DisplayAddress(int orderNo)
    {
        clsOrderCollection collection = new clsOrderCollection();
        collection.getOrder().find(orderNo);
        OrderIDReq.Text = Convert.ToString(collection.getOrder().getOrderNo());
        OrderAddressReq.Text = collection.getOrder().getOrderAddress();
        OrderAddressReq.ReadOnly = false;
        OrderDescReq.Text = collection.getOrder().getOrderDescription();
        OrderDescReq.ReadOnly = false;
        OrderTimeReq.Text = Convert.ToString(collection.getOrder().getDateTime());
        OrderTimeReq.ReadOnly = false;
        OrderPriceReq.Text = Convert.ToString(collection.getOrder().getOrderPrice());
        OrderPriceReq.ReadOnly = false;
        CustomerIDReq.Text = Convert.ToString(collection.getOrder().getCustomerId());
        CustomerIDReq.ReadOnly = false;
        Update.Visible = true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        try
        {
            Update.Visible = false;
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

    protected void Button1_Click1(object sender, EventArgs e)
    {
        string error = orders.validate(OrderAddressReq.Text, OrderDescReq.Text, Convert.ToDateTime(OrderTimeReq.Text), Convert.ToInt32(CustomerIDReq.Text), Convert.ToInt32(OrderPriceReq.Text));
        if (error == "")
        {
            clsOrderCollection collect = new clsOrderCollection();
            clsOrders tempOrder = new clsOrders();
            tempOrder.setCustomerId(Convert.ToInt32(CustomerIDReq.Text));
            tempOrder.setOrderAddress(OrderAddressReq.Text);
            tempOrder.setOrderDescription(OrderDescReq.Text);
            tempOrder.setDateTime(Convert.ToDateTime(OrderTimeReq.Text));
            tempOrder.setOrderPrice(Convert.ToInt32(OrderPriceReq.Text));
            tempOrder.setOrderNo(Convert.ToInt32(OrderIDReq.Text));
            collect.setOrder(tempOrder);
            collect.Update();

        } else
        {
            QueryInfo.Text = error;
        }
    }
}
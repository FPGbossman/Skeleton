using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*clsOrders orders = new clsOrders();

        orders = (clsOrders)Session["Orders"];
        Response.Write("Order Description: " + orders.getOrderDescription() + "<br><br>");
        Response.Write("Order address: " + orders.getOrderAddress() + "<br><br>");
        Response.Write("Time of order: " + orders.getDateTime().ToString());*/

        if (IsPostBack == false)
        {
            DisplayAddresses();
        }
    }

    protected void Add_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void Edit_Click(object sender, EventArgs e)
    {
        int stockId;

        if (OrderList.SelectedIndex != -1)
        {
            Session["Order"] = Convert.ToInt32(OrderList.SelectedValue); ;

            Response.Redirect("OrderViewer.aspx");
        } else
        {
            Error.Text = "Please select a record to edit";
        }
    }

    protected void DisplayAddresses()
    {
        clsOrderCollection orderCollection = new clsOrderCollection();
        OrderList.DataSource = orderCollection.getOrders();
        OrderList.DataValueField = "OrderNo";
        OrderList.DataTextField = "Order No";
        OrderList.DataBind();
    }
}
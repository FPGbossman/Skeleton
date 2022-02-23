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
        clsOrders orders = new clsOrders();

        orders = (clsOrders) Session["Orders"];
        Response.Write("Order Description: " + orders.getOrderDescription() + "<br><br>");
        Response.Write("Order address: " + orders.getOrderAddress() + "<br><br>");
        Response.Write("Time of order: " + orders.getDateTime().ToString());
    }
}
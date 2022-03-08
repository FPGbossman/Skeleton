using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Postcode_TextChanged(object sender, EventArgs e)
    {

    }

    protected void City_TextChanged(object sender, EventArgs e)
    {

    }

    protected void StrtName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void HouseNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void StockQuantity_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Confirm_Click(object sender, EventArgs e)
    {
        clsOrders orders = new clsOrders();
        orders.breakupOrder(StockQuantity.Text);
        orders.setDateTime(DateTime.Now);
        orders.setStandardAddress(HouseNo.Text, StrtName.Text, City.Text, Postcode.Text);
        Session["Orders"] = orders;
        Response.Redirect("OrderViewer.aspx");
    }

    protected void Cancel_Click(object sender, EventArgs e)
    {

    }
}
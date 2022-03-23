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

        if (OrderList.SelectedIndex != -1)
        {
            Session["Order"] = Convert.ToInt32(OrderList.SelectedValue); ;

            Response.Redirect("OrderViewer.aspx");
        } else
        {
            Error.Text = "Please select a record to edit.";
        }
    }

    protected void DisplayAddresses()
    {
        clsOrderCollection orderCollection = new clsOrderCollection();
        OrderList.DataSource = orderCollection.getOrders();
        OrderList.DataValueField = "orderNo";
        OrderList.DataTextField = "orderDescription";
        OrderList.DataBind();
    }

    protected void OrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Delete_Click(object sender, EventArgs e)
    {
        if (OrderList.SelectedIndex != -1)
        {
            Session["OrderNo"] = Convert.ToInt32(OrderList.SelectedValue); ;

            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            Error.Text = "Please select a record to delete.";
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsOrderCollection collection = new clsOrderCollection();
        collection.reportByOrderDescription(txtBoxSearch.Text);
        OrderList.DataSource = collection.getOrders();
        OrderList.DataValueField = "orderNo";
        OrderList.DataTextField = "orderDescription";
        OrderList.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        clsOrderCollection collection = new clsOrderCollection();
        collection.reportByOrderDescription("");
        OrderList.DataSource = collection.getOrders();
        OrderList.DataValueField = "orderNo";
        OrderList.DataTextField = "orderDescription";
        OrderList.DataBind();
    }
}
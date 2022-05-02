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
        if (IsPostBack == false)
        {
            DisplayAddress();
        }
    }
    void DisplayAddress()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        lstCustomer.DataValueField = "CustomerId";
        lstCustomer.DataTextField = "CustomerEmail";
        lstCustomer.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if (lstCustomer.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblEroor.Text = "Please select a record to delete from the list";
        }
    }

    protected void txtbox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ReportByCustomername(txtbox.Text);
        lstCustomer.DataSource = Customer.CustomerList;
        lstCustomer.DataValueField = "CustomerId";
        lstCustomer.DataTextField = "CustomerFirstname";
        lstCustomer.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ReportByCustomername("");
        txtbox.Text = "";
        lstCustomer.DataSource = Customer.CustomerList;
        lstCustomer.DataValueField = "CustomerId";
        lstCustomer.DataTextField = "CustomerFirstname";
        lstCustomer.DataBind();
    }
}



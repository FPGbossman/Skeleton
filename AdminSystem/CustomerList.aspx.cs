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
            DisplayAddresses();
        }

    }

    void DisplayAddresses()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        lstCustomerList.DataSource = Customer.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "CustomerFirstame";
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;

        Response.Redirect("CustDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;

        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);

            Session["CustomerID"] = CustomerID;

            Response.Redirect("CustDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;

        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);

            Session["CustomerID"] = CustomerID;

            Response.Redirect("CustConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        Customers.ReportByCustomername(txtFindCustomerFirstname.Text);

        lstCustomerList.DataSource = Customers.CustomerList;

        lstCustomerList.DataValueField = "CustomerID";

        lstCustomerList.DataTextField = "CustomerFirstname";

        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        txtFindCustomerFirstname.Text = " ";


        lstCustomerList.DataSource = Customers.CustomerList;

        lstCustomerList.DataValueField = "CustomerID";

        lstCustomerList.DataTextField = "CustomerFirstname";

        lstCustomerList.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;

        Response.Redirect("CustDataEntry.aspx")
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}


    
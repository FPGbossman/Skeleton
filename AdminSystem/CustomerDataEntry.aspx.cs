using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Confirm_Click(object sender, EventArgs e)

    {
    }

    protected void Confirm_Click1(object sender, EventArgs e)
    {
        //Create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the house no
        AnCustomer.customerId = int.Parse(txt_Customerno.Text);
        AnCustomer.CustomerFirstname = txtcustomerfirstname.Text;
        AnCustomer.CustomerSurnamename = txtcustomersurname.Text;
        AnCustomer.CustomerEmail = txtCustomerEmail.Text;
        AnCustomer.CustomerDOB = txtDOB.Text;
        //Store the customer in the ssession object 
        Session["AnCustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}
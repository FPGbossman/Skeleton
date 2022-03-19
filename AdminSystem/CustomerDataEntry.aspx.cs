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
        AnCustomer.CustomerId = Convert.ToInt32(txt_CustomerId.Text);
        AnCustomer.CustomerFirstname = txtCustomerFirstname.Text;
        AnCustomer.CustomerSurnamename = txtCustomerSurname.Text;
        AnCustomer.CustomerEmail = txtCustomerEmail.Text;
        AnCustomer.CustomerDOB = Convert.ToDateTime (txtCustomerSurname.CustomerDOB.Text);
        AnCustomer.Gender = txtGender.Text;
        //Store the customer in the ssession object 
        Session["AnCustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
 clsCustomer gg = new clsCustomer();

        Int32 CustomerID;

        Boolean Found = false;

        CustomerID = Convert.ToInt32(txtCustomerID.Text);

        Found = gg.Find(CustomerID);

        if (Found == true)
        {
           
            txtCustomerFirstname.Text = gg.CustomerFirstname;
            txtCustomerSurname.Text = gg.CustomerSurname;
            txtCustomerEmail.Text = gg.CustomerEmail;
            txtCustomerDOB.Text = gg.CustomerDOB.ToString();
            txtGender.Text = gg.Gender;
            

        }

    }


    
}

     
       
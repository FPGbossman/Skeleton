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
        clsCustomer Customer = new clsCustomer();

        Customer = (clsCustomer) Session["AnCustomer"];


        Response.Write("CustomerID" + " = " + Customer.CustomerID + "<br><br>");
        Response.Write("CustomerFirstname" + " = " + Customer.CustomerFirstname + "<br><br>");
        Response.Write("CustomerSurname" + " = " + Customer.CustomerSurname + "<br><br>");
        Response.Write("CustomerEmail" + " = " + Customer.CustomerEmail + "<br><br>");
        Response.Write("CustomerDOB" + " = " + Customer.CustomerDOB + "<br><br>");
        Response.Write("Gender" + " = " + Customer.Gender + "<br><br>");



    }
}
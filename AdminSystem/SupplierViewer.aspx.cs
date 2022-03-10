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
        clssupplier ASupplier = new clssupplier();
        ASupplier = (clssupplier)Session["ASupplier"];

        Response.Write("Supplier Name: " + ASupplier.SupplierName + "<br><br>");
        Response.Write("Are They an Active Supplier? "+ ASupplier.CurrentSupplier + "<br><br>");
        Response.Write("Been a Supplier Since: " + ASupplier.SupplierSince + "<br><br>");
        Response.Write("Supplier Address: " + ASupplier.SupplierAddress + "<br><br>");
        Response.Write("Contact Number: " + ASupplier.ContactNumber + "<br><br>");

    }
}
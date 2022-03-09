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
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clssupplier ASupplier = new clssupplier();     
        ASupplier.SupplierName = tbxName.Text;
        ASupplier.CurrentSupplier = chkCurrent.Checked;
        ASupplier.SupplierSince = tbxSupplierSince.Text;
        ASupplier.SupplierAddress = tbxAddress.Text;
        ASupplier.ContactNumber = long.Parse(tbxContactNumber.Text);

        Session["ASupplier"]= ASupplier;      
        Response.Redirect("SupplierViewer.aspx");

       
       
 
    }

}
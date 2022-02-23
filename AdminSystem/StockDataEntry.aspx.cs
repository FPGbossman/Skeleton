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
        clsStock AStock = new clsStock();
        AStock.ProductCategory = tbProductCategory.Text;
        AStock.Quantity = int.Parse(tbQuantity.Text);
        AStock.Date = tbDate.Text;
        AStock.Available = tbAvailable.Text;
        AStock.ProductName = tbProductName.Text;
        Session["AStock"] = AStock;
        Response.Redirect("Stock Viewer.aspx");
    }
}
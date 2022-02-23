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
        clsStock AStock = new clsStock();
      
        AStock = (clsStock)Session["AStock"];

        Response.Write("ProductCategory" + " = " +AStock.ProductCategory + "<br><br>");
        Response.Write("Quantity" + " = " + AStock.Quantity + "<br><br>");
        Response.Write("Date" + " = " + AStock.Date + "<br><br>");
        Response.Write("Available" + " = " + AStock.Available + "<br><br>");
        Response.Write("ProductName" + " = "  + AStock.ProductName + "<br><br>");
       
        //--------------------------------------------



    }
   

}

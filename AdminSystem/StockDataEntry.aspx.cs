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
        AStock.StockId = tbStockId.Text;
        AStock.ProductCategory = tbProductCategory.Text;
        AStock.Quantity = tbQuantity.Text;
        AStock.Date = tbDate.Text;
        AStock.Available = tbAvailable.Text;
        AStock.ProductName = tbProductName.Text;
        Session["AStock"] = AStock;
        Response.Redirect("Stock Viewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        Int32 StockId;
        Boolean Found = false;
        StockId = Convert.ToInt32(tbStockId.Text);
        Found = AStock.Find(StockId);

        if (Found == true)
        {
            tbStockId.Text = AStock.StockId;
            tbProductCategory.Text = AStock.ProductCategory;
            tbDate.Text = AStock.Date;
            tbAvailable.Text = AStock.Available;
            tbProductCategory.Text = AStock.ProductCategory; 

        }
    }
}

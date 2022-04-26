using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StockId; 
    protected void Page_Load(Object sender, EventArgs e)
    {
        StockId = Convert.ToInt32(Session["StockId"]);
        if (IsPostBack == false)
        {

            if (StockId != -1){
                DisplayStock(); 

            }
        }
    }
void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ThisStock.Find(StockId);
        tbStockId.Text = Stock.ThisStock.StockId.ToString();
        tbProductName.Text = Stock.ThisStock.ProductName;
        tbAvailable.Text = Stock.ThisStock.Available.ToString();
        tbDate.Text = Stock.ThisStock.Date.ToString();
        tbProductCategory.Text = Stock.ThisStock.ProductCategory;
        tbQuantity.Text = Stock.ThisStock.Quantity.ToString();

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //var to store any error messages
        string Error;
        //create an instance of the address class
        clsStockCollection AStock = new clsStockCollection();
        //use the objects validation method to test the data
        Error = AStock.ThisStock.Validation(tbProductCategory.Text, tbQuantity.Text, tbDate.Text, tbProductName.Text);
        //if there is no error message
        if (Error == "")
        {
            //if we are adding a new record
            if (StockId == -1)
            {

                AStock.ThisStock.ProductCategory = tbProductCategory.Text;
                AStock.ThisStock.Quantity = Convert.ToInt32(tbQuantity.Text);
                AStock.ThisStock.Date = Convert.ToDateTime(tbDate.Text);
                AStock.ThisStock.Available = Convert.ToBoolean(tbAvailable.Text);
                AStock.ThisStock.ProductName = tbProductName.Text;
                AStock.Add();
            }
            else//this is an existing record to update
            {

                AStock.ThisStock.Find(StockId);
                AStock.ThisStock.ProductCategory = tbProductCategory.Text;
                AStock.ThisStock.Quantity = Convert.ToInt32(tbQuantity.Text);
                AStock.ThisStock.Date = Convert.ToDateTime(tbDate.Text);
                AStock.ThisStock.Available = Convert.ToBoolean(tbAvailable.Text);
                AStock.ThisStock.ProductName = tbProductName.Text;
                AStock.Update();
            }
            //all done so redirect back to the main page
            Response.Redirect("Stock List.aspx");
        }
        else//there are errors
        {
            //display the error message
            lblError.Text = Error;
        }
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
            tbStockId.Text = Convert.ToString(AStock.StockId);
            tbProductName.Text = Convert.ToString(AStock.ProductName);
            tbQuantity.Text = Convert.ToString(AStock.Quantity);
            tbDate.Text = Convert.ToString(AStock.Date);
            tbAvailable.Text = Convert.ToString(AStock.Available);
            tbProductCategory.Text = Convert.ToString(AStock.ProductCategory);

        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Stock List.aspx");
    }

    
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StockId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockId = Convert.ToInt32(Session["StockId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // this  code will navigat to the address page!
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(StockId);
        StockBook.Delete();
        Response.Redirect("Stock List.aspx");
    }



    protected void btnNo_Click(object sender, EventArgs e)
    {
        // this  code will navigat to the address page!

        Response.Redirect("Stock List.");
    }
}
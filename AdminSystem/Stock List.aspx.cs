using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 StockId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockId = Convert.ToInt32(Session["StockId"]);
        {
            if (IsPostBack == false)
            {
                //update the list box
                DisplayStock();
            }
        }

    }

    protected void lstStock_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ThisStock.Find(Convert.ToInt32(StockId));

        lstStock.DataSource = Stock.StockList;
        lstStock.DataValueField = "StockId";
        lstStock.DataTextField = "ProductName";
        lstStock.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        {
            Session["StockId"] = -1;
            Response.Redirect("StockDataEntry.aspx");
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StockId;
        if (lstStock.SelectedIndex != -1)
        {
            StockId = Convert.ToInt32(lstStock.SelectedValue);
            Session["StockId"] = StockId;
            Response.Redirect("StockDataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please select a record, so that it can be edited from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StockId;
        if (lstStock.SelectedIndex != -1)
        {
            StockId = Convert.ToInt32(lstStock.SelectedValue);
            Session["StockId"] = StockId;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportbyProductName(txtFilter.Text);
        lstStock.DataSource = Stock.StockList;
        lstStock.DataValueField = "StockId";
        lstStock.DataTextField = "ProductName";
        lstStock.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportbyProductName("");
        lstStock.DataSource = Stock.StockList;
        lstStock.DataValueField = "StockId";
        lstStock.DataTextField = "ProductName";
        lstStock.DataBind();
    }
}
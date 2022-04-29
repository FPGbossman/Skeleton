using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySuppliers();
        }
    }

    void DisplaySuppliers()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        lbxSupplierList.DataSource = Suppliers.SupplierList;
        lbxSupplierList.DataValueField = "SupplierID";
        lbxSupplierList.DataTextField = "SupplierName";
        lbxSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierID"] = -1;
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;

        if (lbxSupplierList.SelectedIndex != 1)
        {
            SupplierID = Convert.ToInt32(lbxSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;
        if (lbxSupplierList.SelectedIndex != 1)
        {
            SupplierID = Convert.ToInt32(lbxSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierConfirmDelete.aspxx");
        }
    }
}
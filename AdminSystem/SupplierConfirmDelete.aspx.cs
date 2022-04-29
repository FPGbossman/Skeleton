﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class SupplierConfirmDelete : System.Web.UI.Page
{
    Int32 SupplierID;

    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        ASupplier.ThisSupplier.Find(SupplierID);
        ASupplier.Delete();
        Response.Redirect("SupplierList.aspx");
    }
}
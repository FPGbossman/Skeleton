using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffId"]);
    }

    protected void btnyes_Click(object sender, EventArgs e)
    {
        clsStaffCollection Book = new clsStaffCollection();
        Book.ThisStaff.Find(StaffID);
        Book.Delete();
        Response.Redirect("StaffList.aspx");
    }
}
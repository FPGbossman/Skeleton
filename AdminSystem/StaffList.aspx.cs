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
        if(IsPostBack == false)
        {
            DisplayAddress();
        }
    }
    void DisplayAddress()
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        lstStaff.DataValueField = "StaffId";
        lstStaff.DataTextField = "StaffRole";
        lstStaff.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if(lstStaff.SelectedIndex  != -1)
        {
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            Session["StaffId"] = StaffID;
            Response.Redirect("StaffConfirmDelete.aspx");
        }else
        {
            lblEroor.Text = "Please select a record to delete from the list";
        }
    }

    protected void txtbox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportByStaffName(txtbox.Text);
        lstStaff.DataSource = Staffs.StaffList;
        lstStaff.DataValueField = "StaffId";
        lstStaff.DataTextField = "StaffFullname";
        lstStaff.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportByStaffName("");
        txtbox.Text = "";
        lstStaff.DataSource = Staffs.StaffList;
        lstStaff.DataValueField = "StaffId";
        lstStaff.DataTextField = "StaffFullname";
        lstStaff.DataBind();
    }
}
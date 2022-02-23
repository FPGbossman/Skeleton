using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff Anstaff = new clsStaff();
        Anstaff.staffFullname = tbstaffFullname.Text;
        Anstaff.startDate = tbstartDate.Text;
        Anstaff.staffRole = tbstaffRole.Text;
        Anstaff.availability = tbavailability.Text;


        Session["Anstaff"] = Anstaff;
        Response.Redirect("Staff Viewer.aspx");
    }
}

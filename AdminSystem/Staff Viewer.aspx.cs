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
        clsStaff AnStaff = new clsStaff();
        AnStaff = (clsStaff)Session["AnStaff"];
        Response.Write("StaffFullName" + " = " + AnStaff.staffFullname + "<br>");
        Response.Write("StartDate" + " = " + AnStaff.startDate + "<br>");
        Response.Write("StaffRole" + " = " + AnStaff.staffRole + "<br>");
        Response.Write("availability" + " = " + AnStaff.availability + "<br>");


    }
}
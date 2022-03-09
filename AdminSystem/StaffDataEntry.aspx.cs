using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{

        
        protected void Page_Load1(object sender, EventArgs e)
        { 
            //create a new instance of clsStaff
            clsStaff AnStaff = new clsStaff();
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the the staff number for this entry
        Response.Write(AnStaff.staffId);
    }
        protected void Page_Load2(object sender, EventArgs e)
        {
            //create a new instance of clsStaff
            clsStaff AnStaff = new clsStaff();
            //get the data from the session object
            AnStaff = (clsStaff)Session["AnStaff"];
            //display the the staff number for this entry
            Response.Write(AnStaff.staffFullname);

        }

    protected void Page_Load3(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the the staff number for this entry
        Response.Write(AnStaff.staffRole);
    }
    protected void Page_Load4(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the the staff number for this entry
        Response.Write(AnStaff.startDate);

    }
    protected void Page_Load5(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the the staff number for this entry
        Response.Write(AnStaff.availability);

    }


        protected void btnOK_Click(object sender, EventArgs e)
        {


             clsStaff Anstaff = new clsStaff();
        Anstaff.staffFullname = tbstaffFullname.Text;
        Anstaff.startDate = DateTime.Parse(tbstartDate.Text);
        Anstaff.staffRole = tbstaffRole.Text;
        Anstaff.availability = bool.Parse(tbavailability.Text);
        Anstaff.staffId = int.Parse(tbstaffId.Text);

        Session["Anstaff"] = Anstaff;
        Response.Redirect("Staff Viewer.aspx");
    }
}

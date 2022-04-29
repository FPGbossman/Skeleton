using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplierID;

    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if (IsPostBack == false)
        {
            if(SupplierID != -1)
            {
                DisplaySupplier();
            }
        }
    }

    public void DisplaySupplier()
    {
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        ASupplier.ThisSupplier.Find(SupplierID);
        tbxSupplierID.Text = ASupplier.ThisSupplier.SupplierID.ToString();
        tbxName.Text = ASupplier.ThisSupplier.SupplierName;
        chkCurrent.Checked = ASupplier.ThisSupplier.CurrentSupplier;
        tbxSupplierSince.Text = ASupplier.ThisSupplier.SupplierSince.ToString();
        tbxAddress.Text = ASupplier.ThisSupplier.SupplierAddress;
        tbxContactNumber.Text=ASupplier.ThisSupplier.ContactNumber;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        
        clssupplier ASupplier = new clssupplier();  
        string SupplierName = tbxName.Text;
        string SupplierSince = tbxSupplierSince.Text;
        string SupplierAddress = tbxAddress.Text;
        string ContactNumber = tbxContactNumber.Text;
        string Error = "";
        

        Error = ASupplier.Valid(SupplierName, SupplierSince, SupplierAddress, ContactNumber);
        if (Error == "")
        {
            ASupplier.SupplierID = SupplierID;
            ASupplier.SupplierName = SupplierName;
            ASupplier.CurrentSupplier = chkCurrent.Checked;
            ASupplier.SupplierSince = Convert.ToDateTime(SupplierSince);
            ASupplier.SupplierAddress = SupplierAddress;
            ASupplier.ContactNumber = ContactNumber;

            clsSupplierCollection SupplierList = new clsSupplierCollection();
            if (SupplierID == -1)
            {
                SupplierList.ThisSupplier = ASupplier; 
                SupplierList.Add();
            }
            else
            {
                SupplierList.ThisSupplier.Find(SupplierID);
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Update();
            }
           
            Response.Redirect("SupplierViewer.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }

   protected void btnFind_Click(object sender, EventArgs e)
    {
        clssupplier ASupplier = new clssupplier();
        Int32 SupplierID;
        Boolean Found = false;
        SupplierID = Convert.ToInt32(tbxSupplierID.Text);
        Found = ASupplier.Find(SupplierID);
        if (Found == true)
        {
            tbxSupplierID.Text = Convert.ToString(ASupplier.SupplierID);
            tbxName.Text = ASupplier.SupplierName;
            chkCurrent.Checked = Convert.ToBoolean(ASupplier.CurrentSupplier);
            tbxSupplierSince.Text = Convert.ToString(ASupplier.SupplierSince);
            tbxAddress.Text = ASupplier.SupplierAddress;
            tbxContactNumber.Text = ASupplier.ContactNumber;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}
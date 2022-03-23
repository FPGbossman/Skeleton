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

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Postcode_TextChanged(object sender, EventArgs e)
    {

    }

    protected void City_TextChanged(object sender, EventArgs e)
    {

    }

    protected void StrtName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void HouseNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void StockQuantity_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Confirm_Click(object sender, EventArgs e)
    {
        clsOrders orders = new clsOrders();

        try
        {
            DateTime current = DateTime.Now;
            string address = orders.getStandardAddress(HouseNo.Text, StrtName.Text, City.Text, Postcode.Text);
            int price = Convert.ToInt32(Price.Text);
            int customerid = Convert.ToInt32(CustomerID.Text);
            string description = StockQuantity.Text;
            string validate = orders.validate(address, description, current, customerid, price);
            if (validate == "")
            {
                orders.setOrderAddress(address);
                orders.setOrderDescription(description);
                orders.setOrderPrice(price);
                orders.setDateTime(current);
                orders.setCustomerId(customerid);
                clsOrderCollection collection = new clsOrderCollection();
                collection.setOrder(orders);
                collection.Add();
                Response.Redirect("OrderList.aspx");
            } else
            {
                Error.Text = validate;
            }
        } catch (Exception ex)
        {
            Error.Text = ex.Message;
        } 
    }

    protected void Cancel_Click(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
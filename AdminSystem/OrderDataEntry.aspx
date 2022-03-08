<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>data antry</title>
</head>
<body>
    <form id="form1" runat="server">
        Data entry page (create an order)</body></html><br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Enter stock id and quantity"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Format must be in &lt;\StockID: Quantity&gt; for each stock"></asp:Label>
    <br />
    <p>
    <asp:TextBox ID="StockQuantity" runat="server" Height="90px" style="margin-bottom: 0px" Width="330px" OnTextChanged="StockQuantity_TextChanged"></asp:TextBox>
    </p>
    <p>
        ==========</p>
    <p>
        Enter address:</p>
    <asp:Label ID="lblHouseNo" runat="server" Text="House number" width="57px"></asp:Label>
    <asp:TextBox ID="HouseNo" runat="server" OnTextChanged="HouseNo_TextChanged"></asp:TextBox>
    <br />
    <asp:Label ID="lblStrtName" runat="server" Text="Street name" width="57px"></asp:Label>
    <asp:TextBox ID="StrtName" runat="server" OnTextChanged="StrtName_TextChanged"></asp:TextBox>
    <br />
    <asp:Label ID="lblCity" runat="server" Text="Town/City" width="57px"></asp:Label>
    <asp:TextBox ID="City" runat="server" OnTextChanged="City_TextChanged"></asp:TextBox>
    <br />
    <asp:Label ID="lblPostcode" runat="server" Text="Postcode"></asp:Label>
    <asp:TextBox ID="Postcode" runat="server" OnTextChanged="Postcode_TextChanged"></asp:TextBox>
    <br />
    <br />
    [lblError]<br />
    <p>
        <asp:Button ID="Confirm" runat="server" Text="OK" OnClick="Confirm_Click" />
        <asp:Button ID="Cancel" runat="server" Text="Cancel" OnClick="Cancel_Click" />
    </p>
    </form>


<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>data antry</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Data entry page (create an order)</h1></body></html><br />
    <br />
    <h2> Enter Products</h2>
    <asp:Label ID="Label1" runat="server" Text="Enter stock id and quantity"></asp:Label><br />
    <p>
    <asp:TextBox ID="StockQuantity" runat="server" Height="90px" style="margin-bottom: 0px" Width="330px" OnTextChanged="StockQuantity_TextChanged"></asp:TextBox>
    </p>
    <h2>Enter an address</h2>
    <asp:Label ID="lblHouseNo" runat="server" Text="House number" width="90px"></asp:Label>
    <asp:TextBox ID="HouseNo" runat="server" OnTextChanged="HouseNo_TextChanged"></asp:TextBox>
    <br />
    <asp:Label ID="lblStrtName" runat="server" Text="Street name" width="90px"></asp:Label>
    <asp:TextBox ID="StrtName" runat="server" OnTextChanged="StrtName_TextChanged"></asp:TextBox>
    <br />
    <asp:Label ID="lblCity" runat="server" Text="Town/City" width="90px"></asp:Label>
    <asp:TextBox ID="City" runat="server" OnTextChanged="City_TextChanged"></asp:TextBox>
    <br />
    <asp:Label ID="lblPostcode" runat="server" Text="Postcode"></asp:Label>
    <asp:TextBox ID="Postcode" runat="server" OnTextChanged="Postcode_TextChanged" Height="18px" Width="148px"></asp:TextBox>
    <br />
    <br />
    <h2>Enter customer ID</h2>
    <p>
    <asp:Label ID="Label3" runat="server" Text="Customer ID" height="22px"></asp:Label>
    <asp:TextBox ID="CustomerID" runat="server" OnTextChanged="TextBox1_TextChanged" width="110px"></asp:TextBox>
    <br />
    </p>
    <h2>Enter total price: </h2>&nbsp;<asp:Label ID="Label4" runat="server" Text="Total price"></asp:Label>
    <asp:TextBox ID="Price" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <br />
    <br />
    <p>
        <asp:Button ID="Confirm" runat="server" Text="OK" OnClick="Confirm_Click" />
        <asp:Button ID="Cancel" runat="server" Text="Cancel" OnClick="Cancel_Click" />
    </p>
    <asp:Label ID="Error" runat="server"></asp:Label>
    </form>


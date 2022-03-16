<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <h1> Order entry </h1>
            <h2>Enter order id: </h2>
            <asp:Label ID="OrderIDSubLbl" runat="server" Text="Order ID:" width="111px"></asp:Label>
            <asp:TextBox ID="OrderIDSub" runat="server" width="111px" OnTextChanged="OrderIDSub_TextChanged"></asp:TextBox>
             <br />   <asp:Button ID="Query" runat="server" OnClick="Button1_Click" Text="Query" />
            <br />

        </div>
        <div>
            <h1>Order information</h1>
            <asp:Label ID="OrderID" runat="server" Text="Order ID: " width="111px"></asp:Label>
            <asp:TextBox ID="OrderIDReq" runat="server" width="111px" ReadOnly="True" OnTextChanged="OrderIDReq_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="OrderAddress" runat="server" Text="Order Address: " width="111px"></asp:Label>
            <asp:TextBox ID="OrderAddressReq" runat="server" width="407px" ReadOnly="True" OnTextChanged="OrderAddressReq_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="OrderDesc" runat="server" Text="Order Description: " width="111px"></asp:Label>
            <asp:TextBox ID="OrderDescReq" runat="server" width="412px" ReadOnly="True" OnTextChanged="OrderDescReq_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="OrderTime" runat="server" Text="Time of order: " width="111px"></asp:Label>
            <asp:TextBox ID="OrderTimeReq" runat="server" width="109px" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="CustomerID" runat="server" Text="Customer ID: " width="110px"></asp:Label>
            <asp:TextBox ID="CustomerIDReq" runat="server" width="111px" ReadOnly="True" OnTextChanged="CustomerIDReq_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="OrderPrice" runat="server" Text="Price of order: " width="111px"></asp:Label>
            <asp:TextBox ID="OrderPriceReq" runat="server" width="111px" ReadOnly="True" OnTextChanged="OrderPriceReq_TextChanged"></asp:TextBox>
            <br />

        </div>
        <div>
            <h2> Query information: </h2>
            <asp:Label ID="QueryInfo" runat="server" Text="" width="111px"></asp:Label>

        </div>
    </form>
</body>
</html>

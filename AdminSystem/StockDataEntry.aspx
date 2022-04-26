﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 371px">
    <form id="form1" runat="server">
        <div>
            &nbsp;<asp:Label ID="lblStockId" runat="server" Text="StockId"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbStockId" runat="server" Width="100px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnFind" runat="server" Height="28px" Text="Find" Width="53px" OnClick="btnFind_Click" />
            <br />
            <br />
            <asp:Label ID="lblProductCategory" runat="server" Text="ProductCategory" width="49px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbProductCategory" runat="server" width="100px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="49px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbQuantity" runat="server" width="100px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDate" runat="server" Text="Date" width="49px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbDate" runat="server" width="100px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblAvailable" runat="server" Text="Available" width="49px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbAvailable" runat="server" Height="25px" Width="100px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblProductName" runat="server" Text="ProductName" width="49px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbProductName" runat="server" width="100px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Height="27px" OnClick="btnOK_Click" Text="OK" Width="70px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Height="27px" style="margin-top: 0px" Text="Cancel" Width="70px" OnClick="btnCancel_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
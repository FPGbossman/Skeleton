<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Supplier DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Underline="True" Text="Supplier Form"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Label ID="lblClientName" runat="server" Text="Supplier Name:                 " width="250px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="tbxName" runat="server"></asp:TextBox>
&nbsp;<p>
            <asp:Label ID="lblCurrentSupplier" runat="server" Text="Are They a Current Supplier?" width="250px"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkCurrent" runat="server" Text="Yes" />
        </p>
        <p>
            <asp:Label ID="lblSupplierSince" runat="server" Text="When Have They Been a Supplier Since?"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbxSupplierSince" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAddress" runat="server" Text="Address:" width="250px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="tbxAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblContactNumber" runat="server" Text="Contact Number:" width="250px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="tbxContactNumber" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" BorderStyle="Ridge" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" BorderStyle="Ridge" Text="Cancel" />
        </p>
    </form>
</body>
</html>

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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Supplier ID:"></asp:Label>
&nbsp;&nbsp;
        &nbsp;<asp:TextBox ID="tbxSupplierID" runat="server"></asp:TextBox>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblClientName" runat="server" Text="Supplier Name:                 " width="250px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxName" runat="server" width="128px"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCurrentSupplier" runat="server" Text="Are They a Current Supplier?" width="250px" Height="19px"></asp:Label>
            &nbsp;&nbsp;
            <asp:CheckBox ID="chkCurrent" runat="server" Text="Yes" />
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSupplierSince" runat="server" Text="When Have They Been a Supplier Since?" width="250px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="tbxSupplierSince" runat="server" width="128px"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblAddress" runat="server" Text="Address:" width="250px"></asp:Label>
            <asp:TextBox ID="tbxAddress" runat="server" style="margin-left: 7px" Width="136px"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblContactNumber" runat="server" Text="Contact Number:" width="250px" style="margin-bottom: 1px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="tbxContactNumber" runat="server" width="128px"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblError" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" BorderStyle="Ridge" OnClick="btnOK_Click" Text="OK" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" BorderStyle="Ridge" Text="Cancel" OnClick="btnCancel_Click" Width="69px" />
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Password1 {
            margin-left: 16px;
        }
        #PWDCustomerPassword {
            width: 145px;
            margin-left: 20px;
        }
    </style>
</head>
<body style="height: 294px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="IblCustomerno" runat="server" Text="Customer Number"></asp:Label>
            <asp:TextBox ID="txt_CustomerId" runat="server" style="margin-left: 18px" Width="137px"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Label ID="lblCustomerFirstname" runat="server" Text="Customer Firstname "></asp:Label>
        <asp:TextBox ID="txtCustomerFirstname" runat="server" style="margin-left: 5px" Width="141px"></asp:TextBox>
        <br />
        <p>
            <asp:Label ID="lblCustomersurname" runat="server" Text="Customer Surname "></asp:Label>
            <asp:TextBox ID="txtCustomerSurname" runat="server" style="margin-left: 12px" Width="140px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblcustomeremail" runat="server" Text="Customer Email"></asp:Label>
            <asp:TextBox ID="txtCustomerEmail" runat="server" style="margin-left: 35px; margin-top: 0px" Width="144px"></asp:TextBox>
        </p>
        <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
        <asp:TextBox ID="txtGender" runat="server" style="margin-left: 80px" Width="140px"></asp:TextBox>
        <br />
        <asp:Label ID="LBLDOB" runat="server" Text="Customer D.O.B"></asp:Label>
        <asp:TextBox ID="txtCustomerDOB" runat="server" style="margin-left: 21px; margin-top: 1px" Width="143px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />
        <br />
        <asp:Label ID="LblError" runat="server" Text="[lblError]"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Confirm" runat="server" Text="Login" Width="75px" OnClick="Confirm_Click1" />
        <asp:Button ID="cancel" runat="server" style="margin-left: 91px" Text="cancel" Width="94px" />
        <br />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 321px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblstaffId" runat="server" Text="staffId" width="53px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbstaffId" runat="server" Height="22px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblstaffFullname" runat="server" Text="staffFullname" width="53px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbstaffFullname" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;<asp:Label ID="lblstartDate" runat="server" Text="startDate" width="53px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbstartDate" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Label ID="lblstaffRole" runat="server" Text="staffRole"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbstaffRole" runat="server"></asp:TextBox>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblavaible" runat="server" Text="Avalaible"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkAvailable" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text=":" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>

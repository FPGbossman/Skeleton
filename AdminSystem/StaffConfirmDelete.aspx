<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 54px; margin-left: 0px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="are you sure you want to delete this record"></asp:Label>
        </div>
        <asp:Button ID="btnyes" runat="server" OnClick="btnyes_Click" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" Text="No" />
    </form>
</body>
</html>

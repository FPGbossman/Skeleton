<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaff" runat="server" Height="479px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="318px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" />
        </p>
        <p>
            <asp:Label ID="lblEroor" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>

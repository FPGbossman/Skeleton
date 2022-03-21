<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        



        </div>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <asp:ListBox ID="OrderList" runat="server" Height="540px" Width="494px" OnSelectedIndexChanged="OrderList_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Button ID="Add" runat="server" OnClick="Add_Click" Text="Add" />
            <asp:Button ID="Edit" runat="server" OnClick="Edit_Click" Text="Edit" />
            <asp:Button ID="Delete" runat="server" Text="Delete" />
        </p>
        <asp:Label ID="Error" runat="server"></asp:Label>
    </form>
</body>
</html>

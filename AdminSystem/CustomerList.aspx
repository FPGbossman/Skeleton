<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<script runat="server">

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <a href="CustomerList.aspx">CustomerList.aspx</a>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomer" runat="server" Height="479px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="318px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" />
            <asp:Button ID="btndelete" runat="server" OnClick="btndelete_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter a Customer name"></asp:Label>
            <asp:TextBox ID="txtbox" runat="server" OnTextChanged="txtbox_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
        </p>
        <p>
            <asp:Label ID="lblEroor" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>

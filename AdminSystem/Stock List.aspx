<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stock List.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 38px;
            left: 60px;
            z-index: 1;
            width: 357px;
            height: 335px;
        }
        .auto-style2 {
            position: absolute;
            top: 384px;
            left: 65px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 384px;
            left: 118px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 384px;
            left: 175px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 432px;
            left: 64px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 461px;
            left: 65px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 501px;
            left: 64px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 501px;
            left: 133px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 381px;
            left: 364px;
            z-index: 1;
        }
    </style>
</head>
<body>
    
    <form id ="from1" runat ="server">
      
&nbsp;
        <asp:ListBox ID="lstStock" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" Text="Add" OnClick="btnAdd_Click" style="height: 26px" />
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style3" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style4" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="Label1" runat="server" CssClass="auto-style5" Text="Enter Product Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style7" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnClear" runat="server" CssClass="auto-style8" Text="Clear" OnClick="btnClear_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style9" Text="lblError"></asp:Label>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 187px;
            left: 454px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 242px;
            left: 514px;
            z-index: 1;
            width: 63px;
            right: 468px;
        }
        .auto-style3 {
            position: absolute;
            top: 242px;
            left: 649px;
            z-index: 1;
            width: 63px;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lbl1" runat="server" CssClass="auto-style1" Text="Are  you sure you want to delete this page?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" OnClick="btnNo_Click" Text="No" />
    </form>
</body>
</html>
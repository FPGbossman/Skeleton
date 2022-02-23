<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProcessConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 47px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        Delete page<p id="lblOrderNo">
            Enter an order number to delete<asp:TextBox ID="orderNo" runat="server" Height="16px" style="margin-left: 11px" OnTextChanged="orderNo_TextChanged"></asp:TextBox>
        </p>
        <p>
            [lblError]</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>

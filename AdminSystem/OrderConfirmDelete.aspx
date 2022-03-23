<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
        <h1>Delete page</h1><p id="lblOrderNo">
            
            Are you sure you want to delete this?</p>
        <p>
            <asp:Button ID="Yes" runat="server" Text="Yes" OnClick="Button1_Click" />
            <asp:Button ID="No" runat="server" Text="No" OnClick="No_Click" />
        </p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListBox.aspx.cs" Inherits="PageLifeCycleDemo.ListBoxDemo.ListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="lstBox" runat="server" Rows="3" SelectionMode="Multiple">
            <asp:ListItem Text="Bachelor" Value="1" />
            <asp:ListItem Text="Graduate" Value="2" />
            <asp:ListItem Text="Post Graduate" Value="3" />
            <asp:ListItem Text="Doctrate" Value="4" />
        </asp:ListBox>
        <br /><br />
        <asp:Button Text="Submit" ID="butSubmit" runat="server" OnClick="butSubmit_Click" />
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBox_ListBox.aspx.cs" Inherits="PageLifeCycleDemo.CheckBox_ListBoxDemo.CheckBox_ListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBoxList runat="server" ID="ckBoxList" RepeatDirection="Horizontal" 
            OnSelectedIndexChanged="ckBoxList_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Text="Bachelor" Value="1" />
            <asp:ListItem Text="Graduate" Value="2" />
            <asp:ListItem Text="Post Graduate" Value="3" />
            <asp:ListItem Text="Doctrate" Value="4" />        
        </asp:CheckBoxList>
    </div>

    <div>
        <asp:ListBox runat="server" ID="lstBox" Width="200px" 
            SelectionMode="Multiple">
        </asp:ListBox>
        <br />
    </div>
    <div>
        <asp:Label Text="" runat="server" ID="lblSummary" Font-Bold="true" />
    </div>
    </form>
</body>
</html>

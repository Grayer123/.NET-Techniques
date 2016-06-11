<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBoxList.aspx.cs" Inherits="PageLifeCycleDemo.CheckBoxListDemo.CheckBoxList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="butSelectAll" Text="Select All" runat="server" OnClick="butSelectAll_Click" /> &nbsp &nbsp
        <asp:Button ID="butDeselectAll" Text="Deselect All" runat="server" OnClick="butDeselectAll_Click" /> <br />
        <asp:CheckBoxList runat="server" ID="ckBoxDegree" 
            RepeatDirection="Horizontal" RepeatColumns ="3">
        </asp:CheckBoxList>
        <br /><br />
        <asp:Button Text="Submit" ID="butSubmit" runat="server" OnClick="butSubmit_Click" />
    </div>
    </form>
</body>
</html>



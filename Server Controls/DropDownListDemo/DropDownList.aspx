<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownList.aspx.cs" Inherits="PageLifeCycleDemo.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--DataTextField ="Dept_Name" DataValueField="Dept_ID"--%>
        <asp:DropDownList runat="server" ID="dropListDepts" Width="200px"             
            AutoPostBack="true" OnSelectedIndexChanged="dropsdwnDepts_SelectedIndexChanged">
            <%--<asp:ListItem Text="Select Dept." Value="0"></asp:ListItem>
            <asp:ListItem Text="Computer Engineering" Value="1" Selected="True"></asp:ListItem>
            <asp:ListItem Text="Data Scientist" Value="2" Enabled="false"></asp:ListItem>
            <asp:ListItem Text="UI Development" Value="3"></asp:ListItem>
            <asp:ListItem Text="Test Team" Value="4"></asp:ListItem>--%>
        </asp:DropDownList>
        <br />
    </div>

    <div>
        <asp:DropDownList runat="server" ID="dropListEmpts" Width="200px">
            <%--<asp:ListItem Text="Select Dept." Value="0"></asp:ListItem>
            <asp:ListItem Text="Computer Engineering" Value="1" Selected="True"></asp:ListItem>
            <asp:ListItem Text="Data Scientist" Value="2" Enabled="false"></asp:ListItem>
            <asp:ListItem Text="UI Development" Value="3"></asp:ListItem>
            <asp:ListItem Text="Test Team" Value="4"></asp:ListItem>--%>
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>






        
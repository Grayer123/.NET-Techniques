<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Person_ADO.Show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblPrompt" Text="Please specify the age (age > 0 && age < 150):" runat="server" /> &nbsp&nbsp
        <asp:TextBox ID="txtBoxInput" Text="" runat="server"/>
        <asp:RequiredFieldValidator ErrorMessage="TextBox could not be null" ForeColor="Red" ControlToValidate="txtBoxInput" runat="server" />
        <br />
        <asp:Button ID="butSubmit" Text="Submit" runat="server" OnClick="butSubmit_Click" />
        <br /><br /><br />
        <asp:Label ID="lblSp" Text="" runat="server" />
        
    </div>
    <div>
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>    
     </div>
    </form>
</body>
</html>

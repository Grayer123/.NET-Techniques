<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PageLifeCycleDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>This is WebFrom1 </h2> 
        <p>
            <asp:Label ID="lblName" Text="Name:" runat="server" /> <br />
            <asp:TextBox ID="txtName" Text="" runat="server" />  
        </p>
        <p>
            <asp:Label ID="lblEmail" Text="Email:" runat="server" /> <br />
            <asp:TextBox ID="txtEmail" Text="" runat="server" />  
        </p>
        <p>
            <asp:Button ID="butTranfer" Text="Go to WebFrom2" runat="server" OnClick="butTranfer_Click" />
        </p>    
    </div>
    </form>
</body>
</html>

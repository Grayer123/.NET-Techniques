<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ServerTransferDemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>This is WebFrom2 </h2>
        <p>
            <asp:Label ID="lblName" Text="Name:" runat="server" /> <br />
            <asp:Label ID="lbl1" Text="" runat="server" />  
        </p>
        <p>
            <asp:Label ID="lblEmail" Text="Email:" runat="server" /> <br />
            <asp:Label ID="lbl2" Text="" runat="server" />  
        </p>
    </div>
    </form>
</body>
</html>

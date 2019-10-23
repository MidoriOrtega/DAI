<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="EjemploSessionCookies.Pagina2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSession" runat="server" Text="Session: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblCookie" runat="server" Text="Cookie: "></asp:Label>
        </div>
    </form>
</body>
</html>

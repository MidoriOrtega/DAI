<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informacion.aspx.cs" Inherits="EjercicioPaginaWeb.Informacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Usuario dado de alta:"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="gvInfo" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="lblSession" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

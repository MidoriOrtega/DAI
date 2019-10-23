<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="EjercicioPaginaWeb.Pagina2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="lnkbtnAltas" runat="server" OnClick="lnkbtnAltas_Click">Altas</asp:LinkButton>
&nbsp;|
            <asp:LinkButton ID="lnkbtnCambios" runat="server" OnClick="lnkbtnCambios_Click">Cambios</asp:LinkButton>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Seleccion alumnos:"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlAlumnos" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina3.aspx.cs" Inherits="EjercicioPaginaWeb.Pagina3" %>

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
            <asp:LinkButton ID="lnkbtnBajas" runat="server" OnClick="lnkbtnBajas_Click">Bajas</asp:LinkButton>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Cambios al alumno"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblAlumno" runat="server" Text="Alumno:"></asp:Label>
&nbsp;
            <asp:DropDownList ID="ddlAlumno" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblCorreo" runat="server" Text="Correro electrónico:"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Contraseña:"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" />
            <br />
        </div>
    </form>
</body>
</html>

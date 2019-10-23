<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="EjercicioPaginaWeb.Pagina1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="lnkbtnBajas" runat="server" OnClick="lnkbtnBajas_Click">Bajas</asp:LinkButton>
            &nbsp;|
            <asp:LinkButton ID="lnkbtnCambios" runat="server" OnClick="lnkbtnCambios_Click">Cambios</asp:LinkButton>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Clase DAI - Alta de alumnos"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Registrar Alumno"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblCorreo" runat="server" Text="Correo electrónico:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Contraseña:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btRegistrar_Click" />
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnInfo" runat="server" Text="Información alumno" OnClick="btnInfo_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

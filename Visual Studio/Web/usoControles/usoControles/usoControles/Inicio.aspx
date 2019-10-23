<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="usoControles.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Uso de controles<br />
            <br />
            Colores:
            <asp:DropDownList ID="drdColores" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drdColores_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lbl1" runat="server" Text="Índice seleccionado: "></asp:Label>
            <br />
            <br />
            Sabores:
            <br />
            <asp:RadioButtonList ID="rdbSabores" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rdbSabores_SelectedIndexChanged">
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="lbl2" runat="server" Text="Índice seleccionado: "></asp:Label>
            <br />
            <asp:Label ID="lbl3" runat="server" Text="Valor seleccionado: "></asp:Label>
            <br />
            <br />
            Café<br />
            <asp:CheckBoxList ID="cbl1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cbl1_SelectedIndexChanged">
            </asp:CheckBoxList>
            <br />
            Índice:
            <asp:ListBox ID="ltb1" runat="server"></asp:ListBox>
            <br />
            <br />
            Contenido:
            <asp:ListBox ID="ltb2" runat="server"></asp:ListBox>
            <br />
            <br />
            Session --&gt;
            <asp:Label ID="lblSession" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>

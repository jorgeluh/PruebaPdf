<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Visor.Inicio" %>
<%@ Register Src="~/Controles/VisorPdf.ascx" TagPrefix="cp" TagName="VisorPdf" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Visor de PDF</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Visor de PDF</h1>
        Archivo: <asp:DropDownList ID="DropDownListArchivo" runat="server">
            <asp:ListItem Value="0">Ninguno</asp:ListItem>
            <asp:ListItem Value="1">Archivo 1</asp:ListItem>
            <asp:ListItem Value="2">Archivo 2</asp:ListItem>
            <asp:ListItem Value="3">Archivo complejo</asp:ListItem>
        </asp:DropDownList>
        <asp:CheckBox runat="server" ID="CheckBoxPermitirImpresion"></asp:CheckBox> Permitir impresión <br />
        <asp:Button ID="ButtonVer" runat="server" Text="Ver" OnClick="ButtonVer_Click" />
        <div style="margin: 20px;">
            <cp:VisorPdf ID="VisorPdf" Alto="600" Ancho="1000" runat="server" />
        </div>
    </form>
</body>
</html>

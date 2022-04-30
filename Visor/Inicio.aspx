<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Visor.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Visor de PDF</title>
</head>
<body>
    <h1>Visor de PDF</h1>
    <form id="form1" runat="server">
        <div style="margin: 20px;">
            <iframe id="pd-js-viewer" src="/PdfJs/web/viewer.html?file=%2FPdfJs%2Fweb%2Fcompressed.tracemonkey-pldi-09.pdf" title="webviewer" frameborder="0" width="500" height="600"></iframe>
        </div>
    </form>
</body>
</html>

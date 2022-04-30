<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VisorPdf.ascx.cs" Inherits="Visor.Controles.VisorPdf" %>
<% if (!string.IsNullOrEmpty(this.Archivo))
{
%>
<iframe id="pd-js-viewer" src="/PdfJs/web/viewer.html?file=<%=Archivo%>" title="webviewer" frameborder="0" width="<%=Ancho%>" height="<%=Alto%>"></iframe>
<%
}
else
{
%>
<p>No se especificó ningún archivo.</p>
<%
}
%>
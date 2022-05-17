namespace Visor
{
    using System;
    using System.Web.UI;

    public partial class Inicio : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.SeleccionarArchivo();
            }
        }

        protected void ButtonVer_Click(object sender, EventArgs e)
        {
            this.SeleccionarArchivo();
        }

        private void SeleccionarArchivo()
        {
            this.VisorPdf.PermitirImpresion = this.CheckBoxPermitirImpresion.Checked;
            switch (this.DropDownListArchivo.SelectedValue)
            {
                case "1":
                    this.VisorPdf.Archivo = "/ArchivosPrueba/Archivo1.pdf";
                    break;
                case "2":
                    this.VisorPdf.Archivo = "/ArchivosPrueba/Archivo2.pdf";
                    break;
                case "3":
                    this.VisorPdf.Archivo = "/ArchivosPrueba/compressed.tracemonkey-pldi-09.pdf";
                    break;
                default:
                    this.VisorPdf.Archivo = string.Empty;
                    break;
            }
        }
    }
}
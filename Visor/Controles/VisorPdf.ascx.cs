namespace Visor.Controles
{
    using System;
    using System.Web;
    using System.Web.UI;

    public partial class VisorPdf : UserControl
    {
        private string archivo;

        public int Alto { get; set; }

        public int Ancho { get; set; }

        public bool PermitirImpresion
        {
            get
            {
                return (bool)(this.Session["PermitirImpresion"] ?? false);
            }
            set
            {
                this.Session["PermitirImpresion"] = value;
            }
        }

        public string Archivo
        {
            get { return archivo; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.StartsWith("/"))
                {
                    throw new ArgumentException("El nombre del archivo debe indicarse relativo a la raíz del sitio.", nameof(Archivo));
                }

                archivo = HttpUtility.UrlEncode(value);
            }
        }

        public VisorPdf()
        {
            this.Alto = 600;
            this.Ancho = 500;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}
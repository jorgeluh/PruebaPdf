namespace DeteccionFirma
{
    using System;
    using System.Linq;
    using UglyToad.PdfPig;
    using UglyToad.PdfPig.AcroForms;
    using UglyToad.PdfPig.AcroForms.Fields;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Archivo? ");
            string archivo = Console.ReadLine();

            using (PdfDocument documento = PdfDocument.Open(archivo))
            {
                AcroForm formulario;
                bool contieneFormularios = documento.TryGetForm(out formulario);
                if (contieneFormularios && formulario.Fields.Any(f => f.FieldType == AcroFieldType.Signature))
                {
                    Console.WriteLine("Tiene firmas.");
                }
                else
                {
                    Console.WriteLine("No tiene firmas.");
                }
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Diagnostics;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public class ProcesarPDF2
    {
        private string ruta = Application.StartupPath + "\\facturasPDF";
        private string nombreArchivo;
        bool exists=false;

        private void CrearDirectorio()
        {
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
        }
        private bool VerificarDocumento(string nombreArchivo)
        {
            if (File.Exists(ruta + "\\" + nombreArchivo + ".pdf"))
            {

                return true;
            }

            return false;
        }

        Document docPDF = new Document();
        iTextSharp.text.Image fotoPDF;
        PdfContentByte dc;
        iTextSharp.text.pdf.PdfWriter pdw;
        string rute;

        int x;
        float y;
        public void crearPdf(PDF1 datos)
        {
            CrearDirectorio();
            rute = ruta + "\\" + datos.NombrePdf + ".pdf";

            if (!VerificarDocumento(datos.NombrePdf))
            {
                pdw = PdfWriter.GetInstance(docPDF, new FileStream(rute, FileMode.Create));
                docPDF.Open();
                dc = pdw.DirectContent;

                dc.SetColorFill(BaseColor.BLACK);
                x = -5;
                y = docPDF.PageSize.Height-100;

                if (datos.logo != null)
                {
                    fotoPDF = iTextSharp.text.Image.GetInstance(datos.logo, BaseColor.WHITE);
                    fotoPDF.SetAbsolutePosition(x, y);
                    fotoPDF.ScaleAbsolute(300, 100);
                    docPDF.Add(fotoPDF);
                }
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.COURIER, 14, iTextSharp.text.Font.BOLD).BaseFont, 14);
                x = 0;
                y = 150;
                //lineas de encabezado
                for (int i = 0; i < docPDF.PageSize.Width - 50; i++)
                {
                    dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "  -  ", i, docPDF.PageSize.Height - y, 0);

                }
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.BOLD).BaseFont, 10);
                //fecha y hora
                string fecha = DateTime.Now.ToLongDateString();
                string hora = DateTime.Now.ToLongTimeString();
                x = 120;
                y = 140;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, fecha, x, docPDF.PageSize.Height - y, 0);
                x = 355;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, hora, x, docPDF.PageSize.Height - y, 0);
                //Datos de la compra

                x = 130;
                y += 15;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Name:", x, docPDF.PageSize.Height - y, 0);

                //datos de la compra (precio)
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.BOLD).BaseFont, 10);
                x += 350;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Price:", x, docPDF.PageSize.Height - y, 0);

                List<Juguetes> Lista = new List<Juguetes>();
                BDJuguetes dBRincon = new BDJuguetes();
                Lista = dBRincon.Buscar();
                string precio;
                double subtotal = 0;
                foreach (Juguetes e in Lista)
                {
                    foreach(KeyValuePair<int, int> item in ValoresCompras.carritoCompras)
                    {
                        if(item.Key == Convert.ToInt32(e.Id))
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (exists)
                    {
                        y += 25;
                        x = 130;
                        dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, e.Nombre, x, docPDF.PageSize.Height - y, 0);
                        subtotal += e.Precio;
                        precio = Convert.ToString(e.Precio);
                        for (int i = x + 120; i < 450; i += 6)
                        {
                            dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "x", i, docPDF.PageSize.Height - y, 0);

                        }
                        x += 350;
                        dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "$" + precio, x, docPDF.PageSize.Height - y, 0);
                    }
                    exists = false;
                }
                //lineas de encabezado
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.COURIER, 14, iTextSharp.text.Font.BOLD).BaseFont, 14);
                y += 25;
                for (int i = 30; i < docPDF.PageSize.Width - 50; i += 6)
                {
                    dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "=", i, docPDF.PageSize.Height - y, 0);

                }
                //subtotal
                y += 10;
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.BOLD).BaseFont, 10);
                string subT = Convert.ToString(subtotal);
                x = 400;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Subtotal", x, docPDF.PageSize.Height - y, 0);
                x = 480;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "$" + subT, x, docPDF.PageSize.Height - y, 0);

                //total+IVA

                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.COURIER, 14, iTextSharp.text.Font.BOLD).BaseFont, 14);
                y += 25;
                for (int i = 30; i < docPDF.PageSize.Width - 50; i += 6)
                {
                    dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "=", i, docPDF.PageSize.Height - y, 0);

                }
                y += 10;
                x = 400;
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.BOLD).BaseFont, 10);
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "impuesto--->6% (IVA)", x, docPDF.PageSize.Height - y, 0);
                y += 15;
                double parcial = subtotal + (subtotal * 0.06);
                string total = Convert.ToString(parcial);

                x = 400;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Total", x, docPDF.PageSize.Height - y, 0);
                x = 480;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "$" + total, x, docPDF.PageSize.Height - y, 0);

                //thx msg
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.COURIER, 20, iTextSharp.text.Font.BOLD).BaseFont, 20);
                x = 250;
                y = 600;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Thank You!!", x, docPDF.PageSize.Height - y, 0);
                x = 242;
                y += 20;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Keep Dreaming", x, docPDF.PageSize.Height - y, 0);

                docPDF.Close();
                MessageBox.Show("Documento creado con Exito" + rute + "  " + datos.NombrePdf);
                Process.Start(rute);
            }
            else
            {
                MessageBox.Show("ERROR 1: Error al Generar Recibo de Pago");
            }
        }
    }
}

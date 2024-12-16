using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public class ProcesarPDF
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
        public void crearPdf(PDF1 datos, List<Juguetes> toys)
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
                y = docPDF.PageSize.Height - 100;

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
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.BOLD).BaseFont, 10);
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
                    foreach (KeyValuePair<int, int> item in ValoresCompras.carritoCompras)
                    {
                        if (item.Key == Convert.ToInt32(e.Id))
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
                    exists= false;
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

                //codigo QR
                iTextSharp.text.Image fotQR;
                if (datos.qr != null)
                {
                    
                    fotQR = iTextSharp.text.Image.GetInstance(datos.qr, BaseColor.WHITE);
                    fotQR.SetAbsolutePosition(250, 450);
                    fotQR.ScaleAbsolute(100, 100);
                    docPDF.Add(fotQR);
                }
                x = 253;
                y += 150;
                //digitos de codigo
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.COURIER, 20, iTextSharp.text.Font.BOLD).BaseFont, 20);
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos.NombrePdf, x, docPDF.PageSize.Height - y, 0);
                //lugares de Pago
                //oxxo
                iTextSharp.text.Image fotOxxo;
                if (datos.oxxo != null)
                {
                    x = 0;
                    y = 0;
                    fotOxxo = iTextSharp.text.Image.GetInstance(datos.oxxo, BaseColor.WHITE);
                    fotOxxo.SetAbsolutePosition(x, y);
                    fotOxxo.ScaleAbsolute(150, 150);
                    docPDF.Add(fotOxxo);
                }
                //bbva
                iTextSharp.text.Image fotoBBVA;
                if (datos.bbva != null)
                {
                    x += 230;
                    fotoBBVA = iTextSharp.text.Image.GetInstance(datos.bbva, BaseColor.WHITE);
                    fotoBBVA.SetAbsolutePosition(x, y);
                    fotoBBVA.ScaleAbsolute(150, 150);
                    docPDF.Add(fotoBBVA);
                }
                //Santander
                iTextSharp.text.Image fotoSan;
                if (datos.bbva != null)
                {
                    x += 200;
                    fotoSan = iTextSharp.text.Image.GetInstance(datos.santander, BaseColor.WHITE);
                    fotoSan.SetAbsolutePosition(x, y);
                    fotoSan.ScaleAbsolute(150, 150);
                    docPDF.Add(fotoSan);
                }
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

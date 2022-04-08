using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Printing;
//using Spire.Pdf;
using PdfiumViewer;
//using RawPrint;
using RawPrint.NetStd;
namespace G.A.S.C.O
{
    public partial class PrintForm : Form
    {
        public static bool suc= false;
        public static string ImpressoraSelecionada = String.Empty;
        public static int NumCopias = 0;
        public static bool Cores = false;

        PdfiumViewer.PdfViewer pdfPreview;

        public PrintForm()
        {
            InitializeComponent();
           /* pdfPreview = new PdfViewer();
            this.Controls.Add(pdfPreview);*/
        }



        private void PrintDialog_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Login.corMenu;
            PrintServer ImpServer = new PrintServer();
          

            byte[] pdfbytes = System.IO.File.ReadAllBytes(ImprimirForm.NomePDF);
            var stream = new MemoryStream(pdfbytes);
            PdfiumViewer.PdfDocument pdfDoc = PdfiumViewer.PdfDocument.Load(stream);
            pdfViewer1.Document = pdfDoc;
            




        }

        private void FechBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinBut_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

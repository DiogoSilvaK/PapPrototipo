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
using Spire.Pdf;
using PdfiumViewer;

namespace G.A.S.C.O
{
    public partial class PrintDialog : Form
    {
        public static bool suc= false;
        public static string ImpressoraSelecionada = String.Empty;
        public static int NumCopias = 0;
        public static bool Cores = false;

       PdfiumViewer.PdfViewer pdfPreview;

        public PrintDialog()
        {
            InitializeComponent();
           /* pdfPreview = new PdfViewer();
            this.Controls.Add(pdfPreview);*/
        }

        private void ImpBut_Click(object sender, EventArgs e)
        {
            DialogResult ImprimirResult = MessageBox.Show("Deseja começar a impressão?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ImprimirResult == DialogResult.Yes)
            {
                switch(CoresCBox.Text)
                {
                    case "Cores":
                        Cores = true;
                        break;
                    case "Preto e Branco":
                        Cores = false;
                        break;
                }
                NumCopias = (int)NumCopiasUpDown.Value;
                ImpressoraSelecionada = ImpressorasCBox.Text;

                Spire.Pdf.PdfDocument pdfImp = new Spire.Pdf.PdfDocument();
                pdfImp.LoadFromFile(ImprimirForm.NomePDF);
                pdfImp.PrintSettings.PrinterName = ImpressoraSelecionada;
                if (!Cores)
                    pdfImp.ColorSpace = Spire.Pdf.Graphics.PdfColorSpace.GrayScale;
                else
                    pdfImp.ColorSpace = Spire.Pdf.Graphics.PdfColorSpace.RGB;
                pdfImp.PrintSettings.Color = true;
                if (NumCopias > 0 && NumCopias < 20)
                    pdfImp.PrintSettings.Copies = (short)NumCopias;
                else
                    MessageBox.Show("ERRO! O NÚMERO DE CÓPIAS DEVE ESTAR ENTRE 1 E 20!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bool printSuc = false;
                try
                {
                    
                    pdfImp.Print();
                    printSuc = true;
                }
                catch (Exception ex)
                {
                    printSuc = false;
                    MessageBox.Show(ex.Message);
                    
                }
                finally
                {
                    if (printSuc)
                        MessageBox.Show("Imprimido com sucesso!");
                }

            }

        }

        private void PrintDialog_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Login.corMenu;
            PrintServer ImpServer = new PrintServer();
          
            var ImpQueues = ImpServer.GetPrintQueues(new[]
            { EnumeratedPrintQueueTypes.Shared, EnumeratedPrintQueueTypes.Connections });
            foreach (var item in ImpQueues)
            {
                ImpressorasCBox.Items.Add(item.FullName);
            }
            
            ImpQueues = ImpServer.GetPrintQueues(new[]
            { EnumeratedPrintQueueTypes.Local });
            foreach (var item in ImpQueues)
            {
                ImpressorasCBox.Items.Add(item.FullName);
            }

            byte[] pdfbytes = System.IO.File.ReadAllBytes(ImprimirForm.NomePDF);
            var stream = new MemoryStream(pdfbytes);
            PdfiumViewer.PdfDocument pdfDoc = PdfiumViewer.PdfDocument.Load(stream);
            pdfViewer1.Document = pdfDoc;

            CoresCBox.SelectedIndex = 0;
            ImpressorasCBox.SelectedIndex = 0;


        }

        private void CancBut_Click(object sender, EventArgs e)
        {
            DialogResult SairResult = MessageBox.Show("Deseja cancelar a impressão?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SairResult == DialogResult.Yes)
            {
                suc= false;
                this.Close();
                
            }
        }
    }
}

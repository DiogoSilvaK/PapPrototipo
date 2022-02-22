using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PapPrototipo
{
    public partial class ImprimirForm : Form
    {
        static string ImpressorasDisp;
        public ImprimirForm()
        {
            InitializeComponent();

        }

        private void ImprimirForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                ImpressorasDisp = PrinterSettings.InstalledPrinters[i];
                CBoxImp.Items.Add(ImpressorasDisp);
            }
            CBoxImp.SelectedIndex = 0;
            //CBoxQual.SelectedIndex = 0;
            CBoxTF.SelectedIndex = 0;
            PrinterSettings settings = new PrinterSettings();
            foreach (PaperSize size in settings.PaperSizes)
            {int i = 1; }
            foreach (PrinterResolution res in settings.PrinterResolutions)
            {
                int i = 1;
            }
        }

        private void CBoxTF_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CBoxImp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

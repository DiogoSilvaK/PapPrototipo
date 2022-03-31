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

namespace G.A.S.C.O
{
    public partial class PrintDialog : Form
    {
        public static bool suc= false;
        public static string ImpressoraSelecionada = String.Empty;
        public static int NumCopias = 0;
        public static bool Cores = false;

        public PrintDialog()
        {
            InitializeComponent();
        }

        private void ImpBut_Click(object sender, EventArgs e)
        {

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

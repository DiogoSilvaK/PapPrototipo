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
    }
}

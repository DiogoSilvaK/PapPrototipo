using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapPrototipo
{
    public partial class FormPesquisar : Form
    {
        public FormPesquisar()
        {
            InitializeComponent();
        }

        private void OperadoresCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(CBoxOperadores.Text){
                case "maior":
                    label4.Text = "que";
                    break;
                case "menor":
                    label4.Text = "que";
                    break;
                case "maior ou igual":
                    label4.Text = "que";
                    break;
                case "menor ou igual":
                    label4.Text = "que";
                    break;
                case "igual":
                    label4.Text = "a";
                    break;
                case "diferente":
                    label4.Text = "de";
                    break;

            }
        }

        private void FormPesquisar_Load(object sender, EventArgs e)
        {

        }
    }
}

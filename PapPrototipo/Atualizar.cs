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
    public partial class FormAtualizar : Form
    {
        public FormAtualizar()
        {
            InitializeComponent();
        }

        private void FormAtualizar_Load(object sender, EventArgs e)
        {

        }



        private void NovoVeiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void VeiculoCBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VeiculoCBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /**Verifica se a Combobox VeiculoCBox está selecionada no "Mês/Ano", se sim ele ativa o DateTimePicker de nome
 * MesAnoV, e desativa as textboxes AntigoVeiculo/NovoVeiculo, senão faz o contrario**/
            if (CampoVeiculo2.Text == "Mês/Ano")
            { MesAnoV.Enabled = true; NovoVeiculo.Enabled = false; }
            else { MesAnoV.Enabled = false; NovoVeiculo.Enabled = true; }
        }
    }
}

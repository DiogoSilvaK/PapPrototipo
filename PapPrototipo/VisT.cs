using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PapPrototipo
{
    public partial class VTForm : Form
    {
        public VTForm()
        {
            InitializeComponent();
        }

        private void FormVTC_Load(object sender, EventArgs e)
        {
            
        }

        private void RefreshBut_Click(object sender, EventArgs e)
        { 


        }

        private void CBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string consultaSql = String.Empty;
            string ConnectS = "data source=localhost; database=pap1 ; user id=root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);


            switch (CBoxCampo.Text)
            {
                case "Clientes":
                    consultaSql = "SELECT * FROM cliente where Cod_Cliente='(Select Cod_Cliente From Veiculo where Matricula='(Select VeiculoMatricula from servico where LoginEmail ='"+ Login.UserLogado+"' )')'";
                    break;
                case "Lista de peças":
                    consultaSql = "SELECT * FROM lista_de_pecas WHERE cod_servico='(Select Cod_Servico From servico where Loginemail='"+Login.UserLogado+"')'";
                    break;
                case "Serviços":
                    consultaSql = "SELECT * FROM servico where LoginEmail='"+Login.UserLogado+"'";
                    break;
                case "Veículos":
                    consultaSql = "SELECT * FROM veiculo where";
                    break;
            }

            // DialogResult DR = MessageBox.Show("Deseja procurar por todos os elementos da tabela " + CBoxCampo.Text, "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                Conn.Open();

                    MySqlDataAdapter DataAdapter = new MySqlDataAdapter(consultaSql, Conn);
                    DataSet DataTemp = new DataSet();

                    DataAdapter.Fill(DataTemp, "tabela");
                    TabelaDataGrid.DataSource = DataTemp.Tables["tabela"];

                    // Set your desired AutoSize Mode:
                    TabelaDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    TabelaDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    TabelaDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
                    for (int i = 0; i <= TabelaDataGrid.Columns.Count - 1; i++)
                    {
                        // Store Auto Sized Widths:
                        int colw = TabelaDataGrid.Columns[i].Width;

                        // Remove AutoSizing:
                        TabelaDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                        // Set Width to calculated AutoSize value:
                        TabelaDataGrid.Columns[i].Width = colw;
                    }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }

        }
    }
}

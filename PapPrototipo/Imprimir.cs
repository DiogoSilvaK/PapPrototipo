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
using System.Drawing.Text;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace PapPrototipo
{
    public partial class ImprimirForm : Form
    {
        //static string ImpressorasDisp;
        static string tabelaSelect;

        public ImprimirForm()
        {
            InitializeComponent();

        }

        private void ImprimirForm_Load(object sender, EventArgs e)
        {
            CBoxTabela.SelectedIndex = 0;
        }

        private void CBoxTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consultaSql1 = string.Empty;
            
            CBoxReg.Items.Clear();
            switch(CBoxTabela.Text)
            {
                case "Clientes":
                    tabelaSelect = "cliente";
                    break;
                case "Lista de peças":
                    tabelaSelect = "lista_de_pecas";
                    break;
                case "Serviços":
                    tabelaSelect = "servico";
                    break;
                case "Veículos":
                    tabelaSelect = "veiculo";
                    break;
            }

            string consultaSql = "SELECT * FROM " + tabelaSelect;

            string ConnectS = "data source= localhost; database=pap1; user id= root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);

            try
            {
                Conn.Open();

                CBoxReg.Items.Clear();

                
                    MySqlDataAdapter DataAdapter = new MySqlDataAdapter(consultaSql,Conn);
                    DataSet DataTemp = new DataSet();


                    DataAdapter.Fill(DataTemp, "tabela");
                    
                    TabelaDataGrid.DataSource = DataTemp.Tables["tabela"];
                    MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);
                    MySqlDataReader DataReader = queryCmd.ExecuteReader();




                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        CBoxReg.Items.Add(DataReader.GetValue(0));
                    }
                    CBoxReg.SelectedIndex = 0;

                    TabelaDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    TabelaDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    TabelaDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                    for (int i = 0; i <= TabelaDataGrid.Columns.Count - 1; i++)
                    {

                        int colw = TabelaDataGrid.Columns[i].Width;

                        TabelaDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;


                        TabelaDataGrid.Columns[i].Width = colw;
                    }
                }
                else
                {
                    MessageBox.Show("Esta tabelá está vazia!!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               


            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();

            }


        }

        private void CBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void CBoxReg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabelaDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch(CBoxTabela.Text)
            {
                case "Veículos":
                    CBoxReg.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                    break;
                default:
                    CBoxReg.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;
            }
        }
    }
}

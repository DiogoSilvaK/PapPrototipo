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
    public partial class FormApagar : Form
    {
        static string WREG = string.Empty;
        public FormApagar()
        {
            InitializeComponent();
            
        }

        private void ButDel_Click(object sender, EventArgs e)
        {
           string tabelaSelect = string.Empty;

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

            string ConnectS = "data source= localhost; database= pap1; user id= root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);

            string consultaSql = "DELETE FROM " + tabelaSelect + " WHERE " + CampoCBox.Text + "='" + WREG + "'";
            DialogResult DR = MessageBox.Show("Deseja eliminar o(s) registo(s) cujo campo " + CampoCBox.Text + " contem o valor '" + WREG + "'?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            try
            {
                MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);
                Conn.Open();
                if(DR == DialogResult.Yes)
                {
                    queryCmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                string consultaSql1 = "SELECT * FROM " + tabelaSelect;
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter(consultaSql1, Conn);
                DataSet DataTemp = new DataSet();


                //DataAdapter = new MySqlDataAdapter(query2, Conn);
                //DataTemp = new DataSet("tabela");
                DataAdapter.Fill(DataTemp, "tabela");
                TabelaDataGrid.DataSource = DataTemp.Tables["tabela"];

                // Set your desired AutoSize Mode:
                TabelaDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TabelaDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TabelaDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i <= TabelaDataGrid.Columns.Count - 1; i++)
                {
                    // Store Auto Sized Widths:
                    int colw = TabelaDataGrid.Columns[i].Width;

                    // Remove AutoSizing:
                    TabelaDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    // Set Width to calculated AutoSize value:
                    TabelaDataGrid.Columns[i].Width = colw;

                }

                Conn.Close();
            }

        }

        private void CBoxTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consultaSql = "";
            string ConnectS = "data source=localhost; database=pap1; user id=root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);
            DataSet DataTemp = new DataSet();

            CampoCBox.Items.Clear();


            switch (CBoxTabela.Text)
            {


                case "Clientes":
                    consultaSql = "SELECT * FROM Cliente";
                    DataServicos.Visible = false;
                    break;

                case "Serviços":
                    consultaSql = "SELECT * FROM servico";
                    DataServicos.Visible = true;
                    DataServicos.Format = DateTimePickerFormat.Custom;
                    DataServicos.CustomFormat = "dd/MM/yyyy";
                    break;

                case "Veículos":
                    consultaSql = "SELECT * FROM Veiculo";
                    DataServicos.Visible = true;
                    DataServicos.Format = DateTimePickerFormat.Custom;
                    DataServicos.CustomFormat = "MM/yy";
                    break;

                case "Lista de peças":
                    consultaSql = "SELECT * FROM lista_de_pecas";
                    DataServicos.Visible = false;
                    break;

            }

            MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);
            MySqlDataAdapter Adapter = new MySqlDataAdapter(consultaSql, Conn);
            Adapter.Fill(DataTemp, "tabela");

            TabelaDataGrid.DataSource = (DataTemp.Tables["tabela"]);
            try
            {
                Conn.Open();
                MySqlDataReader DataReader = queryCmd.ExecuteReader();

                if (DataReader.HasRows)
                {
                    for (int i = 0; i < DataReader.FieldCount; i++)
                    {
                        CampoCBox.Items.Add(DataReader.GetName(i));
                    }
                    CampoCBox.SelectedIndex = 0;

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
                    MessageBox.Show("Esta tabela está vazia...", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }

        }

        private void CampoCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CampoCBox.Items.Remove("Descricao");
            switch(CampoCBox.Text)
            {
                case "Data":
                case "Mes_Ano":
                    WREG = DataServicos.Text;
                    DelReg.Enabled = false;
                    DataServicos.Enabled = true;
                    break;
                    /*
                case "Marca":
                case "Modelo":

                    break;
                    */
                default:
                    WREG = DelReg.Text;
                    DelReg.Enabled = true;
                    DataServicos.Enabled = false;
                    break;
            }

        }

        private void FormApagar_Load(object sender, EventArgs e)
        {
            CBoxTabela.SelectedIndex = 0;
        }

        private void TabelaDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {

                DelReg.Text = TabelaDataGrid.CurrentCell.Value.ToString();

                CampoCBox.SelectedItem = TabelaDataGrid.Columns[e.ColumnIndex].Name.ToString();
            }
        }
    }
}

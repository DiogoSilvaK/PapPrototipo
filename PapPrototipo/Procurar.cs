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
    public partial class FormPesquisar : Form
    {
        static string operFinal = String.Empty;
        static string PesqReg = String.Empty;
        static string tabelaSelect = String.Empty;
        public FormPesquisar()
        {
            InitializeComponent();
        }

        private void OperadoresCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(CBoxOperadores.Text){
                case "maior":
                    operFinal = ">";
                    label4.Text = "que";
                    break;
                case "menor":
                    operFinal = "<";
                    label4.Text = "que";
                    break;
                case "maior ou igual":
                    operFinal = ">=";
                    label4.Text = "que";
                    break;
                case "menor ou igual":
                    operFinal = "<=";
                    label4.Text = "que";
                    break;
                case "igual":
                    operFinal = "=";
                    label4.Text = "a";
                    break;
                case "diferente":
                    operFinal = "!=";
                    label4.Text = "de";
                    break;

            }
        }

        private void FormPesquisar_Load(object sender, EventArgs e)
        {

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
                    tabelaSelect = "cliente";
                    break;

                case "Serviços":
                    tabelaSelect = "servico";
                    consultaSql = "SELECT * FROM servico";
                    DataServicos.Format = DateTimePickerFormat.Custom;
                    DataServicos.CustomFormat = "dd/MM/yyyy";
                    break;

                case "Veículos":
                    tabelaSelect = "veiculo";
                    consultaSql = "SELECT * FROM Veiculo";
                    DataServicos.Format = DateTimePickerFormat.Custom;
                    DataServicos.CustomFormat = "MM/yy";
                    break;

                case "Lista de peças":
                    tabelaSelect = "lista_de_pecas";
                    consultaSql = "SELECT * FROM lista_de_pecas";
                    break;

            }

            MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);
            MySqlDataAdapter Adapter = new MySqlDataAdapter(consultaSql, Conn);
            Adapter.Fill(DataTemp, "tabela");

            //TabelaDataGrid.DataSource = (DataTemp.Tables["tabela"]);
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
            finally{ }
        }

        private void CampoCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(CampoCBox.Text)
            {
                case "Data":
                case "Mes_Ano":
                    
                    DataServicos.Visible = true;
                    PesqTBox.Visible = false;
                    PesqReg = DataServicos.Text;
                    break;
                default:
                    PesqReg = PesqTBox.Text;
                    DataServicos.Visible = false;
                    PesqTBox.Visible = true;

                    break;

            }
        }

        private void PesquisarBut_Click(object sender, EventArgs e)
        {
            string ConnectS = "data source=localhost; database= pap1; user id= root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);
            
            switch (CampoCBox.Text)
            {
                case "Data":
                case "Mes_Ano":
                    PesqReg = DataServicos.Text;
                    break;
                default:
                    PesqReg = PesqTBox.Text;
                    break;

            }

            string consultaSql = "SELECT * FROM "+tabelaSelect+ " WHERE "+ CampoCBox.Text + operFinal+ "'"+ PesqReg+"'";
            DialogResult DR = MessageBox.Show("Deseja procurar pelo o registo cujo o campo '"+CampoCBox.Text+"' contem o valor '"+ PesqReg +"'?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                Conn.Open();
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter(consultaSql, Conn);
                DataSet DataTemp = new DataSet();


                //DataAdapter = new MySqlDataAdapter(query2, Conn);
                //DataTemp = new DataSet("tabela");
                DataAdapter.Fill(DataTemp, "tabela");
                TabelaDataGrid.DataSource = DataTemp.Tables["tabela"];

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
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            //MessageBox.Show(consultaSql);
        }
    }
}

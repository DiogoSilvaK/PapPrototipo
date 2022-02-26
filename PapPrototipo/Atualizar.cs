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
    public partial class FormAtualizar : Form
    {
        bool notchange1=true, notchange2=true;
        static string AtNReg = String.Empty;

        public FormAtualizar()
        {
            InitializeComponent();
        }

        private void FormAtualizar_Load(object sender, EventArgs e)
        {

        }


        private void TabelaCBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consultaSql = "";
            string ConnectS = "data source=localhost; database=pap1; user id=root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);
            DataSet DataTemp = new DataSet();

            Campo1.Items.Clear();
            Campo2.Items.Clear();

            switch (TabelaCBox1.Text) 
            {


                case "Clientes":
                    consultaSql = "SELECT * FROM Cliente";

                    labelat3.Visible = false;
                    DataServicos.Visible = false;
                    DescricaoRTR.Visible = false;
                    labelat6.Visible = false;
                    break;


                case "Serviços":
                    consultaSql = "SELECT * FROM servico";
                    labelat3.Visible = true;
                    DataServicos.Visible = true;
                    labelat3.Text = "Data:";
                    DataServicos.Format = DateTimePickerFormat.Custom;
                    DataServicos.CustomFormat = "dd/MM/yyyy";
                    DescricaoRTR.Visible = true;
                    labelat6.Visible = true;
                    break;


                case "Veículos":
                    consultaSql = "SELECT * FROM Veiculo";
                    labelat3.Visible = true;
                    DataServicos.Visible = true;
                    labelat3.Text = "MêsAnoV:";
                    DataServicos.Format = DateTimePickerFormat.Custom;
                    DataServicos.CustomFormat = "MM/yy";
                    DescricaoRTR.Visible= false;
                    labelat6.Visible= false;
                    break;


                case "Lista de peças":
                    consultaSql = "SELECT * FROM lista_de_pecas";
                    labelat3.Visible = false;
                    DataServicos.Visible = false;
                    DescricaoRTR.Visible = false;
                    labelat6.Visible = false;
                    break;


            }

            MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);
            MySqlDataAdapter Adapter = new MySqlDataAdapter(consultaSql, Conn);
            Adapter.Fill(DataTemp, "tabela");

            TabelaDataGrid.DataSource =(DataTemp.Tables["tabela"]);
            try
            {
                Conn.Open();
                MySqlDataReader DataReader = queryCmd.ExecuteReader();

                if (DataReader.HasRows)
                {
                    for (int i = 0; i < DataReader.FieldCount; i++)
                    {
                        Campo1.Items.Add(DataReader.GetName(i));
                        Campo2.Items.Add(DataReader.GetName(i));
                    }
                    Campo1.SelectedIndex = 0;
                    Campo2.SelectedIndex = 0;
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

            }



        }

        private void TabelaDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notchange1 = true;
            AntigoReg.Text = TabelaDataGrid.CurrentCell.Value.ToString();
            //MessageBox.Show(TabelaDataGrid.Columns[e.ColumnIndex].Name.ToString());
            Campo1.SelectedItem = TabelaDataGrid.Columns[e.ColumnIndex].Name.ToString() ;
        }

        private void Campo1_SelectedIndexChanged(object sender, EventArgs e)
        {


                    Campo1.Items.Remove("Descricao");
                    Campo1.Items.Remove("Data");
           



            if(!notchange1)
            AntigoReg.Clear();
            else
            notchange1 = false;
        }

        private void ButAt_Click(object sender, EventArgs e)
        {
            string tabelaSelect = "";
            switch(TabelaCBox1.Text)
            {
                case "Clientes":
                    tabelaSelect = "cliente";
                    break;
                case "Lista de Peças":
                    tabelaSelect = "lista_de_pecas";
                    break;
                case "Serviços":
                    tabelaSelect = "servico";
                    break;
                case "Veículos":
                    tabelaSelect = "veiculo";
                    break;
            }

            switch (Campo2.Text)
            {
                case "Descricao":
                    AtNReg = DescricaoRTR.Text;
                    break;
                case "Mes_Ano":
                    AtNReg = DataServicos.Text;
                    break;
                case "Data":
                    AtNReg = DataServicos.Text;
                    break;
                default:
                    AtNReg = NovoReg.Text;
                    break;

            }


            string consultaSql = "UPDATE "+ tabelaSelect + " SET "+ Campo2.Text +"='"+ AtNReg +"' WHERE "+ Campo1.Text + "='"+ AntigoReg.Text+"'";
            string ConnectS = "data source= localhost; database=pap1; user id= root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);

            DialogResult DR = MessageBox.Show("Deseja atualizar o campo: " + Campo2.Text + "com o registo '" + NovoReg.Text + "' onde o campo: " + Campo1.Text + " tem o registo '" + AntigoReg.Text + "' da Tabela " + tabelaSelect, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                Conn.Open();
                MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);
                if (DR == DialogResult.Yes)
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
                string consultaSql1 = "SELECT * FROM " + tabelaSelect + " WHERE "+ Campo2.Text + "='" + AtNReg+"'";
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter(consultaSql1, Conn);
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
                Conn.Close();
            }
        }

        private void TabelaDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Campo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Campo2.Text)
            {
                case "Descricao":
                    DescricaoRTR.Enabled = true;
                    DataServicos.Enabled = false;
                    NovoReg.Enabled = false;
                    break;
                case "Mes_Ano":
                    DataServicos.Enabled = true;
                    DescricaoRTR.Enabled = false;
                    NovoReg.Enabled = false;
                    break;
                case "Data":
                    DataServicos.Enabled = true;
                    DescricaoRTR.Enabled = false;
                    NovoReg.Enabled = false;
                    break;
                default:
                    NovoReg.Enabled = true;
                    DescricaoRTR.Enabled = false;
                    DataServicos.Enabled = false;
                    break;

            }
            NovoReg.Clear();
        }
    }
}

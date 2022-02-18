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
            string cs = "data source=localhost; database=pap1; user id=root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(cs);
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

                }
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
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }



        }

        private void TabelaDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notchange1 = true;
            AntigoReg.Text = TabelaDataGrid.CurrentCell.Value.ToString();
            MessageBox.Show(TabelaDataGrid.Columns[e.ColumnIndex].Name.ToString());
            Campo1.SelectedItem = TabelaDataGrid.Columns[e.ColumnIndex].Name.ToString() ;
        }

        private void Campo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!notchange1)
            AntigoReg.Clear();
            else
            notchange1 = false;
        }

        private void Campo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            NovoReg.Clear();
        }
    }
}

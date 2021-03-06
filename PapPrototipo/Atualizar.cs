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
using System.Text.RegularExpressions;

namespace G.A.S.C.O
{
    public partial class FormAtualizar : Form
    {
        bool notchange1 = true;
        static string AtNReg = String.Empty;
        static Regex campo1Regex;
        static Regex campo2Regex;
        public FormAtualizar()
        {
            InitializeComponent();
        }

        private void FormAtualizar_Load(object sender, EventArgs e)
        {
            TabelaCBox1.SelectedIndex = 0;
            panel1.BackColor = Login.corMenu;
            TabelaDataGrid.DefaultCellStyle.SelectionBackColor = Login.corMenu;
            
        }


        private void TabelaCBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consultaSql = String.Empty;
            string ConnectS = "data source=localhost; database=gasco_ds; user id=GASCO_OP; pwd='GascoDb1234'";
            MySqlConnection Conn = new MySqlConnection(ConnectS);
            DataSet DataTemp = new DataSet();

            Campo1.Items.Clear();
            Campo2.Items.Clear();


                
                    
                
                
                    
                
                
                    



            switch (TabelaCBox1.Text) 
            {


                case "Clientes":
                    //consultaSql = "SELECT * FROM Cliente";
                    //consultaSql = "SELECT DISTINCT Cliente.Cod_Cliente,Cliente.Nome, Cliente.Morada, Cliente.Localidade, Cliente.N_Contr FROM Cliente inner join login" + Login.NAQueryS;
                    consultaSql = "SELECT * FROM CLIENTE";
                    labelat3.Visible = false;
                    DataServicos.Visible = false;
                    DescricaoRTR.Visible = false;
                    labelat6.Visible = false;
                    break;


                case "Serviços":
                    //consultaSql = "SELECT * FROM servico";
                    consultaSql = "SELECT * From servico"+ Login.NASQueryS;
                    //consultaSql = "SELECT * FROM SERVICO WHERE LoginEmail='" + Login.UserLogado + "'";

                    labelat3.Visible = true;
                    DataServicos.Visible = true;
                    labelat3.Text = "Data:";
                    DataServicos.Format = DateTimePickerFormat.Custom;
                    DataServicos.CustomFormat = "dd/MM/yyyy";
                    DescricaoRTR.Visible = true;
                    labelat6.Visible = true;
                    break;


                case "Veículos":
                    //consultaSql = "SELECT * FROM Veiculo";
                    //consultaSql = "SELECT DISTINCT veiculo.Marca, veiculo.Modelo, veiculo.Cilindrada, veiculo.Mes_Ano, veiculo.Matricula, veiculo.Cod_Cliente from veiculo inner join login" + Login.NAQueryS;
                    consultaSql = "SELECT * FROM VEICULO ";

                    labelat3.Visible = true;
                    DataServicos.Visible = true;
                    labelat3.Text = "MêsAnoV:";
                    DataServicos.Format = DateTimePickerFormat.Custom;
                    DataServicos.CustomFormat = "MM/yy";
                    DescricaoRTR.Visible= false;
                    labelat6.Visible= false;
                    break;
                    

                case "Lista de peças":
                    //consultaSql = "SELECT * FROM lista_de_pecas";
                    //consultaSql = "SELECT DISTINCT lista_de_pecas.Cod_Peca, lista_de_pecas.Nome, lista_de_pecas.Marca, lista_de_pecas.Num_Serie, lista_de_pecas.Preco, lista_de_pecas.Cod_Servico, lista_de_pecas.Desconto from lista_de_pecas inner join login" + Login.NAQueryS;
                    if (Login.Adm <= 0)
                    {
                        consultaSql = "SELECT * FROM Lista_de_pecas WHERE Cod_Servico in (SELECT Cod_Servico FROM SERVICO WHERE LoginEmail='" + Login.UserLogado + "')";
                    }
                    else
                    {
                        consultaSql = "SELECT * FROM Lista_de_pecas";
                    }
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
                else
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
           
            switch(Campo1.Text)
            {
                case "Nome": case "Titulo": case "Modelo": case "Marca":
                    if(TabelaCBox1.Text == "Clientes")
                    campo1Regex = new Regex(@"^[a-zA-ZçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ_ ]{3,40}$");
                    else
                    campo1Regex = new Regex(@"^[0-9a-zA-ZçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ\-\.\,_ ]{3,40}$");
                    break;
                case "Morada":
                    campo1Regex = new Regex(@"^[a-zA-Z0-9çÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛºª\.\,\-_ ]{10,80}$");
                    break;
                case "Cod_Cliente": case "Cod_Servico": case "Cod_Peca":
                    campo1Regex = new Regex(@"^[0-9]{1,11}$");
                    break;
                case "Localidade":
                    campo1Regex = new Regex(@"^[A-Za-zçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ\.\,\-_ ]{3,80}$");
                    break;
                case "Cilindrada":
                    campo1Regex = new Regex(@"^[0-9]{2,4}$");
                    break;
                case "Desconto": case "Horas":
                    campo1Regex = new Regex(@"^[0-9]{1,3}$");
                    break;
                case "Matricula":
                    campo1Regex = new Regex(@"^(([A-Z]{2}-\d{2}-(\d{2}|[A-Z]{2}))|(\d{2}-(\d{2}-[A-Z]{2}|[A-Z]{2}-\d{2})))$");
                    break;
                case "N_Contr":
                    campo1Regex = new Regex(@"^[0-9]{9}$");
                    break;
            }






            if (!notchange1)
            AntigoReg.Clear();
            else
            notchange1 = false;
        }

        private void ButAt_Click(object sender, EventArgs e)
        {
            string tabelaSelect = String.Empty;
            if (errorProvider1.GetError(AntigoReg) == "" && errorProvider2.GetError(NovoReg) == "")
            {
                switch (TabelaCBox1.Text)
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


                string consultaSql = "UPDATE " + tabelaSelect + " SET " + Campo2.Text + "='" + AtNReg + "' WHERE " + Campo1.Text + "='" + AntigoReg.Text + "'";
                string ConnectS = "data source= localhost; database=gasco_ds; user id= GASCO_OP; pwd='GascoDb1234'";
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


                    string consultaSql1 = "SELECT * FROM Cliente where " + Campo2.Text + "='" + AtNReg + "'";
                    if (Login.Adm <= 0)
                    {
                        switch (tabelaSelect)
                        {
                            case "cliente":
                                consultaSql1 = "SELECT * FROM Cliente where " + Campo2.Text + "='" + AtNReg + "'";
                                break;
                            case "veiculo":
                                consultaSql1 = "SELECT * from veiculo where " + Campo2.Text + "='" + AtNReg + "'";
                                break;
                            case "lista_de_pecas":
                                consultaSql1 = "SELECT * from lista_de_pecas where " + Campo2.Text + "='" + AtNReg + "'";
                                break;
                            case "servico":
                                consultaSql1 = "SELECT * From servico where " + Campo2.Text + "='" + AtNReg + "'";
                                break;
                        }
                    }
                    else
                    {
                        consultaSql1 = "SELECT * FROM " + tabelaSelect;
                    }


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
            else
            {
                MessageBox.Show("ERRO! PREENCHA TODOS OS CAMPOS COM A INFORMAÇÃO CORRETA!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TabelaDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Campo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Campo2.Text)
            {
                case "Nome":
                case "Titulo":
                case "Modelo":
                case "Marca":
                    if (TabelaCBox1.Text == "Clientes")
                        campo2Regex = new Regex(@"^[a-zA-ZçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ_ ]{3,40}$");
                    else
                        campo2Regex = new Regex(@"^[0-9a-zA-ZçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ\-\.\,_ ]{3,40}$");
                    break;
                case "Morada":
                    campo2Regex = new Regex(@"^[a-zA-Z0-9çÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛºª\.\,\-_ ]{10,80}$");
                    break;
                case "Cod_Cliente":
                case "Cod_Servico":
                case "Cod_Peca":
                    campo2Regex = new Regex(@"^[0-9]{1,11}$");
                    break;
                case "Localidade":
                    campo2Regex = new Regex(@"^[A-Za-zçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ\.\,\-_ ]{3,80}$");
                    break;
                case "Cilindrada":
                    campo2Regex = new Regex(@"^[0-9]{2,4}$");
                    break;
                case "Desconto":
                case "Horas":
                    campo2Regex = new Regex(@"^[0-9]{1,3}$");
                    break;
                case "Matricula":
                    campo2Regex = new Regex(@"^(([A-Z]{2}-\d{2}-(\d{2}|[A-Z]{2}))|(\d{2}-(\d{2}-[A-Z]{2}|[A-Z]{2}-\d{2})))$");
                    break;
                case "N_Contr":
                    campo2Regex = new Regex(@"^[0-9]{9}$");
                    break;
            }
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

        private void AntigoReg_Validating(object sender, CancelEventArgs e)
        {
            if (!campo1Regex.IsMatch(AntigoReg.Text))
                errorProvider1.SetError(AntigoReg, "Formato inválido!!");
            else
                errorProvider1.SetError(AntigoReg, "");
        }

        private void NovoReg_Validating(object sender, CancelEventArgs e)
        {
            if (!campo2Regex.IsMatch(NovoReg.Text))
                errorProvider2.SetError(NovoReg, "Formato inválido!!");
            else
                errorProvider2.SetError(NovoReg, "");
        }
    }
}

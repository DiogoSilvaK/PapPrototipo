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
    
    public partial class FormInserir : Form
    {
        //Definindo variaveis estáticas para serem usadas em todo o código
        static string consultaSql;
        static bool aut1 = true;

        public FormInserir()
        {
            InitializeComponent();
        }


        private void FormInserir_Load(object sender, EventArgs e)
        {
            //Define a cor do painel principal do form, com a cor respetiva do tema, guardada na variavel "Login.corMenu"
            panel1.BackColor = Login.corMenu;

            //Seleciona o indice 0 na ComboBox que define a tabela a ser inserida
            CBoxTab.SelectedIndex = 0;

            //Define a cor da celula selecionada para a cor do tema
            TabelaDataGrid.DefaultCellStyle.SelectionBackColor = Login.corMenu;
        }

        //Quando o indice da combobox da seleção de tabela muda
        public void CBoxTab_SelectedIndexChanged(object sender, EventArgs e)
        { //Limpa o que está nos erros e controles
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            errorProvider7.Clear();
            errorProvider8.Clear();
            TBox1.Clear();
            TBox2.Clear();
            TBox3.Clear();
            TBox4.Clear();
            TBox5.Clear();
            TBox6.Clear();
            RTBDescricao.Clear();
            Data1.ResetText();
            MesAnoV.ResetText();

            //Define a string que guarda as informações de conexão e cria uma conexão
            string ConnectS = "data source= localhost; database= gasco_ds; user id= GASCO_OP; pwd='GascoDb1234'";
            MySqlConnection Conn = new MySqlConnection(ConnectS);

            //Define uma variavel para ser usada no "switch"
            string ConsultaSql = String.Empty;

            //Vai analisar o texto no ComboBox da tabela, para depois selecionar quais controles e quais os textos nas TextBoxes dependendo de qual tabela selecionada
            switch (CBoxTab.Text)
            {
                //Se for "Clientes"
                case "Clientes":
                    labelIns1.Text = "Cod_Cliente:";
                    labelIns2.Text = "Nome:";
                    labelIns3.Text = "NumContr:";
                    labelIns4.Text = "Morada:";
                    labelIns5.Text = "Localidade:";

                    TBox4.Visible = true;
                    TBox4.Location = new Point(119,177);
                    TBox6.Location = new Point(412, 55);
                    CBox1.Visible = false;
                    TBox5.Enabled = true;
                    TBox5.Clear();
                    labelIns4.Visible = true;
                    labelIns5.Visible = true;
                    labelIns6.Visible = false;
                    labelIns7.Visible = false;
                    labelIns8.Visible = false;
                    labelIns9.Visible = false;
                    TBox5.Visible = false;
                    TBox6.Visible = true;
                    Data1.Visible = false;
                    MesAnoV.Visible = false;
                    RTBDescricao.Visible = false;
                break;

                //Se for "Lista de Peças"
                case "Lista de Peças":
                    
      
                        CBox1.Items.Clear();
                    
                    

                    ConsultaSql = "Select * from servico where LoginEmail='"+Login.UserLogado+"'";
                    MySqlCommand queryCmd = new MySqlCommand(ConsultaSql,Conn);
                    try
                    {
                        Conn.Open();
                        MySqlDataReader leitor = queryCmd.ExecuteReader();
                        if (leitor.HasRows)
                        {
                            int NumCol = leitor.FieldCount;
                            while (leitor.Read())
                            {
                                CBox1.Items.Add(leitor.GetValue(0));
                            }
                            CBox1.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("ERRO! IMPOSSIVEL INSERIR NESTA TABELA(NÃO EXISTEM SERVIÇOS!)", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CBoxTab.SelectedValue = "Serviços";
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

                    labelIns1.Text = "Cod_Peca:"; //TBox1
                    labelIns2.Text = "Nome:"; //TBox2
                    labelIns3.Text = "Marca:"; //TBox3
                    labelIns4.Text = "NumSerie:"; //TBox6
                    labelIns5.Text = "Preço:"; //TBox4
                    labelIns6.Text = "Cod_Servico:"; //CBox1
                    labelIns7.Text = "Desconto:";//TBox5

                    CBox1.Visible = true;
                    CBox1.Location = new Point(412, 96);
                    TBox4.Location = new Point(412, 55);
                    TBox6.Location = new Point(119, 177);
                    TBox5.Location = new Point(412, 137);
                    TBox5.Enabled = true;
                    labelIns4.Visible = true;
                    labelIns5.Visible = true;
                    labelIns6.Visible = true;
                    labelIns7.Visible = true;
                    labelIns8.Visible = false;
                    labelIns9.Visible = false;
                    TBox4.Visible = true;
                    TBox5.Visible = true;
                    TBox6.Visible = true;
                    Data1.Visible = false;
                    MesAnoV.Visible = false;
                    RTBDescricao.Visible = false;

                break;
                //Se for "Serviços"
                case "Serviços":
                    CBox1.Items.Clear();
                    
                    
                    ConsultaSql = "Select Matricula from Veiculo";
                    MySqlCommand queryCmd1 = new MySqlCommand(ConsultaSql, Conn);
                    try
                    {
                        Conn.Open();
                        MySqlDataReader leitor = queryCmd1.ExecuteReader();
                        if (leitor.HasRows)
                        {
                            int NumCol = leitor.FieldCount;
                            while (leitor.Read())
                            {
                                CBox1.Items.Add(leitor.GetValue(0));
                            }
                            CBox1.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("ERRO! Não há veículos disponiveis!!!!!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CBoxTab.SelectedIndex = 1;
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

                    labelIns1.Text = "CodServiço:";
                    labelIns2.Text = "Titulo:";
                    labelIns3.Text = "Matricula:";
                    labelIns4.Text = "Data:";
                    labelIns5.Text = "Horas:";
                    labelIns6.Text = "Login:";

                    TBox5.Text = Login.UserLogado;

                    CBox1.Visible = true;
                    CBox1.Location = new Point(119, 137);
                    TBox5.Enabled = false;
                    TBox6.Visible = false;
                    TBox5.Visible = true;
                    TBox4.Visible = true;
                    Data1.Visible = true;
                    TBox6.Location = new Point(412, 137);
                    TBox4.Location = new Point(412, 55);
                    TBox5.Location = new Point(412, 96);
                    labelIns4.Visible = true;
                    labelIns5.Visible = true;
                    labelIns6.Visible = true;
                    labelIns7.Visible = false;
                    labelIns8.Visible = false;
                    labelIns9.Visible = true;
                    MesAnoV.Visible = false;
                    RTBDescricao.Visible = true;
                break;
                //Se for "Veículos"
                case "Veículos":
                    CBox1.Items.Clear();
                    ConsultaSql = "Select Cod_Cliente from Cliente";
                    MySqlCommand queryCmd2 = new MySqlCommand(ConsultaSql, Conn);
                    try
                    {
                        Conn.Open();
                        MySqlDataReader leitor = queryCmd2.ExecuteReader();
                        if (leitor.HasRows)
                        {
                            int NumCol = leitor.FieldCount;
                            while (leitor.Read())
                            {
                                CBox1.Items.Add(leitor.GetValue(0));
                            }
                        }
                        Conn.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {

                        CBox1.SelectedIndex = 0;
                    }

                    labelIns1.Text = "Marca:";
                    labelIns2.Text = "Modelo:";
                    labelIns3.Text = "Matricula:";
                    labelIns4.Text = "Mes/Ano:";
                    labelIns5.Text = "Cod_Cliente:";
                    labelIns6.Text = "Cilindrada:";
                    

                    

                    CBox1.Location = new Point(412, 55);
                    TBox6.Location = new Point(412, 137);
                    TBox4.Location = new Point(412, 55);
                    TBox5.Location = new Point(412, 96); 
                    TBox5.Enabled = true;
                    CBox1.Visible = true;
                    TBox4.Visible = false;
                    TBox5.Visible = true;
                    TBox6.Visible = false;
                    MesAnoV.Location = new Point(119, 177);
                    labelIns4.Visible = true;
                    labelIns5.Visible = true;
                    labelIns6.Visible = true;
                    labelIns7.Visible = false;
                    labelIns8.Visible = false;
                    labelIns9.Visible = false;
                    RTBDescricao.Visible = false;
                    Data1.Visible = false;
                    MesAnoV.Visible = true;
                break;
                    

            }










        }


        //Quando o botão de inserir é pressionado
        private void InsButton_Click(object sender, EventArgs e)
        {
            //Se os erros estiveram limpos, ele define uma boolean para verdadeira, e limpa os.
            if (errorProvider1.GetError(TBox1) == "" && errorProvider2.GetError(TBox2) == "" && errorProvider3.GetError(TBox3) == "" && errorProvider4.GetError(TBox4) == "" && errorProvider5.GetError(TBox5) == "" && errorProvider6.GetError(TBox6) == "")
            {
                aut1 = true;
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();
                errorProvider7.Clear();
                errorProvider8.Clear();
            }
        

            //define outra variavel booleana para verdadeiro
            bool aut = true;

            //Define a variavel que vai ter a consulta de pesquisa
            string consultaSql1 = String.Empty;
            //Define a variavel que vai ter a consulta de inserir
            string SDR = String.Empty;

            //Analisa o texto da combobox da seleção de tabela
            switch (CBoxTab.Text)
            {

               //Se for "Serviços"
                case "Serviços":
                    consultaSql1 = "SELECT * FROM servico where LoginEmail='"+Login.UserLogado+"'";
                    SDR = "Deseja inserir o serviço "+ TBox1.Text+" de nome '"+ TBox2.Text+"'?";
                    consultaSql = "insert into servico(Cod_Servico,Titulo, Descricao,Horas, Data, VeiculoMatricula,LoginEmail) VALUES (" + TBox1.Text + ",'" + TBox2.Text + "','" + RTBDescricao.Text+ "',"+TBox4.Text+",'" + Data1.Text + "','" + CBox1.Text + "','" + Login.UserLogado + "')";
                    if (TBox1.Text == ""|| TBox2.Text == ""|| RTBDescricao.Text == ""|| TBox4.Text == ""|| TBox5.Text == "")aut = false;
                    break;

                //Se for "Clientes"
                case "Clientes":
                    consultaSql1 = "SELECT * FROM Cliente";
                    SDR = "Deseja inserir o cliente "+TBox2.Text+" de nome "+ TBox2.Text +"?";
                    consultaSql = "insert into Cliente(Cod_Cliente, Nome, N_Contr, Morada, Localidade) VALUES(" + TBox1.Text + ",'" + TBox2.Text + "'," + TBox3.Text + ",'" + TBox4.Text + "','"+TBox6.Text+"')";
                    if (TBox1.Text == "" || TBox2.Text == "" || TBox3.Text == "" || TBox4.Text == "" || TBox6.Text == "") aut = false;
                    break;

                //Se for "Lista de Peças"
                case "Lista de Peças":
                    consultaSql1 = "SELECT * FROM Lista_de_pecas WHERE Cod_Servico in (SELECT Cod_Servico FROM Servico where Cod_Servico='"+ CBox1.Text + "'";
                    SDR = "Deseja inserir a peça "+TBox1.Text+" para o serviço "+ CBox1.Text+"?";
                    consultaSql = "insert into Lista_de_pecas(Cod_Peca, Nome, Marca, Num_Serie, Preco, Cod_Servico, Desconto) VALUES(" + TBox1.Text + ",'" + TBox2.Text + "','" + TBox3.Text+ "','" + TBox6.Text + "','" + TBox4.Text + "','" + CBox1.Text + "', '"+ TBox5.Text+"')";
                    if (TBox1.Text == "" || TBox2.Text == "" || TBox3.Text == "" || TBox4.Text == "" || TBox6.Text == "" || CBox1.Text == "") aut = false;
                    break;

                //Se for "Veículos"
                case "Veículos":
                    consultaSql1 = "SELECT * from veiculo";
                    SDR = "Deseja inserir o veiculo "+TBox1.Text+" "+TBox2.Text+ " de matricula "+TBox3.Text+"?";
                    consultaSql = "insert into veiculo(Marca, Modelo, Matricula, Cilindrada, Mes_Ano, Cod_Cliente) VALUES('" + TBox1.Text + "','" + TBox2.Text + "','" + TBox3.Text + "'," + TBox5.Text + ",'" + MesAnoV.Text + "'," + CBox1.Text + ")";
                    if (TBox2.Text == "" || TBox1.Text == ""|| TBox3.Text == "" || TBox5.Text =="" || CBox1.Text == "") aut = false;
                    break;

            }
                    //Define a string de conexão a base de dados
                    string ConnectS = "data source=localhost; database=gasco_ds; user id= GASCO_OP; pwd=''";
                    MySqlConnection Conn = new MySqlConnection(ConnectS);
            //Verifica se aquelas mesmas variavéis booleanas são verdadeiras
            if (aut && aut1)
            {

                //Gera uma MessageBox de aviso
                DialogResult DR = MessageBox.Show(SDR, "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //Faz uma tentativa de executar o bloco de código a seguir
                try
                {
                    //Gera um comando MySql
                    MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);

                    //Abre uma conexão
                    Conn.Open();

                    //Verifica se a pessoa aceitou o MessageBox
                    if (DR == DialogResult.Yes)
                    {

                        //Executa o comando MySql
                        queryCmd.ExecuteNonQuery();

                        ///Cria um Adapator de dados MySql com uma consulta
                        MySqlDataAdapter DataAdapter = new MySqlDataAdapter(consultaSql1, Conn);

                        //Cria um armazenador de dados temporário
                        DataSet DataTemp = new DataSet();

                        //Enche o armazenador com os dados do adaptador
                        DataAdapter.Fill(DataTemp, "tabela");

                        //Preenche o controle "TabelaDataGrid" com as informações obtidas
                        TabelaDataGrid.DataSource = DataTemp.Tables["tabela"];

                        //Este bloco a seguir é responsavel por ajustar o tamanho das colunas da tabela
                        TabelaDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        TabelaDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        TabelaDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                        for (int i = 0; i <= TabelaDataGrid.Columns.Count - 1; i++)
                        {

                            int colw = TabelaDataGrid.Columns[i].Width;

                            TabelaDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;


                            TabelaDataGrid.Columns[i].Width = colw;
                        }

                        //----------------------------------------------------------------------------------------------//
                    }


                }
                //Se houver um erro
                catch (MySqlException ex)
                {
                    //Mostra a mensagem de erro
                    MessageBox.Show(ex.Message);
                }
                //Finalmente
                finally
                {
                    //Fecha a conexão
                    Conn.Close();
                }
                aut = true;
            } 
            //Se alguma das variaveis booleanas estiver falsa
            else 
            {
                //Mostra uma mensagem de erro
                MessageBox.Show("PREENCHA TODOS OS CAMPOS OU VERIFIQUE SE TODOS ESTÃO BEM PREENCHIDOS!!","AVISO!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                aut1 = true;
            }
        }


        //Sempre que for selecionado uma celula da Tabela
        private void TabelaDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Analisa o texto da combobox da seleção de tabela
            switch (CBoxTab.Text)
            {
                //Se for "Serviços"
                case "Serviços":
                    if (TabelaDataGrid.SelectedCells.ToString() != "")
                    {
                        if (e.RowIndex > 0)
                        {
                            TBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                            TBox2.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                            TBox3.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                            TBox4.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                            Data1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                            CBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                            TBox5.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                        }
                    }
                    break;
                //Se for "Clientes"
                case "Clientes":
                    if (TabelaDataGrid.SelectedCells.ToString() != "")
                    {
                        if (e.RowIndex >= 0)
                        {
                            TBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                            TBox2.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                            TBox3.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                            TBox4.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                        }
                    }
                    break;
                //Se for "Lista de Peças"
                case "Lista de Peças":
                    if (TabelaDataGrid.SelectedCells.ToString() != "")
                    {
                        if (e.RowIndex >= 0)
                        {
                        TBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                        TBox2.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                        TBox3.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                        TBox4.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                        TBox5.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                        CBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                        }
                    }
                    break;
                //Se for "Veiculos
                case "Veículos":
                    if (TabelaDataGrid.SelectedCells.ToString() != "")
                    {
                        if (e.RowIndex >= 0)
                        {
                            TBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                            TBox2.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                            TBox3.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                            TBox4.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                            CBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                        }
                    }
                    break;
            }

        }

        //Validação da TextBox1
        private void TBox1_Validating(object sender, CancelEventArgs e)
        {
            switch(CBoxTab.Text)
            {
                case "Clientes":
                    Regex CodClienteCheck = new Regex(@"^[0-9]{1,11}$");
                    if (!CodClienteCheck.IsMatch(TBox1.Text))
                    {
                        errorProvider1.SetError(TBox1, "Insira apenas números!!");
                    }
                    else
                    {
                        errorProvider1.SetError(TBox1, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "" || errorProvider6.GetError(TBox6) != "")
                        aut1 = false;
                    break;
                case "Lista de Peças":
                    Regex CodPecaCheck = new Regex(@"^[0-9]{1,11}$");
                    if (!CodPecaCheck.IsMatch(TBox1.Text))
                    {
                        errorProvider1.SetError(TBox1, "Insira apenas números!!!");
                    }
                    else
                    {
                        errorProvider1.SetError(TBox1, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "" || errorProvider5.GetError(TBox5) != "")
                        aut1 = false;
                    break;
                case "Serviços":

                    Regex CodServicoCheck = new Regex(@"^[0-9]{1,11}$");
                    if (!CodServicoCheck.IsMatch(TBox1.Text))
                    {
                        errorProvider2.SetError(TBox1, "Insira um código válido!!");
                    }
                    else
                    {
                        errorProvider2.SetError(TBox1, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "" || errorProvider5.GetError(TBox5) != "")
                        aut1 = false;
                    break;
                case "Veiculos":
                    Regex Marca1Check = new Regex(@"^[0-9a-zA-ZçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ\.\-\,_ ]{3,40}$");
                    if (!Marca1Check.IsMatch(TBox1.Text))
                    {
                        errorProvider1.SetError(TBox1, "Insira uma marca válida!!");
                    }
                    else
                    {
                        errorProvider1.SetError(TBox1, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "" || errorProvider6.GetError(TBox6) != "")
                        aut1 = false;
                    break;
            }
        }

        //Validação da TextBox2
        private void TBox2_Validating(object sender, CancelEventArgs e)
        {
            switch(CBoxTab.Text)
            {
                case "Clientes":
                    Regex NomeCheck = new Regex(@"^[a-zA-ZçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ_ ]{3,40}$");
                    if (!NomeCheck.IsMatch(TBox2.Text))
                    {
                        errorProvider2.SetError(TBox2, "Insira um nome válida!");
                    }
                    else
                    {
                        errorProvider2.SetError(TBox2, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "" || errorProvider6.GetError(TBox6) != "")
                        aut1 = false;
                    break;
                case "Lista de Peças":
                    Regex Nome1Check = new Regex(@"^[0-9a-zA-ZçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ\.\-\,_ ]{3,40}$");
                    if (!Nome1Check.IsMatch(TBox2.Text))
                    {
                        errorProvider2.SetError(TBox2, "Insira um nome válido!!");
                    }
                    else
                    {
                        errorProvider2.SetError(TBox2, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "" || errorProvider5.GetError(TBox5) != "")
                        aut1 = false;
                    break;
                case "Serviços":
                    Regex TituloCheck = new Regex(@"^[0-9a-zA-ZçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ\-\._ ]{3,40}$");
                    if (!TituloCheck.IsMatch(TBox2.Text))
                    {
                        errorProvider2.SetError(TBox2, "Insira um titulo válido!!");
                    }
                    else
                    {
                        errorProvider2.SetError(TBox2, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != ""|| errorProvider5.GetError(TBox5) != "")
                        aut1 = false;
                    break;
                case "Veículos":
                    Regex ModeloCheck = new Regex(@"^[0-9a-zA-ZçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ\.\-\,_ ]{3,40}$");
                    if (!ModeloCheck.IsMatch(TBox2.Text))
                    {
                        errorProvider2.SetError(TBox2, "Insira um modelo válido!!");
                    }
                    else
                    {
                        errorProvider2.SetError(TBox2, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "" || errorProvider6.GetError(TBox6) != "")
                        aut1 = false;

                    break;
            }
        }


        //Validação da TextBox3
        private void TBox3_Validating(object sender, CancelEventArgs e)
        {
            switch(CBoxTab.Text)
            {
                case "Clientes":
                    Regex NContCheck = new Regex(@"^[0-9]{9}$");
                    if (!NContCheck.IsMatch(TBox3.Text))
                    {
                        errorProvider3.SetError(TBox3, "Insira apenas 9 números!!");
                    }
                    else
                    {
                        errorProvider3.SetError(TBox3, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "" || errorProvider6.GetError(TBox6) != "")
                        aut1 = false;
                    break;
                case "Lista de Peças":
                    Regex MarcaCheck = new Regex(@"^[a-zA-Z0-9çÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ\-\._ ]{3,40}$");
                    if (!MarcaCheck.IsMatch(TBox3.Text))
                    {
                        errorProvider3.SetError(TBox3, "Insira uma marca válida!!");
                    }
                    else
                    {
                        errorProvider3.SetError(TBox3, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "" || errorProvider5.GetError(TBox5) != "")
                        aut1 = false;
                    break;
                case "Veículos":
                    Regex MatriculaCheck = new Regex(@"^(([A-Z]{2}-\d{2}-(\d{2}|[A-Z]{2}))|(\d{2}-(\d{2}-[A-Z]{2}|[A-Z]{2}-\d{2})))$");
                    if (!MatriculaCheck.IsMatch(TBox3.Text))
                    {
                        errorProvider3.SetError(TBox3, "Insira uma matricula válida!!");
                    }
                    else
                    {
                        errorProvider3.SetError(TBox3, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "")
                        aut1 = false;
                    break;
            }
        }


        //Validação da TextBox4
        private void TBox4_Validating(object sender, CancelEventArgs e)
        {
            switch(CBoxTab.Text)
            {
                case "Clientes":
                    Regex MoradaCheck = new Regex(@"^[a-zA-Z0-9çÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛºª\.\,\-_ ]{10,80}$");
                    if (!MoradaCheck.IsMatch(TBox4.Text))
                    {
                        errorProvider4.SetError(TBox4, "Insira uma morada válida!!");
                    }
                    else
                    {
                        errorProvider4.SetError(TBox4, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "" || errorProvider6.GetError(TBox6) != "")
                        aut1 = false;
                    break;
                case "Lista de Peças":
                    Regex PrecoCheck = new Regex(@"^[0-9]{1,4}$");
                    if (!PrecoCheck.IsMatch(TBox4.Text))
                    {
                        errorProvider4.SetError(TBox4, "Insira apenas números e até 4 digitos!!");
                    }
                    else
                    {
                        errorProvider4.SetError(TBox4, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "" || errorProvider5.GetError(TBox5) != "")
                        aut1 = false;
                    break;
                case "Veículos":
                    Regex HorasCheck = new Regex(@"^[0-9]{1,3}$");
                    if (!HorasCheck.IsMatch(TBox4.Text))
                    {
                        errorProvider4.SetError(TBox4, "Insira apenas números e até 3 digitos!!");
                    }
                    else
                    {
                        errorProvider4.SetError(TBox4, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "")
                        aut1 = false;
                    break;
            }
        }

        //Validação da TextBox5
        private void TBox5_Validating(object sender, CancelEventArgs e)
        {
            switch(CBoxTab.Text)
            {
                case "Lista de Peças":
                    Regex DescontoCheck = new Regex(@"^[0-9]{1,3}$");
                    if(!DescontoCheck.IsMatch(TBox5.Text) || TBox5.Text.Length > 3)
                    {
                        errorProvider5.SetError(TBox5, "Insira apenas números e com menos de 3 digitos");
                    }
                    else
                    {
                        errorProvider5.SetError(TBox5, "");
                    }
                    break;
                case "Veículos":
                    Regex CilindradaCheck = new Regex(@"^[0-9]{2,4}$");
                    if (!CilindradaCheck.IsMatch(TBox5.Text))
                    {
                        errorProvider5.SetError(TBox5, "Insira apenas números!!");
                    }
                    else
                    {
                        errorProvider5.SetError(TBox5, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "")
                        aut1 = false;
                    break;
            }
        }

        //Validação da TextBox6
        private void TBox6_Validating(object sender, CancelEventArgs e)
        {
            switch(CBoxTab.Text)
            {
                case "Clientes":
                    Regex LocalidadeCheck = new Regex(@"^[A-Za-zçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ\.\,\-_ ]{3,80}$");
                    if (!LocalidadeCheck.IsMatch(TBox6.Text))
                    {
                        errorProvider6.SetError(TBox6, "Insira uma localidade validade");
                    }
                    else
                    {
                        errorProvider6.SetError(TBox6, "");
                    }
                    if (errorProvider1.GetError(TBox1) != "" || errorProvider2.GetError(TBox2) != "" || errorProvider3.GetError(TBox3) != "" || errorProvider4.GetError(TBox4) != "" || errorProvider6.GetError(TBox6) != "")
                        aut1 = false;
                    break;

            }
        }
    }
}

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

namespace PapPrototipo
{
    
    public partial class FormInserir : Form
    {
        static string consultaSql;
        //int erro = 0;
        public FormInserir()
        {
            InitializeComponent();
        }

        private void InsLDP_Click(object sender, EventArgs e)
        {
            /*
            if (PreçoLdpTBox.Text != ""|| NumSerLdpTBox.Text != ""|| NomeLdpTBox.Text !=""|| MarcaLdpTBox.Text != ""||CodServLdpTBox.Text != "") 
            {
            
            
            
            }
            else
            {
                MessageBox.Show("Tem de preencher todos os campos antes de introduzir!");

            }
            */
        }

        private void InsVeiculo_Click(object sender, EventArgs e)
        {
           /* if (MarcaVTBox.Text != "" || ModeloVTBox.Text != "" || CilinVTBox.Text != "" || MatriculaVTBox.Text != "" || CodClienteVTBox.Text != "")
            {
                string connectionS = "data source=localhost; database= pap1; user id=root; pwd=''";
                MySqlConnection MSC = new MySqlConnection(connectionS);

                
                string sqlinsert= 
                "INSERT INTO Veiculo(Marca,Modelo,Matricula,Cilindrada,Mes_Ano,Cod_Cliente)VALUES (" + "'" + MarcaVTBox.Text + "','" + ModeloVTBox.Text + "','" + MatriculaVTBox.Text + "'," + CilinVTBox.Text + ",'" + MesAnoV.Text+ "'," + CodClienteVTBox.Text+")";
                DialogResult InsPerg = MessageBox.Show("Deseja inserir " + MarcaVTBox.Text + ", " + ModeloVTBox.Text + ", " + CilinVTBox.Text + ", '" + MesAnoV.Text + "', " + MatriculaVTBox.Text + " do cliente " + CodClienteVTBox.Text + "?", "Inserir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    MySqlCommand consultaInserir = new MySqlCommand(sqlinsert,MSC);
                    MSC.Open();
                    //if (InsPerg == DialogResult.OK)
                    //{
                        consultaInserir.ExecuteNonQuery();
                    //}
                }
                catch (MySqlException ex)
                { MessageBox.Show(ex.Message); }
                finally
                { MSC.Close(); }
            
            }
            else { MessageBox.Show("Tem de preencher todos os campos antes de introduzir!"); }*/
        }

        private void FormInserir_Load(object sender, EventArgs e)
        {
            CBoxTab.SelectedIndex = 0;

        }

        public void CBoxTab_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            Data1.ResetText();
            MesAnoV.ResetText();

            string ConnectS = "data source=localhost;database=pap1;user id=root;pwd=''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);
            string ConsultaSql = String.Empty;

            switch (CBoxTab.Text)
            {
                case "Clientes":
                    labelIns1.Text = "Cod_Cliente:";
                    labelIns2.Text = "Nome:";
                    labelIns3.Text = "NumContr:";
                    labelIns4.Text = "Morada:";

                    TBox4.Visible = true;
                    TBox4.Location = new Point(119,177);
                    CBox1.Visible = false;
                    TBox5.Enabled = true;
                    TBox5.Clear();
                    labelIns4.Visible = true;
                    labelIns5.Visible = false;
                    labelIns6.Visible = false;
                    labelIns7.Visible = false;
                    labelIns8.Visible = false;
                    labelIns9.Visible = false;
                    TBox5.Visible = false;
                    TBox6.Visible = false;
                    Data1.Visible = false;
                    MesAnoV.Visible = false;
                    RTBDescricao.Visible = false;
                break;
                case "Lista de Peças":
                    
      
                        CBox1.Items.Clear();
                    
                    

                    ConsultaSql = "Select Titulo from Serviço";
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

                    labelIns1.Text = "Cod_Peça:";
                    labelIns2.Text = "Nome:";
                    labelIns3.Text = "Marca:";
                    labelIns4.Text = "NumSerie:";
                    labelIns5.Text = "Preço:";
                    labelIns6.Text = "Cod_Serviço:";

                    CBox1.Visible = true;
                    CBox1.Location = new Point(412, 96);
                    TBox4.Location = new Point(412, 55);
                    TBox6.Location = new Point(119, 177);
                    TBox5.Clear();
                    TBox5.Enabled = false;
                    labelIns4.Visible = true;
                    labelIns5.Visible = true;
                    labelIns6.Visible = true;
                    labelIns7.Visible = false;
                    labelIns8.Visible = false;
                    labelIns9.Visible = false;
                    TBox4.Visible = true;
                    TBox5.Visible = false;
                    TBox6.Visible = true;
                    Data1.Visible = false;
                    MesAnoV.Visible = false;
                    RTBDescricao.Visible = false;

                break;
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
                    labelIns4.Visible = true;
                    labelIns5.Visible = true;
                    labelIns6.Visible = true;
                    labelIns7.Visible = false;
                    labelIns8.Visible = false;
                    labelIns9.Visible = true;
                    MesAnoV.Visible = false;
                    RTBDescricao.Visible = true;
                break;
                case "Veículos":
                    CBox1.Items.Clear();
                    ConsultaSql = "Select Nome from Cliente";
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

                    TBox5.Clear();

                    CBox1.Location = new Point(412, 55);
                    TBox6.Location = new Point(412, 137);
                    TBox4.Location = new Point(412, 55);
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

        private void InsButton_Click(object sender, EventArgs e)
        {
            bool aut = true;
            bool aut1 = true; 
            String consultaSql1 = "SELECT * FROM Cliente ";
            string SDR ="";
            switch (CBoxTab.Text)
            {



                //Caso ComboBox das tabelas tiver como opção "Serviços"
                case "Serviços":
                    consultaSql1 = "SELECT * FROM Serviço";
                    SDR = "Deseja inserir o serviço "+ TBox1.Text+" de nome '"+ TBox2.Text+"'?";
                    consultaSql = "insert into Serviço(Cod_Serviço,Titulo, Descrição,Horas, Data, VeiculoMatricula,LoginEmail) VALUES (" + TBox1.Text.ToLower() + ",'" + TBox2.Text.ToLower() + "','" + RTBDescricao.Text.ToLower() + "',"+TBox4.Text.ToLower()+",'" + Data1.Text.ToLower() + "','" + CBox1.Text.ToLower() + "','" + Login.UserLogado.ToLower() + "')";
                    if (TBox1.Text == ""|| TBox2.Text == ""|| RTBDescricao.Text == ""|| TBox4.Text == ""|| TBox5.Text == "")aut = false;



                        Regex CodServicoCheck = new Regex(@"^[0-9]{1,11}$");
                        if (!CodServicoCheck.IsMatch(TBox1.Text))
                        {
                           aut1 = false;
                            errorProvider2.SetError(TBox2, "Insira um titulo válido!!");
                        }
                        else
                        {  
                            errorProvider2.SetError(TBox2, "");
                        }

                        Regex TituloCheck = new Regex(@"^[a-zA-Z_ ]{3,40}$");
                        if (!TituloCheck.IsMatch(TBox2.Text))
                        {
                            errorProvider2.SetError(TBox2, "Insira um titulo válido!!");
                            aut1 = false;
                        }
                        else
                        {
                            errorProvider2.SetError(TBox2, "");
                        }

                        Regex HorasCheck = new Regex(@"^[0-9]{1,3}$");
                        if (!HorasCheck.IsMatch(TBox4.Text))
                        {
                            errorProvider4.SetError(TBox4, "Insira apenas números e até 3 digitos!!");
                            aut1 = false; 
                        }
                        else
                        {
                            errorProvider4.SetError(TBox4, "");
                        }


                    break;


                case "Clientes":
                    consultaSql1 = "SELECT * FROM Cliente";
                    SDR = "Deseja inserir o cliente "+TBox2.Text+" de nome "+ TBox2.Text +"?";
                    consultaSql = "insert into Cliente(Cod_Cliente, Nome, N_Contr, Morada) VALUES(" + TBox1.Text + ",'" + TBox2.Text + "'," + TBox3.Text + ",'" + TBox4.Text + "')";
                    if (TBox1.Text == "" || TBox2.Text == "" || TBox3.Text == "" || TBox4.Text == "") aut = false;



                    Regex CodClienteCheck = new Regex(@"^[0-9]{1,11}$");
                    if (!CodClienteCheck.IsMatch(TBox1.Text))
                    {
                        errorProvider1.SetError(TBox1, "Insira apenas números!!");
                        aut1 = false;
                    }
                    else
                    {
                        errorProvider1.SetError(TBox1, "");

                    }

                    Regex NomeCheck = new Regex(@"^[a-zA-Z_ ]{3,40}$");
                    if (!NomeCheck.IsMatch(TBox2.Text))
                    {
                        errorProvider2.SetError(TBox2, "Insira um nome válida!");
                        aut1 = false;
                    }
                    else
                    {
                        errorProvider2.SetError(TBox2, "");

                    }

                    Regex NContCheck = new Regex(@"^[0-9]{9}$");
                    if (!NContCheck.IsMatch(TBox3.Text))
                    {
                        errorProvider3.SetError(TBox3, "Insira apenas números!!");
                        aut1 = false;
                    }
                    else
                    {
                        errorProvider3.SetError(TBox3, "");

                    }

                    Regex MoradaCheck = new Regex(@"^[a-zA-Z0-9._ ]{10,40}$");
                    if (!MoradaCheck.IsMatch(TBox4.Text))
                    {
                        errorProvider4.SetError(TBox4, "Insira uma morada válida!!");
                        aut1 = false;
                    }
                    else
                    {
                        errorProvider4.SetError(TBox4, "");

                    }


                    break;


                case "Lista de Peças":
                    consultaSql1 = "SELECT * FROM Lista_de_peças";
                    SDR = "Deseja inserir a peça "+TBox1.Text+" para o serviço "+ TBox6.Text+"?";
                    consultaSql = "insert into Lista_de_peças(Cod_Peça, Nome, Marca, Num_Serie, Preco, Cod_Serviço) VALUES(" + TBox1.Text + ",'" + TBox2.Text + "','" + TBox3.Text + "','" + TBox4.Text + "','" + TBox5.Text + "','" + CBox1.Text + "')";
                    if (TBox1.Text == "" || TBox2.Text == "" || TBox3.Text == "" || TBox4.Text == "" || TBox5.Text == "" || CBox1.Text == "") aut = false;

                    Regex CodPecaCheck = new Regex(@"^[0-9]{1,11}$");
                    if (!CodPecaCheck.IsMatch(TBox1.Text))
                    {
                        errorProvider1.SetError(TBox1, "Insira apenas números!!");
                        aut1 = false;
                    }
                    else
                    {
                        errorProvider1.SetError(TBox1, "");

                    }

                    Regex Nome1Check = new Regex(@"^[a-zA-Z_ ]{3,40}$");
                    if (!Nome1Check.IsMatch(TBox2.Text))
                    {
                        errorProvider2.SetError(TBox2, "Insira um nome válido!!");
                        aut1 = false;
                    }
                    else
                    {
                        errorProvider2.SetError(TBox2, "");

                    }

                    Regex MarcaCheck = new Regex(@"^[a-zA-Z0-9_ ]{3,40}$");
                    if (!MarcaCheck.IsMatch(TBox3.Text))
                    {
                        errorProvider3.SetError(TBox3, "Insira uma marca válida!!");
                        aut1 = false;
                    }
                    else
                    {
                        errorProvider3.SetError(TBox3, "");

                    }

                    Regex PrecoCheck = new Regex(@"^[0-9]{1,4}$");
                    if (!PrecoCheck.IsMatch(TBox4.Text))
                    {
                        errorProvider4.SetError(TBox4, "Insira apenas números e até 4 digitos!!");
                        aut1 = false;
                    }
                    else
                    {
                        errorProvider4.SetError(TBox4, "");

                    }



                    break;


                case "Veículos":
                    consultaSql1 = "SELECT * FROM Veiculo";
                    SDR = "Deseja inserir o veiculo "+TBox1.Text+" "+TBox2.Text+ " de matricula "+TBox3.Text+"?";
                    consultaSql = "insert into veiculo(Marca, Modelo, Matricula, Cilindrada, Mes_Ano, Cod_Cliente) VALUES('" + TBox1.Text + "','" + TBox2.Text + "','" + TBox3.Text + "'," + TBox5.Text + ",'" + MesAnoV.Text + "'," + CBox1.Text + ")";
                    if (TBox2.Text == "" || TBox1.Text == ""|| TBox3.Text == "" || TBox5.Text =="" || CBox1.Text == "") aut = false;

                    Regex Marca1Check = new Regex(@"^[a-zA-Z_ ]{3,40}$");
                    if (!Marca1Check.IsMatch(TBox1.Text))
                    {
                        errorProvider1.SetError(TBox1, "Insira uma marca válida!!");
                        aut1 = false;
                    }
                    else
                    {
                        errorProvider1.SetError(TBox1, "");


                    }

                    Regex ModeloCheck = new Regex(@"^[a-zA-Z_ ]{3,40}$");
                    if (!ModeloCheck.IsMatch(TBox2.Text))
                    {
                        errorProvider2.SetError(TBox2, "Insira um modelo válido!!");
                        aut1 = false;
                    }
                    else
                    {
                        errorProvider2.SetError(TBox2, "");

                    }

                    Regex MatriculaCheck = new Regex(@"^(([A-Z]{2}-\d{2}-(\d{2}|[A-Z]{2}))|(\d{2}-(\d{2}-[A-Z]{2}|[A-Z]{2}-\d{2})))$");
                    if (!MatriculaCheck.IsMatch(TBox3.Text))
                    {
                        errorProvider3.SetError(TBox3, "Insira uma matricula válida!!");
                        aut1 = false;
                    }
                    else
                    {
                        errorProvider3.SetError(TBox3, "");

                    }

                    Regex CilindradaCheck = new Regex(@"^[0-9]{2,4}$");
                    if (!CilindradaCheck.IsMatch(TBox5.Text))
                    {
                        errorProvider5.SetError(TBox5, "Insira apenas números!!");
                        aut1 = false;
                    }
                    else
                    {
                        errorProvider5.SetError(TBox5, "");

                    }

                    break;



            }
                    string ConnectS = "data source=localhost; database=pap1; user id= root; pwd=''";
                    MySqlConnection Conn = new MySqlConnection(ConnectS);

            if (aut && aut1)
            {
                DialogResult DR = MessageBox.Show(SDR, "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);

                    Conn.Open();


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
                    Conn.Close();
                }
                aut = true;
            }
            else 
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS OU VERIFIQUE SE TODOS ESTÃO BEM PREENCHIDOS!!","AVISO!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                aut1 = false;
            }
        }



        private void TabelaDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            switch (CBoxTab.Text)
            {
                case "Serviços":
                    if (TabelaDataGrid.SelectedCells.ToString() != "")
                    {
                        TBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                        TBox2.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                        TBox3.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                        TBox4.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                        Data1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                        CBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                        TBox5.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    }
                    break;
                case "Clientes":
                    if (TabelaDataGrid.SelectedCells.ToString() != "")
                    {
                        TBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                        TBox2.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                        TBox3.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                        TBox4.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                        
                    }
                    break;
                case "Lista de Peças":
                    if (TabelaDataGrid.SelectedCells.ToString() != "")
                    {
                        TBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                        TBox2.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                        TBox3.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                        TBox4.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                        TBox5.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                        CBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    }
                    break;
                case "Veiculos":
                    if (TabelaDataGrid.SelectedCells.ToString() != "")
                    {
                        TBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                        TBox2.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                        TBox3.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                        TBox4.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                        CBox1.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    }
                    break;
            }

        }


    }
}

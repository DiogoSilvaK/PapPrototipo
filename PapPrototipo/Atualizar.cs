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
        public FormAtualizar()
        {
            InitializeComponent();
        }

        private void FormAtualizar_Load(object sender, EventArgs e)
        {

        }


        private void TabelaCBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cs = "data source=localhost; database=pap1; user id=root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(cs);
            DataSet DataTemp = new DataSet();


            switch (TabelaCBox1.Text) 
            {


                case "Clientes":
                    string ConsultaSql = "SELECT * FROM Cliente";
                    MySqlCommand queryCmd = new MySqlCommand(ConsultaSql, Conn);
                    
                    
                    try 
                    {
                        Conn.Open();
                        MySqlDataReader DataReader = queryCmd.ExecuteReader();
                        
                        if(DataReader.HasRows)
                        {
                            for (int i = 0; i < DataReader.FieldCount; i++)
                            {
                                Campo1.Items.Add(DataReader.GetName(i));
                                Campo2.Items.Add(DataReader.GetName(i));
                            }

                        }
                        Conn.Close();
                    }
                    catch(MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {

                    }

                    labelat3.Visible = false;
                    DataServicos.Visible = false;
                    DescricaoRTR.Visible = false;
                    labelat6.Visible = false;
                    break;


                case "Serviços":
                    labelat3.Visible = true;
                    DataServicos.Visible = true;
                    labelat3.Text = "Data:";
                    DataServicos.Format = DateTimePickerFormat.Custom;
                    DataServicos.CustomFormat = "dd/MM/yyyy";
                    DescricaoRTR.Visible = true;
                    labelat6.Visible = true;
                    break;


                case "Veículos":
                    labelat3.Visible = true;
                    DataServicos.Visible = true;
                    labelat3.Text = "MêsAnoV:";
                    DataServicos.Format = DateTimePickerFormat.Custom;
                    DataServicos.CustomFormat = "MM/yy";
                    DescricaoRTR.Visible= false;
                    labelat6.Visible= false;
                    break;


                case "Lista de peças":
                    labelat3.Visible = false;
                    DataServicos.Visible = false;
                    DescricaoRTR.Visible = false;
                    labelat6.Visible = false;
                    break;


            }
        }
    }
}

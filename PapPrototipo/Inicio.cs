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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

            string ConnectS = "data source=localhost; database=pap1; user id= root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);

            string consultaSqlUserN = "SELECT Nome FROM Login where Email='" + Login.UserLogado + "'";
            MySqlCommand queryCmdUser = new MySqlCommand(consultaSqlUserN, Conn);
            MySqlDataReader DataReader = null;

            string UserN = String.Empty;
            try
            {
                Conn.Open();
                
                DataReader = queryCmdUser.ExecuteReader();
                string[] BomDiaArray = new string[14];

                if (DataReader.HasRows)
                { 
                    UserN = DataReader.GetValue(0).ToString();
                    BomDiaArray =
                    {
                "Bom-dia " + UserN,//Portugues 0
            "Buenos-dias " + UserN,//Espanol 1
            "Guten-Morgen "+ UserN,//Alemão 2
            "Good Morning "+ UserN,//Inglês 3
            "Bonjour "+ UserN,//Francês 4
            "Buongiorno "+UserN,//Italiano 5
            "Goedemorgen "+UserN,//Holandês 6
            "Ohayōgozaimasu "+ UserN,//Japonês 7 
            "Hyvää huomenta "+ UserN,//Finlandês 8
            "Zǎoshang hǎo " + UserN, //Chinês 9 
            "Buen día "+UserN, //Mexicano 10
            "Bonum mane "+UserN, //Latim 11
            "Dzień dobry"+UserN, //Polaco 12
            "God dag "+UserN, //Norueguês 13
            "Dobroho ranku"+UserN //Ucraniano 14
                };
               

               }
                
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            string consultaSql = "SELECT Titulo, Cod_Servico,Data FROM servico where LoginEmail='"+Login.UserLogado+"'";

            MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);
            

            try
            {
                
                Conn.Open();
                DataReader.Close();
                DataReader = queryCmd.ExecuteReader();

                if (DataReader.HasRows)
                {
                    while(DataReader.Read())
                    {
                        if (Convert.ToDateTime(DataReader.GetValue(2).ToString()) > (DateTime.Today.AddDays(-7)))
                        {
                            TBoxInicio.Text += DataReader.GetValue(0).ToString() +" - " + DataReader.GetValue(1).ToString() + "\n";
                        }
                    }
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

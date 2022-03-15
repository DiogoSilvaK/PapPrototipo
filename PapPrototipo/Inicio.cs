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

                if (DataReader.HasRows)
                { 
                    UserN = DataReader.GetValue(0).ToString();
                string[] BomDiaArray = new string[]
                {
                "Bom-dia " + UserN,//Portugues
            "Buenos-dias " + UserN,//Espanol
            "Guten-Morgen "+ UserN,//Alemão
            "Good Morning "+ UserN,//Inglês
            "Bonjour "+ UserN,//Francês
            "Buongiorno "+UserN,//Italiano
            "Goedemorgen "+UserN,//Holandês
            "Ohayōgozaimasu "+ UserN,//Japonês
            "Hyvää huomenta "+ UserN,//Finlandês
            "Zǎoshang hǎo " + UserN, //Chinês
            "Buen día "+UserN, //Mexicano
            "Bonum mane "+UserN, //Latim
            "Dzień dobry"+UserN, //Polaco
            "God dag "+UserN, //Norueguês
            "Dobroho ranku"+UserN //Ucraniano
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

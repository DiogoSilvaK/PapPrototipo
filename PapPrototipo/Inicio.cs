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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            
            panel1.BackColor = Login.corMenu;
            string ConnectS = "data source=localhost; database=gasco_ds; user id= GASCO_OP; pwd='GascoDb1234'";
            string UserN = String.Empty;
            MySqlConnection Conn = new MySqlConnection(ConnectS);
            



            //MySqlDataReader DataReader = null;

            

                string consultaSqlUserN = "select Nome from Login where Email ='" + Login.UserLogado + "'";
            try
            {
                Conn.Open();

                MySqlCommand queryCmdUser = new MySqlCommand(consultaSqlUserN, Conn);
                MySqlDataReader DataReader = queryCmdUser.ExecuteReader();


                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        UserN = DataReader.GetValue(0).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("ERRO FATAL!!");
                }

                string[] BomDiaArray = new string[]
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
            "Dobroho ranku"+UserN, //Ucraniano 14
            "Bom-dia "+UserN
               };

                string[] BoaTardeArray = new string[]
                {
                "Boa-tarde "+ UserN, //Portugues 0
                "Buenas-tardes "+ UserN, //Espanol 1
                "Guten-Tag "+UserN, //Alemão 2
                "Good Afternoon "+ UserN, //Inglês 3
                "Bon après-midi "+UserN, //Francês 4
                "Buon pomeriggio "+UserN, //Italiano 5
                "Goedemiddag " + UserN, // Holandês 6
                "こんにちは "+ UserN, //Japonês 7
                "Hyvää iltapäivää " + UserN, //Finlandês 8
                "下午好 "+ UserN, // Chinês 9
                "Buenas tardes "+ UserN, //Mexicano 10
                "Bona dies "+ UserN, //Latim 11
                "Dzień dobry "+ UserN, //Polaco 12
                "God ettermiddag "+UserN, //Norueguês 13
                "Dobroho dnya "+ UserN, //Ucraniano 14
                "Boa-Tarde "+UserN
                };

                string[] BoaNoiteArray = new string[]
                {
                "Boa-noite "+ UserN, //Português 0
                "Buenas noches "+UserN, //Espanol 1
                "Gute-Nacht "+ UserN, //Alemão 2
                "Good Night "+UserN, //Inglês 3
                "Bonne nuit "+UserN, //Francês 4
                "Buona Notte "+ UserN,//Italiano 5
                "Goedenacht "+UserN, //Holandês 6
                "Oyasumi "+ UserN, //Japonês 7
                "Hyvää yötä "+ UserN, //Finlândês 8
                "Wǎn'ān "+ UserN, //Chinês 9
                "Buenas noches "+ UserN, //Mexicano 10
                "Bonum noctis "+ UserN, //Latim 11
                "Dobranoc "+UserN, //Polaco 12
                "God natt "+UserN, //Ñorueguês 13
                "Nadobranich "+ UserN, //Ucraniano 14
                "Boa-noite "+UserN 
                };

                Random randSeed = new Random();
                int seed = randSeed.Next(1, 80000);
                Random rand = new Random(seed);

                int LinguaRandom = rand.Next(0, 15);

                if (DateTime.Now.Hour > 18 || DateTime.Now.Hour < 7)
                {
                    BemVindoLabel.Text = BoaNoiteArray[LinguaRandom];
                }
                else if (DateTime.Now.Hour > 7 || DateTime.Now.Hour < 13)
                {
                    BemVindoLabel.Text = BoaTardeArray[LinguaRandom];
                }
                else if (DateTime.Now.Hour > 13 || DateTime.Now.Hour < 18)
                {
                    BemVindoLabel.Text = BomDiaArray[LinguaRandom];
                }

                Main M1 = (Main)Application.OpenForms["Main"];

                if (LinguaRandom == 14)
                {
                    panel1.BackColor = Color.FromArgb(255, 213, 0);
                    BackColor = Color.FromArgb(0, 91, 187);
                    USLabel.ForeColor = Color.Black;
                   

                    M1.panel2.BackColor = Color.FromArgb(255, 213, 0);
                      

                }
                else
                {
                    M1.panel2.BackColor = Login.corMenu;
                }

                Conn.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            string consultaSql = "SELECT Titulo, Cod_Servico,Data FROM servico "+ Login.NASQueryS;


            MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);
            

            try
            {
                
                Conn.Open();
              
            MySqlDataReader DataReader = queryCmd.ExecuteReader();

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

        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {

            
        }
    }
}

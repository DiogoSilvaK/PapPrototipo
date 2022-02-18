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
using System.Security.Cryptography;

namespace PapPrototipo
{
    public partial class Login : Form
    {

        public static string UserLogado;
        public Login()
        {
            InitializeComponent();

            }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void LoginBut_Click(object sender, EventArgs e)
        {
            bool suc = true;
            string ConnectS = "data source= sql11.freemysqlhosting.net; database= sql11473764; user id= sql11473764; pwd= 'esUYyKeaAT'";
            MySqlConnection Conn = new MySqlConnection(ConnectS);


            string UserT=UserTextBox.Text.ToLower(), PassT = PassTextBox.Text;
           
            
            
           

            MD5 md5 = MD5.Create();
            byte[] valorC = md5.ComputeHash(Encoding.Default.GetBytes(PassT));
            StringBuilder PassSb = new StringBuilder();

            for (int i = 0; i < valorC.Length; i++) { PassSb.Append(valorC[i].ToString("x2")); }

            string ConsultaSql = "select Nome from login where Email='"+UserT+"' and Pass='"+PassSb+"'";



            if ((UserT != "") || (PassT != ""))
            {
                try
                {
                    MySqlCommand queryCmd = new MySqlCommand(ConsultaSql, Conn);
                    Conn.Open();
                    MySqlDataReader LeitorConsulta = queryCmd.ExecuteReader();
                    if (LeitorConsulta.Read())
                    {
                        
                        //Login f1 = new Login();
                        Main f2 = new Main();
                        this.Hide();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("User ou Pass errados!! Tente de novo...");
                    }
                }
                catch (MySqlException MySqlEx)
                {
                    suc = false;
                    MessageBox.Show(MySqlEx.Message);
                }
                finally
                {
                    
                    Conn.Close();
                    if (suc) { UserLogado = UserT; }
                }
            }
            



            
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro FormReg = new Registro();
            FormReg.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
using System.IO;
using System.Text.RegularExpressions;

namespace PapPrototipo
{
    public partial class Login : Form
    {
        public static Color corMenu = new Color();
        public static string UserLogado;
        public static Bitmap logotipoMain;
        public Login()
        {
            InitializeComponent();

            }
        
        public void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               // StreamReader leitorTxt = new StreamReader(@"colorconfig.ini");
                string corSF = "Color = " + Color.Firebrick;
                string corSB = "Color = " + SystemColors.HotTrack;
                string corSG = "Color = " + Color.Green;
                
                //ERRO AQUI
                string[] arquivo = File.ReadAllLines(@"colorconfig.ini");
                if (arquivo[0] == (corSF))
                {
                    panel1.BackColor = Color.Firebrick;
                    corMenu = Color.Firebrick;
                    logotipoMain = PapPrototipo.Properties.Resources.LogoAMMv2FireBrick;
                }
                if (arquivo[0] == (corSB))
                {
                    panel1.BackColor = SystemColors.HotTrack;
                    corMenu = SystemColors.HotTrack;
                    //leitorTxt.Close();
                    logotipoMain = PapPrototipo.Properties.Resources.LogoAMMv2Azul;
                }
                if (arquivo[0] == (corSG))
                {
                    panel1.BackColor = Color.Green;
                    corMenu = Color.Green;
                    logotipoMain = PapPrototipo.Properties.Resources.LogoAMMv2GreenGasco;
                    
                }
                //leitorTxt.Close();
                
            }
            catch (Exception ex)
            {
                StreamWriter gravErro = new StreamWriter(@"colorconfig.ini");
                gravErro.WriteLine("Color = " + SystemColors.HotTrack);
                //MessageBox.Show(ex.Message);
                corMenu = SystemColors.HotTrack;
                gravErro.Close();
            }


        }

        public void LoginBut_Click(object sender, EventArgs e)
        {
            bool suc = true;
            string ConnectS = "data source= localhost; database= pap1; user id= root; pwd= ''";
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
                    if (LeitorConsulta.HasRows)
                    {
                        UserLogado = UserT;
                        //Login f1 = new Login();
                        Main f2 = new Main();
                        this.Hide();
                        f2.Show();
                        suc = true;
                          
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

        private void UserTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex emailCheck = new Regex(@"^(?('')(''.+?(?<!\\)''@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
        
            if(!emailCheck.IsMatch(UserTextBox.Text))
            {
                errorProvider1.SetError(UserTextBox, "Insira um Email válido!");
            }
            else
            {
                errorProvider1.SetError(UserTextBox, "");
            }
        }

        private void PassTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(PassTextBox.Text == "")
            {
                errorProvider2.SetError(PassTextBox, "Insira uma password!!");
            }
            else
            {
                errorProvider2.SetError(PassTextBox, "");
            }
        }
    }
}

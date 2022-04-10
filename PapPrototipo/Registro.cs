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
using System.Text.RegularExpressions;

namespace G.A.S.C.O
{
    public partial class Registro : Form
    {
        bool login = false;
        public Registro()
        {
            InitializeComponent();
        }

        private void RegistrarBut_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(UserTextBox) == "" && errorProvider2.GetError(NomeTextBox) == "" && errorProvider3.GetError(PassTextBox) == "" && errorProvider4.GetError(EmpTBox) == "")
            {
                bool suc = true;
                string ConnectS = "data source= localhost; database= gasco_ds; user id= GASCO_OP; pwd='GascoDb1234'";
                MySqlConnection Conn = new MySqlConnection(ConnectS);

                string UserT = UserTextBox.Text.ToLower(), PassT = PassTextBox.Text, NomeT = NomeTextBox.Text, EmpT = EmpTBox.Text;

                MD5 mD5 = MD5.Create();
                byte[] valorC = mD5.ComputeHash(Encoding.Default.GetBytes(PassT));
                StringBuilder passSb = new StringBuilder();
                for (int i = 0; i < valorC.Length; i++)
                {
                    passSb.Append(valorC[i].ToString("x2"));
                }



                string consultaSql = "INSERT INTO Login(Nome, Email, Pass, NomeEmpresa,Admin) VALUES('" + NomeT + "','" + UserT + "','" + passSb + "','" + EmpT + "', 0)";
                if (NomeT != "" || UserT != "" || PassT != "")
                {
                    DialogResult DR = MessageBox.Show("Deseja registrar o(a) utilizador(a) '" + NomeT + "' no endereço email '" + UserT + "'", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    try
                    {
                        MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);
                        Conn.Open();
                        if (DR == DialogResult.Yes) queryCmd.ExecuteNonQuery();
                    }
                    catch (MySqlException MySqlEx)
                    {
                        MessageBox.Show(MySqlEx.Message);
                        suc = false;
                    }
                    finally
                    {
                        if (suc) MessageBox.Show("Dados inseridos com sucesso");
                        Conn.Close();
                    }

                }

            }
            else
            {
                MessageBox.Show("ERRO!! PREENCHA TODOS OS CAMPOS COM INFORMAÇÕES CORRETAS!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void Registro_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Login.corMenu;
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!login)
            {
                Application.Exit();
                login = false;
            }
        }

        private void VoltarBut_Click(object sender, EventArgs e)
        {
            login = true;
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void NomeTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex nomeCheck = new Regex(@"^[a-zA-ZçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ_ ]{3,40}$");
            if(!nomeCheck.IsMatch(NomeTextBox.Text))
            {
                errorProvider1.SetError(NomeTextBox, "Insira um nome válido!");
            }
            else
            {
                errorProvider1.SetError(NomeTextBox,"");
            }
        }

        private void UserTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex emailCheck = new Regex(@"^(?('')(''.+?(?<!\\)''@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

            if (!emailCheck.IsMatch(UserTextBox.Text))
            {
                errorProvider2.SetError(UserTextBox, "Insira um Email válido!");
            }
            else
            {
                errorProvider2.SetError(UserTextBox, "");
            }
        }

        private void PassTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (PassTextBox.Text == "")
            {
                errorProvider3.SetError(PassTextBox, "Insira uma password!!");
            }
            else
            {
                errorProvider3.SetError(PassTextBox, "");
            }
        }

        private void EmpTBox_Validating(object sender, CancelEventArgs e)
        {
            Regex EmpCheck = new Regex(@"^[a-zA-ZçÇàÀáÁâÂãÃÉéÈèÊêÕõÔôÓóÒòíÍìÌîÎúÚùÙûÛ\,\.\-&_ ]{3,40}$");
            if(!EmpCheck.IsMatch(EmpTBox.Text))
            {
                errorProvider4.SetError(EmpTBox, "Nome de Empresa inválido - cuidado com carateres especiais");
            }
            else
            {
                errorProvider4.SetError(EmpTBox, "");
            }
        }
    }
}

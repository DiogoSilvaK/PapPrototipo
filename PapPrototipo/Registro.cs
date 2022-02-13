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
    public partial class Registro : Form
    {
        bool login = false;
        public Registro()
        {
            InitializeComponent();
        }

        private void RegistrarBut_Click(object sender, EventArgs e)
        {
            bool suc = true;
            string ConnectS = "data source= localhost; database= pap1; user id= root; pwd= ''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);

            string UserT= UserTextBox.Text.ToLower(), PassT= PassTextBox.Text, NomeT= NomeTextBox.Text;

            MD5 mD5 = MD5.Create();
            byte[] valorC = mD5.ComputeHash(Encoding.Default.GetBytes(PassT));
            StringBuilder passSb = new StringBuilder();
            for (int i = 0; i< valorC.Length; i++)
            {
                passSb.Append(valorC[i].ToString("x2"));
            }



            string consultaSql = "insert into Login(Nome, Email, Pass) VALUES('"+NomeT+"','"+UserT+"','"+passSb+"')";
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
                    if(suc)MessageBox.Show("Dados inseridos com sucesso");
                    Conn.Close();
                }
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {

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
    }
}

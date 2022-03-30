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
using System.IO;


namespace G.A.S.C.O
{
    public partial class DefinForms : Form
    {
        public static Color corMenu = new Color();
        public DefinForms()
        {
            InitializeComponent();
        }

        public void DefinForms_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Login.corMenu;
        }

        private void BackDBBut_Click(object sender, EventArgs e)
        {
            string ConnectS = "data source= localhost; database=pap1; user id= root; pwd=''";
            string ficheiroSql = @"BackupBDPAP.sql";

            SaveFileDialog GravarRestauroDialog = new SaveFileDialog();
            GravarRestauroDialog.Filter = "Ficheiro Sql | .sql";
            GravarRestauroDialog.Title = "Guardar Restauro";
            GravarRestauroDialog.FileName = "BackupBDPAP.sql";

            //GravarRestauroDialog.ShowDialog();
            



            MySqlConnection Conn = new MySqlConnection(ConnectS);
            if (GravarRestauroDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ficheiroSql = GravarRestauroDialog.FileName;
                    Conn.Open();

                    MySqlCommand backupCmd = new MySqlCommand();
                    backupCmd.Connection = Conn;
                    MySqlBackup backupSql = new MySqlBackup(backupCmd);

                    backupSql.ExportToFile(ficheiroSql);
                    Conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Não foi possível gravar o ficheiro - tente novamente!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void DefinForms_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void RestDBBut_Click(object sender, EventArgs e)
        {
            string ConnectS = "data source= localhost; database=Backup_PAP; user id=root; pwd=''";

            OpenFileDialog AbrirRestauroDialog = new OpenFileDialog();
            AbrirRestauroDialog.Filter = "Ficheiro Sql | .sql";
            AbrirRestauroDialog.Title = "Abrir o restauro";
            AbrirRestauroDialog.FileName = "BackupBDPAP.sql";

            //AbrirRestauroDialog.ShowDialog();
            

            MySqlConnection Conn = new MySqlConnection(ConnectS);
            if (AbrirRestauroDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ficheiroSql = AbrirRestauroDialog.FileName;
                    Conn.Open();
                    MySqlCommand queryCmd = new MySqlCommand();
                    queryCmd.Connection = Conn;
                    MySqlBackup BackupSql = new MySqlBackup(queryCmd);

                    BackupSql.ImportFromFile(ficheiroSql);


                    Conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Não foi possível abrir o ficheiro - tente Novamente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void RedBut_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Deseja trocar a cor do tema para Vermelha('Firebrick')? Vai precisar de reiniciar a aplicação!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DR == DialogResult.Yes)
            {
                try
                {
                    StreamWriter gravTxt = new StreamWriter(@"colorconfig.ini");
                    gravTxt.WriteLine("Color = " + Color.Firebrick);
                    gravTxt.Close();
                    panel1.BackColor = Color.Firebrick;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível gravar o ficheiro - " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Application.Exit();
            }


        }

        private void BlueBut_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Deseja trocar a cor do tema para Azul('Hottrack')? Vai precisar de reiniciar a aplicação!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DR == DialogResult.Yes)
            {
                try
                {
                    StreamWriter gravTxt = new StreamWriter(@"colorconfig.ini");
                    gravTxt.WriteLine("Color = " + SystemColors.HotTrack);
                    gravTxt.Close();
                    panel1.BackColor = SystemColors.HotTrack;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível gravar o ficheiro - " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Application.Exit();
            }
        }

        private void GreenBut_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Deseja trocar a cor do tema para Verde? Vai precisar de reiniciar a aplicação!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DR == DialogResult.Yes)
            {
                try
                {
                    StreamWriter gravTxt = new StreamWriter(@"colorconfig.ini");
                    gravTxt.WriteLine("Color = " + Color.Green);
                    gravTxt.Close();
                    panel1.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível gravar o ficheiro - " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Application.Exit();
            }
        }
    }
}

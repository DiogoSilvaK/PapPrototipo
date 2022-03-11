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
    public partial class DefinForms : Form
    {
        public static Color corMenu = new Color();
        public DefinForms()
        {
            InitializeComponent();
        }

        public void DefinForms_Load(object sender, EventArgs e)
        {
            
        }

        private void BackDBBut_Click(object sender, EventArgs e)
        {
            string ConnectS = "data source= localhost; database=Backup_PAP; user id= root; pwd=''";
            string ficheiroSql = "@BDPAP.sql";

            MySqlConnection Conn = new MySqlConnection(ConnectS);
            try
            {
                Conn.Open();

                MySqlCommand backupCmd = new MySqlCommand();
                backupCmd.Connection = Conn;
                MySqlBackup backupSql = new MySqlBackup(backupCmd);

                backupSql.ExportToFile(ficheiroSql);
                Conn.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void DefinForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}

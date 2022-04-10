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

namespace G.A.S.C.O
{
    public partial class VTForm : Form
    {
        public VTForm()
        {
            InitializeComponent();
        }

        private void FormVTC_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Login.corMenu;
            CBoxCampo.SelectedIndex = 0;
            TabelaDataGrid.DefaultCellStyle.SelectionBackColor = Login.corMenu;
        }

        private void RefreshBut_Click(object sender, EventArgs e)
        {

           
        }

        private void CBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string consultaSql = String.Empty;
            string ConnectS = "data source=localhost; database=gasco_ds ; user id=GASCO_OP; pwd='GascoDb1234'";
            MySqlConnection Conn = new MySqlConnection(ConnectS);


            switch (CBoxCampo.Text)
            {
                case "Clientes":
                    consultaSql = "SELECT * FROM Cliente";
                    break;
                case "Lista de peças":
                    if (Login.Adm <= 0)
                    {
                        consultaSql = "SELECT * FROM Lista_de_pecas WHERE Cod_Servico in (SELECT Cod_Servico FROM Servico where LoginEmail='" + Login.UserLogado + "')";
                    }
                    else
                    {
                        consultaSql = "SELECT * FROM Lista_de_pecas";
                    }
                    break;
                case "Serviços":
                    consultaSql = "SELECT * FROM servico " + Login.NASQueryS;
                    break;
                case "Veículos":
                    consultaSql = "SELECT * from veiculo";
                    break;
            }

            // DialogResult DR = MessageBox.Show("Deseja procurar por todos os elementos da tabela " + CBoxCampo.Text, "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                Conn.Open();

                    MySqlDataAdapter DataAdapter = new MySqlDataAdapter(consultaSql, Conn);
                    DataSet DataTemp = new DataSet();

                    DataAdapter.Fill(DataTemp, "tabela");
                    TabelaDataGrid.DataSource = DataTemp.Tables["tabela"];

                    // Set your desired AutoSize Mode:
                    TabelaDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    TabelaDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    TabelaDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
                    for (int i = 0; i <= TabelaDataGrid.Columns.Count - 1; i++)
                    {
                        // Store Auto Sized Widths:
                        int colw = TabelaDataGrid.Columns[i].Width;

                        // Remove AutoSizing:
                        TabelaDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                        // Set Width to calculated AutoSize value:
                        TabelaDataGrid.Columns[i].Width = colw;
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

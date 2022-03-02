using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System.IO;

namespace PapPrototipo
{
    public partial class ImprimirForm : Form
    {
        //static string ImpressorasDisp;
        static string tabelaSelect;

        public ImprimirForm()
        {
            InitializeComponent();

        }

        private void ImprimirForm_Load(object sender, EventArgs e)
        {
            string ConnectS = "data source= localhost; database=pap1; user id= root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);

            string consultaSql = "SELECT * FROM Servico";
            CBoxReg.Items.Clear();
            try
            {
                Conn.Open();

                MySqlDataAdapter DataAdapter = new MySqlDataAdapter(consultaSql, Conn);
                DataSet DataTemp = new DataSet();

                DataAdapter.Fill(DataTemp, "tabela");
                TabelaDataGrid.DataSource = DataTemp.Tables["tabela"];

                MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);
                MySqlDataReader DataReader = queryCmd.ExecuteReader();

                if(DataReader.HasRows)
                {
                    while(DataReader.Read())
                    {
                        CBoxReg.Items.Add(DataReader.GetValue(0));
                    }
                    CBoxReg.SelectedIndex = 0;

                    TabelaDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    TabelaDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    TabelaDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                    for (int i = 0; i <= TabelaDataGrid.Columns.Count - 1; i++)
                    {

                        int colw = TabelaDataGrid.Columns[i].Width;

                        TabelaDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;


                        TabelaDataGrid.Columns[i].Width = colw;
                    }
                }
                else
                {
                    MessageBox.Show("Esta tabelá está vazia!!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }


        private void CBoxReg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabelaDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                
            if (e.RowIndex != 0)
                    CBoxReg.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void SOGPbut_Click(object sender, EventArgs e)
        {
            Document documento = new Document();
            string NomePDF = TBoxND.Text + ".pdf";
            PdfWriter.GetInstance(documento, new FileStream(NomePDF, FileMode.Create));

            documento.Open();
            string tituloPDF = "Relatório do serviço\n\n\n\n";
            Paragraph linhaSeparadora = new Paragraph(new Chunk(new LineSeparator(0.0F, 100.0F, lineColor:BaseColor.BLACK , Element.ALIGN_CENTER, 1)));
            iTextSharp.text.Font tituloFont = FontFactory.GetFont("Century Gothic", 24, iTextSharp.text.Font.BOLD, BaseColor.BLUE);

            documento.Add(new Paragraph(tituloPDF, tituloFont) { Alignment = Element.ALIGN_CENTER, Leading = 10.0F, });
            documento.Add(linhaSeparadora);
            string ConnectS = "data source= localhost; database= pap1; user id= root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);

            Conn.Open();

            Graf.Series.Clear();
            Graf.Series.Add("Serviço");

            Graf.Series["Serviço"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.;

            Graf.Series["Serviço"].Color = Color.Green;
            Graf.Series["Serviço"].IsValueShownAsLabel = true;

           

            Graf.Series["Serviço"].Font = new System.Drawing.Font("Century Gothic, Microsoft Sans Serif, Sans-Serif", 16, FontStyle.Regular);
            Graf.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic, Microsoft Sans Serif, Sans-Serif", 12, FontStyle.Regular);
            Graf.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic, Microsoft Sans Serif, Sans-Serif", 12, FontStyle.Regular);
            Graf.ChartAreas[0].AxisX.TitleForeColor = Color.Green;
            Graf.ChartAreas[0].AxisY.TitleForeColor = Color.Violet;
            Graf.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 18, FontStyle.Regular);
            Graf.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 18, FontStyle.Regular);

            Title Titulo = new Title("Estátistica do serviço", Docking.Top, new System.Drawing.Font("Arial",15),Color.DarkViolet);
            Graf.Titles.Clear();
            Graf.Titles.Add(Titulo);
            //Graf.ChartAreas[0].AxisX.Title = "";
            //Graf.ChartAreas[0].AxisY.Title = "Quantidade";

            MySqlDataAdapter DataAdapter;
            DataSet DataTemp;

            string consultaSql = "Select SUM(Preco) from lista_de_pecas where Cod_Servico='"+CBoxReg.Text+"'";
            MySqlCommand queryCmd = new MySqlCommand(consultaSql, Conn);
            Graf.Series["Serviço"].Points.AddXY("Valor total das peças", queryCmd.ExecuteScalar());

            //MySqlDataReader DataReader = queryCmd.ExecuteReader();
            double intervalo = 0;


            Graf.ChartAreas[0].AxisY.Interval = 200;

            MemoryStream memoryStream = new MemoryStream();
            Graf.SaveImage(memoryStream, ChartImageFormat.Png);
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
            img.Alignment = Element.ALIGN_CENTER;
            img.ScalePercent(50, 50);
            documento.Add(img);

            documento.Close();

            System.Diagnostics.Process.Start(NomePDF); 


        }
    }
}

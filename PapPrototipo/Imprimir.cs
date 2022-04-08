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
//using Spire.Pdf;
using RawPrint;
namespace G.A.S.C.O
{
    public partial class ImprimirForm : Form
    {
        public static string NomePDF = String.Empty;
        public static string NomePDF2 = String.Empty;
        public ImprimirForm()
        {
            InitializeComponent();

        }

        private void ImprimirForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Login.corMenu;

            if (Login.corMenu == Color.Firebrick)
                Graf.Palette = ChartColorPalette.Fire;
            else if (Login.corMenu == Color.Green)
                Graf.Palette = ChartColorPalette.SeaGreen;
            else if (Login.corMenu == SystemColors.HotTrack)
                Graf.Palette = ChartColorPalette.Berry;
            string ConnectS = "data source= localhost; database=pap1; user id= root; pwd=''";
            MySqlConnection Conn = new MySqlConnection(ConnectS);

            TipoCBox.SelectedIndex = 0;

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

            if (e.RowIndex > 0)
                    CBoxReg.Text = TabelaDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void SOGPbut_Click(object sender, EventArgs e)
        {

            Document documento = new Document(PageSize.A4);
            NomePDF = TBoxND.Text + ".pdf";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Ficheiro PDF | .pdf ";
            saveFileDialog1.Title = "Guardar o ficheiro PDF";
            saveFileDialog1.FileName = NomePDF;

            saveFileDialog1.ShowDialog();
            NomePDF = saveFileDialog1.FileName;
            MessageBox.Show(NomePDF);
            PdfWriter.GetInstance(documento, new FileStream(NomePDF, FileMode.Create));

            documento.Open();
            // string tituloPDF = "Relatório do serviço";


            Paragraph linhaSeparadora = new Paragraph(new Chunk(new LineSeparator(0.0F, 100.0F, lineColor: BaseColor.BLACK, Element.ALIGN_CENTER, 1)));
            iTextSharp.text.Font tituloFont = FontFactory.GetFont("Microsoft Sans Serif", 24, iTextSharp.text.Font.BOLD, BaseColor.BLACK );
            iTextSharp.text.Font tituloCabFont = FontFactory.GetFont("Microsoft Sans Serif", 20, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font textoFont = FontFactory.GetFont("Microsoft Sans Serif", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            //documento.Add(new Paragraph(tituloPDF, tituloFont) { Alignment = Element.ALIGN_CENTER, Leading = 10.0F, });

            double precoTot = 0.0;

            string EmailTec = String.Empty, NomeTec = String.Empty, NomeEmpTec = String.Empty;

            string TituloServ = String.Empty, DescrServ = String.Empty, DataServ = String.Empty;
            int HorasServ = 0;

            string NomeCliente = String.Empty, MoradaCliente = String.Empty, LocalCliente = String.Empty;  
            int NContr = 0;

            string MarcaV = String.Empty, ModeloV = String.Empty, MesAnoV = String.Empty, MatriculaV = String.Empty;
            int CilindradaV = 0;

            /*
            string MarcaLDP = String.Empty, NomeLDP = String.Empty, N_SerieLDP = String.Empty;
            double PrecoLDP = 0.0;
            */
            //documento.Add(new Paragraph(NomeEmp, textoFont) { Alignment = Element.ALIGN_LEFT, Leading = 10.0F, });

            //MessageBox.Show(PageSize.A4.Width + " " + PageSize.A4.Height);
            string ConnectS = "data source= localhost; database= pap1; user id= root; pwd='';Allow User Variables=True";
            MySqlConnection Conn = new MySqlConnection(ConnectS);


            try
            {
                Conn.Open();

                MySqlDataAdapter DataAdapter;
                DataSet DataTemp;

                string consultaSql = "Select SUM(Preco) from lista_de_pecas where Cod_Servico='" + CBoxReg.Text + "'";
                string consultaSqlLogin = "SELECT Nome, Email, NomeEmpresa from login where Email='" + Login.UserLogado + "'";
                string consultaSqlServico = "SELECT Titulo, Descricao, Horas,Data FROM servico where cod_servico='" + CBoxReg.Text + "'";
                string consultaSqlCliente = "SELECT Nome, N_Contr,Morada,Localidade FROM cliente where Cod_Cliente=(Select Cod_Cliente from veiculo where Matricula=(Select VeiculoMatricula from servico where Cod_Servico='" + CBoxReg.Text + "'))";
                string consultaSqlVeiculo = "SELECT Marca, Modelo,Matricula, Cilindrada, Mes_Ano FROM Veiculo where Matricula=(SELECT VeiculoMatricula from servico where Cod_Servico ='" + CBoxReg.Text + "')";
                string consultaSqlLDP = String.Empty; int subLDP = 0; int subDescLDP = 0;
                if (TipoCBox.Text == "Cliente")
                {
                    consultaSqlLDP = "SELECT (@row_num:=@row_num+1) AS 'Nº', Marca, Nome, Num_Serie, Preco as Preço FROM Lista_de_pecas where cod_servico=(Select Cod_Servico from Servico where cod_servico='" + CBoxReg.Text + "')";
                    subLDP = 1;
                    subDescLDP = 2;
                }
                else
                {
                    consultaSqlLDP = "SELECT (@row_num:=@row_num+1) AS 'Nº', Marca, Nome, Num_Serie, Preco as Preço, Desconto FROM Lista_de_pecas where cod_servico=(Select Cod_Servico from Servico where cod_servico='" + CBoxReg.Text + "')";
                    subLDP = 2;
                    subDescLDP = 1;
                }
                MySqlCommand queryCmdLogin = new MySqlCommand(consultaSqlLogin, Conn);
                MySqlCommand queryCmdServico = new MySqlCommand(consultaSqlServico, Conn);
                MySqlCommand queryCmdCliente = new MySqlCommand(consultaSqlCliente, Conn);
                MySqlCommand queryCmdVeiculo = new MySqlCommand(consultaSqlVeiculo, Conn);
                MySqlCommand queryCmdLDP = new MySqlCommand(consultaSqlLDP, Conn);





                MySqlDataReader DataReader = queryCmdLogin.ExecuteReader();
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        NomeTec = DataReader.GetValue(0).ToString();
                        EmailTec = DataReader.GetValue(1).ToString();
                        NomeEmpTec = DataReader.GetValue(2).ToString();
                    }
                }
                PdfPTable Cabecalho = new PdfPTable(3);
                Cabecalho.DefaultCell.Border = 0;
                PdfPCell cellCab = new PdfPCell(new Phrase(NomeEmpTec, tituloCabFont));
                cellCab.Padding = 20;
                cellCab.Colspan = 2;
                cellCab.Border = 0;
                cellCab.HorizontalAlignment = Element.ALIGN_CENTER;
                System.Drawing.Image cabeclogo = G.A.S.C.O.Properties.Resources.CabecalhoPDFAzul;


                var img = iTextSharp.text.Image.GetInstance(cabeclogo, System.Drawing.Imaging.ImageFormat.Png);
                if (panel1.BackColor == SystemColors.HotTrack)
                {
                    cabeclogo = G.A.S.C.O.Properties.Resources.CabecalhoPDFAzul;
                    img = iTextSharp.text.Image.GetInstance(cabeclogo, System.Drawing.Imaging.ImageFormat.Png);
                    // img = iTextSharp.text.Image.GetInstance("../../Resources/CabecalhoPDFAzul.png");
                }
                if (panel1.BackColor == Color.Firebrick)
                {
                    cabeclogo = G.A.S.C.O.Properties.Resources.CabecalhoPDFFirebrick;
                    img = iTextSharp.text.Image.GetInstance(cabeclogo, System.Drawing.Imaging.ImageFormat.Png);
                    //img = iTextSharp.text.Image.GetInstance("../../Resources/CabecalhoPDFFirebrick.png");
                }
                if (panel1.BackColor == Color.Green)
                {
                    cabeclogo = G.A.S.C.O.Properties.Resources.CabecalhoPDFGreenGasco;
                    img = iTextSharp.text.Image.GetInstance(cabeclogo, System.Drawing.Imaging.ImageFormat.Png);
                    //img = iTextSharp.text.Image.GetInstance("../../Resources/CabecalhoPDFGreenGasco.png");
                }
                img.ScalePercent(35, 35);
                img.Alignment = Element.ALIGN_CENTER;

                PdfPCell Cellimg = new PdfPCell(img);
                //Cellimg.Rowspan = 2;
                //PdfPCell Cellimg = new PdfPCell(new Phrase("LOGOTIPO AQUI!!", textoFont));
                Cellimg.Border = 0;
                Cellimg.Padding = 20;


                Cabecalho.AddCell(cellCab);
                Cabecalho.AddCell(Cellimg);




                PdfPCell NTPCell = new PdfPCell(new Phrase("Nome do Técnico:\n" + NomeTec, textoFont));

                //NTPCell.Padding = 15;
                PdfPCell ETPCell = new PdfPCell(new Phrase("Email do Técnico:\n" + EmailTec, textoFont));

                //ETPCell.Padding= 15;
                PdfPCell DTPCell = new PdfPCell(new Phrase("Data da entrega:\n" + DateTime.Now.ToString(), textoFont));

                //DTPCell.Padding = 15;

                Cabecalho.AddCell(NTPCell); Cabecalho.AddCell(ETPCell); Cabecalho.AddCell(DTPCell);




                Cabecalho.WidthPercentage = 100;
                Paragraph TextoCab = new Paragraph();
                //documento.Add(new Phrase("\n"));
                documento.Add(Cabecalho);
                //documento.Add(new Phrase("\n"));
                documento.Add(linhaSeparadora);

                PdfPTable ClienteTab = new PdfPTable(2);
                ClienteTab.WidthPercentage = 100;

                DataReader.Close();
                DataReader = queryCmdServico.ExecuteReader();
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        TituloServ = DataReader.GetValue(0).ToString();
                        DescrServ = DataReader.GetValue(1).ToString();
                        HorasServ = DataReader.GetInt16(2);
                        DataServ = DataReader.GetValue(3).ToString();

                    }
                }
                PdfPTable DataPrT = new PdfPTable(1);

                PdfPCell DSCell = new PdfPCell(new Phrase("Data de conclusão: " + DataServ, textoFont));
                DSCell.Border = 0;
                PdfPCell HorasCell = new PdfPCell(new Phrase("Horas: " + HorasServ, textoFont));
                HorasCell.Border = 0;
                PdfPCell PrecoCell = new PdfPCell(new Phrase("Preço por Hora: " + PAHUD.Value + "€/h", textoFont));
                PrecoCell.Border = 0;
                PdfPCell TotalPCell = new PdfPCell(new Phrase("Total: " + (HorasServ * PAHUD.Value) + "€", textoFont));
                TotalPCell.Border = 0;

                DataPrT.WidthPercentage = 100;
                DataPrT.AddCell(DSCell);
                DataPrT.AddCell(HorasCell);
                DataPrT.AddCell(PrecoCell);
                DataPrT.AddCell(TotalPCell);

                PdfPCell DataPrCol = new PdfPCell(DataPrT);


                DataReader.Close();
                DataReader = queryCmdCliente.ExecuteReader();
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        NomeCliente = DataReader.GetValue(0).ToString();
                        NContr = ((int)DataReader.GetValue(1));
                        MoradaCliente = DataReader.GetValue(2).ToString();
                        LocalCliente = DataReader.GetValue(3).ToString();

                    }
                }


                documento.Add(new Phrase("", textoFont));
                PdfPTable ClientinfTab = new PdfPTable(1);
                ClientinfTab.WidthPercentage = 100;

                PdfPCell NomeClientCell = new PdfPCell(new Phrase("Nome do cliente: " + NomeCliente, textoFont));
                NomeClientCell.Border = 0;
                PdfPCell NContrCell = new PdfPCell(new Phrase("Número de Contribuinte: " + NContr, textoFont));
                NContrCell.Border = 0;
                PdfPCell MoradaClientCell = new PdfPCell(new Phrase("Morada: " + MoradaCliente, textoFont));
                MoradaClientCell.Border = 0;
                PdfPCell LocalClienteCell = new PdfPCell(new Phrase("Localidade: " + LocalCliente, textoFont));
                LocalClienteCell.Border = 0;

                ClientinfTab.AddCell(NomeClientCell);
                ClientinfTab.AddCell(NContrCell);
                ClientinfTab.AddCell(MoradaClientCell);
                ClientinfTab.AddCell(LocalClienteCell);

                PdfPCell ClienteCol = new PdfPCell(ClientinfTab);

                ClienteTab.AddCell(DataPrCol);
                ClienteTab.AddCell(ClienteCol);

                documento.Add(ClienteTab);

                DataReader.Close();
                DataReader = queryCmdVeiculo.ExecuteReader();
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        MarcaV = DataReader.GetValue(0).ToString();
                        ModeloV = DataReader.GetValue(1).ToString();
                        MatriculaV = DataReader.GetValue(2).ToString();
                        CilindradaV = ((int)DataReader.GetValue(3));
                        MesAnoV = DataReader.GetValue(4).ToString();
                    }
                }

                PdfPTable VeiculoTab = new PdfPTable(2);
                VeiculoTab.WidthPercentage = 100;
                PdfPCell LVCell = new PdfPCell(new Phrase("Carro: " + MarcaV + " " + ModeloV + " " + CilindradaV + "cm³ " + MesAnoV, textoFont));
                LVCell.BorderWidthRight = 0;
                PdfPCell RVCell = new PdfPCell(new Phrase("Matrícula: " + MatriculaV, textoFont));
                RVCell.BorderWidthLeft = 0;
                RVCell.HorizontalAlignment = Element.ALIGN_RIGHT;

                VeiculoTab.AddCell(LVCell);
                VeiculoTab.AddCell(RVCell);

                documento.Add(VeiculoTab);

                /*
                DataReader.Close();
                DataReader = queryCmdLDP.ExecuteReader();
                if(DataReader.HasRows)
                {
                    while(DataReader.Read())
                    {
                        MarcaLDP = DataReader.GetValue(0).ToString();
                        NomeLDP = DataReader.GetValue(1).ToString();
                        N_SerieLDP = DataReader.GetValue(2).ToString();
                        PrecoLDP = ((double)DataReader.GetValue(3));
                    }
                }
                */

                DataReader.Close();
                string consultaSqlRowNReset = "Set @row_num=0";
                MySqlCommand RNR = new MySqlCommand(consultaSqlRowNReset, Conn);
                RNR.ExecuteNonQuery();

                DataReader.Close();
                DataAdapter = new MySqlDataAdapter(consultaSqlLDP, Conn);
                DataTemp = new DataSet();
                DataAdapter.Fill(DataTemp, "tabela");

                int nc = DataTemp.Tables["tabela"].Columns.Count;
                int nl = DataTemp.Tables["tabela"].Rows.Count;
                //int count = 0;
                 

                PdfPTable tableLDP = new PdfPTable(nc);


                PdfPCell LDPT = new PdfPCell(new Phrase("Lista de Peças"));
                LDPT.Colspan = nc;
                LDPT.BorderWidthBottom = 0;

                tableLDP.AddCell(LDPT);
                tableLDP.WidthPercentage = 100;
                string stemp = String.Empty;
                string[] nomeCol = { "Nº", "Marca", "Nome", "Num_Serie", "Preço", "Desconto" };
                for (int Col = 0; Col < nc; Col++)
                {

                    stemp = DataTemp.Tables[0].Columns[Col].ToString();

                    tableLDP.AddCell(new PdfPCell(new Phrase(nomeCol[Col], textoFont))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        Padding = 8,
                        BorderWidth = 1,
                        //BorderColor = iTextSharp.text.BaseColor.BLUE,
                        //BackgroundColor = iTextSharp.text.BaseColor.WHITE,
                    });
                }




                for (int linhas = 0; linhas < nl; linhas++)
                {
                    for (int colunas = 0; colunas < nc; colunas++)
                    {

                        stemp = DataTemp.Tables["tabela"].Rows[linhas][colunas].ToString();

                        

                        if (colunas == nc - subLDP)
                            tableLDP.AddCell(new PdfPCell(new Phrase(stemp + "€", textoFont))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                Padding = 4,
                                BorderWidth = 1,
                                //BorderColor = iTextSharp.text.BaseColor.BLUE,
                                //BackgroundColor = iTextSharp.text.BaseColor.WHITE,
                            });
                        else if(colunas == nc - subDescLDP)
                            tableLDP.AddCell(new PdfPCell(new Phrase(stemp, textoFont))
                            {
                               
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                
                                BorderWidth = 1,
                                //BorderColor = iTextSharp.text.BaseColor.BLUE,
                                //BackgroundColor = iTextSharp.text.BaseColor.WHITE,
                            });
                        else
                            tableLDP.AddCell(new PdfPCell(new Phrase(stemp, textoFont))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                Padding = 4,
                                BorderWidth = 1,
                                //BorderColor = iTextSharp.text.BaseColor.BLUE,
                                //BackgroundColor = iTextSharp.text.BaseColor.WHITE,
                            });

                    }
                }


                DataReader.Close();
                string TotalPCs = "SELECT SUM(Preco) from lista_de_pecas where Cod_Servico='" + CBoxReg.Text + "'";
                precoTot = 0.0;
                MySqlCommand queryTotPCmd = new MySqlCommand(TotalPCs, Conn);
                DataReader = queryTotPCmd.ExecuteReader();
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        precoTot = DataReader.GetDouble(0);
                    }
                }

                PdfPCell TotalPrecCell = new PdfPCell(new Phrase("Total: " + precoTot.ToString() + "€", textoFont));
                TotalPrecCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                TotalPrecCell.Colspan = 5;
                TotalPrecCell.BorderWidth = 1;
                TotalPrecCell.PaddingRight = 4;
                tableLDP.AddCell(TotalPrecCell);

                documento.Add(tableLDP);

                PdfPTable PrecFinalTab = new PdfPTable(1);
                PrecFinalTab.WidthPercentage = 100;
                PdfPCell PrecFinalCell = new PdfPCell(new Phrase("O preço final da reparação ficará: " + (precoTot + (double)(HorasServ * PAHUD.Value)) + "€", textoFont));
                PrecFinalTab.AddCell(PrecFinalCell);
                documento.Add(PrecFinalTab );


                PdfPTable DescTab = new PdfPTable(1);
                DescTab.WidthPercentage = 100;
                PdfPCell DescTCell = new PdfPCell(new Phrase("Descrição: ", textoFont));
                DescTCell.BorderWidthBottom = 0;
                PdfPCell DescPCell = new PdfPCell(new Phrase(DescrServ, textoFont));
                DescPCell.BorderWidthTop = 0;

                DescTab.AddCell(DescTCell);
                DescTab.AddCell(DescPCell);

                documento.Add(DescTab);
            }
            finally
            {
                Conn.Close();
            }
            switch (TipoCBox.Text)
                {
                    case "Cliente":
                        documento.Add(new Paragraph("Eu, " + NomeCliente + ", declaro que recebi o meu veículo imaculado e com respectivo serviço realizado."));
                documento.Add(new Paragraph(new Phrase("", textoFont)));
                documento.Add(new Paragraph(new Paragraph(new Chunk(new LineSeparator(0.0F, 15.0F, lineColor: BaseColor.BLACK, Element.ALIGN_CENTER, 1)))));


                documento.Close();
              //  System.Diagnostics.Process.Start(NomePDF);
            
          
            break;

                case "Servidor":
                  
                    /*
                        string consultaSql = "Select SUM(Preco) from lista_de_pecas where Cod_Servico='" + CBoxReg.Text + "'";
                        string consultaSqlLogin = "SELECT Nome, Email from login where Email='" + Login.UserLogado + "'";
                        string consultaSqlServico = "SELECT Titulo, Descricao, Horas,Data FROM servico where cod_servico='" + CBoxReg.Text + "'";
                        string consultaSqlCliente = "SELECT Nome, N_Contr,Morada FROM cliente where Cod_Cliente=(Select Cod_Cliente from veiculo where Matricula=(Select VeiculoMatricula from servico where Cod_Servico='" + CBoxReg.Text + "'))";
                        string consultaSqlVeiculo = "SELECT Marca, Modelo,Matricula, Cilindrada, Mes_Ano FROM Veiculo where Matricula=(SELECT VeiculoMatricula from servico where Cod_Servico ='" + CBoxReg.Text + "')";
                        string consultaSqlLDP = "SELECT (@row_num:=@row_num+1) AS 'N', Marca, Nome, Num_Serie, Preco FROM Lista_de_pecas where cod_servico=(Select Cod_Servico from Servico where cod_servico='" + CBoxReg.Text + "')";
                        MySqlCommand queryCmdLogin = new MySqlCommand(consultaSqlLogin, Conn);
                        MySqlCommand queryCmdServico = new MySqlCommand(consultaSqlServico, Conn);
                        MySqlCommand queryCmdCliente = new MySqlCommand(consultaSqlCliente, Conn);
                        MySqlCommand queryCmdVeiculo = new MySqlCommand(consultaSqlVeiculo, Conn);
                        MySqlCommand queryCmdLDP = new MySqlCommand(consultaSqlLDP, Conn);
                    */






                        double MOPT = (double)HorasServ * (double)PAHUD.Value ;
                   

                         











                        string TotalPCs = "SELECT SUM(Preco) from lista_de_pecas where Cod_Servico='" + CBoxReg.Text + "'";
                       // double precoTot = 0.0;
                        

                        Graf.Series.Clear();Graf.Series.Add("Servico");
                        Graf.Series["Servico"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                       //Graf.Series["Servico"].Color = Color.Red;

                        Graf.Series["Servico"].IsValueShownAsLabel = true;

                        Graf.Series["Servico"].Font = new System.Drawing.Font("Century Gothic, Microsoft Sans Serif,Sans-Serif", 28, FontStyle.Regular);
                      //  Graf.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic, Microsoft Sans Serif,Sans-Serif", 50, FontStyle.Regular);
                       // Graf.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic, Microsoft Sans Serif, Sans-Serif", 50, FontStyle.Regular);
                        Graf.ChartAreas[0].AxisX.TitleForeColor = Color.Black;
                        Graf.ChartAreas[0].AxisY.TitleForeColor = Color.Black;
                        Graf.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 22, FontStyle.Regular);
                        Graf.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 22, FontStyle.Regular);

                        
                        Title Titulo = new Title("Estátistica do serviço", Docking.Top, new System.Drawing.Font("Arial", 24), Color.Black);
                        Graf.Titles.Clear();
                        Graf.Titles.Add(Titulo);



                        double precoFinal = MOPT+precoTot;
                        double VTPF = (double)(decimal.Round((decimal)((precoTot*100)/precoFinal), 2));
                        double VMOF = (double)(decimal.Round((decimal)((MOPT*100)/precoFinal), 2));

                        Graf.Series["Servico"].Points.AddXY("Valor Total das Peças", VTPF);
                        Graf.Series["Servico"].Points.AddXY("Valor da Mão de Obra", VMOF);
                       
                        


                        

                        MemoryStream memoryStream = new MemoryStream();
                        Graf.SaveImage(memoryStream, ChartImageFormat.Png);
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
                        img.Alignment = Element.ALIGN_CENTER;
                        img.ScalePercent(50, 50);
                        documento.Add(img);

                
                        documento.Close();
                        //System.Diagnostics.Process.Start(NomePDF);


                    break;
            }

        




            PrintForm IF = new PrintForm();
            IF.Show();
            Main M1 = new Main();
            M1.Hide();






        }






    }
}

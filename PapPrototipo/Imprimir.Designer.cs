﻿namespace PapPrototipo
{
    partial class ImprimirForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabelaPag = new System.Windows.Forms.TabPage();
            this.TabelaDataGrid = new System.Windows.Forms.DataGridView();
            this.GrafPag = new System.Windows.Forms.TabPage();
            this.Graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SOGPbut = new System.Windows.Forms.Button();
            this.GPIbut = new System.Windows.Forms.Button();
            this.TBoxND = new System.Windows.Forms.TextBox();
            this.labelimp4 = new System.Windows.Forms.Label();
            this.labelimp3 = new System.Windows.Forms.Label();
            this.CBoxReg = new System.Windows.Forms.ComboBox();
            this.labelimp0 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabelaPag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDataGrid)).BeginInit();
            this.GrafPag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graf)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 538);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabelaPag);
            this.tabControl1.Controls.Add(this.GrafPag);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1078, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // TabelaPag
            // 
            this.TabelaPag.BackColor = System.Drawing.SystemColors.Highlight;
            this.TabelaPag.Controls.Add(this.TabelaDataGrid);
            this.TabelaPag.Location = new System.Drawing.Point(4, 30);
            this.TabelaPag.Name = "TabelaPag";
            this.TabelaPag.Padding = new System.Windows.Forms.Padding(3);
            this.TabelaPag.Size = new System.Drawing.Size(1070, 498);
            this.TabelaPag.TabIndex = 0;
            this.TabelaPag.Text = "Tabela";
            // 
            // TabelaDataGrid
            // 
            this.TabelaDataGrid.AllowUserToAddRows = false;
            this.TabelaDataGrid.AllowUserToDeleteRows = false;
            this.TabelaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.TabelaDataGrid.Location = new System.Drawing.Point(6, 6);
            this.TabelaDataGrid.Name = "TabelaDataGrid";
            this.TabelaDataGrid.Size = new System.Drawing.Size(1058, 491);
            this.TabelaDataGrid.TabIndex = 12;
            this.TabelaDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaDataGrid_CellClick);
            // 
            // GrafPag
            // 
            this.GrafPag.BackColor = System.Drawing.SystemColors.Highlight;
            this.GrafPag.Controls.Add(this.Graf);
            this.GrafPag.Location = new System.Drawing.Point(4, 30);
            this.GrafPag.Name = "GrafPag";
            this.GrafPag.Padding = new System.Windows.Forms.Padding(3);
            this.GrafPag.Size = new System.Drawing.Size(1070, 498);
            this.GrafPag.TabIndex = 1;
            this.GrafPag.Text = "Gráfico";
            // 
            // Graf
            // 
            chartArea2.Name = "ChartArea1";
            this.Graf.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Graf.Legends.Add(legend2);
            this.Graf.Location = new System.Drawing.Point(8, 45);
            this.Graf.Name = "Graf";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Graf.Series.Add(series2);
            this.Graf.Size = new System.Drawing.Size(1056, 452);
            this.Graf.TabIndex = 0;
            this.Graf.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SOGPbut);
            this.groupBox2.Controls.Add(this.GPIbut);
            this.groupBox2.Controls.Add(this.TBoxND);
            this.groupBox2.Controls.Add(this.labelimp4);
            this.groupBox2.Controls.Add(this.labelimp3);
            this.groupBox2.Controls.Add(this.CBoxReg);
            this.groupBox2.Controls.Add(this.labelimp0);
            this.groupBox2.Location = new System.Drawing.Point(4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1079, 129);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // SOGPbut
            // 
            this.SOGPbut.BackColor = System.Drawing.Color.DimGray;
            this.SOGPbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SOGPbut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOGPbut.Location = new System.Drawing.Point(615, 92);
            this.SOGPbut.Name = "SOGPbut";
            this.SOGPbut.Size = new System.Drawing.Size(226, 29);
            this.SOGPbut.TabIndex = 21;
            this.SOGPbut.Text = "Gerar PDF";
            this.SOGPbut.UseVisualStyleBackColor = false;
            this.SOGPbut.Click += new System.EventHandler(this.SOGPbut_Click);
            // 
            // GPIbut
            // 
            this.GPIbut.BackColor = System.Drawing.Color.DimGray;
            this.GPIbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPIbut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPIbut.Location = new System.Drawing.Point(846, 92);
            this.GPIbut.Name = "GPIbut";
            this.GPIbut.Size = new System.Drawing.Size(226, 29);
            this.GPIbut.TabIndex = 20;
            this.GPIbut.Text = "Gerar PDF e Imprimir";
            this.GPIbut.UseVisualStyleBackColor = false;
            // 
            // TBoxND
            // 
            this.TBoxND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxND.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TBoxND.Location = new System.Drawing.Point(615, 59);
            this.TBoxND.Name = "TBoxND";
            this.TBoxND.Size = new System.Drawing.Size(454, 27);
            this.TBoxND.TabIndex = 17;
            this.TBoxND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelimp4
            // 
            this.labelimp4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelimp4.ForeColor = System.Drawing.Color.White;
            this.labelimp4.Location = new System.Drawing.Point(615, 34);
            this.labelimp4.Name = "labelimp4";
            this.labelimp4.Size = new System.Drawing.Size(454, 22);
            this.labelimp4.TabIndex = 16;
            this.labelimp4.Text = "Nome do documento";
            this.labelimp4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelimp3
            // 
            this.labelimp3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelimp3.ForeColor = System.Drawing.Color.White;
            this.labelimp3.Location = new System.Drawing.Point(8, 87);
            this.labelimp3.Name = "labelimp3";
            this.labelimp3.Size = new System.Drawing.Size(197, 22);
            this.labelimp3.TabIndex = 15;
            this.labelimp3.Text = "Codigo do Serviço:";
            this.labelimp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBoxReg
            // 
            this.CBoxReg.BackColor = System.Drawing.Color.White;
            this.CBoxReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxReg.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CBoxReg.FormattingEnabled = true;
            this.CBoxReg.Items.AddRange(new object[] {
            "Clientes",
            "Lista de peças",
            "Serviços",
            "Veículos"});
            this.CBoxReg.Location = new System.Drawing.Point(211, 85);
            this.CBoxReg.Name = "CBoxReg";
            this.CBoxReg.Size = new System.Drawing.Size(222, 29);
            this.CBoxReg.TabIndex = 14;
            this.CBoxReg.SelectedIndexChanged += new System.EventHandler(this.CBoxReg_SelectedIndexChanged);
            // 
            // labelimp0
            // 
            this.labelimp0.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.labelimp0.ForeColor = System.Drawing.Color.White;
            this.labelimp0.Location = new System.Drawing.Point(407, 17);
            this.labelimp0.Name = "labelimp0";
            this.labelimp0.Size = new System.Drawing.Size(154, 39);
            this.labelimp0.TabIndex = 6;
            this.labelimp0.Text = "Imprimir";
            this.labelimp0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImprimirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1085, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImprimirForm";
            this.Text = "ImprimirForm";
            this.Load += new System.EventHandler(this.ImprimirForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TabelaPag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDataGrid)).EndInit();
            this.GrafPag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graf)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TabelaDataGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SOGPbut;
        private System.Windows.Forms.Button GPIbut;
        private System.Windows.Forms.TextBox TBoxND;
        private System.Windows.Forms.Label labelimp4;
        private System.Windows.Forms.Label labelimp3;
        private System.Windows.Forms.ComboBox CBoxReg;
        private System.Windows.Forms.Label labelimp0;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabelaPag;
        private System.Windows.Forms.TabPage GrafPag;
    }
}
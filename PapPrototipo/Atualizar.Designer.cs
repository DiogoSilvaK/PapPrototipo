namespace PapPrototipo
{
    partial class FormAtualizar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListaDePeçasGroupBox = new System.Windows.Forms.GroupBox();
            this.TabelaDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServicoGroupBox = new System.Windows.Forms.GroupBox();
            this.labelat5 = new System.Windows.Forms.Label();
            this.TabelaCBox1 = new System.Windows.Forms.ComboBox();
            this.ButAServicos = new System.Windows.Forms.Button();
            this.DescricaoRTR = new System.Windows.Forms.RichTextBox();
            this.labelat6 = new System.Windows.Forms.Label();
            this.DataServicos = new System.Windows.Forms.DateTimePicker();
            this.labelat1 = new System.Windows.Forms.Label();
            this.labelat4 = new System.Windows.Forms.Label();
            this.Campo2 = new System.Windows.Forms.ComboBox();
            this.Campo1 = new System.Windows.Forms.ComboBox();
            this.labelat3 = new System.Windows.Forms.Label();
            this.NovoReg = new System.Windows.Forms.TextBox();
            this.labelat2 = new System.Windows.Forms.Label();
            this.AntigoReg = new System.Windows.Forms.TextBox();
            this.labelat0 = new System.Windows.Forms.Label();
            this.ListaDePeçasGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ServicoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaDePeçasGroupBox
            // 
            this.ListaDePeçasGroupBox.Controls.Add(this.TabelaDataGrid);
            this.ListaDePeçasGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDePeçasGroupBox.ForeColor = System.Drawing.Color.White;
            this.ListaDePeçasGroupBox.Location = new System.Drawing.Point(12, 0);
            this.ListaDePeçasGroupBox.Name = "ListaDePeçasGroupBox";
            this.ListaDePeçasGroupBox.Size = new System.Drawing.Size(1061, 344);
            this.ListaDePeçasGroupBox.TabIndex = 8;
            this.ListaDePeçasGroupBox.TabStop = false;
            this.ListaDePeçasGroupBox.Text = "Tabela";
            // 
            // TabelaDataGrid
            // 
            this.TabelaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaDataGrid.Location = new System.Drawing.Point(6, 23);
            this.TabelaDataGrid.Name = "TabelaDataGrid";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.TabelaDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaDataGrid.Size = new System.Drawing.Size(1049, 315);
            this.TabelaDataGrid.TabIndex = 0;
            this.TabelaDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaDataGrid_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 325);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServicoGroupBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 319);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ServicoGroupBox
            // 
            this.ServicoGroupBox.Controls.Add(this.labelat5);
            this.ServicoGroupBox.Controls.Add(this.TabelaCBox1);
            this.ServicoGroupBox.Controls.Add(this.ButAServicos);
            this.ServicoGroupBox.Controls.Add(this.DescricaoRTR);
            this.ServicoGroupBox.Controls.Add(this.labelat6);
            this.ServicoGroupBox.Controls.Add(this.DataServicos);
            this.ServicoGroupBox.Controls.Add(this.labelat1);
            this.ServicoGroupBox.Controls.Add(this.labelat4);
            this.ServicoGroupBox.Controls.Add(this.Campo2);
            this.ServicoGroupBox.Controls.Add(this.Campo1);
            this.ServicoGroupBox.Controls.Add(this.labelat3);
            this.ServicoGroupBox.Controls.Add(this.NovoReg);
            this.ServicoGroupBox.Controls.Add(this.labelat2);
            this.ServicoGroupBox.Controls.Add(this.AntigoReg);
            this.ServicoGroupBox.Controls.Add(this.labelat0);
            this.ServicoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicoGroupBox.ForeColor = System.Drawing.Color.White;
            this.ServicoGroupBox.Location = new System.Drawing.Point(9, 15);
            this.ServicoGroupBox.Name = "ServicoGroupBox";
            this.ServicoGroupBox.Size = new System.Drawing.Size(1046, 298);
            this.ServicoGroupBox.TabIndex = 1;
            this.ServicoGroupBox.TabStop = false;
            // 
            // labelat5
            // 
            this.labelat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelat5.ForeColor = System.Drawing.Color.White;
            this.labelat5.Location = new System.Drawing.Point(6, 46);
            this.labelat5.Name = "labelat5";
            this.labelat5.Size = new System.Drawing.Size(79, 23);
            this.labelat5.TabIndex = 26;
            this.labelat5.Text = " Tabela:";
            this.labelat5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabelaCBox1
            // 
            this.TabelaCBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TabelaCBox1.FormattingEnabled = true;
            this.TabelaCBox1.Items.AddRange(new object[] {
            "Clientes",
            "Serviços",
            "Lista de peças",
            "Veículos"});
            this.TabelaCBox1.Location = new System.Drawing.Point(86, 45);
            this.TabelaCBox1.Name = "TabelaCBox1";
            this.TabelaCBox1.Size = new System.Drawing.Size(122, 28);
            this.TabelaCBox1.TabIndex = 2;
            this.TabelaCBox1.SelectedIndexChanged += new System.EventHandler(this.TabelaCBox1_SelectedIndexChanged);
            // 
            // ButAServicos
            // 
            this.ButAServicos.BackColor = System.Drawing.Color.DimGray;
            this.ButAServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButAServicos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButAServicos.FlatAppearance.BorderSize = 2;
            this.ButAServicos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButAServicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButAServicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ButAServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButAServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButAServicos.ForeColor = System.Drawing.Color.White;
            this.ButAServicos.Location = new System.Drawing.Point(531, 262);
            this.ButAServicos.Name = "ButAServicos";
            this.ButAServicos.Size = new System.Drawing.Size(509, 27);
            this.ButAServicos.TabIndex = 25;
            this.ButAServicos.Text = "Atualizar";
            this.ButAServicos.UseVisualStyleBackColor = false;
            // 
            // DescricaoRTR
            // 
            this.DescricaoRTR.BackColor = System.Drawing.Color.White;
            this.DescricaoRTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescricaoRTR.Location = new System.Drawing.Point(531, 44);
            this.DescricaoRTR.Name = "DescricaoRTR";
            this.DescricaoRTR.Size = new System.Drawing.Size(509, 212);
            this.DescricaoRTR.TabIndex = 24;
            this.DescricaoRTR.Text = "";
            // 
            // labelat6
            // 
            this.labelat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelat6.ForeColor = System.Drawing.Color.White;
            this.labelat6.Location = new System.Drawing.Point(527, 18);
            this.labelat6.Name = "labelat6";
            this.labelat6.Size = new System.Drawing.Size(94, 26);
            this.labelat6.TabIndex = 23;
            this.labelat6.Text = "Descrição:";
            this.labelat6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataServicos
            // 
            this.DataServicos.CustomFormat = "dd/MM/yyyy";
            this.DataServicos.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DataServicos.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataServicos.Location = new System.Drawing.Point(86, 258);
            this.DataServicos.Name = "DataServicos";
            this.DataServicos.Size = new System.Drawing.Size(173, 26);
            this.DataServicos.TabIndex = 22;
            // 
            // labelat1
            // 
            this.labelat1.ForeColor = System.Drawing.Color.White;
            this.labelat1.Location = new System.Drawing.Point(11, 194);
            this.labelat1.Name = "labelat1";
            this.labelat1.Size = new System.Drawing.Size(69, 26);
            this.labelat1.TabIndex = 5;
            this.labelat1.Text = "Campo:";
            // 
            // labelat4
            // 
            this.labelat4.ForeColor = System.Drawing.Color.White;
            this.labelat4.Location = new System.Drawing.Point(11, 101);
            this.labelat4.Name = "labelat4";
            this.labelat4.Size = new System.Drawing.Size(69, 26);
            this.labelat4.TabIndex = 5;
            this.labelat4.Text = "Campo:";
            // 
            // Campo2
            // 
            this.Campo2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Campo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Campo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Campo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo2.ForeColor = System.Drawing.Color.White;
            this.Campo2.FormattingEnabled = true;
            this.Campo2.Location = new System.Drawing.Point(86, 191);
            this.Campo2.Name = "Campo2";
            this.Campo2.Size = new System.Drawing.Size(173, 26);
            this.Campo2.TabIndex = 4;
            // 
            // Campo1
            // 
            this.Campo1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Campo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Campo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Campo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo1.ForeColor = System.Drawing.Color.White;
            this.Campo1.FormattingEnabled = true;
            this.Campo1.Location = new System.Drawing.Point(86, 98);
            this.Campo1.Name = "Campo1";
            this.Campo1.Size = new System.Drawing.Size(171, 26);
            this.Campo1.TabIndex = 4;
            // 
            // labelat3
            // 
            this.labelat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelat3.ForeColor = System.Drawing.Color.White;
            this.labelat3.Location = new System.Drawing.Point(20, 262);
            this.labelat3.Name = "labelat3";
            this.labelat3.Size = new System.Drawing.Size(60, 23);
            this.labelat3.TabIndex = 21;
            this.labelat3.Text = "Data:";
            this.labelat3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NovoReg
            // 
            this.NovoReg.BackColor = System.Drawing.Color.White;
            this.NovoReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NovoReg.Location = new System.Drawing.Point(86, 225);
            this.NovoReg.Name = "NovoReg";
            this.NovoReg.Size = new System.Drawing.Size(173, 26);
            this.NovoReg.TabIndex = 18;
            // 
            // labelat2
            // 
            this.labelat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelat2.ForeColor = System.Drawing.Color.White;
            this.labelat2.Location = new System.Drawing.Point(39, 229);
            this.labelat2.Name = "labelat2";
            this.labelat2.Size = new System.Drawing.Size(41, 23);
            this.labelat2.TabIndex = 17;
            this.labelat2.Text = "Por:";
            this.labelat2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AntigoReg
            // 
            this.AntigoReg.BackColor = System.Drawing.Color.White;
            this.AntigoReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AntigoReg.Location = new System.Drawing.Point(86, 130);
            this.AntigoReg.Name = "AntigoReg";
            this.AntigoReg.Size = new System.Drawing.Size(173, 26);
            this.AntigoReg.TabIndex = 13;
            // 
            // labelat0
            // 
            this.labelat0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelat0.ForeColor = System.Drawing.Color.White;
            this.labelat0.Location = new System.Drawing.Point(3, 135);
            this.labelat0.Name = "labelat0";
            this.labelat0.Size = new System.Drawing.Size(79, 23);
            this.labelat0.TabIndex = 12;
            this.labelat0.Text = "Substitui:";
            this.labelat0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1085, 675);
            this.Controls.Add(this.ListaDePeçasGroupBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAtualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAtualizar";
            this.Load += new System.EventHandler(this.FormAtualizar_Load);
            this.ListaDePeçasGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ServicoGroupBox.ResumeLayout(false);
            this.ServicoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ListaDePeçasGroupBox;
        private System.Windows.Forms.DataGridView TabelaDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ServicoGroupBox;
        private System.Windows.Forms.RichTextBox DescricaoRTR;
        private System.Windows.Forms.Label labelat6;
        private System.Windows.Forms.DateTimePicker DataServicos;
        private System.Windows.Forms.Label labelat3;
        private System.Windows.Forms.TextBox NovoReg;
        private System.Windows.Forms.Label labelat2;
        private System.Windows.Forms.TextBox AntigoReg;
        private System.Windows.Forms.Label labelat0;
        private System.Windows.Forms.Button ButAServicos;
        private System.Windows.Forms.Label labelat4;
        private System.Windows.Forms.ComboBox Campo1;
        private System.Windows.Forms.Label labelat1;
        private System.Windows.Forms.ComboBox Campo2;
        private System.Windows.Forms.Label labelat5;
        private System.Windows.Forms.ComboBox TabelaCBox1;
    }
}
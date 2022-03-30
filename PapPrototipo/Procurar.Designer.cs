namespace G.A.S.C.O
{
    partial class FormPesquisar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabelaBox = new System.Windows.Forms.GroupBox();
            this.TabelaDataGrid = new System.Windows.Forms.DataGridView();
            this.PesquisarBox = new System.Windows.Forms.GroupBox();
            this.DataServicos = new System.Windows.Forms.DateTimePicker();
            this.PesquisarBut = new System.Windows.Forms.Button();
            this.PesqTBox = new System.Windows.Forms.TextBox();
            this.CampoCBox = new System.Windows.Forms.ComboBox();
            this.CBoxTabela = new System.Windows.Forms.ComboBox();
            this.CBoxOperadores = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TabelaBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDataGrid)).BeginInit();
            this.PesquisarBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.TabelaBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 563);
            this.panel1.TabIndex = 0;
            // 
            // TabelaBox
            // 
            this.TabelaBox.Controls.Add(this.TabelaDataGrid);
            this.TabelaBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabelaBox.ForeColor = System.Drawing.Color.White;
            this.TabelaBox.Location = new System.Drawing.Point(5, 0);
            this.TabelaBox.Name = "TabelaBox";
            this.TabelaBox.Size = new System.Drawing.Size(1077, 560);
            this.TabelaBox.TabIndex = 0;
            this.TabelaBox.TabStop = false;
            this.TabelaBox.Text = "Tabela";
            // 
            // TabelaDataGrid
            // 
            this.TabelaDataGrid.AllowUserToAddRows = false;
            this.TabelaDataGrid.AllowUserToDeleteRows = false;
            this.TabelaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaDataGrid.Location = new System.Drawing.Point(7, 26);
            this.TabelaDataGrid.Name = "TabelaDataGrid";
            this.TabelaDataGrid.Size = new System.Drawing.Size(1064, 528);
            this.TabelaDataGrid.TabIndex = 0;
            // 
            // PesquisarBox
            // 
            this.PesquisarBox.BackColor = System.Drawing.Color.Transparent;
            this.PesquisarBox.Controls.Add(this.DataServicos);
            this.PesquisarBox.Controls.Add(this.PesquisarBut);
            this.PesquisarBox.Controls.Add(this.PesqTBox);
            this.PesquisarBox.Controls.Add(this.CampoCBox);
            this.PesquisarBox.Controls.Add(this.CBoxTabela);
            this.PesquisarBox.Controls.Add(this.CBoxOperadores);
            this.PesquisarBox.Controls.Add(this.label4);
            this.PesquisarBox.Controls.Add(this.label3);
            this.PesquisarBox.Controls.Add(this.label2);
            this.PesquisarBox.Controls.Add(this.label1);
            this.PesquisarBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarBox.ForeColor = System.Drawing.Color.White;
            this.PesquisarBox.Location = new System.Drawing.Point(5, 1);
            this.PesquisarBox.Name = "PesquisarBox";
            this.PesquisarBox.Size = new System.Drawing.Size(1077, 105);
            this.PesquisarBox.TabIndex = 1;
            this.PesquisarBox.TabStop = false;
            this.PesquisarBox.Text = "Pesquisar";
            // 
            // DataServicos
            // 
            this.DataServicos.CustomFormat = "dd/MM/yyyy";
            this.DataServicos.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DataServicos.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataServicos.Location = new System.Drawing.Point(763, 30);
            this.DataServicos.Name = "DataServicos";
            this.DataServicos.Size = new System.Drawing.Size(308, 27);
            this.DataServicos.TabIndex = 23;
            // 
            // PesquisarBut
            // 
            this.PesquisarBut.BackColor = System.Drawing.Color.DimGray;
            this.PesquisarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PesquisarBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PesquisarBut.FlatAppearance.BorderSize = 2;
            this.PesquisarBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PesquisarBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PesquisarBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PesquisarBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisarBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarBut.ForeColor = System.Drawing.Color.White;
            this.PesquisarBut.Location = new System.Drawing.Point(763, 63);
            this.PesquisarBut.Name = "PesquisarBut";
            this.PesquisarBut.Size = new System.Drawing.Size(308, 33);
            this.PesquisarBut.TabIndex = 4;
            this.PesquisarBut.Text = "Pesquisar";
            this.PesquisarBut.UseVisualStyleBackColor = false;
            this.PesquisarBut.Click += new System.EventHandler(this.PesquisarBut_Click);
            // 
            // PesqTBox
            // 
            this.PesqTBox.Location = new System.Drawing.Point(763, 30);
            this.PesqTBox.Name = "PesqTBox";
            this.PesqTBox.Size = new System.Drawing.Size(308, 27);
            this.PesqTBox.TabIndex = 2;
            // 
            // CampoCBox
            // 
            this.CampoCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CampoCBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CampoCBox.FormattingEnabled = true;
            this.CampoCBox.Items.AddRange(new object[] {
            "Serviço",
            "Cliente",
            "Lista de Peças",
            "Veiculo"});
            this.CampoCBox.Location = new System.Drawing.Point(364, 30);
            this.CampoCBox.Name = "CampoCBox";
            this.CampoCBox.Size = new System.Drawing.Size(121, 29);
            this.CampoCBox.TabIndex = 1;
            this.CampoCBox.SelectedIndexChanged += new System.EventHandler(this.CampoCBox_SelectedIndexChanged);
            // 
            // CBoxTabela
            // 
            this.CBoxTabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxTabela.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CBoxTabela.FormattingEnabled = true;
            this.CBoxTabela.Items.AddRange(new object[] {
            "Clientes",
            "Lista de peças",
            "Serviços",
            "Veículos"});
            this.CBoxTabela.Location = new System.Drawing.Point(145, 30);
            this.CBoxTabela.Name = "CBoxTabela";
            this.CBoxTabela.Size = new System.Drawing.Size(121, 29);
            this.CBoxTabela.TabIndex = 1;
            this.CBoxTabela.SelectedIndexChanged += new System.EventHandler(this.CBoxTabela_SelectedIndexChanged);
            // 
            // CBoxOperadores
            // 
            this.CBoxOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxOperadores.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CBoxOperadores.FormattingEnabled = true;
            this.CBoxOperadores.Items.AddRange(new object[] {
            "maior",
            "menor",
            "maior ou igual",
            "menor ou igual",
            "igual",
            "diferente"});
            this.CBoxOperadores.Location = new System.Drawing.Point(562, 30);
            this.CBoxOperadores.Name = "CBoxOperadores";
            this.CBoxOperadores.Size = new System.Drawing.Size(148, 29);
            this.CBoxOperadores.TabIndex = 1;
            this.CBoxOperadores.SelectedIndexChanged += new System.EventHandler(this.OperadoresCbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(716, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "que";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(491, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "valores";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "no campo";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mostrar na tabela";
            // 
            // FormPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1085, 675);
            this.Controls.Add(this.PesquisarBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPesquisar";
            this.Text = "FormPesquisar";
            this.Load += new System.EventHandler(this.FormPesquisar_Load);
            this.panel1.ResumeLayout(false);
            this.TabelaBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDataGrid)).EndInit();
            this.PesquisarBox.ResumeLayout(false);
            this.PesquisarBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox TabelaBox;
        private System.Windows.Forms.DataGridView TabelaDataGrid;
        private System.Windows.Forms.GroupBox PesquisarBox;
        private System.Windows.Forms.ComboBox CBoxOperadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PesqTBox;
        private System.Windows.Forms.ComboBox CampoCBox;
        private System.Windows.Forms.ComboBox CBoxTabela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PesquisarBut;
        private System.Windows.Forms.DateTimePicker DataServicos;
    }
}
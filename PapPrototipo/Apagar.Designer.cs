namespace PapPrototipo
{
    partial class FormApagar
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
            this.TabelaGroupBox = new System.Windows.Forms.GroupBox();
            this.CBoxTabela = new System.Windows.Forms.ComboBox();
            this.TabelaDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClientesGBox = new System.Windows.Forms.GroupBox();
            this.labeldel1 = new System.Windows.Forms.Label();
            this.ButDel = new System.Windows.Forms.Button();
            this.CampoCBox = new System.Windows.Forms.ComboBox();
            this.labeldel3 = new System.Windows.Forms.Label();
            this.labeldel2 = new System.Windows.Forms.Label();
            this.DelReg = new System.Windows.Forms.TextBox();
            this.DataServicos = new System.Windows.Forms.DateTimePicker();
            this.TabelaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.ClientesGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabelaGroupBox
            // 
            this.TabelaGroupBox.Controls.Add(this.TabelaDataGrid);
            this.TabelaGroupBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabelaGroupBox.ForeColor = System.Drawing.Color.White;
            this.TabelaGroupBox.Location = new System.Drawing.Point(12, 3);
            this.TabelaGroupBox.Name = "TabelaGroupBox";
            this.TabelaGroupBox.Size = new System.Drawing.Size(1061, 424);
            this.TabelaGroupBox.TabIndex = 11;
            this.TabelaGroupBox.TabStop = false;
            this.TabelaGroupBox.Text = "Tabela";
            // 
            // CBoxTabela
            // 
            this.CBoxTabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxTabela.FormattingEnabled = true;
            this.CBoxTabela.Items.AddRange(new object[] {
            "Clientes",
            "Lista de peças",
            "Serviços",
            "Veículos"});
            this.CBoxTabela.Location = new System.Drawing.Point(8, 25);
            this.CBoxTabela.Name = "CBoxTabela";
            this.CBoxTabela.Size = new System.Drawing.Size(1047, 26);
            this.CBoxTabela.TabIndex = 1;
            this.CBoxTabela.SelectedIndexChanged += new System.EventHandler(this.CBoxTabela_SelectedIndexChanged);
            // 
            // TabelaDataGrid
            // 
            this.TabelaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaDataGrid.Location = new System.Drawing.Point(6, 25);
            this.TabelaDataGrid.Name = "TabelaDataGrid";
            this.TabelaDataGrid.Size = new System.Drawing.Size(1049, 392);
            this.TabelaDataGrid.TabIndex = 0;
            this.TabelaDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaDataGrid_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.TabelaGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 433);
            this.panel1.TabIndex = 9;
            // 
            // ClientesGBox
            // 
            this.ClientesGBox.Controls.Add(this.DataServicos);
            this.ClientesGBox.Controls.Add(this.CBoxTabela);
            this.ClientesGBox.Controls.Add(this.labeldel1);
            this.ClientesGBox.Controls.Add(this.ButDel);
            this.ClientesGBox.Controls.Add(this.CampoCBox);
            this.ClientesGBox.Controls.Add(this.labeldel3);
            this.ClientesGBox.Controls.Add(this.labeldel2);
            this.ClientesGBox.Controls.Add(this.DelReg);
            this.ClientesGBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesGBox.ForeColor = System.Drawing.Color.White;
            this.ClientesGBox.Location = new System.Drawing.Point(12, 0);
            this.ClientesGBox.Name = "ClientesGBox";
            this.ClientesGBox.Size = new System.Drawing.Size(1061, 236);
            this.ClientesGBox.TabIndex = 10;
            this.ClientesGBox.TabStop = false;
            // 
            // labeldel1
            // 
            this.labeldel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldel1.ForeColor = System.Drawing.Color.White;
            this.labeldel1.Location = new System.Drawing.Point(12, 59);
            this.labeldel1.Name = "labeldel1";
            this.labeldel1.Size = new System.Drawing.Size(1043, 23);
            this.labeldel1.TabIndex = 15;
            this.labeldel1.Text = "No:";
            this.labeldel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButDel
            // 
            this.ButDel.BackColor = System.Drawing.Color.DimGray;
            this.ButDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButDel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButDel.FlatAppearance.BorderSize = 2;
            this.ButDel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ButDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButDel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButDel.ForeColor = System.Drawing.Color.White;
            this.ButDel.Location = new System.Drawing.Point(8, 203);
            this.ButDel.Name = "ButDel";
            this.ButDel.Size = new System.Drawing.Size(1047, 27);
            this.ButDel.TabIndex = 3;
            this.ButDel.Text = "Apagar";
            this.ButDel.UseVisualStyleBackColor = false;
            this.ButDel.Click += new System.EventHandler(this.ButDel_Click);
            // 
            // CampoCBox
            // 
            this.CampoCBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CampoCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CampoCBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoCBox.ForeColor = System.Drawing.Color.White;
            this.CampoCBox.FormattingEnabled = true;
            this.CampoCBox.Items.AddRange(new object[] {
            "Marca",
            "Mês/Ano"});
            this.CampoCBox.Location = new System.Drawing.Point(87, 82);
            this.CampoCBox.Name = "CampoCBox";
            this.CampoCBox.Size = new System.Drawing.Size(968, 28);
            this.CampoCBox.TabIndex = 12;
            this.CampoCBox.SelectedIndexChanged += new System.EventHandler(this.CampoCBox_SelectedIndexChanged);
            // 
            // labeldel3
            // 
            this.labeldel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldel3.ForeColor = System.Drawing.Color.White;
            this.labeldel3.Location = new System.Drawing.Point(12, 112);
            this.labeldel3.Name = "labeldel3";
            this.labeldel3.Size = new System.Drawing.Size(1043, 23);
            this.labeldel3.TabIndex = 4;
            this.labeldel3.Text = "Em:";
            this.labeldel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeldel2
            // 
            this.labeldel2.ForeColor = System.Drawing.Color.White;
            this.labeldel2.Location = new System.Drawing.Point(13, 86);
            this.labeldel2.Name = "labeldel2";
            this.labeldel2.Size = new System.Drawing.Size(69, 26);
            this.labeldel2.TabIndex = 13;
            this.labeldel2.Text = "Campo:";
            // 
            // DelReg
            // 
            this.DelReg.BackColor = System.Drawing.Color.White;
            this.DelReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelReg.Location = new System.Drawing.Point(8, 138);
            this.DelReg.Name = "DelReg";
            this.DelReg.Size = new System.Drawing.Size(1047, 26);
            this.DelReg.TabIndex = 5;
            // 
            // DataServicos
            // 
            this.DataServicos.CustomFormat = "dd/MM/yyyy";
            this.DataServicos.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DataServicos.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataServicos.Location = new System.Drawing.Point(8, 170);
            this.DataServicos.Name = "DataServicos";
            this.DataServicos.Size = new System.Drawing.Size(1047, 26);
            this.DataServicos.TabIndex = 23;
            // 
            // FormApagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1085, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClientesGBox);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormApagar";
            this.Text = "FormApagar";
            this.Load += new System.EventHandler(this.FormApagar_Load);
            this.TabelaGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ClientesGBox.ResumeLayout(false);
            this.ClientesGBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TabelaGroupBox;
        private System.Windows.Forms.ComboBox CBoxTabela;
        private System.Windows.Forms.DataGridView TabelaDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox ClientesGBox;
        private System.Windows.Forms.Label labeldel1;
        private System.Windows.Forms.Button ButDel;
        private System.Windows.Forms.ComboBox CampoCBox;
        private System.Windows.Forms.Label labeldel3;
        private System.Windows.Forms.Label labeldel2;
        private System.Windows.Forms.TextBox DelReg;
        private System.Windows.Forms.DateTimePicker DataServicos;
    }
}
﻿namespace PapPrototipo
{
    partial class FormVTC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshBut = new System.Windows.Forms.Button();
            this.TabelaDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 632);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RefreshBut);
            this.groupBox1.Controls.Add(this.TabelaDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(3, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 635);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // RefreshBut
            // 
            this.RefreshBut.BackColor = System.Drawing.Color.DimGray;
            this.RefreshBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RefreshBut.FlatAppearance.BorderSize = 2;
            this.RefreshBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.RefreshBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.RefreshBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBut.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.RefreshBut.ForeColor = System.Drawing.Color.White;
            this.RefreshBut.Location = new System.Drawing.Point(6, 596);
            this.RefreshBut.Name = "RefreshBut";
            this.RefreshBut.Size = new System.Drawing.Size(1064, 30);
            this.RefreshBut.TabIndex = 1;
            this.RefreshBut.Text = "Atualizar";
            this.RefreshBut.UseVisualStyleBackColor = false;
            // 
            // TabelaDataGrid
            // 
            this.TabelaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaDataGrid.Location = new System.Drawing.Point(9, 13);
            this.TabelaDataGrid.Name = "TabelaDataGrid";
            this.TabelaDataGrid.Size = new System.Drawing.Size(1067, 577);
            this.TabelaDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(348, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visualizar todos os clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormVTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1085, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVTC";
            this.Text = "FormVTC";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TabelaDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RefreshBut;
    }
}
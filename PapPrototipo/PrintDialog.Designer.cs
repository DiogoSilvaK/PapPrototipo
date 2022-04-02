namespace G.A.S.C.O
{
    partial class PrintDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumCopiasUpDown = new System.Windows.Forms.NumericUpDown();
            this.ImpressorasCBox = new System.Windows.Forms.ComboBox();
            this.CoresCBox = new System.Windows.Forms.ComboBox();
            this.CancBut = new System.Windows.Forms.Button();
            this.ImpBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCopiasUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 95);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imprimir";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NumCopiasUpDown);
            this.panel1.Controls.Add(this.ImpressorasCBox);
            this.panel1.Controls.Add(this.CoresCBox);
            this.panel1.Controls.Add(this.CancBut);
            this.panel1.Controls.Add(this.ImpBut);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 236);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 292);
            this.panel1.TabIndex = 2;
            // 
            // NumCopiasUpDown
            // 
            this.NumCopiasUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumCopiasUpDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCopiasUpDown.Location = new System.Drawing.Point(131, 103);
            this.NumCopiasUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumCopiasUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCopiasUpDown.Name = "NumCopiasUpDown";
            this.NumCopiasUpDown.Size = new System.Drawing.Size(59, 27);
            this.NumCopiasUpDown.TabIndex = 17;
            this.NumCopiasUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ImpressorasCBox
            // 
            this.ImpressorasCBox.BackColor = System.Drawing.Color.White;
            this.ImpressorasCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImpressorasCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImpressorasCBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ImpressorasCBox.FormattingEnabled = true;
            this.ImpressorasCBox.Location = new System.Drawing.Point(131, 18);
            this.ImpressorasCBox.Name = "ImpressorasCBox";
            this.ImpressorasCBox.Size = new System.Drawing.Size(230, 29);
            this.ImpressorasCBox.TabIndex = 16;
            // 
            // CoresCBox
            // 
            this.CoresCBox.BackColor = System.Drawing.Color.White;
            this.CoresCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoresCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CoresCBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CoresCBox.FormattingEnabled = true;
            this.CoresCBox.Items.AddRange(new object[] {
            "Cores",
            "Preto e Branco"});
            this.CoresCBox.Location = new System.Drawing.Point(131, 157);
            this.CoresCBox.Name = "CoresCBox";
            this.CoresCBox.Size = new System.Drawing.Size(230, 29);
            this.CoresCBox.TabIndex = 15;
            // 
            // CancBut
            // 
            this.CancBut.BackColor = System.Drawing.Color.Firebrick;
            this.CancBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CancBut.FlatAppearance.BorderSize = 2;
            this.CancBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.CancBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.CancBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancBut.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancBut.ForeColor = System.Drawing.Color.White;
            this.CancBut.Location = new System.Drawing.Point(189, 227);
            this.CancBut.Name = "CancBut";
            this.CancBut.Size = new System.Drawing.Size(176, 53);
            this.CancBut.TabIndex = 4;
            this.CancBut.Text = "Cancelar";
            this.CancBut.UseVisualStyleBackColor = false;
            this.CancBut.Click += new System.EventHandler(this.CancBut_Click);
            // 
            // ImpBut
            // 
            this.ImpBut.BackColor = System.Drawing.Color.Green;
            this.ImpBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ImpBut.FlatAppearance.BorderSize = 2;
            this.ImpBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ImpBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ImpBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ImpBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImpBut.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImpBut.ForeColor = System.Drawing.Color.White;
            this.ImpBut.Location = new System.Drawing.Point(7, 227);
            this.ImpBut.Name = "ImpBut";
            this.ImpBut.Size = new System.Drawing.Size(176, 53);
            this.ImpBut.TabIndex = 3;
            this.ImpBut.Text = "Imprimir";
            this.ImpBut.UseVisualStyleBackColor = false;
            this.ImpBut.Click += new System.EventHandler(this.ImpBut_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cores:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número  de cópias:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Impressora:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pdfViewer1);
            this.panel2.Location = new System.Drawing.Point(382, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 520);
            this.panel2.TabIndex = 18;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(3, 0);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(387, 517);
            this.pdfViewer1.TabIndex = 1;
            // 
            // PrintDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(787, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PrintDialog_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumCopiasUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancBut;
        private System.Windows.Forms.Button ImpBut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumCopiasUpDown;
        private System.Windows.Forms.ComboBox ImpressorasCBox;
        private System.Windows.Forms.ComboBox CoresCBox;
        private System.Windows.Forms.Panel panel2;
        private PdfiumViewer.PdfViewer pdfViewer1;
    }
}
namespace G.A.S.C.O
{
    partial class PrintForm
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
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FechBut = new System.Windows.Forms.Button();
            this.MinBut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-7, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imprimir";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(16, 7);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(519, 721);
            this.pdfViewer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pdfViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 728);
            this.panel1.TabIndex = 2;
            // 
            // FechBut
            // 
            this.FechBut.BackColor = System.Drawing.Color.Firebrick;
            this.FechBut.FlatAppearance.BorderSize = 0;
            this.FechBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.FechBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.FechBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechBut.Location = new System.Drawing.Point(506, 0);
            this.FechBut.Name = "FechBut";
            this.FechBut.Size = new System.Drawing.Size(41, 21);
            this.FechBut.TabIndex = 4;
            this.FechBut.Text = "❌";
            this.FechBut.UseVisualStyleBackColor = false;
            this.FechBut.Click += new System.EventHandler(this.FechBut_Click);
            // 
            // MinBut
            // 
            this.MinBut.BackColor = System.Drawing.Color.DimGray;
            this.MinBut.FlatAppearance.BorderSize = 0;
            this.MinBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.MinBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.MinBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBut.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBut.Location = new System.Drawing.Point(471, 0);
            this.MinBut.Name = "MinBut";
            this.MinBut.Size = new System.Drawing.Size(35, 21);
            this.MinBut.TabIndex = 5;
            this.MinBut.Text = "_";
            this.MinBut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinBut.UseVisualStyleBackColor = false;
            this.MinBut.Click += new System.EventHandler(this.MinBut_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(547, 781);
            this.Controls.Add(this.MinBut);
            this.Controls.Add(this.FechBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PrintDialog_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private PdfiumViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FechBut;
        private System.Windows.Forms.Button MinBut;
    }
}
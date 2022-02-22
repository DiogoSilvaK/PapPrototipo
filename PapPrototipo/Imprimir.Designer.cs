namespace PapPrototipo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelimp1 = new System.Windows.Forms.Label();
            this.labelimp3 = new System.Windows.Forms.Label();
            this.labelimp2 = new System.Windows.Forms.Label();
            this.labelimp4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBoxTF = new System.Windows.Forms.ComboBox();
            this.CBoxImp = new System.Windows.Forms.ComboBox();
            this.CBoxQual = new System.Windows.Forms.ComboBox();
            this.UpDownQtde = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownQtde)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 519);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 504);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelimp1
            // 
            this.labelimp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelimp1.ForeColor = System.Drawing.Color.White;
            this.labelimp1.Location = new System.Drawing.Point(12, 46);
            this.labelimp1.Name = "labelimp1";
            this.labelimp1.Size = new System.Drawing.Size(110, 22);
            this.labelimp1.TabIndex = 3;
            this.labelimp1.Text = "Tipo de Folha:";
            // 
            // labelimp3
            // 
            this.labelimp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelimp3.ForeColor = System.Drawing.Color.White;
            this.labelimp3.Location = new System.Drawing.Point(485, 46);
            this.labelimp3.Name = "labelimp3";
            this.labelimp3.Size = new System.Drawing.Size(110, 22);
            this.labelimp3.TabIndex = 4;
            this.labelimp3.Text = "Quantidade:";
            // 
            // labelimp2
            // 
            this.labelimp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelimp2.ForeColor = System.Drawing.Color.White;
            this.labelimp2.Location = new System.Drawing.Point(12, 108);
            this.labelimp2.Name = "labelimp2";
            this.labelimp2.Size = new System.Drawing.Size(110, 22);
            this.labelimp2.TabIndex = 5;
            this.labelimp2.Text = "Qualidade:";
            // 
            // labelimp4
            // 
            this.labelimp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelimp4.ForeColor = System.Drawing.Color.White;
            this.labelimp4.Location = new System.Drawing.Point(485, 108);
            this.labelimp4.Name = "labelimp4";
            this.labelimp4.Size = new System.Drawing.Size(110, 22);
            this.labelimp4.TabIndex = 7;
            this.labelimp4.Text = "Impressora:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1079, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Imprimir";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBoxTF
            // 
            this.CBoxTF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxTF.FormattingEnabled = true;
            this.CBoxTF.Items.AddRange(new object[] {
            "A3",
            "A4",
            "A5"});
            this.CBoxTF.Location = new System.Drawing.Point(128, 46);
            this.CBoxTF.Name = "CBoxTF";
            this.CBoxTF.Size = new System.Drawing.Size(278, 28);
            this.CBoxTF.TabIndex = 8;
            this.CBoxTF.SelectedIndexChanged += new System.EventHandler(this.CBoxTF_SelectedIndexChanged);
            // 
            // CBoxImp
            // 
            this.CBoxImp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxImp.FormattingEnabled = true;
            this.CBoxImp.Location = new System.Drawing.Point(601, 108);
            this.CBoxImp.Name = "CBoxImp";
            this.CBoxImp.Size = new System.Drawing.Size(278, 28);
            this.CBoxImp.TabIndex = 9;
            this.CBoxImp.SelectedIndexChanged += new System.EventHandler(this.CBoxImp_SelectedIndexChanged);
            // 
            // CBoxQual
            // 
            this.CBoxQual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxQual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxQual.FormattingEnabled = true;
            this.CBoxQual.Location = new System.Drawing.Point(128, 108);
            this.CBoxQual.Name = "CBoxQual";
            this.CBoxQual.Size = new System.Drawing.Size(278, 28);
            this.CBoxQual.TabIndex = 10;
            // 
            // UpDownQtde
            // 
            this.UpDownQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpDownQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDownQtde.Location = new System.Drawing.Point(601, 46);
            this.UpDownQtde.Name = "UpDownQtde";
            this.UpDownQtde.Size = new System.Drawing.Size(278, 26);
            this.UpDownQtde.TabIndex = 11;
            // 
            // ImprimirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1085, 675);
            this.Controls.Add(this.UpDownQtde);
            this.Controls.Add(this.CBoxQual);
            this.Controls.Add(this.CBoxImp);
            this.Controls.Add(this.CBoxTF);
            this.Controls.Add(this.labelimp4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelimp2);
            this.Controls.Add(this.labelimp3);
            this.Controls.Add(this.labelimp1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImprimirForm";
            this.Text = "ImprimirForm";
            this.Load += new System.EventHandler(this.ImprimirForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpDownQtde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelimp1;
        private System.Windows.Forms.Label labelimp3;
        private System.Windows.Forms.Label labelimp2;
        private System.Windows.Forms.Label labelimp4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBoxTF;
        private System.Windows.Forms.ComboBox CBoxImp;
        private System.Windows.Forms.ComboBox CBoxQual;
        private System.Windows.Forms.NumericUpDown UpDownQtde;
    }
}
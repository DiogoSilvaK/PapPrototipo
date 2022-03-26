namespace PapPrototipo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InicioBut = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.InserirBut = new System.Windows.Forms.Button();
            this.AtualizarBut = new System.Windows.Forms.Button();
            this.ApagarBut = new System.Windows.Forms.Button();
            this.PesquisarBut = new System.Windows.Forms.Button();
            this.VTC = new System.Windows.Forms.Button();
            this.VTS = new System.Windows.Forms.Button();
            this.panelf3 = new System.Windows.Forms.Panel();
            this.DefinBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panelf3);
            this.splitContainer1.Size = new System.Drawing.Size(1246, 675);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.LogoBox);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 141);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.InicioBut);
            this.panel2.Controls.Add(this.InserirBut);
            this.panel2.Controls.Add(this.AtualizarBut);
            this.panel2.Controls.Add(this.ApagarBut);
            this.panel2.Controls.Add(this.PesquisarBut);
            this.panel2.Controls.Add(this.VTC);
            this.panel2.Controls.Add(this.VTS);
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 563);
            this.panel2.TabIndex = 1;
            // 
            // InicioBut
            // 
            this.InicioBut.BackColor = System.Drawing.Color.DimGray;
            this.InicioBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InicioBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InicioBut.FlatAppearance.BorderSize = 2;
            this.InicioBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InicioBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InicioBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.InicioBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InicioBut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioBut.ForeColor = System.Drawing.Color.White;
            this.InicioBut.Location = new System.Drawing.Point(3, 38);
            this.InicioBut.Margin = new System.Windows.Forms.Padding(4);
            this.InicioBut.Name = "InicioBut";
            this.InicioBut.Size = new System.Drawing.Size(151, 50);
            this.InicioBut.TabIndex = 1;
            this.InicioBut.Text = "Inicio";
            this.InicioBut.UseVisualStyleBackColor = false;
            this.InicioBut.Click += new System.EventHandler(this.InicioBut_Click);
            // 
            // Sair
            // 
            this.Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sair.BackColor = System.Drawing.Color.Firebrick;
            this.Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Sair.FlatAppearance.BorderSize = 2;
            this.Sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.ForeColor = System.Drawing.Color.White;
            this.Sair.Location = new System.Drawing.Point(83, 5);
            this.Sair.Margin = new System.Windows.Forms.Padding(4);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(70, 43);
            this.Sair.TabIndex = 1;
            this.Sair.Text = "❌";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // InserirBut
            // 
            this.InserirBut.BackColor = System.Drawing.Color.DimGray;
            this.InserirBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InserirBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InserirBut.FlatAppearance.BorderSize = 2;
            this.InserirBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InserirBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InserirBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.InserirBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InserirBut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InserirBut.ForeColor = System.Drawing.Color.White;
            this.InserirBut.Location = new System.Drawing.Point(3, 96);
            this.InserirBut.Margin = new System.Windows.Forms.Padding(4);
            this.InserirBut.Name = "InserirBut";
            this.InserirBut.Size = new System.Drawing.Size(151, 50);
            this.InserirBut.TabIndex = 0;
            this.InserirBut.Text = "Inserir";
            this.InserirBut.UseVisualStyleBackColor = false;
            this.InserirBut.Click += new System.EventHandler(this.InserirBut_Click);
            // 
            // AtualizarBut
            // 
            this.AtualizarBut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AtualizarBut.BackColor = System.Drawing.Color.DimGray;
            this.AtualizarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AtualizarBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AtualizarBut.FlatAppearance.BorderSize = 2;
            this.AtualizarBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AtualizarBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AtualizarBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AtualizarBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AtualizarBut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtualizarBut.ForeColor = System.Drawing.Color.White;
            this.AtualizarBut.Location = new System.Drawing.Point(2, 154);
            this.AtualizarBut.Margin = new System.Windows.Forms.Padding(4);
            this.AtualizarBut.Name = "AtualizarBut";
            this.AtualizarBut.Size = new System.Drawing.Size(151, 50);
            this.AtualizarBut.TabIndex = 0;
            this.AtualizarBut.Text = "Atualizar";
            this.AtualizarBut.UseVisualStyleBackColor = false;
            this.AtualizarBut.Click += new System.EventHandler(this.AtualizarBut_Click);
            // 
            // ApagarBut
            // 
            this.ApagarBut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ApagarBut.BackColor = System.Drawing.Color.DimGray;
            this.ApagarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApagarBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ApagarBut.FlatAppearance.BorderSize = 2;
            this.ApagarBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ApagarBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ApagarBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ApagarBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApagarBut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApagarBut.ForeColor = System.Drawing.Color.White;
            this.ApagarBut.Location = new System.Drawing.Point(2, 212);
            this.ApagarBut.Margin = new System.Windows.Forms.Padding(4);
            this.ApagarBut.Name = "ApagarBut";
            this.ApagarBut.Size = new System.Drawing.Size(151, 50);
            this.ApagarBut.TabIndex = 0;
            this.ApagarBut.Text = "Apagar";
            this.ApagarBut.UseVisualStyleBackColor = false;
            this.ApagarBut.Click += new System.EventHandler(this.ApagarBut_Click);
            // 
            // PesquisarBut
            // 
            this.PesquisarBut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PesquisarBut.BackColor = System.Drawing.Color.DimGray;
            this.PesquisarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PesquisarBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PesquisarBut.FlatAppearance.BorderSize = 2;
            this.PesquisarBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PesquisarBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PesquisarBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PesquisarBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisarBut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarBut.ForeColor = System.Drawing.Color.White;
            this.PesquisarBut.Location = new System.Drawing.Point(2, 270);
            this.PesquisarBut.Margin = new System.Windows.Forms.Padding(4);
            this.PesquisarBut.Name = "PesquisarBut";
            this.PesquisarBut.Size = new System.Drawing.Size(151, 50);
            this.PesquisarBut.TabIndex = 0;
            this.PesquisarBut.Text = "Pesquisar";
            this.PesquisarBut.UseVisualStyleBackColor = false;
            this.PesquisarBut.Click += new System.EventHandler(this.PesquisarBut_Click);
            // 
            // VTC
            // 
            this.VTC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VTC.BackColor = System.Drawing.Color.DimGray;
            this.VTC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VTC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VTC.FlatAppearance.BorderSize = 2;
            this.VTC.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.VTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VTC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VTC.ForeColor = System.Drawing.Color.White;
            this.VTC.Location = new System.Drawing.Point(2, 328);
            this.VTC.Margin = new System.Windows.Forms.Padding(4);
            this.VTC.Name = "VTC";
            this.VTC.Size = new System.Drawing.Size(151, 53);
            this.VTC.TabIndex = 0;
            this.VTC.Text = "Visualizar todos";
            this.VTC.UseVisualStyleBackColor = false;
            this.VTC.Click += new System.EventHandler(this.VTC_Click);
            // 
            // VTS
            // 
            this.VTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VTS.BackColor = System.Drawing.Color.DimGray;
            this.VTS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VTS.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VTS.FlatAppearance.BorderSize = 2;
            this.VTS.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VTS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VTS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.VTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VTS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VTS.ForeColor = System.Drawing.Color.White;
            this.VTS.Location = new System.Drawing.Point(2, 389);
            this.VTS.Margin = new System.Windows.Forms.Padding(4);
            this.VTS.Name = "VTS";
            this.VTS.Size = new System.Drawing.Size(151, 53);
            this.VTS.TabIndex = 0;
            this.VTS.Text = "Imprimir";
            this.VTS.UseVisualStyleBackColor = false;
            this.VTS.Click += new System.EventHandler(this.VTS_Click);
            // 
            // panelf3
            // 
            this.panelf3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelf3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelf3.Location = new System.Drawing.Point(0, 0);
            this.panelf3.Name = "panelf3";
            this.panelf3.Size = new System.Drawing.Size(1085, 675);
            this.panelf3.TabIndex = 0;
            // 
            // DefinBut
            // 
            this.DefinBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DefinBut.BackColor = System.Drawing.Color.DimGray;
            this.DefinBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefinBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DefinBut.FlatAppearance.BorderSize = 2;
            this.DefinBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DefinBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DefinBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.DefinBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefinBut.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefinBut.ForeColor = System.Drawing.Color.White;
            this.DefinBut.Location = new System.Drawing.Point(2, 5);
            this.DefinBut.Margin = new System.Windows.Forms.Padding(4);
            this.DefinBut.Name = "DefinBut";
            this.DefinBut.Size = new System.Drawing.Size(70, 43);
            this.DefinBut.TabIndex = 2;
            this.DefinBut.Text = "🔧";
            this.DefinBut.UseVisualStyleBackColor = false;
            this.DefinBut.Click += new System.EventHandler(this.DefinBut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.Sair);
            this.panel1.Controls.Add(this.DefinBut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 509);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 52);
            this.panel1.TabIndex = 3;
            // 
            // LogoBox
            // 
            this.LogoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.LogoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoBox.Image = global::PapPrototipo.Properties.Resources.LogoAMMv2;
            this.LogoBox.Location = new System.Drawing.Point(0, 0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(153, 141);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 2;
            this.LogoBox.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 675);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1262, 714);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G.A.S.C.O";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button VTS;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button InserirBut;
        private System.Windows.Forms.Button ApagarBut;
        private System.Windows.Forms.Button PesquisarBut;
        private System.Windows.Forms.Button VTC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button InicioBut;
        private System.Windows.Forms.Panel panelf3;
        private System.Windows.Forms.Button AtualizarBut;
        private System.Windows.Forms.Button DefinBut;
        private System.Windows.Forms.Panel panel1;
    }
}
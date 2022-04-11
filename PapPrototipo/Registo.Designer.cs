namespace G.A.S.C.O
{
    partial class Registo
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserPicBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpTBox = new System.Windows.Forms.TextBox();
            this.VoltarBut = new System.Windows.Forms.Button();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.RegistarBut = new System.Windows.Forms.Button();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.UserPicBox);
            this.panel2.Location = new System.Drawing.Point(110, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 160);
            this.panel2.TabIndex = 5;
            // 
            // UserPicBox
            // 
            this.UserPicBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserPicBox.BackColor = System.Drawing.Color.White;
            this.UserPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPicBox.Image = global::G.A.S.C.O.Properties.Resources.User_Icon;
            this.UserPicBox.Location = new System.Drawing.Point(0, 0);
            this.UserPicBox.Name = "UserPicBox";
            this.UserPicBox.Size = new System.Drawing.Size(160, 160);
            this.UserPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPicBox.TabIndex = 0;
            this.UserPicBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EmpTBox);
            this.panel1.Controls.Add(this.VoltarBut);
            this.panel1.Controls.Add(this.NomeLabel);
            this.panel1.Controls.Add(this.NomeTextBox);
            this.panel1.Controls.Add(this.RegistarBut);
            this.panel1.Controls.Add(this.PassLabel);
            this.panel1.Controls.Add(this.PassTextBox);
            this.panel1.Controls.Add(this.UserLabel);
            this.panel1.Controls.Add(this.UserTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 477);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Empresa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmpTBox
            // 
            this.EmpTBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmpTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpTBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpTBox.Location = new System.Drawing.Point(113, 240);
            this.EmpTBox.Name = "EmpTBox";
            this.EmpTBox.Size = new System.Drawing.Size(160, 27);
            this.EmpTBox.TabIndex = 11;
            this.EmpTBox.Validating += new System.ComponentModel.CancelEventHandler(this.EmpTBox_Validating);
            // 
            // VoltarBut
            // 
            this.VoltarBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.VoltarBut.BackColor = System.Drawing.Color.DimGray;
            this.VoltarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VoltarBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VoltarBut.FlatAppearance.BorderSize = 2;
            this.VoltarBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.VoltarBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.VoltarBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VoltarBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VoltarBut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoltarBut.ForeColor = System.Drawing.Color.White;
            this.VoltarBut.Location = new System.Drawing.Point(3, 441);
            this.VoltarBut.Name = "VoltarBut";
            this.VoltarBut.Size = new System.Drawing.Size(185, 31);
            this.VoltarBut.TabIndex = 9;
            this.VoltarBut.Text = "Voltar";
            this.VoltarBut.UseVisualStyleBackColor = false;
            this.VoltarBut.Click += new System.EventHandler(this.VoltarBut_Click);
            // 
            // NomeLabel
            // 
            this.NomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.NomeLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLabel.ForeColor = System.Drawing.Color.White;
            this.NomeLabel.Location = new System.Drawing.Point(111, 117);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(160, 32);
            this.NomeLabel.TabIndex = 7;
            this.NomeLabel.Text = "Nome";
            this.NomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NomeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeTextBox.Location = new System.Drawing.Point(113, 152);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(160, 27);
            this.NomeTextBox.TabIndex = 8;
            this.NomeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NomeTextBox_Validating);
            // 
            // RegistarBut
            // 
            this.RegistarBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RegistarBut.BackColor = System.Drawing.Color.DimGray;
            this.RegistarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistarBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RegistarBut.FlatAppearance.BorderSize = 2;
            this.RegistarBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.RegistarBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.RegistarBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegistarBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistarBut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistarBut.ForeColor = System.Drawing.Color.White;
            this.RegistarBut.Location = new System.Drawing.Point(194, 441);
            this.RegistarBut.Name = "RegistarBut";
            this.RegistarBut.Size = new System.Drawing.Size(184, 31);
            this.RegistarBut.TabIndex = 6;
            this.RegistarBut.Text = "Registar";
            this.RegistarBut.UseVisualStyleBackColor = false;
            this.RegistarBut.Click += new System.EventHandler(this.RegistarBut_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PassLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.ForeColor = System.Drawing.Color.White;
            this.PassLabel.Location = new System.Drawing.Point(113, 364);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(160, 32);
            this.PassLabel.TabIndex = 3;
            this.PassLabel.Text = "Password";
            this.PassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTextBox.Location = new System.Drawing.Point(113, 399);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(160, 27);
            this.PassTextBox.TabIndex = 4;
            this.PassTextBox.UseSystemPasswordChar = true;
            this.PassTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PassTextBox_Validating);
            // 
            // UserLabel
            // 
            this.UserLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(113, 284);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(160, 32);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Email";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTextBox.Location = new System.Drawing.Point(113, 319);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(160, 27);
            this.UserTextBox.TabIndex = 2;
            this.UserTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UserTextBox_Validating);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(34, 5);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(311, 62);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "G.A.S.C.O";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(383, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Registo";
            this.Text = "Registo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registo_FormClosing);
            this.Load += new System.EventHandler(this.Registo_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox UserPicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RegistarBut;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.Button VoltarBut;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpTBox;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}
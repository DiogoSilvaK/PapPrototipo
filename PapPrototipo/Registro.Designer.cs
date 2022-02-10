﻿namespace PapPrototipo
{
    partial class Registro
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserPicBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegistrarBut = new System.Windows.Forms.Button();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.UserPicBox.Image = global::PapPrototipo.Properties.Resources.User_Icon;
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
            this.panel1.Controls.Add(this.NomeLabel);
            this.panel1.Controls.Add(this.NomeTextBox);
            this.panel1.Controls.Add(this.RegistrarBut);
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
            // RegistrarBut
            // 
            this.RegistrarBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RegistrarBut.BackColor = System.Drawing.Color.DimGray;
            this.RegistrarBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrarBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RegistrarBut.FlatAppearance.BorderSize = 2;
            this.RegistrarBut.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.RegistrarBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.RegistrarBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegistrarBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarBut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarBut.ForeColor = System.Drawing.Color.White;
            this.RegistrarBut.Location = new System.Drawing.Point(3, 441);
            this.RegistrarBut.Name = "RegistrarBut";
            this.RegistrarBut.Size = new System.Drawing.Size(375, 31);
            this.RegistrarBut.TabIndex = 6;
            this.RegistrarBut.Text = "Registrar";
            this.RegistrarBut.UseVisualStyleBackColor = false;
            this.RegistrarBut.Click += new System.EventHandler(this.RegistrarBut_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PassLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PassLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.ForeColor = System.Drawing.Color.White;
            this.PassLabel.Location = new System.Drawing.Point(115, 277);
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
            this.PassTextBox.Location = new System.Drawing.Point(115, 312);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(160, 27);
            this.PassTextBox.TabIndex = 4;
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // UserLabel
            // 
            this.UserLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UserLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(115, 197);
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
            this.UserTextBox.Location = new System.Drawing.Point(115, 232);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(160, 27);
            this.UserTextBox.TabIndex = 2;
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
            this.LoginLabel.Text = "AutoMobil Manager";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NomeLabel
            // 
            this.NomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NomeLabel.BackColor = System.Drawing.SystemColors.HotTrack;
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
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(383, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Registro";
            this.Text = "Registro";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox UserPicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RegistrarBut;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.TextBox NomeTextBox;
    }
}
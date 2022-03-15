namespace PapPrototipo
{
    partial class FormInicio
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
            this.TBoxInicio = new System.Windows.Forms.RichTextBox();
            this.USLabel = new System.Windows.Forms.Label();
            this.BemVindoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.TBoxInicio);
            this.panel1.Controls.Add(this.USLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 199);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 476);
            this.panel1.TabIndex = 0;
            // 
            // TBoxInicio
            // 
            this.TBoxInicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBoxInicio.BackColor = System.Drawing.Color.DimGray;
            this.TBoxInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.TBoxInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxInicio.ForeColor = System.Drawing.Color.White;
            this.TBoxInicio.Location = new System.Drawing.Point(36, 39);
            this.TBoxInicio.Name = "TBoxInicio";
            this.TBoxInicio.ReadOnly = true;
            this.TBoxInicio.Size = new System.Drawing.Size(340, 420);
            this.TBoxInicio.TabIndex = 1;
            this.TBoxInicio.Text = "";
            // 
            // USLabel
            // 
            this.USLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.USLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USLabel.ForeColor = System.Drawing.Color.White;
            this.USLabel.Location = new System.Drawing.Point(32, 11);
            this.USLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.USLabel.Name = "USLabel";
            this.USLabel.Size = new System.Drawing.Size(136, 25);
            this.USLabel.TabIndex = 0;
            this.USLabel.Text = "Ultimos serviços:";
            this.USLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BemVindoLabel
            // 
            this.BemVindoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BemVindoLabel.Font = new System.Drawing.Font("Century Gothic", 42F);
            this.BemVindoLabel.ForeColor = System.Drawing.Color.White;
            this.BemVindoLabel.Location = new System.Drawing.Point(170, 5);
            this.BemVindoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BemVindoLabel.Name = "BemVindoLabel";
            this.BemVindoLabel.Size = new System.Drawing.Size(755, 135);
            this.BemVindoLabel.TabIndex = 1;
            this.BemVindoLabel.Text = "Bem-Vindo";
            this.BemVindoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1085, 675);
            this.Controls.Add(this.BemVindoLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label USLabel;
        private System.Windows.Forms.Label BemVindoLabel;
        private System.Windows.Forms.RichTextBox TBoxInicio;
    }
}
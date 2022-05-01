namespace RecuperarClave
{
    partial class frmAcerca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing&&(components!=null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcerca));
            this.btnGoGithub = new System.Windows.Forms.Button();
            this.txtAcerca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoGithub
            // 
            this.btnGoGithub.Image = global::RecuperarPIN.Properties.Resources.github;
            this.btnGoGithub.Location = new System.Drawing.Point(133, 148);
            this.btnGoGithub.Name = "btnGoGithub";
            this.btnGoGithub.Size = new System.Drawing.Size(64, 64);
            this.btnGoGithub.TabIndex = 1;
            this.btnGoGithub.UseVisualStyleBackColor = true;
            this.btnGoGithub.Click += new System.EventHandler(this.btnGoGithub_Click);
            // 
            // txtAcerca
            // 
            this.txtAcerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcerca.Location = new System.Drawing.Point(12, 37);
            this.txtAcerca.Multiline = true;
            this.txtAcerca.Name = "txtAcerca";
            this.txtAcerca.ReadOnly = true;
            this.txtAcerca.Size = new System.Drawing.Size(306, 105);
            this.txtAcerca.TabIndex = 2;
            this.txtAcerca.Text = "Este programa sirve para recuperar el PIN de 4 dígitos del certificado p12 (Llave" +
    " Criptográfica) de Ministerio de Hacienda de Costa Rica.\r\n\r\nDesarrollado por Ser" +
    "gio Ramírez, 2022";
            this.txtAcerca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ACERCA";
            // 
            // frmAcerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAcerca);
            this.Controls.Add(this.btnGoGithub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 260);
            this.MinimizeBox = false;
            this.Name = "frmAcerca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoGithub;
        private System.Windows.Forms.TextBox txtAcerca;
        private System.Windows.Forms.Label label1;
    }
}
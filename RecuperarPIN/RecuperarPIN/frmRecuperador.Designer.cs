namespace RecuperarClave
{
    partial class frmRecuperador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperador));
            this.btnRecuperarClave = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lbPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.ofdAbrirCertificado = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.pbAvance = new System.Windows.Forms.ProgressBar();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.bWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnRecuperarClave
            // 
            this.btnRecuperarClave.Location = new System.Drawing.Point(307, 84);
            this.btnRecuperarClave.Name = "btnRecuperarClave";
            this.btnRecuperarClave.Size = new System.Drawing.Size(244, 23);
            this.btnRecuperarClave.TabIndex = 2;
            this.btnRecuperarClave.Text = "Recuperar PIN";
            this.btnRecuperarClave.UseVisualStyleBackColor = true;
            this.btnRecuperarClave.Click += new System.EventHandler(this.btnRecuperarClave_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(15, 58);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(536, 20);
            this.txtRuta.TabIndex = 3;
            // 
            // label
            // 
            this.lbPin.AutoSize = true;
            this.lbPin.Location = new System.Drawing.Point(12, 13);
            this.lbPin.Name = "label";
            this.lbPin.Size = new System.Drawing.Size(28, 13);
            this.lbPin.TabIndex = 2;
            this.lbPin.Text = "PIN:";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(46, 10);
            this.txtPin.Name = "txtPin";
            this.txtPin.ReadOnly = true;
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 4;
            // 
            // ofdAbrirCertificado
            // 
            this.ofdAbrirCertificado.DefaultExt = "p12";
            this.ofdAbrirCertificado.FileName = ".p12";
            this.ofdAbrirCertificado.Filter = "Archivos de Certificado (*.p12)|*.p12";
            this.ofdAbrirCertificado.InitialDirectory = "";
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Location = new System.Drawing.Point(15, 84);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(244, 23);
            this.btnAbrirArchivo.TabIndex = 1;
            this.btnAbrirArchivo.Text = "Buscar Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // pbAvance
            // 
            this.pbAvance.Location = new System.Drawing.Point(152, 10);
            this.pbAvance.Maximum = 10000;
            this.pbAvance.Name = "pbAvance";
            this.pbAvance.Size = new System.Drawing.Size(340, 42);
            this.pbAvance.TabIndex = 5;
            // 
            // btnAcerca
            // 
            this.btnAcerca.Location = new System.Drawing.Point(498, 10);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(53, 42);
            this.btnAcerca.TabIndex = 6;
            this.btnAcerca.Text = "Acerca";
            this.btnAcerca.UseVisualStyleBackColor = true;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // bWorker
            // 
            this.bWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWorker_DoWork);
            this.bWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bWorker_ProgressChanged);
            this.bWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWorker_RunWorkerCompleted);
            // 
            // frmRecuperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 126);
            this.Controls.Add(this.btnAcerca);
            this.Controls.Add(this.pbAvance);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lbPin);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnRecuperarClave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(580, 165);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(580, 165);
            this.Name = "frmRecuperador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar PIN de Llave Criptográfica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecuperarClave;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lbPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.OpenFileDialog ofdAbrirCertificado;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.ProgressBar pbAvance;
        private System.Windows.Forms.Button btnAcerca;
        private System.ComponentModel.BackgroundWorker bWorker;
    }
}


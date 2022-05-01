using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RecuperarClave
{
    public partial class frmRecuperador : Form
    {
        string path = "";
        string pin = "";
        bool recuperado = false;
        

        public frmRecuperador()
        {
            InitializeComponent();

            ofdAbrirCertificado.InitialDirectory =Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

        private void btnRecuperarClave_Click(object sender, EventArgs e)
        {
            pbAvance.Minimum=0;
            pbAvance.Maximum=10000;

            bWorker = new BackgroundWorker();

            bWorker.DoWork+=bWorker_DoWork;

            bWorker.ProgressChanged+=bWorker_ProgressChanged;

            bWorker.RunWorkerCompleted+=bWorker_RunWorkerCompleted;

            bWorker.WorkerReportsProgress=true;

            btnAbrirArchivo.Enabled=false;
            btnRecuperarClave.Enabled=false;

            bWorker.RunWorkerAsync();
        }

        private void btnAbrirArchivo_Click( object sender, EventArgs e )
        {

            if (ofdAbrirCertificado.ShowDialog()==DialogResult.OK)
            {
                path=ofdAbrirCertificado.FileName;

                txtRuta.Text=path;
                btnRecuperarClave.Enabled=true;
            }
        }

        private void bWorker_DoWork( object sender, DoWorkEventArgs e )
        {
            Cursor.Current=Cursors.WaitCursor;

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show( "Primero seleccione un archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                

                for (int i = 9000; i<10000; i++)
                {
                    if (Certificado.firmarXAdes(txtRuta.Text, i.ToString("D4")))
                    {
                        pin=i.ToString("D4");
                        recuperado=true;
                        
                        bWorker.ReportProgress(10000);
                        Console.Beep();
                        break;
                    }
                    bWorker.ReportProgress(i);
                }
            }
            Cursor.Current=Cursors.Arrow;
        }

        private void bWorker_ProgressChanged( object sender, ProgressChangedEventArgs e )
        {
            pbAvance.Value=e.ProgressPercentage;
        }

        private void bWorker_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
        {
            if (recuperado)
            {
                txtPin.Text=pin;
                MessageBox.Show(this, "PIN Recuperado con Éxito: "+pin, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                path="";
                pin="";
                recuperado=false;
                txtPin.Focus();
            }
            
            btnAbrirArchivo.Enabled=true;
            btnRecuperarClave.Enabled=false;
        }

        private void btnAcerca_Click( object sender, EventArgs e )
        {
            frmAcerca acerca=new frmAcerca();
            acerca.ShowDialog();
        }
    }
}

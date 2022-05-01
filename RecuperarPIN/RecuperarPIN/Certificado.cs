using System;
using System.Security.Cryptography.X509Certificates;

namespace RecuperarClave
{
    class Certificado
    {
        public static Boolean  firmarXAdes(string ruta, string claveCertificado)
        {
            X509Certificate2 cert;

            try
            {
                cert = new X509Certificate2(ruta, claveCertificado);
            }
            catch (Exception)
            {

                return false;
            }            
            return true;            
        }
    }
}

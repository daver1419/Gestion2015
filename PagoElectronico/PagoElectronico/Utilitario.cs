using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico
{
    class Utilitario
    {

        public static string GetSHA256Encriptado(string password)
        {
            System.Security.Cryptography.SHA256 sha256 = new System.Security.Cryptography.SHA256Managed();
            byte[] sha256Bytes = System.Text.Encoding.Default.GetBytes(password);
            byte[] cryString = sha256.ComputeHash(sha256Bytes);
            string resultEncriptado = string.Empty;
            for (int i = 0; i < cryString.Length; i++)
            {
                resultEncriptado += cryString[i].ToString("X");
            }

            return resultEncriptado;
        }

    }
}

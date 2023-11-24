using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SistemaMarques.Controller
{
    internal class CriarHash
    {
        public string criarHash(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));

                // Converte o hash para uma representação hexadecimal
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

        public string verificaHash(string senha,string senhahash)
        {
            string newhash = criarHash(senha);
            return newhash;
        }
    }
}

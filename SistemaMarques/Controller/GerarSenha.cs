using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMarques.Controller
{
    internal class GerarSenha
    {
        public int gerar()
        {
            Random random = new Random();
            int codigo = random.Next(1024, 9568);
            return codigo;
        }
    }
}

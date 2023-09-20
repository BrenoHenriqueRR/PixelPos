using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SistemaMarques
{
    class Html
    {
        public string TextoEmail() {
            int i;
            Cadastro gerar = new Cadastro();
            i = gerar.GerarCodigo();
            string HTMLEmail =
                @"<!DOCTYPE html>
                    <html>
                    <head>LerMangas</head>
                    <meta charset=""utf-8"" /><body>
                    <h1>BOA NOITE!!</h1>
                    <h4>
                    <p>Um novo código de validação do email pessoal (PIN de segurança) foi criado.</p>
                    </h4>

                    <h4>
                    <p>Esse código de validação é importante para verificar a existência do seu email, dessa forma, por exemplo, ficará
                        mais fácil redefinir a sua senha de acesso, caso você a perca.</p>
                    </h4>

                    <h2>
                    Codigo de Validação:<p></p>
                    "+ i + @"
                    </h2>
                </body>

                </html>";
           return HTMLEmail;
         }
    }
}

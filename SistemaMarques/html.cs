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

        private int i;
        public string TextoEmail() {
            Cadastro gerar = new Cadastro();
            this.i = gerar.GerarCodigo();

            string HTMLEmail =
                @"<!DOCTYPE html>
                    <html lang = ""pt-br"">
                    <head>LerMangas</head>
                    <meta charset=""utf-8"" />
                    <body>
                        <h1>Opa ,Tudo Bom?</h1>
                        <p>Um novo código de validação do email pessoal (PIN de segurança) foi criado.</p>
                        <br>Esse código de validação é importante para verificar a existência do seu email, dessa forma, por exemplo, ficará
                            mais fácil redefinir a sua senha de acesso, caso você a perca.
                        <p>Codigo de Validação:</p>
                        <h2>" + i + @"</h2>
                    </body>
                    </html>";
            return HTMLEmail;
        }

        public int gerar()
        {
            return this.i;
        }
    }
}

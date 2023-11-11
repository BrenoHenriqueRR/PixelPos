using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMarques.Controller
{
    internal class Email
    {
        public string enviarEmail()
        {
            string HTMLEmail =
                $@"<!DOCTYPE html>
                    <html lang=""pt-br"">
                    <head>
                      <meta charset=""UTF-8"">
                      <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                      <title>Validação de Código</title>
                      <link rel=""stylesheet"" href=""../Css/styles.css"">
                    </head>
                    <body>
                        <div class=""quadrado"">
                            <h1>Obrigado por Cadastrar!!</h1>
                        </div>  
                        <div class=""container"">
                            <h1>Validação de Código</h1>
                            <p>Utilize o seguinte código para validar sua conta:</p>
                        ";
            string testehtml = HTMLEmail;
            return testehtml;

        }
    }
}

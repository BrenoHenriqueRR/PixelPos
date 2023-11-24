using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SistemaMarques.Controller
{
    internal class Email
    {
        public string enviarEmail()
        {
            string HTMLEmail =
                @"<!DOCTYPE html>
                    <html lang=""pt-br"">
                    <head>
                      <meta charset=""UTF-8"">
                      <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                      <title>Validação de Código</title>
                      <style>
                        body 
                        {
                          font-family: 'Arial', sans-serif;
                          background-color: #f4f4f4;
                          margin: 0;
                          padding: 0;
                        }
                        .quadrado 
                         {
                          width: 600px; /* Largura do quadrado */
                          height: 80px; /* Altura do quadrado */
                          margin: 20px auto;
                          border-radius: 5px;
                          padding: 20px;
                          background-color: #01629f; /* Cor de fundo do quadrado */
                        }
                        .quadrado h1
                        {
                            color: #ffffff;
                            text-align: center;
                        }

                        .container 
                        {
                          max-width: 600px;
                          margin: 20px auto;
                          background-color: #ffffff;
                          padding: 20px;
                          border-radius: 5px;
                          box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                        }
                        h1 
                        {
                            color: #333;
                        }

                        p 
                        {
                            color: #666;
                        }

                        .verification-code 
                          {
                          font-size: 24px;
                          font-weight: bold;
                          color: #4285f4;
                        }
                    </style>
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

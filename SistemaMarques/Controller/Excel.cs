using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMarques.Controller
{
    internal class Excel
    {
        public void gerarExcel(SqlDataReader sql)
        {
            DateTime dateTime = DateTime.Now;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string caminhoArquivo = $@"C:\Users\breno\Downloads\Relatorio_{dateTime.ToString("yyyy-MM-dd")}.xlsx";

            using (var package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Relatorio " + dateTime );
                int linha = 1;
                // Escrever dados na planilha
                while (sql.Read())
                {
                    worksheet.Cells[linha, 1].Value = sql["id"];
                    worksheet.Cells[linha, 2].Value = sql["nome_album"];
                    worksheet.Cells[linha, 3].Value = sql["nome_cli"];
                    worksheet.Cells[linha, 4].Value = sql["email_cli"];
                    worksheet.Cells[linha, 5].Value = sql["album_criacao"];
                    linha++;
                }

                // Salvar o arquivo Excel
                package.SaveAs(new FileInfo(caminhoArquivo));

            }
        }
    }
}

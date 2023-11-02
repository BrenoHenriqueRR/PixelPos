using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMarques.Controller
{
    internal class Excel
    {
        public void gerarExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                // Adicionar uma nova planilha ao pacote
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Escrever dados na planilha
                worksheet.Cells["A1"].Value = "Nome";
                worksheet.Cells["B1"].Value = "Idade";

                worksheet.Cells["A2"].Value = "Alice";
                worksheet.Cells["B2"].Value = 25;

                worksheet.Cells["A3"].Value = "Bob";
                worksheet.Cells["B3"].Value = 30;

                // Salvar o arquivo Excel
                package.SaveAs(new FileInfo(@"C:\Users\breno\Downloads\Relatorio.xlsx"));
            }
        }
    }
}

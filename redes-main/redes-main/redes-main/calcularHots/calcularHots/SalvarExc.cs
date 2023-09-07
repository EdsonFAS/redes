using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace calcularHots
{
    internal class SalvarExc
    {
        public static string[] coluna = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P","Q" };
        public static string[] linha = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
       

        public  static string salva(List<string> x, List<string> y, string cabecalho)
        {
            string pasta = AppDomain.CurrentDomain.BaseDirectory;
            pasta = pasta.Replace("\\bin\\Debug\\net6.0", "\\resp");
            string nomeArquivo = $"arquivo_{DateTime.Now:yyyyMMddHHmmss}.xlsx";

            string caminho = Path.Combine(pasta, nomeArquivo);
            using (var package = new ExcelPackage())
            {var worksheet = package.Workbook.Worksheets.Add("Planilha1");
                for (int i = 0; i < x.Count; i++) {

                    // Adicione a string à célula A1 da planilha.
                    worksheet.Cells[$"A1"].Value = cabecalho;
                    worksheet.Cells[$"{coluna[0]}{i+1+1}"].Value += x[i];
                worksheet.Cells[$"{coluna[1]}{i+1+1}"].Value += y[i];
                }

                // Salve o pacote Excel no arquivo especificado.

                package.SaveAs(new System.IO.FileInfo(caminho));


            }return caminho;
            
        }

    }
}

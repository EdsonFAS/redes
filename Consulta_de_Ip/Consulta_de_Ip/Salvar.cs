using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace Consulta_de_Ip
{
    internal class Salvar
    {
        public static string[] coluna = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q" };



        public static void salva(List<string> sub, List<string> pri, List<string> ult, List<string> brod, string cabecalho)
        {

            string pasta = AppDomain.CurrentDomain.BaseDirectory;
            pasta = pasta.Replace("\\bin\\Debug\\net7.0", "\\resp");
            string nomeArquivo = $"arquivo_{DateTime.Now:yyyyMMddHHmmss}.xlsx";


            string caminho = Path.Combine(pasta, nomeArquivo);


            using (var package = new ExcelPackage())
            {
                
                    var worksheet = package.Workbook.Worksheets.Add("Planilha1");
                    for (int i = 0; i < sub.Count; i++)
                    {

                        worksheet.Cells[$"A1"].Value = cabecalho;
                        worksheet.Cells[$"{coluna[0]}{i + 1 + 1}"].Value += sub[i];
                        worksheet.Cells[$"{coluna[1]}{i + 1 + 1}"].Value += pri[i];
                        worksheet.Cells[$"{coluna[2]}{i + 1 + 1}"].Value += ult[i];
                        worksheet.Cells[$"{coluna[3]}{i + 1 + 1}"].Value += brod[i];
                    }

                    // Salve o pacote Excel no arquivo especificado.

                    package.SaveAs(new System.IO.FileInfo(caminho));




                
               
            }
        }
    }
}

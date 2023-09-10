using static Consulta_de_Ip.IP;
using static Consulta_de_Ip.Masc;
using static Consulta_de_Ip.Binario;
using static Consulta_de_Ip.Salvar;
using Consulta_de_Ip;
using OfficeOpenXml;
using System;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;

string ip;
string mascara;
int subrede = 0,host=0;
string cabecalho = "";

do { Console.Write("Digite o IP,(x.x.x.x):");
         ip = Console.ReadLine();
    VerificaIp(ip);
} while (valiIP != true);


do
{
    Console.Write("Digite a mascara,(x.x.x.x):");
    mascara = Console.ReadLine();
    verficMask(mascara, tipo);
} while (valiMask != true);
if (tipo == "C"){
    subrede = Convert.ToInt32(Math.Pow(2, _ContUm));
    host = Convert.ToInt32(Math.Pow(2, _ContZero));
    
    cabecalho = $"Rede: {ip}\nMascara: {mascara}\nQuantidade de SubRedes: {subrede}\nQuantidade de Host: {host - 2}";
}
if (tipo == "B") {

    subrede = Convert.ToInt32(Math.Pow(2, _ContUm));
    host = Convert.ToInt32(Math.Pow(2, _ContZero + 8));
    
    cabecalho = $"Rede: {ip}\nMascara: {mascara}\nQuantidade de SubRedes: {subrede}\nQuantidade de Host: {host - 2}";


}

List<string> ips = new List<string>();
List<string> brod = new List<string>();
List<string> prim = new List<string>();
List<string> ult = new List<string>();


ips.Clear();
brod.Clear();
prim.Clear();
ult.Clear();

string visual_Ip="",visual_Brod="",visual_Prim="",visual_ult="";
Console.WriteLine( cabecalho);

for(int i = 0; i < 256; i+=number) {

    if (tipo=="C") {
        if ( Convert.ToInt32(bit4) == 0) {
        
        visual_Ip="SubRede:"+ipretorno.Replace("*", $"{i}");
         visual_Prim = "Primeiro Ip VD:"+ ipretorno.Replace("*", $"{i+1}");
         visual_ult = "Ultimo IP VD:"+ipretorno.Replace("*", $"{i+number-2}");
         visual_Brod = "Brodcast:" +ipretorno.Replace("*", $"{i + number - 1}");
        
        }
        if (Convert.ToInt32(bit4)!=0) {

        
            visual_Ip = "SubRede:" + ipretorno.Replace("*", $"{i+Convert.ToInt32(bit4)}");
            visual_Prim = "Primeiro Ip VD:" + ipretorno.Replace("*", $"{i + 1 + Convert.ToInt32(bit4)}");
            visual_ult = "Ultimo IP VD:" + ipretorno.Replace("*", $"{i + number - 2 + Convert.ToInt32(bit4)}");
            visual_Brod = "Brodcast:" + ipretorno.Replace("*", $"{i + number - 1 + Convert.ToInt32(bit4)}");

        }



    }
    if (tipo=="B") {


        if (Convert.ToInt32(bit3) == 0)
        {

            visual_Ip = "SubRede:" + ipretorno.Replace("*", $"{i}").Replace("#","0");
            visual_Prim = "Primeiro Ip VD:" + ipretorno.Replace("*", $"{i}").Replace("#", (1).ToString());
            visual_ult = "Ultimo IP VD:" + ipretorno.Replace("*", $"{i + number - 1}").Replace("#", (256-2).ToString());
            visual_Brod = "Brodcast:" + ipretorno.Replace("*", $"{i + number - 1}").Replace("#", (256 - 1).ToString());

        }
        if (Convert.ToInt32(bit3) != 0)
        {

            visual_Ip = "SubRede:" + ipretorno.Replace("*", $"{i + Convert.ToInt32(bit3)}").Replace("#", "0");
            visual_Prim = "Primeiro Ip VD:" + ipretorno.Replace("*", $"{i + Convert.ToInt32(bit3)}").Replace("#", (1).ToString());
            visual_ult = "Ultimo IP VD:" + ipretorno.Replace("*", $"{i + number - 1 + Convert.ToInt32(bit3)}").Replace("#", (256 - 2).ToString());
            visual_Brod = "Brodcast:" + ipretorno.Replace("*", $"{i + number - 1 + Convert.ToInt32(bit3)}").Replace("#", (256 - 1).ToString());


        }
     




    }
    ips.Add(visual_Ip);
        brod.Add(visual_Brod);
        prim.Add(visual_Prim);
        ult.Add(visual_ult);

Console.WriteLine($"------------------- \nSubREde: {visual_Ip}\nPrimeiro Ip VD: {visual_Prim}\nUltimo IP VD: {visual_ult}\nBrodcast: {visual_Brod}");}  
      
salva(ips, prim, ult, brod, cabecalho);
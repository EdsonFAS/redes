using calcularHots;
using static calcularHots.CalculoBinario;


VerificarMask verificar = new VerificarMask();

string ip="", mascara="", numero="",mask="",result,sub="",resto = "" ;
int subrede = 0, decmal = 0,host=0, calculo,tamanho=0;
Console.WriteLine("Digite o IP:");
ip = Console.ReadLine();
Console.WriteLine("digite a mascara;");
ip=ip.Trim();
mascara=Console.ReadLine();
tamanho=Convert.ToInt32(ip.Length);

mask= mascara.Replace(".", null);
for(int i = 9; i < mask.Length; i++)
{
   
    numero+= mask[i].ToString();
   
}
//decmal=Convert.ToInt32(numero);
DecimalEmBinario(Convert.ToInt32(numero));
calculo =  256- Convert.ToInt32(numero);
subrede=Convert.ToInt32(Math.Pow(2, _ContUm ));
host= (Convert.ToInt32(Math.Pow(2,_ContZero)));
Console.WriteLine( $"\nrede: {ip}" +
    $"\nmascara: {mascara}" +
    $"\nQuantidade de Subredes:{subrede}" +
    $"\nQuantidade de Host: {host-2}");
 sub = extrairIp(ip);
Console.WriteLine(resto);
for (int i = 0; i < 256; i += calculo)
{
   
    if (Convert.ToInt32(resto) == 0)
    {
       
        Console.WriteLine($"\n=====================\nRede: {sub}{i} " +
            $"\nBrodcast: {sub}{i+calculo-1} ");
    }
    if (Convert.ToInt32(resto) != 0) {
        Console.WriteLine($"{sub}{i + Convert.ToInt32(resto)}" +
            $"\nBrodcast: {sub}{i + calculo - 1+ Convert.ToInt32(resto)}");
         

    }
    
}

string extrairIp(string ip) { 

    int cont =0;
    string novoIP = "";
    
    for (int i = 0; i < ip.Length; i++) {


        if (ip[i].ToString() == ".") {
            cont++;
          
        novoIP += ip[i].ToString();
        
        }
        if (ip[i].ToString() != ".") { 
            if (cont < 3)
            {
            novoIP += ip[i].ToString();
            }
        }
        if (i>10) {

            resto +=  ip[i].ToString();
            
        
        }
    
    }
    return novoIP;
}


    


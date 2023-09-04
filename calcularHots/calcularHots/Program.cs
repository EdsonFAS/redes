using calcularHots;
using static calcularHots.CalculoBinario;
using static calcularHots.VerificarMask;


VerificarMask verificar = new VerificarMask();

string ip="", mascara="", numero="",mask="",sub="",resto = "", veri ="" ;
int subrede = 0, decmal = 0,host=0, calculo,tamanho=0,result;
bool v = false;
do { 
    Console.WriteLine("Digite o IP:");
    ip = Console.ReadLine();

    if (ip.Length>15||ip.Length<7)
    {
        Console.WriteLine("Ip Invalido");
    
    }
} while (ip.Length>15);ip=ip.Trim(); sub = extrairIp(ip);
do { Console.WriteLine("digite a mascara;");
   
    mascara = Console.ReadLine();
    mask= mascara.Replace(".", null);
    result = Convert.ToInt32(veri);
    
    if(192<= result&& result<=223)
    { 
        if ("C"!=verficMask(mask)) {
            Console.WriteLine("Mascara Incopativel com o IP!!!");
            
        }
        else
        {v= true;
            
        }
        

    }
} while (!v);
tamanho = Convert.ToInt32(ip.Length);

for(int i = 9; i < mask.Length; i++)
{
   
    numero+= mask[i].ToString();
   
}

DecimalEmBinario(Convert.ToInt32(numero));
calculo =  256- Convert.ToInt32(numero);
subrede=Convert.ToInt32(Math.Pow(2, _ContUm ));
host= (Convert.ToInt32(Math.Pow(2,_ContZero)));
Console.WriteLine( $"\nrede: {ip}" +
    $"\nmascara: {mascara}" +
    $"\nQuantidade de Subredes:{subrede}" +
    $"\nQuantidade de Host: {host-2}");


for (int i = 0; i < 256; i += calculo)
{
   
    if (Convert.ToInt32(resto) == 0)
    {
       
        Console.WriteLine($"\n=====================\nRede: {sub}{i} " +
            $"\nBrodcast: {sub}{i+calculo-1} ");
    }
    if (Convert.ToInt32(resto) != 0) {
        Console.WriteLine($"\n=====================\nRede:{sub}{i + Convert.ToInt32(resto)}" +
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
        if (cont==3) {
            if (ip[i].ToString()!=".")
            resto +=  ip[i].ToString();
            
        
        }
        if (cont<1) {
            veri += ip[i].ToString();
        
        }
    
    }
    return novoIP;
}


    


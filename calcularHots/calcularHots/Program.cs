string id, mascara, numero="",bin;
int subrede = 0, decmal = 0,host=0;
Console.WriteLine("digite a mascara;");

mascara=Console.ReadLine();


mascara= mascara.Replace(".", null);
for(int i = 9; i < mascara.Length; i++)
{
   
    numero+= mascara[i].ToString();
   
}
decmal=Convert.ToInt32(numero);
bin = DecimalEmBinario(decmal);
int contum = 0,contzero=0;
for (int i = 0; i < bin.Length; i++)
{
    if (Convert.ToInt32(bin[i].ToString()) == 1) {
        contum++;
    }
    if (Convert.ToInt32(bin[i].ToString()) == 0)
    {
        contzero++;
    }
}

subrede=Convert.ToInt32(Math.Pow(2, contum));
host= (Convert.ToInt32(Math.Pow(2,contzero))-2);
Console.WriteLine($"{host}  {subrede}");
 string DecimalEmBinario( int numero)
{

    if (numero < 0)
    {
        return "0";

    }
    string binario = "";
    while (numero > 0)
    {
        int resto = numero % 2;
        binario = resto.ToString() + binario;
        numero /= 2;
    }
    return binario;
}

    


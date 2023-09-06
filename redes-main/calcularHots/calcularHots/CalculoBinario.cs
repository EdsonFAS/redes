using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularHots
{
    internal class CalculoBinario
    {
        public static int _ContUm { get; set; }
        public static int _ContZero { get; set; }


        public static void DecimalEmBinario(int numero)
        {
            _ContUm = 0;
            _ContZero= 0;

            string binario = "";
            while (numero > 0)
            {
                int resto = numero % 2;
                binario = resto.ToString() + binario;
                numero /= 2;
            }
            for (int i = 0; i < binario.Length; i++)
            {
                if (Convert.ToInt32(binario[i].ToString()) == 1)
                {
                    _ContUm++;
                }
                if (Convert.ToInt32(binario[i].ToString()) == 0)
                {
                    _ContZero++;
                }
            }
            
        }


    }
}

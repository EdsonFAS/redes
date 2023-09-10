using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Consulta_de_Ip.Binario;

namespace Consulta_de_Ip
{
    internal class Masc
    {   public static string maskBit1, maskBit2, maskBit3  , maskBit4 ;
        public static int number;
        public static bool valiMask;

        public static void verficMask(string mask, string tipo)
        {
            mask = mask.Replace(" ", null);
            maskBit1 = ""; maskBit2 = ""; maskBit3 = ""; maskBit4 = "";
            number=0;
            valiMask = false;
            string verificar = "", numcalculo = "";
            int contPonto = 0;
            for (int i = 0; i < mask.Length; i++)
            {

                if (mask[i].ToString() == ".")
                {

                    contPonto++;

                }

                if (mask[i].ToString() != ".")
                {
                    if (contPonto < 1)
                    {

                        maskBit1 += Convert.ToInt32(mask[i].ToString());

                    }
                    if (contPonto == 1)
                    {

                        maskBit2 += Convert.ToInt32(mask[i].ToString());


                    }
                    if (contPonto == 2)
                    {

                        maskBit3 += Convert.ToInt32(mask[i].ToString());


                    }
                    if (contPonto == 3)
                    {


                        maskBit4 += Convert.ToInt32(mask[i].ToString());

                    }
                }

            }



            if (tipo == "A") {

                if (maskBit1 == "255") {

                 

                    Console.WriteLine(_ContZero+" "+_ContUm);

                    valiMask = true;

                }
            
            }
            if (tipo == "B") {

                if (maskBit1 == "255" && maskBit2 == "255")
                {

                    valiMask = true;
                    number = 256 - (Convert.ToInt32(maskBit3));
                    DecimalEmBinario(Convert.ToInt32(maskBit3));

                }
              


            }
            if (tipo == "C") {

                if (maskBit1 == "255" && maskBit2 == "255" && maskBit3 == "255")
                {

                    number = 256 - (Convert.ToInt32(maskBit4));
                    DecimalEmBinario(Convert.ToInt32(maskBit4));

                    valiMask = true;


                }
             
            
            
            
            }
           
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularHots
{
    public class VerificarMask
        
    {
       
        public static string verficMask(string mask) {
            string tipo = "",result="";
            int i = 0;
            while( mask[i].ToString()!="0"&& i<9) {
            
                tipo += mask[i].ToString();
                
                i++;
                if (tipo.Equals("255255255"))
                {
                    result = "C";

                }
                if (tipo == "255255")
                {
                    result = "B";
                }
                if (tipo == "255")
                {
                    result = "A";
                }
            }
            
               
           if(result!="C"& result != "B"&&result != "A")
           {
              result = "Invalido";
            }



            return result;
            
        }
    }
}

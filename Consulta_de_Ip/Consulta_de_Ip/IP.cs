using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace Consulta_de_Ip
{
    internal class IP
    {
        public static string tipo, bit1, bit2, bit3, bit4;
        public static string ipretorno ;
        public static bool valiIP ;
           

        public static void   VerificaIp(string ip) {
            tipo = ""; bit1 = ""; bit2 = ""; bit3 = ""; bit4 = "";
            ipretorno = "";
            int contPonto=0;
            valiIP = false;
            ip = ip.Replace(" ",null);
            StringBuilder stringBuilder = new StringBuilder(ip);
            for (int i = 0; i < ip.Length; i++) {

                if (ip[i].ToString() == ".") {

                    contPonto++;
                
                }

                if (ip[i].ToString() != ".") {
                    if (contPonto < 1) { 
                      
                         bit1 += Convert.ToInt32(ip[i].ToString());
                        
                    }
                    if (contPonto == 1 )
                    {
                      
                            bit2 += Convert.ToInt32(ip[i].ToString());
                       

                    }
                    if (contPonto ==2)
                    {
                       
                            bit3 += Convert.ToInt32(ip[i].ToString());

                        
                    }
                    if (contPonto == 3)
                    {
                       

                            bit4 += Convert.ToInt32(ip[i].ToString());
                        
                    }
                }
            
            }
            contPonto = 0;
            for (int i = 0;i < ip.Length;i++) {



                if (ip[i].ToString() == ".")
                {

                    contPonto++;

                }
                if (ip[i].ToString() != ".")
                {
                    if (Convert.ToInt32(bit1) > 191 && Convert.ToInt32(bit1) < 224)
                    {

                        tipo = "C";

                        if (contPonto == 3)
                        {

                            stringBuilder[i] = '*';
                          

                        }
                        valiIP = true;
                    }

                    if (Convert.ToInt32(bit1) > 127 && Convert.ToInt32(bit1) < 192)
                    {

                        tipo = "B";
                        if (contPonto == 2)
                        {

                            stringBuilder[i] = '*';
                         

                        }if (contPonto == 3) {
                            stringBuilder[i] = '#';
                        }
                        valiIP= true;

                    }
                    if (Convert.ToInt32(bit1) > 0 && Convert.ToInt32(bit1) < 128)
                    {
                        tipo = "A";
                        if (contPonto ==1 )
                        {

                            stringBuilder[i] = '*';
                            

                        }
                        if (contPonto == 2)
                        {
                            stringBuilder[i] = '#';
                        }
                        if (contPonto == 3)
                        {
                            stringBuilder[i] = '#';
                        }
                        valiIP = true;
                    }
                  
                }
            } 
           

            ipretorno = stringBuilder.ToString();
            ipretorno = ipretorno.Replace("***","*").Replace("**","*").Replace("###","#").Replace("##","#");
           

        }

    }
}

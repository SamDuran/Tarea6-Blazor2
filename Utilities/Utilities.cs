using System;
using Entidades;
using BLL;

namespace Utilities
{
    public partial class Utilities
    {
        public static int ToInt(string criterio)
        {
            if(!string.IsNullOrEmpty(criterio) || !string.IsNullOrWhiteSpace(criterio))
            {

                string numero = "";
                for(int i = 0; i<criterio.Length;i++)
                {
                    if (!char.IsNumber(criterio[i]))
                    {
                        continue;
                    }else
                    {
                        numero += criterio[i]; 
                    }
                }
                if(!string.IsNullOrEmpty(numero) || !string.IsNullOrWhiteSpace(numero))
                {
                    return Convert.ToInt32(numero);
                }else{
                    return 1;
                }
            }else{
                return 1;
            }
        }
    }
}
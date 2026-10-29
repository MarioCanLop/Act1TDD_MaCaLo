using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaTDD_MaCaLo;

namespace PracticaTDD_MaCaLo
{
    public class Funciones
    {

        public long CalcularFactorial(int n)
        {
            long resultado = 1;


            if (n < 0)
            {

                resultado = -1;

            }
            else if (n == 0)
            {


                resultado = 1;

            }
            else
            {

                for (int i = 1; i <= n; i++)
                {

                    resultado *= i;
                }
            }
                return resultado;
        }


    }
}

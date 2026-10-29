using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaTDD_MaCaLo;

namespace PracticaTDD_MaCaLo
{
    public class Funciones
    {

        public long CalcularFactorial(int n)
        {
            if (n < 0)
            {
                return -1;
            }

            long resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }


    }
}

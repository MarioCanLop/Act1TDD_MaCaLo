namespace TestActividadTDDAppMaCaLo
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
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

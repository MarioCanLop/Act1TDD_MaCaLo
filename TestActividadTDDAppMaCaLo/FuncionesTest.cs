using PracticaTDD_MaCaLo;

namespace TestActividadTDDAppMaCaLo
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void CalcularFactorial_NumeroNegativo()
        {
         
            Funciones f = new Funciones();
            long resultado = f.CalcularFactorial(-5);
            Assert.AreEqual(-1, resultado);

        }

        [TestMethod]
        public void CalcularFactorial_Cero()
        {
            Funciones f = new Funciones();
            long resultado = f.CalcularFactorial(0);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_NumeroPositivo()
        {
            Funciones f = new Funciones();
            long resultado = f.CalcularFactorial(5);
            Assert.AreEqual(120, resultado);
        }
    }
}

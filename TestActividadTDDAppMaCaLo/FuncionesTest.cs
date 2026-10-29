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

        [TestMethod]
        public void EsContrasenyaValida_Null()
        {
            Funciones f = new Funciones();
            bool resultado = f.EsContrasenyaValida(null);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_Vacia()
        {
            Funciones f = new Funciones();
            bool resultado = f.EsContrasenyaValida("");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_LogintudMenos8()
        {
            Funciones f = new Funciones();
            bool resultado = f.EsContrasenyaValida("asdfty#");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_SinCaracter()
        {
            Funciones f = new Funciones();
            bool resultado = f.EsContrasenyaValida("asdftyui");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_()
        {
            Funciones f = new Funciones();
            bool resultado = f.EsContrasenyaValida("asdftyi#");
            Assert.IsTrue(resultado);
        }


    }
}

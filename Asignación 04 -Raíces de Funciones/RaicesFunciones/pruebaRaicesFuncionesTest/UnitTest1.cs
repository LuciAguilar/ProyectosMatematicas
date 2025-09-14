using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace pruebaRaicesFuncionesTest
{
    [TestClass]
    public class RaicesFuncionesTest
    {

        /// <summary>
        ///  Esta prueba verifica que el método de Bisección encuentre una raíz real de la función cúbica
        /// dentro del intervalo [0,1], comprobando que f(raíz) sea cercano a 0.
        /// </summary>
        [TestMethod]
        public void Biseccion_EncuentraRaizCubica()
        {
            // Arrange
            var rf = new RaicesFunciones.Implementaciones.RaicesFunciones();
            Func<double, double> f = x => 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;

            // Act
            double raiz = rf.Biseccion(f, 0.0, 1.0, 0.1);

            // Assert:
            Assert.IsTrue(Math.Abs(f(raiz)) < 0.01, "f(raíz) no es suficientemente cercana a 0");
        }


        /// <summary>
        ///erifica que el método de la Regla Falsa encuentre una raíz real de la función
        /// trigonométrica en el intervalo [2,3], comprobando que f(raíz) sea cercano a 0.
        /// </summary>
        [TestMethod]
        public void ReglaFalsa_EncuentraRaizTrigonometrica()
        {
            // Arrange
            var rf = new RaicesFunciones.Implementaciones.RaicesFunciones();
            Func<double, double> g = x => Math.Pow(x, 2) * Math.Sqrt(Math.Abs(Math.Cos(x))) - 5;

            // Act
            double raiz = rf.ReglaFalsa(g, 2.0, 3.0, 0.1);

            // Assert:
            Assert.IsTrue(Math.Abs(g(raiz)) < 0.01, "f(raíz) no es suficientemente cercana a 0");
        }

        /// <summary>
        /// Esta prueba comprueba que al finalizar el método de Bisección, el error relativo aproximado
        /// calculado sea menor o igual al valor máximo permitido (emax).
        /// </summary>
        [TestMethod]
        public void Biseccion_ErrorMenorQueMaximo()
        {
            // Arrange
            var rf = new RaicesFunciones.Implementaciones.RaicesFunciones();
            Func<double, double> f = x => 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;

            // Act
            double raiz = rf.Biseccion(f, 0.0, 1.0, 0.1);

            // Assert:
            Assert.IsTrue(rf.GetError() <= 0.1, "El error no fue menor o igual al máximo permitido");
        }
    }
}

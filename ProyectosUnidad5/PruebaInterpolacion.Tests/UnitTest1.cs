using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaInterpolacion.implementaciones;
using System.Windows.Forms;

namespace PruebaInterpolacion.Tests
{
    [TestClass]
    public class InterpolacionTests
    {
        private Interpolacion interp;
        private RichTextBox rtb;

        [TestInitialize]
        public void Setup()
        {
            interp = new Interpolacion();
            rtb = new RichTextBox();
        }



        // ..* PRUEBAS PARA LAGRANGE *..

        // Test para interpolación lineal de Lagrange:
        [TestMethod]
        public void InterpolacionLagrange_Lineal_DebeRetornar8875()
        {
            // Arrange
            double[,] puntos = { { 3, 5.25 }, { 5, 19.75 } };
            int grado = 1;
            double x = 3.5;
            double esperado = 8.875;

            // Act
            double resultado = interp.InterpolacionLagrange(puntos, grado, x, rtb);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001, "Resultado lineal de Lagrange incorrecto.");
        }


        // Test para interpolación cuadrática de Lagrange:
        [TestMethod]
        public void InterpolacionLagrange_Cuadratica_DebeRetornar7375()
        {
            // Arrange
            double[,] puntos = { { 2, 4 }, { 3, 5.25 }, { 5, 19.75 } };
            int grado = 2;
            double x = 3.5;
            double esperado = 7.375;

            // Act
            double resultado = interp.InterpolacionLagrange(puntos, grado, x, rtb);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001, "Resultado cuadrático de Lagrange incorrecto.");
        }




        // ..* PRUEBAS PARA NEWTON *..

        // Test para interpolación lineal de Newton:
        [TestMethod]
        public void InterpolacionNewton_Lineal_DebeRetornar8875()
        {
            // Arrange
            double[,] puntos = { { 3, 5.25 }, { 5, 19.75 } };
            int grado = 1;
            double x = 3.5;
            double esperado = 8.875;

            // Act
            double resultado = interp.InterpolacionNewton(puntos, grado, x, rtb);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001, "Resultado lineal de Newton incorrecto.");
        }


        // Test para interpolación cúbica de Newton:
        [TestMethod]
        public void InterpolacionNewton_Cubica_DebeRetornar7094()
        {
            // Arrange
            double[,] puntos = { { 2, 4 }, { 3, 5.25 }, { 5, 19.75 }, { 6, 36 } };
            int grado = 3;
            double x = 3.5;
            double esperado = 7.094;

            // Act
            double resultado = interp.InterpolacionNewton(puntos, grado, x, rtb);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001, "Resultado cúbico de Newton incorrecto.");
        }
    }
}
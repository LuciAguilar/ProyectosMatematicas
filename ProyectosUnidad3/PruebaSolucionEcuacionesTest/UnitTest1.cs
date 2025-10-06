using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaSolucionEcuaciones.Implementaciones;
using System;

namespace PruebaSolucionEcuacionesTest
{
    [TestClass]
    public class UnitTest1
    {
        private SolucionEcuaciones solver;

        [TestInitialize]
        public void Inicializar()
        {
            solver = new SolucionEcuaciones();
        }


        //TEST PARA COMPROBAR QUE EL METODO DE ELIMINACION DE GAUSS FUNCIONA CORRECTAMENTE
        [TestMethod]
        public void Test_EliminacionGauss()
        {
            double[,] matriz = {
                {  2,  1, -1,  8 },
                { -3, -1,  2, -11 },
                { -2,  1,  2, -3 }
            };

            double[] resultado = solver.EliminacionGauss(matriz);

            // Solución esperada exacta
            double[] esperado = { 2, 3, -1 };

            for (int i = 0; i < resultado.Length; i++)
                Assert.AreEqual(Math.Round(esperado[i], 3), Math.Round(resultado[i], 3), $"Error en X{i + 1}");
        }



        // TEST PARA COMPROBAR QUE EL METODO DE GAUSS-JORDAN FUNCIONA CORRECTAMENTE
        [TestMethod]
        public void Test_GaussJordan()
        {
            double[,] matriz = {
                {  2,  1, -1,  8 },
                { -3, -1,  2, -11 },
                { -2,  1,  2, -3 }
            };

            double[] resultado = solver.GaussJordan(matriz);
            double[] esperado = { 2, 3, -1 };

            for (int i = 0; i < resultado.Length; i++)
                Assert.AreEqual(Math.Round(esperado[i], 3), Math.Round(resultado[i], 3), $"Error en X{i + 1}");
        }
    }
}

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


        //TEST PARA COMPROBAR QUE EL METODO DE ELIMINACION DE GAUSS FUNCIONA CORRECTAMENTE:
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



        // TEST PARA COMPROBAR QUE EL METODO DE GAUSS-JORDAN FUNCIONA CORRECTAMENTE:
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


        // TEST PARA COMPROBAR QUE EL MÉTODO DE GAUSS–SEIDEL FUNCIONA CORRECTAMENTE:
        [TestMethod]
        public void Test_GaussSeidel()
        {

            double[,] matriz = {
                {  3.0, -0.1, -0.2,  7.85 },
                {  0.1,  7.0, -0.3, -19.3 },
                {  0.3, -0.2, 10.0,  71.4 }
            };

            
            double eaMax = 0.0001;

            
            var dgv = new System.Windows.Forms.DataGridView();
          
            solver.GaussSeidel(matriz, eaMax, dgv);

            
            int lastRowIndex = dgv.Rows.Count - 2;
            double x1 = Convert.ToDouble(dgv.Rows[lastRowIndex].Cells["x1"].Value);
            double x2 = Convert.ToDouble(dgv.Rows[lastRowIndex].Cells["x2"].Value);
            double x3 = Convert.ToDouble(dgv.Rows[lastRowIndex].Cells["x3"].Value);

            // Valores esperados:
            double[] esperado = { 3.0, -2.5, 7.0 };
            double[] resultado = { x1, x2, x3 };

            for (int i = 0; i < 3; i++)
                Assert.AreEqual(Math.Round(esperado[i], 3), Math.Round(resultado[i], 3), 0.01, $"Error en X{i + 1}");
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using ExamenUnidad2.Implementaciones;

namespace ExamenUnidad2Pruebas
{
    [TestClass]
    public class MetodosRaicesTests
    {
        private MetodosRaices mr;

        [TestInitialize]
        public void Setup()
        {
            mr = new MetodosRaices();
        }


        // 1. Bisección
        [TestMethod]
        public void Biseccion_EncuentraRaizPolinomio()
        {
            Func<double, double> f = x => 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;

            double raiz = mr.Biseccion(f, 0.0, 1.0, 0.001);

            Assert.IsTrue(Math.Abs(f(raiz)) < 0.01, "La raíz encontrada no es suficientemente cercana a 0.");
        }


        // 2. Regla Falsa
        [TestMethod]
        public void ReglaFalsa_EncuentraRaizTrigonometrica()
        {
            Func<double, double> f = x => Math.Pow(x, 2) * Math.Sqrt(Math.Abs(Math.Cos(x))) - 5;

            double raiz = mr.ReglaFalsa(f, 2.0, 3.0, 0.001);

            Assert.IsTrue(Math.Abs(f(raiz)) < 0.01, "La raíz encontrada no es suficientemente cercana a 0.");
        }


        // 3. Newton-Raphson
        [TestMethod]
        public void NewtonRaphson_ConvergePolinomio()
        {
            Func<double, double> f = x => 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;
            Func<double, double> df = x => 12 * Math.Pow(x, 2) - 12 * x + 7;

            double raiz = mr.NewtonRaphson(f, df, 0.5, 0.001);

            Assert.IsTrue(Math.Abs(f(raiz)) < 0.01, "Newton-Raphson no converge correctamente.");
        }


        // 4. Secante
        [TestMethod]
        public void Secante_EncuentraRaizTrigonometrica()
        {
            Func<double, double> f = x => Math.Pow(x, 2) * Math.Sqrt(Math.Abs(Math.Cos(x))) - 5;

            double raiz = mr.Secante(f, 2.0, 3.0, 0.001);

            Assert.IsTrue(Math.Abs(f(raiz)) < 0.01, "La raíz encontrada con Secante no es suficientemente cercana a 0.");
        }


        // 5. Error final
        [TestMethod]
        public void Metodo_ErrorFinalEsMenorQueMaximo()
        {
            Func<double, double> f = x => 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;

            double raiz = mr.Biseccion(f, 0.0, 1.0, 0.1);

            var ultimaIteracion = mr.Iteraciones[mr.Iteraciones.Count - 1];
            Assert.IsTrue(ultimaIteracion.Ea <= 0.1, "El error final fue mayor al máximo permitido.");
        }


        // 6. Manejo de errores
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NewtonRaphson_DerivadaCeroLanzaExcepcion()
        {
            Func<double, double> f = x => x * x;   // f(x) = x²
            Func<double, double> df = x => 2 * x;  // f'(x) = 2x → en x = 0 se hace 0

            // Intentar con valor inicial en 0 debe lanzar excepción
            double raiz = mr.NewtonRaphson(f, df, 0.0, 0.001);
        }
    }
}

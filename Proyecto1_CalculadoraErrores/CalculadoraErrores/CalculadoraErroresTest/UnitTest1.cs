using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraErroresTest.Implementaciones
{
    [TestClass]
    public class ErroresTests
    {

        /// <summary>
        /// Verifica que el método Calcular calcule correctamente el error absoluto
        /// entre un valor verdadero y un valor aproximado.
        /// </summary>
        [TestMethod]
        public void Calcular_ErrorAbsolutoCorrecto()
        {
            var errores = new CalculadoraErrores.Implementaciones.Errores();

            string resultado = errores.Calcular(10, 9.5);

            Assert.IsTrue(resultado.Contains("Error absoluto: 0.500000"),
                "El error absoluto calculado no es correcto.");
        }


        /// <summary>
        /// Verifica que el método Calcular calcule correctamente el error relativo
        /// entre un valor verdadero y un valor aproximado, expresado en porcentaje.
        /// </summary>
        [TestMethod]
        public void Calcular_ErrorRelativoCorrecto()
        {
            var errores = new CalculadoraErrores.Implementaciones.Errores();

            string resultado = errores.Calcular(10, 9.5);

            Assert.IsTrue(resultado.Contains("Error relativo: 5.0000%"),
                "El error relativo calculado no es correcto.");
        }


        /// <summary>
        /// Comprueba que la salida generada por el método Calcular contenga
        /// las etiquetas de "Error absoluto" y "Error relativo", validando el formato.
        /// </summary>
        [TestMethod]
        public void Calcular_ContieneTextoEsperado()
        {
            var errores = new CalculadoraErrores.Implementaciones.Errores();

            string resultado = errores.Calcular(3.1416, 3.14);

            Assert.IsTrue(resultado.Contains("Error absoluto"),
                "La salida no contiene la etiqueta de Error absoluto.");

            Assert.IsTrue(resultado.Contains("Error relativo"),
                "La salida no contiene la etiqueta de Error relativo.");
        }
    }
}
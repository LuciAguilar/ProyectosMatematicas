using System;

namespace CalculadoraErrores.Implementaciones
{
    internal class Errores
    {
        /// <summary>
        /// Calcula error absoluto y relativo a partir de un valor verdadero y uno aproximado.
        /// </summary>
        /// <param name="valorVerdadero">El valor considerado como exacto.</param>
        /// <param name="valorAprox">El valor aproximado o medido.</param>
        /// <returns>Cadena con los resultados de error absoluto y relativo.</returns>
        public string Calcular(double valorExacto, double valorAprox)
        {
            double errorVerdadero = Math.Abs(valorExacto - valorAprox); // fórmula para el Ev (error verdadero o absoluto)
            double errorRelativo = errorVerdadero / Math.Abs(valorExacto); // fórmula para el Error verdadero relativo

            // Aquí especificamos como queremos que se imprima en el richTextBox:
            string resultado = "";
            resultado += $"Valor verdadero: {valorExacto:F4}\n";
            resultado += $"Valor aproximado: {valorAprox:F4}\n";
            resultado += $"Error absoluto: {errorVerdadero:F6}\n";
            resultado += $"Error relativo: {errorRelativo:P4}\n"; // <- aquí el de porcentaje

            return resultado;
        }
    }
}

using System;
using System.Windows.Forms;

namespace PruebaInterpolacion.implementaciones
{
    public class Interpolacion
    {


        /// <summary>
        /// Muestra los puntos dados (para depuración o consola).
        /// </summary>
        public void DespliegaPuntos(double[,] puntos, int n)
        {
            Console.WriteLine("Tabla de puntos:");
            for (int i = 0; i <= n; i++)
                Console.WriteLine($"x{i} = {puntos[i, 0]}, y{i} = {puntos[i, 1]}");
        }



        /// <summary>
        /// Realiza la interpolación de Lagrange y muestra el procedimiento.
        /// </summary>
        public double InterpolacionLagrange(double[,] puntos, int n, double x, RichTextBox rtb)
        {
            rtb.Clear();
            double resultado = 0;
            rtb.AppendText($"--- Interpolación de Lagrange (grado {n}) ---\n\n");

            for (int i = 0; i <= n; i++)
            {
                rtb.AppendText($"Término {i}:\n");
                rtb.AppendText($"L{i}(x) = ");
                string formula = "";

                for (int j = 0; j <= n; j++)
                {
                    if (j != i)
                    {
                        formula += $"(({x} - {puntos[j, 0]}) / ({puntos[i, 0]} - {puntos[j, 0]}))";
                        if (j < n - 1) formula += " * ";
                    }
                }

                rtb.AppendText(formula + $"\n");
                double Li = Multiplicatoria(i, puntos, n, x);
                rtb.AppendText($"→ L{i}({x}) = {Li:F6}\n");
                rtb.AppendText($"→ f(x{i}) * L{i}(x) = {puntos[i, 1]:F6} * {Li:F6}\n\n");
                resultado += puntos[i, 1] * Li;
            }

            rtb.AppendText($"Resultado final:\n");
            rtb.AppendText($"f({x}) = {resultado:F6}\n");
            return resultado;
        }



        /// <summary>
        /// Calcula la multiplicatoria del término i en el método de Lagrange.
        /// </summary>
        public double Multiplicatoria(int i, double[,] puntos, int n, double x)
        {
            double producto = 1;
            for (int j = 0; j <= n; j++)
            {
                if (j != i)
                    producto *= (x - puntos[j, 0]) / (puntos[i, 0] - puntos[j, 0]);
            }
            return producto;
        }



        /// <summary>
        /// Realiza la interpolación de Newton con diferencias divididas y muestra el procedimiento.
        /// </summary>
        public double InterpolacionNewton(double[,] puntos, int n, double x, RichTextBox rtb)
        {

            rtb.Clear();
            int N = n + 1;
            double[,] tabla = new double[N, N];
            double resultado = 0;


            // Copiar valores de y
            for (int i = 0; i < N; i++)
                tabla[i, 0] = puntos[i, 1];


            // Calcular diferencias divididas
            for (int j = 1; j < N; j++)
                for (int i = 0; i < N - j; i++)
                    tabla[i, j] = (tabla[i + 1, j - 1] - tabla[i, j - 1]) /
                                  (puntos[i + j, 0] - puntos[i, 0]);


            // Mostrar tabla
            rtb.AppendText($"--- Interpolación de Newton (grado {n}) ---\n\n");
            rtb.AppendText("Tabla de diferencias divididas:\n");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - i; j++)
                    rtb.AppendText($"{tabla[i, j],10:F6} ");
                rtb.AppendText("\n");
            }


            // Construcción del polinomio
            rtb.AppendText("\nProcedimiento paso a paso:\n\n");
            rtb.AppendText($"f(x) = {tabla[0, 0]:F6}");

            double termino = 1;
            resultado = tabla[0, 0];

            for (int j = 1; j < N; j++)
            {
                termino *= (x - puntos[j - 1, 0]);
                resultado += tabla[0, j] * termino;

                rtb.AppendText($" + ({tabla[0, j]:F6})");
                for (int k = 0; k < j; k++)
                    rtb.AppendText($"({x} - {puntos[k, 0]})");
            }

            rtb.AppendText($"\n\nResultado final:\n");
            rtb.AppendText($"f({x}) = {resultado:F6}\n");

            return resultado;
        }
    }
}
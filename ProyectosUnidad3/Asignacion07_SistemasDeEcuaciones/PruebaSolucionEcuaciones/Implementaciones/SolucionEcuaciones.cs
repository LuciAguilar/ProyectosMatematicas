using System;
using System.Text;
using System.Windows.Forms;

namespace PruebaSolucionEcuaciones.Implementaciones
{
    public class SolucionEcuaciones
    {
        public StringBuilder Log = new StringBuilder();


        // MÉTODO DE ELIMINACIÓN DE GAUSS CON PIVOTEO PARCIAL:
        public double[] EliminacionGauss(double[,] a)
        {
            int filas = a.GetLength(0);
            int cols = a.GetLength(1);
            int n = cols - 1; // variables

            Log.Clear();
            Log.AppendLine("────────| MÉTODO DE ELIMINACIÓN DE GAUSS |────────\n");
            Log.AppendLine("MATRIZ INICIAL   [A | B]:");
            ImprimirMatriz(a);

            // Eliminación hacia adelante
            for (int i = 0; i < n - 1; i++)
            {
                Pivotea(a, i);

                for (int j = i + 1; j < n; j++)
                {
                    double factor = a[j, i] / a[i, i];
                    Log.AppendLine($"R{j + 1} = R{j + 1} - ({factor:F4}) * R{i + 1}");
                    for (int k = i; k < cols; k++)
                        a[j, k] -= factor * a[i, k];
                }

                Log.AppendLine("\n── ESTADO ACTUAL:");
                ImprimirMatriz(a);
            }

            // Sustitución hacia atrás
            double[] x = SustitucionAtras(a);

            Log.AppendLine("\n────| SOLUCIÓN FINAL |────:");
            for (int i = 0; i < n; i++)
            {
                string frac = DecimalAFraccion(x[i]);
                Log.AppendLine($"x{i + 1} = {x[i]:F6}   ≈   {frac}");
            }
            return x;
        }


        // MÉTODO DE SUSTITUCIÓN HACIA ATRÁS:
        private double[] SustitucionAtras(double[,] a)
        {
            int filas = a.GetLength(0);
            int cols = a.GetLength(1);
            int n = cols - 1;
            double[] x = new double[n];

            for (int i = n - 1; i >= 0; i--)
            {
                double suma = 0;
                for (int j = i + 1; j < n; j++)
                    suma += a[i, j] * x[j];
                x[i] = (a[i, n] - suma) / a[i, i];
            }
            return x;
        }


        // MÉTODO DE PIVOTEO PARCIAL:
        private void Pivotea(double[,] a, int i)
        {
            int filas = a.GetLength(0);
            int cols = a.GetLength(1);
            int max = i;

            for (int j = i + 1; j < filas; j++)
                if (Math.Abs(a[j, i]) > Math.Abs(a[max, i])) max = j;

            if (max != i)
            {
                Log.AppendLine($"── INTERCAMBIO DE FILAS   R{i + 1} ↔ R{max + 1}");
                for (int k = 0; k < cols; k++)
                {
                    double temp = a[i, k];
                    a[i, k] = a[max, k];
                    a[max, k] = temp;
                }
                ImprimirMatriz(a);
            }
        }


        // MÉTODO DE GAUSS-JORDAN CON PIVOTEO PARCIAL:
        public double[] GaussJordan(double[,] a)
        {
            int filas = a.GetLength(0);
            int cols = a.GetLength(1);
            int n = cols - 1;

            Log.Clear();
            Log.AppendLine("────────| MÉTODO DE GAUSS - JORDAN |────────\n");
            Log.AppendLine("MATRIZ INICIAL    [A | B]:");
            ImprimirMatriz(a);

            for (int i = 0; i < n; i++)
            {
                Pivotea(a, i);

                // Normalizar pivote
                double pivote = a[i, i];
                for (int k = 0; k < cols; k++)
                    a[i, k] /= pivote;
                Log.AppendLine($"── NORMALIZAR PIVOTE A 1:    R{i + 1} = R{i + 1} / {pivote:F4}");
                ImprimirMatriz(a);

                // Hacer ceros en otras filas
                for (int j = 0; j < filas; j++)
                {
                    if (j == i) continue;
                    double factor = a[j, i];
                    for (int k = 0; k < cols; k++)
                        a[j, k] -= factor * a[i, k];
                    Log.AppendLine($"── HACER CERO A  [{j + 1},{i + 1}]:   R{j + 1} = R{j + 1} - ({factor:F4}) * R{i + 1}");
                }
                ImprimirMatriz(a);
            }

            // Solución final
            double[] x = new double[n];
            for (int i = 0; i < n; i++) x[i] = a[i, n];

            Log.AppendLine("\n────| SOLUCIÓN FINAL |────:");
            for (int i = 0; i < n; i++)
            {
                string frac = DecimalAFraccion(x[i]);
                Log.AppendLine($"x{i + 1} = {x[i]:F6}   ≈   {frac}");
            }
            return x;
        }


        // MÉTODO AUXILIAR PARA IMPRIMIR MATRICES:
        private void ImprimirMatriz(double[,] a)
        {
            int filas = a.GetLength(0);
            int cols = a.GetLength(1);
            for (int i = 0; i < filas; i++)
            {

                for (int j = 0; j < cols; j++)
                    Log.Append($"{a[i, j],10:F4}");
                Log.AppendLine();
            }

            Log.AppendLine();
        }


        // CONVERSIÓN DECIMAL A FRACCIÓN:
        private string DecimalAFraccion(double valor)
        {
            if (Math.Abs(valor % 1) < 1e-10) return $"{valor:0}";

            int maxDen = 1000;
            double num = Math.Abs(valor);
            int signo = Math.Sign(valor);

            int mejorNum = 1, mejorDen = 1;
            double minError = double.MaxValue;

            for (int den = 1; den <= maxDen; den++)
            {
                int numAprox = (int)Math.Round(num * den);
                double error = Math.Abs(num - (double)numAprox / den);
                if (error < minError)
                {
                    mejorNum = numAprox;
                    mejorDen = den;
                    minError = error;
                }
                if (error < 1e-6) break;
            }

            return $"{(signo < 0 ? "-" : "")}{mejorNum}/{mejorDen}";
        }



        // ───────────── MÉTODO DE GAUSS-SEIDEL ─────────────
        public void GaussSeidel(double[,] a, double eaMax, DataGridView dgv)
        {
            int n = a.GetLength(0);
            int cols = a.GetLength(1);

            if (cols != n + 1)
            {
                MessageBox.Show("La matriz debe ser cuadrada con una columna adicional para los valores B (Aumentada).",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgv.Rows.Clear();
            dgv.Columns.Clear();

            // Crear columnas dinámicamente:
            dgv.Columns.Add("Iter", "Iter");
            for (int i = 0; i < n; i++)
                dgv.Columns.Add($"x{i + 1}", $"x{i + 1}");
            for (int i = 0; i < n; i++)
                dgv.Columns.Add($"ea{i + 1}", $"ea{i + 1}");

            // Verificación de las dimensiones:
            if (cols != n + 1)
            {
                MessageBox.Show($"Error en las dimensiones de la matriz. Filas: {n}, Columnas: {cols}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificación de la diagonal dominante:
            for (int i = 0; i < n; i++)
            {
                double suma = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                        suma += Math.Abs(a[i, j]);
                }

                if (Math.Abs(a[i, i]) <= suma)
                {
                    MessageBox.Show($"La matriz no cumple la condición de diagonal dominante en la ecuación {i + 1}.\n" +
                                  $"Diagonal: |{a[i, i]}| = {Math.Abs(a[i, i]):F4}\n" +
                                  $"Suma otros: {suma:F4}",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Inicializar los valores:
            double[] x = new double[n];
            double[] xAnt = new double[n];
            double[] ea = new double[n];

            for (int i = 0; i < n; i++)
            {
                x[i] = 0;
                xAnt[i] = 0;
                ea[i] = 0;
            }

            int iterMax = 100;
            int iter = 0;
            bool converge = false;

            // Primera fila (iteración 0)
            object[] filaInicial = new object[1 + 2 * n];
            filaInicial[0] = 0;
            for (int i = 0; i < n; i++) filaInicial[1 + i] = x[i].ToString("F4");
            for (int i = 0; i < n; i++) filaInicial[1 + n + i] = ea[i].ToString("F4");
            dgv.Rows.Add(filaInicial);

            // Iteraciones
            while (!converge && iter < iterMax)
            {
                iter++;
                converge = true;

                // Guardar valores previos:
                for (int i = 0; i < n; i++)
                    xAnt[i] = x[i];

                for (int i = 0; i < n; i++)
                {
                    double suma = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j != i)
                            suma += a[i, j] * x[j];
                    }

                    x[i] = (a[i, n] - suma) / a[i, i];

                    // Calcular el error relativo aproximado
                    if (Math.Abs(x[i]) > 1e-10)
                        ea[i] = Math.Abs((x[i] - xAnt[i]) / x[i]) * 100.0;
                    else
                        ea[i] = 0;

                    if (ea[i] > eaMax * 100)
                        converge = false;
                }

                // Agregar la fila con resultados de esta iteración:
                object[] fila = new object[1 + 2 * n];
                fila[0] = iter;
                for (int i = 0; i < n; i++) fila[1 + i] = x[i].ToString("F4");
                for (int i = 0; i < n; i++) fila[1 + n + i] = ea[i].ToString("F4");
                dgv.Rows.Add(fila);
            }

            // Mensaje final
            if (converge)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Convergencia alcanzada en {iter} iteraciones.\n");
                sb.AppendLine("Solución aproximada:");
                for (int i = 0; i < n; i++)
                    sb.AppendLine($"x{i + 1} = {x[i]:F4}");
                MessageBox.Show(sb.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No converge después de {iterMax} iteraciones.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
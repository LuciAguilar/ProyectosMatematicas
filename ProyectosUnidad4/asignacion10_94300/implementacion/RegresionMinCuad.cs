using System;
using System.Data;
using PruebaSolucionEcuaciones.Implementaciones;

namespace asignacion10_94300.implementacion
{
    internal class RegresionMinCuad
    {
        // -------- REGRESIÓN POLINOMIAL --------
        public (string ecuacion, DataTable tabla) RegresionPolinomial(double[][] puntos, int grado)
        {
            int n = puntos.Length;
            double[] sx = new double[2 * grado + 1];
            double[] sxy = new double[grado + 1];

            // Calcular sumatorias
            for (int i = 0; i < 2 * grado + 1; i++)
                for (int k = 0; k < n; k++)
                    sx[i] += Math.Pow(puntos[k][0], i);

            for (int i = 0; i <= grado; i++)
                for (int k = 0; k < n; k++)
                    sxy[i] += puntos[k][1] * Math.Pow(puntos[k][0], i);

            // Crear matriz aumentada
            double[,] A = new double[grado + 1, grado + 2];
            for (int i = 0; i <= grado; i++)
            {
                for (int j = 0; j <= grado; j++)
                    A[i, j] = sx[i + j];
                A[i, grado + 1] = sxy[i];
            }

            // Resolver con Gauss-Jordan de tu otro proyecto
            var solver = new SolucionEcuaciones();
            double[] coef = solver.GaussJordan(A);

            // Crear tabla para mostrar solo X, Y y Ŷ
            DataTable tabla = new DataTable();
            tabla.Columns.Add("X");
            tabla.Columns.Add("Y (real)");
            tabla.Columns.Add("Y (estimada)");

            for (int i = 0; i < n; i++)
            {
                double x = puntos[i][0];
                double yReal = puntos[i][1];
                double yCalc = 0;

                for (int j = 0; j <= grado; j++)
                    yCalc += coef[j] * Math.Pow(x, j);

                var fila = tabla.NewRow();
                fila["X"] = x;
                fila["Y (real)"] = Math.Round(yReal, 6);
                fila["Y (estimada)"] = Math.Round(yCalc, 6);
                tabla.Rows.Add(fila);
            }

            // Construir ecuación final
            string eq = "Ecuación final:\n";
            eq += "y = ";
            for (int i = 0; i <= grado; i++)
            {
                eq += $"{coef[i]:F6}";
                if (i > 0) eq += $"x^{i}";
                if (i < grado) eq += " + ";
            }

            return (eq, tabla);
        }


        // -------- REGRESIÓN LINEAL MÚLTIPLE --------
        public (string ecuacion, DataTable tabla) RegresionLinealMultiple(double[][] puntos)
        {
            int n = puntos.Length;
            int vars = puntos[0].Length - 1;

            double[,] A = new double[vars + 1, vars + 2];

            // Construcción de matriz de sumatorias
            for (int i = 0; i <= vars; i++)
            {
                for (int j = 0; j <= vars; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < n; k++)
                    {
                        double xi = (i == 0) ? 1 : puntos[k][i - 1];
                        double xj = (j == 0) ? 1 : puntos[k][j - 1];
                        sum += xi * xj;
                    }
                    A[i, j] = sum;
                }

                double sumY = 0;
                for (int k = 0; k < n; k++)
                {
                    double xi = (i == 0) ? 1 : puntos[k][i - 1];
                    sumY += xi * puntos[k][vars];
                }
                A[i, vars + 1] = sumY;
            }

            var solver = new SolucionEcuaciones();
            double[] coef = solver.GaussJordan(A);

            // Crear tabla con X1, X2... Y (real) y Y (estimada)
            DataTable tabla = new DataTable();
            for (int i = 1; i <= vars; i++)
                tabla.Columns.Add($"X{i}");
            tabla.Columns.Add("Y (real)");
            tabla.Columns.Add("Y (estimada)");

            for (int i = 0; i < n; i++)
            {
                double yCalc = coef[0];
                for (int j = 0; j < vars; j++)
                    yCalc += coef[j + 1] * puntos[i][j];

                var fila = tabla.NewRow();
                for (int j = 0; j < vars; j++)
                    fila[$"X{j + 1}"] = puntos[i][j];
                fila["Y (real)"] = Math.Round(puntos[i][vars], 6);
                fila["Y (estimada)"] = Math.Round(yCalc, 6);
                tabla.Rows.Add(fila);
            }

            // Construir ecuación final
            string eq = "Ecuación final:\n";
            eq += "y = ";
            for (int i = 0; i <= vars; i++)
            {
                eq += $"{coef[i]:F6}";
                if (i > 0) eq += $"x{i}";
                if (i < vars) eq += " + ";
            }

            return (eq, tabla);
        }
    }
}

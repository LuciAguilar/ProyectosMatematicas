using PruebaSolucionEcuaciones.Implementaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pruebaRegresionMinCuad.implementaciones
{
    public class RegresionMinCuad
    {

        // ───────────── MÉTODO PARA REGRESIÓN LINEAL SIMPLE ─────────────:
        public (string ecuacion, DataTable tabla) RegresionLinealSimple(double[][] puntos)
        {
            int n = puntos.Length;

            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

            // Tabla de resultados:
            DataTable tabla = new DataTable();
            tabla.Columns.Add("No.");
            tabla.Columns.Add("Xi");
            tabla.Columns.Add("Yi");
            tabla.Columns.Add("Xi²");
            tabla.Columns.Add("Xi·Yi");

            // Calculo de sumatorias y llenado de tabla:
            for (int i = 0; i < n; i++)
            {
                double x = puntos[i][0];
                double y = puntos[i][1];

                double x2 = x * x;
                double xy = x * y;

                sumX += x;
                sumY += y;
                sumX2 += x2;
                sumXY += xy;

                tabla.Rows.Add((i + 1).ToString(), x, y, x2, xy);
            }

            // Fila de sumatorias:
            tabla.Rows.Add("Σ", sumX, sumY, sumX2, sumXY);

            // Cálculo de coeficientes:
            double a1 = (n * sumXY - sumX * sumY) / (n * sumX2 - Math.Pow(sumX, 2));
            double a0 = (sumY - a1 * sumX) / n;

            // Resultado en texto para mostrar:
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("──────── REGRESIÓN LINEAL SIMPLE ────────");
            sb.AppendLine($"a₀ = {a0:F6}");
            sb.AppendLine($"a₁ = {a1:F6}");
            sb.AppendLine();
            sb.AppendLine($"Ecuación final:");
            sb.AppendLine($"y = {a0:F6} + ({a1:F6})x");

            return (sb.ToString(), tabla);
        }



        //───────────── MÉTODO PARA REGRESIÓN EXPONENCIAL ─────────────:
        public (string ecuacion, DataTable tabla) RegresionExponencial(double[][] puntos)
        {
            int n = puntos.Length;

            double sumW = 0, sumZ = 0, sumWZ = 0, sumW2 = 0;

            // Crear tabla con columnas para cada valor calculado
            DataTable tabla = new DataTable();
            tabla.Columns.Add("No.");
            tabla.Columns.Add("Xi");
            tabla.Columns.Add("Yi");
            tabla.Columns.Add("Wi (Xi)");
            tabla.Columns.Add("Zi = ln(Yi)");
            tabla.Columns.Add("Wi²");
            tabla.Columns.Add("Wi·Zi");

            for (int i = 0; i < n; i++)
            {
                double x = puntos[i][0];
                double y = puntos[i][1];

                if (y <= 0)
                    throw new Exception("Todos los valores de Y deben ser positivos para aplicar logaritmo.");

                double w = x;
                double z = Math.Log(y);
                double w2 = w * w;
                double wz = w * z;

                sumW += w;
                sumZ += z;
                sumW2 += w2;
                sumWZ += wz;

                tabla.Rows.Add((i + 1).ToString(), x, y, w.ToString("F4"), z.ToString("F6"), w2.ToString("F4"), wz.ToString("F6"));
            }

            // Agregar fila de sumatorias
            tabla.Rows.Add("Σ", "", "", sumW.ToString("F4"), sumZ.ToString("F6"), sumW2.ToString("F4"), sumWZ.ToString("F6"));

            // Calcular coeficientes
            double a1 = (n * sumWZ - sumW * sumZ) / (n * sumW2 - Math.Pow(sumW, 2));
            double ln_a0 = (sumZ - a1 * sumW) / n;
            double a0 = Math.Exp(ln_a0);

            // agregar resultados al richTextBox:
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("──────── REGRESIÓN EXPONENCIAL ────────");
            sb.AppendLine($"a₀ = {a0:F6}");
            sb.AppendLine($"a₁ = {a1:F6}");
            sb.AppendLine();
            sb.AppendLine("Ecuación final:");
            sb.AppendLine($"y = {a0:F6} · e^({a1:F6}x)");

            return (sb.ToString(), tabla);
        }



        // ───────────── MÉTODO PARA REGRESIÓN POLINOMIAL ─────────────:
        public (string ecuacion, DataTable tabla) RegresionPolinomial(double[][] puntos, int grado)
        {
            int n = puntos.Length;                 // número de puntos
            int g = grado;                         // grado del polinomio

            // Crear tabla dinámica
            DataTable tabla = new DataTable();
            tabla.Columns.Add("No.");
            tabla.Columns.Add("Xi");
            tabla.Columns.Add("Yi");
            for (int i = 2; i <= 2 * g; i++)
                tabla.Columns.Add($"Xi^{i}");
            for (int i = 1; i <= g; i++)
                tabla.Columns.Add($"Xi^{i}·Yi");


            // --- SUMATORIAS ---
            double[] sumX = new double[2 * g + 1];
            double[] sumXY = new double[g + 1];
            double sumY = 0;

            for (int i = 0; i < n; i++)
            {
                double x = puntos[i][0];
                double y = puntos[i][1];
                sumY += y;

                // Potencias de X
                double[] pot = new double[2 * g + 1];
                pot[0] = 1;
                for (int p = 1; p < pot.Length; p++)
                    pot[p] = pot[p - 1] * x;

                for (int p = 1; p < pot.Length; p++)
                    sumX[p] += pot[p];

                for (int j = 0; j <= g; j++)
                    sumXY[j] += y * Math.Pow(x, j);

                // Agregar fila a la tabla
                List<object> fila = new List<object> { (i + 1).ToString(), x, y };
                for (int p = 2; p <= 2 * g; p++) fila.Add(Math.Pow(x, p));
                for (int p = 1; p <= g; p++) fila.Add(y * Math.Pow(x, p));
                tabla.Rows.Add(fila.ToArray());
            }


            // Agregar fila de SUMATORIAS:
            List<object> filaSum = new List<object> { "Σ", "", sumY };
            for (int p = 2; p <= 2 * g; p++) filaSum.Add(sumX[p]);
            for (int p = 1; p <= g; p++) filaSum.Add(sumXY[p]);
            tabla.Rows.Add(filaSum.ToArray());


            // CREAR MATRIZ (g+1)x(g+2):
            double[,] matriz = new double[g + 1, g + 2];
            for (int i = 0; i <= g; i++)
            {
                for (int j = 0; j <= g; j++)
                    matriz[i, j] = (i == 0 && j == 0) ? n : sumX[i + j];
                matriz[i, g + 1] = sumXY[i];
            }


            // Guardar copia original antes del Gauss-Jordan:
            double[,] matrizOriginal = (double[,])matriz.Clone();


            // Resolver sistema:
            var solver = new SolucionEcuaciones();
            double[] coef = solver.GaussJordan(matriz);



            StringBuilder sb = new StringBuilder();
            sb.AppendLine("──────── REGRESIÓN POLINOMIAL ────────");
            sb.AppendLine("Matriz de sumatorias [A | B]:\n");

            for (int i = 0; i <= g; i++)
            {
                for (int j = 0; j <= g; j++)
                    sb.Append($"{matrizOriginal[i, j],10:F2} ");
                sb.Append($"  a{i}  {matrizOriginal[i, g + 1],8:F2}");
                sb.AppendLine();
            }

            sb.AppendLine();
            for (int i = 0; i < coef.Length; i++)
                sb.AppendLine($"a{i} = {coef[i]:F6}");

            sb.AppendLine("\nEcuación final:");
            sb.Append("y = ");
            for (int i = 0; i < coef.Length; i++)
            {
                if (i == 0)
                    sb.Append($"{coef[i]:F6}");
                else
                    sb.Append($" + ({coef[i]:F6})x^{i}");
            }

            return (sb.ToString(), tabla);
        }



        // ───────────── MÉTODO PARA REGRESIÓN LINEAL MÚLTIPLE ─────────────:
        public (string ecuacion, DataTable tabla) RegresionLinealMultiple(double[][] puntos)
        {
            int n = puntos.Length;              // número de filas (puntos)
            int k = puntos[0].Length - 1;       // número de variables independientes (todas menos Y)

            // Crear tabla de resultados
            DataTable tabla = new DataTable();

            // Columnas base: No., X1, X2, ..., Xk, Y
            tabla.Columns.Add("No.");
            for (int i = 0; i < k; i++)
                tabla.Columns.Add($"X{i + 1}i");
            tabla.Columns.Add("Yi");

            // Columnas adicionales comunes
            for (int i = 0; i < k; i++)
                tabla.Columns.Add($"X{i + 1}i²");

            // Productos cruzados X1·X2, X1·X3, etc.
            if (k > 1)
            {
                for (int i = 0; i < k - 1; i++)
                {
                    for (int j = i + 1; j < k; j++)
                    {
                        tabla.Columns.Add($"X{i + 1}i·X{j + 1}i");
                    }
                }
            }

            for (int i = 0; i < k; i++)
                tabla.Columns.Add($"X{i + 1}i·Yi");

            // SUMATORIAS:
            double[] sumX = new double[k];
            double[] sumX2 = new double[k];
            double[] sumXY = new double[k];
            double[,] sumXiXj = new double[k, k];
            double sumY = 0;

            // Llenar tabla y calcular sumatorias
            for (int r = 0; r < n; r++)
            {
                double[] fila = puntos[r];
                double y = fila[k];


                // Calcular productos para la tabla
                List<object> filaTabla = new List<object>();

                // No. consecutivo
                filaTabla.Add((r + 1).ToString());

                // Xs y Y
                for (int i = 0; i < k; i++)
                    filaTabla.Add(fila[i]);
                filaTabla.Add(y);

                // X²
                for (int i = 0; i < k; i++)
                    filaTabla.Add(Math.Pow(fila[i], 2));

                // Productos cruzados
                if (k > 1)
                {
                    for (int i = 0; i < k - 1; i++)
                        for (int j = i + 1; j < k; j++)
                            filaTabla.Add(fila[i] * fila[j]);
                }

                // X·Y
                for (int i = 0; i < k; i++)
                    filaTabla.Add(fila[i] * y);

                tabla.Rows.Add(filaTabla.ToArray());


                // Sumatorias base
                sumY += y;
                for (int i = 0; i < k; i++)
                {
                    sumX[i] += fila[i];
                    sumX2[i] += Math.Pow(fila[i], 2);
                    sumXY[i] += fila[i] * y;
                }

                for (int i = 0; i < k; i++)
                    for (int j = 0; j < k; j++)
                        sumXiXj[i, j] += fila[i] * fila[j];
            }

            // Fila de sumatorias:
            List<object> filaSum = new List<object>();
            filaSum.Add("Σ");
            for (int i = 0; i < k; i++) filaSum.Add(sumX[i]);
            filaSum.Add(sumY);
            for (int i = 0; i < k; i++) filaSum.Add(sumX2[i]);
            if (k > 1)
            {
                for (int i = 0; i < k - 1; i++)
                    for (int j = i + 1; j < k; j++)
                        filaSum.Add(sumXiXj[i, j]);
            }
            for (int i = 0; i < k; i++) filaSum.Add(sumXY[i]);

            tabla.Rows.Add(filaSum.ToArray());


            // --- CREAR MATRIZ DE SUMATORIAS [A|B] ---
            double[,] matriz = new double[k + 1, k + 2];


            // Primera fila
            matriz[0, 0] = n;
            for (int j = 0; j < k; j++)
            {
                matriz[0, j + 1] = sumX[j];
                matriz[j + 1, 0] = sumX[j];
            }
            matriz[0, k + 1] = sumY;


            // Rellenar parte interna y última columna (B)
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                    matriz[i + 1, j + 1] = sumXiXj[i, j];
                matriz[i + 1, k + 1] = sumXY[i];
            }

            // COPIAR MATRIZ ORIGINAL
            double[,] matrizOriginal = (double[,])matriz.Clone();


            // Resolver por Gauss-Jordan
            var solver = new SolucionEcuaciones();
            double[] coef = solver.GaussJordan(matriz);


            // CONSTRUIR TEXTO PARA EL RICH TEXTBOX
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("──────── REGRESIÓN LINEAL MÚLTIPLE ────────");
            sb.AppendLine("Matriz de sumatorias [A | B]:");
            sb.AppendLine();

            // Mostrar la matriz original:
            for (int i = 0; i < k + 1; i++)
            {
                for (int j = 0; j < k + 1; j++)
                    sb.Append($"{matrizOriginal[i, j],10:F2} ");
                sb.Append($"  a{i}  {matrizOriginal[i, k + 1],8:F2}");
                sb.AppendLine();
            }

            sb.AppendLine();
            for (int i = 0; i < coef.Length; i++)
                sb.AppendLine($"a{i} = {coef[i]:F6}");

            sb.AppendLine();
            sb.Append("Ecuación final:\n y = ");
            for (int i = 0; i < coef.Length; i++)
            {
                if (i == 0) sb.Append($"{coef[i]:F6}");
                else sb.Append($" + ({coef[i]:F6})x{i}");
            }

            return (sb.ToString(), tabla);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaRegresionMinCuad
{
    public partial class Form1 : Form
    {
        private int anchoInicial = 480;
        private int anchoExpandido = 1000;

        public Form1()
        {
            InitializeComponent();

            // Cargar opciones del combo
            cmbTipoRegresion.Items.Add("Lineal Simple");
            cmbTipoRegresion.Items.Add("Exponencial");
            cmbTipoRegresion.Items.Add("Polinomial");
            cmbTipoRegresion.Items.Add("Lineal Múltiple");

            // Evento cuando se cambia la selección:
            cmbTipoRegresion.SelectedIndexChanged += cmbTipoRegresion_SelectedIndexChanged;

            // Evento del botón Calcular:
            btnCalcular.Click += btnCalcular_Click;

            // Evento del botón Graficar:
            btnGraficar.Click += btnGraficar_Click;

            // Configuración inicial del DataGridView:
            for (int i = 0; i < 10; i++)
            {
                dgvDatos.Rows.Add();
            }

            // Evento KeyDown para pegar/copiar:
            this.dgvDatos.KeyDown += dgvDatos_KeyDown;

            // Configuración inicial del gráfico
            ConfigurarChart();

            // Tamaño inicial reducido (solo entrada)
            this.Width = anchoInicial;
            pnlResultados.Visible = false;
            chartRegresion.Visible = false;
        }


        // ───────────── MÉTODO PARA CAMBIAR LAS COLUMNAS DEL DATAGRID SEGÚN EL TIPO DE REGRESIÓN SELECCIONADO ─────────────:
        private void cmbTipoRegresion_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();
            dgvDatos.Columns.Clear();

            // Ocultar resultados al cambiar de tipo
            pnlResultados.Visible = false;
            chartRegresion.Visible = false;
            this.Width = anchoInicial;

            string tipo = cmbTipoRegresion.SelectedItem.ToString();

            // Ocultar temporalmente los controles de grado y variables:
            nudGrado.Visible = false;
            lblGrado.Visible = false;
            nudVariables.Visible = false;
            lblVariables.Visible = false;

            switch (tipo)
            {
                case "Lineal Simple":
                case "Exponencial":
                    dgvDatos.Columns.Add("X", "X");
                    dgvDatos.Columns.Add("Y", "Y");
                    break;

                case "Polinomial":
                    dgvDatos.Columns.Add("X", "X");
                    dgvDatos.Columns.Add("Y", "Y");
                    nudGrado.Visible = true;
                    lblGrado.Visible = true;
                    break;

                case "Lineal Múltiple":
                    nudVariables.Visible = true;
                    lblVariables.Visible = true;
                    ConfigurarColumnasLinealMultiple((int)nudVariables.Value);

                    // Remover evento previo para evitar duplicados
                    nudVariables.ValueChanged -= nudVariables_ValueChanged;
                    nudVariables.ValueChanged += nudVariables_ValueChanged;
                    break;
            }

            // 10 FILAS INICIALES:
            dgvDatos.AllowUserToAddRows = false;
            for (int i = 0; i < 10; i++)
            {
                dgvDatos.Rows.Add();
            }
        }


        // MÉTODO AUXILIAR PARA CONFIGURAR COLUMNAS EN REGRESIÓN LINEAL MÚLTIPLE:
        private void ConfigurarColumnasLinealMultiple(int numVars)
        {
            dgvDatos.Columns.Clear();
            dgvDatos.Rows.Clear();

            for (int i = 1; i <= numVars; i++)
                dgvDatos.Columns.Add($"X{i}", $"X{i}");
            dgvDatos.Columns.Add("Y", "Y");

            dgvDatos.AllowUserToAddRows = false;
            for (int i = 0; i < 10; i++)
            {
                dgvDatos.Rows.Add();
            }
        }


        // EVENTO CUANDO CAMBIA EL NUD DE VARIABLES EN REGRESIÓN LINEAL MÚLTIPLE:
        private void nudVariables_ValueChanged(object sender, EventArgs e)
        {
            ConfigurarColumnasLinealMultiple((int)nudVariables.Value);
        }



        // -------- FUNCIONALIDAD DEL BOTÓN CALCULAR --------:
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbTipoRegresion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de regresión.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese al menos un punto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipo = cmbTipoRegresion.SelectedItem.ToString();
            var regresion = new implementaciones.RegresionMinCuad();

            try
            {
                // Ajustar visibilidad y tamaño
                pnlResultados.Visible = true;
                chartRegresion.Visible = false;
                this.Width = anchoExpandido;

                // Limpiar resultados anteriores
                rtbResultados.Clear();
                dgvResultados.DataSource = null;
                dgvResultados.Rows.Clear();
                dgvResultados.Columns.Clear();

                switch (tipo)
                {
                    case "Lineal Simple":
                        {
                            double[][] puntos = LeerPuntos(2);
                            var resultado = regresion.RegresionLinealSimple(puntos);
                            rtbResultados.Text = resultado.ecuacion;
                            dgvResultados.DataSource = resultado.tabla;
                            break;
                        }

                    case "Exponencial":
                        {
                            double[][] puntos = LeerPuntos(2);
                            var resultado = regresion.RegresionExponencial(puntos);
                            rtbResultados.Text = resultado.ecuacion;
                            dgvResultados.DataSource = resultado.tabla;
                            break;
                        }

                    case "Polinomial":
                        {
                            int grado = (int)nudGrado.Value;
                            double[][] puntos = LeerPuntos(2);
                            var resultado = regresion.RegresionPolinomial(puntos, grado);
                            rtbResultados.Text = resultado.ecuacion;
                            dgvResultados.DataSource = resultado.tabla;
                            break;
                        }

                    case "Lineal Múltiple":
                        {
                            int columnas = (int)nudVariables.Value + 1;
                            double[][] puntos = LeerPuntos(columnas);
                            var resultado = regresion.RegresionLinealMultiple(puntos);
                            rtbResultados.Text = resultado.ecuacion;
                            dgvResultados.DataSource = resultado.tabla;
                            break;
                        }
                }

                chartRegresion.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // -------- MÉTODO PARA LEER LOS PUNTOS INGRESADOS EN EL DATAGRIDVIEW --------:
        private double[][] LeerPuntos(int columnas)
        {
            var lista = new List<double[]>();

            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                if (fila.IsNewRow) continue;

                double[] valores = new double[columnas];
                bool valido = true;

                for (int i = 0; i < columnas; i++)
                {
                    if (fila.Cells[i].Value == null || !double.TryParse(fila.Cells[i].Value.ToString(), out valores[i]))
                    {
                        valido = false;
                        break;
                    }
                }

                if (valido)
                    lista.Add(valores);
            }

            if (lista.Count == 0)
                throw new Exception("No hay datos válidos en la tabla.");

            return lista.ToArray();
        }

        private void dgvDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                PegarDesdeExcel(dgvDatos);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                CopiarAExcel(dgvDatos);
                e.Handled = true;
            }
        }



        // MÉTODO P/PEGAR DESDE EXCEL AL DATAGRIDVIEW:
        private void PegarDesdeExcel(DataGridView dgv)
        {
            string texto = Clipboard.GetText();
            if (string.IsNullOrEmpty(texto)) return;

            string[] filas = texto.Split('\n');
            int filaActual = dgv.CurrentCell?.RowIndex ?? 0;
            int colActual = dgv.CurrentCell?.ColumnIndex ?? 0;

            foreach (string fila in filas)
            {
                if (fila.Trim() == "") continue;
                string[] celdas = fila.Split('\t');
                int col = colActual;
                foreach (string celda in celdas)
                {
                    if (col < dgv.ColumnCount && filaActual < dgv.RowCount)
                        dgv[col++, filaActual].Value = celda.Trim();
                }

                filaActual++;
            }
        }


        // MÉTODO P/COPIAR DESDE EL DATAGRIDVIEW A EXCEL:
        private void CopiarAExcel(DataGridView dgv)
        {
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }


        // FUNCIONALIDAD DEL BOTÓN GRAFICAR:
        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbResultados.Text) || !rtbResultados.Text.Contains("y ="))
            {
                MessageBox.Show("Primero calcula la regresión antes de graficar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pnlResultados.Visible = true;
            chartRegresion.Visible = true;
            chartRegresion.BringToFront();

            var seriePuntos = chartRegresion.Series["Puntos"];
            var serieCurva = chartRegresion.Series["Curva"];
            seriePuntos.Points.Clear();
            serieCurva.Points.Clear();

            List<double> listaX = new List<double>();

            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                if (fila.IsNewRow) continue;
                if (double.TryParse(fila.Cells[0].Value?.ToString(), out double x) &&
                    double.TryParse(fila.Cells[1].Value?.ToString(), out double y))
                {
                    seriePuntos.Points.AddXY(x, y);
                    listaX.Add(x);
                }
            }

            // Extraer la ecuación
            string eq = rtbResultados.Text.Split('\n')
                .FirstOrDefault(l => l.Contains("y ="))?.Trim();

            if (string.IsNullOrEmpty(eq))
            {
                MessageBox.Show("No se encontró la ecuación en el resultado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular rango dinámico de X
            double minX = listaX.Min();
            double maxX = listaX.Max();

            for (double x = minX - 0.5; x <= maxX + 0.5; x += 0.1)
            {
                double y = CalcularY(eq, x);
                if (!double.IsNaN(y))
                    serieCurva.Points.AddXY(x, y);
            }

            chartRegresion.ChartAreas[0].RecalculateAxesScale();
            chartRegresion.Invalidate();
        }

        // CONFIGURACIÓN INICIAL DEL CHART
        private void ConfigurarChart()
        {
            if (chartRegresion.ChartAreas.Count == 0)
                chartRegresion.ChartAreas.Add("ChartArea1");

            chartRegresion.Series.Clear();

            var seriePuntos = chartRegresion.Series.Add("Puntos");
            seriePuntos.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            seriePuntos.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            seriePuntos.MarkerSize = 8;
            seriePuntos.Color = Color.DarkBlue;

            var serieCurva = chartRegresion.Series.Add("Curva");
            serieCurva.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            serieCurva.BorderWidth = 2;
            serieCurva.Color = Color.Red;

            var area = chartRegresion.ChartAreas[0];
            area.AxisX.Title = "X";
            area.AxisY.Title = "Y";
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            chartRegresion.Titles.Clear();
            chartRegresion.Titles.Add("Gráfica de Regresión");
            chartRegresion.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

            if (chartRegresion.Legends.Count == 0)
                chartRegresion.Legends.Add("Legend1");
            chartRegresion.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;

            chartRegresion.Visible = false;
        }

        // MÉTODO AUXILIAR PARA CALCULAR Y DADO X Y LA ECUACIÓN:
        private double CalcularY(string ecuacion, double x)
        {
            try
            {
                // Extraer solo la parte de la ecuación
                string expr = ecuacion.Replace("y =", "").Replace("Y =", "").Trim();

                // Reemplazar potencias si existen (ejemplo: x^2 → (x)*(x))
                expr = Regex.Replace(expr, @"x\^2", $"({x})*({x})");
                expr = Regex.Replace(expr, @"x\^3", $"({x})*({x})*({x})");

                // Reemplazar todas las x por su valor
                expr = expr.Replace("x", $"({x})");

                // Limpiar signos duplicados
                expr = expr.Replace("++", "+").Replace("+-", "-").Replace("--", "+");

                System.Data.DataTable dt = new System.Data.DataTable();
                return Convert.ToDouble(dt.Compute(expr, ""));
            }
            catch
            {
                return double.NaN;
            }
        }
    }
}
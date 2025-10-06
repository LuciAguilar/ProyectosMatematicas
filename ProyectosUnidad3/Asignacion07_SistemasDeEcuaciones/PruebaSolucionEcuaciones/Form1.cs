using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaSolucionEcuaciones.Implementaciones;

namespace PruebaSolucionEcuaciones
{
    public partial class Form1 : Form
    {
        SolucionEcuaciones solver = new SolucionEcuaciones();

        public Form1()
        {
            InitializeComponent();

            // Bloquear edición por defecto
            dgvMatriz.ReadOnly = true;
            dgvMatriz.Enabled = false;

            // Limitar NumericUpDown para que solo se puedan poner a partir de matriz de 2x2 a 4x4:
            numericRows.Minimum = 2;
            numericRows.Maximum = 4;
            numericCols.Minimum = 2;
            numericCols.Maximum = 4;

            // Colores del DataGridView:
            dgvMatriz.BackgroundColor = Color.LavenderBlush;
            dgvMatriz.DefaultCellStyle.BackColor = Color.White;
            dgvMatriz.DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            dgvMatriz.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMatriz.GridColor = Color.MediumPurple;


            // Ajustar ancho de la columna del encabezado (Eq):
            dgvMatriz.RowHeadersWidth = 80;

            // FONT del dataviewgrid:
            dgvMatriz.ColumnHeadersDefaultCellStyle.Font = new Font("Louis George Cafe", 9, FontStyle.Bold);
            dgvMatriz.DefaultCellStyle.Font = new Font("Louis George Cafe", 9);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        // FUNCIONALIDAD DEL BOTON ESTABLECER MATRIZ:
        private void btnEstabMatriz_Click(object sender, EventArgs e)
        {
            int filas = (int)numericRows.Value;
            int cols = (int)numericCols.Value;

            if (filas <= 0 || cols <= 0 || filas > 4 || cols > 4)
            {
                MessageBox.Show("Por favor, ingrese dimensiones válidas (máximo 4x4).",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar solo las columnas necesarias según la cantidad de variables:
            dgvMatriz.Columns["X1"].Visible = cols >= 1;
            dgvMatriz.Columns["X2"].Visible = cols >= 2;
            dgvMatriz.Columns["X3"].Visible = cols >= 3;
            dgvMatriz.Columns["X4"].Visible = cols >= 4;
            dgvMatriz.Columns["b"].Visible = true;

            // Limpiar y crear filas:
            dgvMatriz.Rows.Clear();
            dgvMatriz.AllowUserToAddRows = false;
            dgvMatriz.RowCount = filas;

            // Etiquetas visuales:
            for (int i = 0; i < filas; i++)
            {
                dgvMatriz.Rows[i].HeaderCell.Value = $"Eq {i + 1}";
            }

            // Habilitar edición
            dgvMatriz.ReadOnly = false;
            dgvMatriz.Enabled = true;

            // Limpiar resultados
            rtbResultado.Clear();

            MessageBox.Show($"Matriz de {filas}x{cols} establecida, puede ingresar los datos.", "Listo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        // FUNCIONALIDAD DEL BOTÓN RELLENAR CEROS:
        private void btnRellenarCeros_Click(object sender, EventArgs e)
        {
            try
            {
                bool todosCeros = true;

                foreach (DataGridViewRow row in dgvMatriz.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Rellenar vacío con cero
                        if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                            cell.Value = 0;

                        // Verificar si hay algún valor diferente de cero
                        if (double.TryParse(cell.Value.ToString(), out double valor))
                        {
                            if (valor != 0) todosCeros = false;
                        }
                        else
                        {
                            MessageBox.Show("Solo se permiten valores numéricos (enteros, decimales o negativos).",
                                            "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                // Si toda la matriz es cero
                if (todosCeros)
                {
                    MessageBox.Show("Debe ingresar al menos un valor distinto de cero en la matriz.",
                                    "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Las celdas vacías se rellenaron con ceros correctamente.",
                                "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la matriz:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // FUNCIONALIDAD DEL BOTON LIMPIAR:
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvMatriz.Rows.Clear();
            rtbResultado.Clear();
            dgvMatriz.Enabled = false;
            dgvMatriz.ReadOnly = true;
            MessageBox.Show("Matriz y resultados limpiados.", "Limpieza",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        // FUNCIONALIDAD DEL BOTON GAUSS:
        private void btnGauss_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] matriz = LeerMatriz();
                solver.EliminacionGauss(matriz);
                rtbResultado.Text = solver.Log.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Verifique que todos los valores sean numéricos válidos.\n" +
                                "Solo se permiten números decimales o negativos.",
                                "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // FUNCIONALIDAD DEL BOTON GAUSS-JORDAN:
        private void btnGaussJordan_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] matriz = LeerMatriz();
                solver.GaussJordan(matriz);
                rtbResultado.Text = solver.Log.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Verifique que todos los valores sean numéricos válidos.\n" +
                                "Solo se permiten números decimales o negativos.",
                                "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // MÉTODO DE LECTURA DE MATRIZ DESDE DATAGRIDVIEW:
        private double[,] LeerMatriz()
        {

            // Filas válidas:
            int filas = dgvMatriz.Rows.Cast<DataGridViewRow>()
                .Count(r => !r.IsNewRow);


            // Detectar cuántas columnas X visibles hay:
            int vars = dgvMatriz.Columns.Cast<DataGridViewColumn>()
                .Count(c => c.Visible && c.Name.StartsWith("X"));


            // Agregar una más para la columna b:
            double[,] matriz = new double[filas, vars + 1];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < vars; j++)
                {
                    string valor = dgvMatriz.Rows[i].Cells[$"X{j + 1}"].Value?.ToString().Trim() ?? "0";
                    matriz[i, j] = ParseValor(valor, i, j);
                }

                // Leer la columna b directamente por nombre:
                string valorB = dgvMatriz.Rows[i].Cells["b"].Value?.ToString().Trim() ?? "0";
                matriz[i, vars] = ParseValor(valorB, i, vars);
            }

            return matriz;
        }


        // Permite fracciones o decimales:
        private double ParseValor(string valor, int fila, int col)
        {
            double resultado;

            if (valor.Contains("/"))
            {
                var partes = valor.Split('/');
                if (partes.Length == 2 &&
                    double.TryParse(partes[0], out double n1) &&
                    double.TryParse(partes[1], out double n2) &&
                    n2 != 0)
                {
                    resultado = n1 / n2;
                }
                else
                {
                    throw new FormatException($"Valor inválido en celda [{fila + 1},{col + 1}]: {valor}");
                }
            }

            else if (double.TryParse(valor, out double num))
            {
                resultado = num;
            }

            else
            {
                throw new FormatException($"Valor inválido en celda [{fila + 1},{col + 1}]: {valor}");
            }

            return resultado;
        }
    }
}
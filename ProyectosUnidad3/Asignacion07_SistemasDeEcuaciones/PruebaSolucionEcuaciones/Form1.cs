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

            // Limitar NumericUpDown para que solo se puedan poner a partir de matriz de 2x2 a 4x4 (se corrigió el máximo a 50):
            numericRows.Minimum = 2;
            numericRows.Maximum = 50;
            numericCols.Minimum = 2;
            numericCols.Maximum = 50;

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
            dgvMatriz.KeyDown += dgvMatriz_KeyDown;
        }



        // PERMITIR COPIAR Y PEGAR EN EL DATAGRIDVIEW:
        private void dgvMatriz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject dataObj = dgvMatriz.GetClipboardContent();
                if (dataObj != null) Clipboard.SetDataObject(dataObj);
                e.Handled = true;
            }

            if (e.Control && e.KeyCode == Keys.V)
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int row = dgvMatriz.CurrentCell.RowIndex;
                int col = dgvMatriz.CurrentCell.ColumnIndex;

                foreach (string line in lines)
                {
                    if (row >= dgvMatriz.RowCount) break;
                    string[] cells = line.Split('\t');
                    for (int i = 0; i < cells.Length && col + i < dgvMatriz.ColumnCount; i++)
                    {
                        dgvMatriz[col + i, row].Value = cells[i].Trim();
                    }
                    row++;
                }
                e.Handled = true;
            }
        }



        // FUNCIONALIDAD DEL BOTON ESTABLECER MATRIZ:
        private void btnEstabMatriz_Click(object sender, EventArgs e)
        {

            int filas = (int)numericRows.Value;
            int cols = (int)numericCols.Value;

            if (filas != cols)
            {
                MessageBox.Show("Para Gauss-Seidel, la matriz debe ser cuadrada (mismo número de ecuaciones e incógnitas).",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Limpiar columnas y filas anteriores:
            dgvMatriz.Columns.Clear();
            dgvMatriz.Rows.Clear();
            dgvMatriz.AllowUserToAddRows = false;


            // columnas dinámicas:
            for (int i = 0; i < cols; i++)
            {
                dgvMatriz.Columns.Add($"x{i + 1}", $"x{i + 1}".ToUpper());
            }

            dgvMatriz.Columns.Add("b", "B");


            for (int i = 0; i < filas; i++)
            {
                int rowIndex = dgvMatriz.Rows.Add();
                dgvMatriz.Rows[rowIndex].HeaderCell.Value = $"Eq {i + 1}";
            }

            dgvMatriz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMatriz.ReadOnly = false;
            dgvMatriz.Enabled = true;
            dgvMatriz.ClearSelection();
            rtbResultado.Clear();

            MessageBox.Show($"Matriz de {filas}x{cols} establecida correctamente. Ahora puede ingresar los datos.",
                            "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception)
            {
                MessageBox.Show($"Debe agregar valores a la matriz.",
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
                                "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception)
            {
                MessageBox.Show($"Debe agregar valores a la matriz.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // MÉTODO DE LECTURA DE MATRIZ DESDE DATAGRIDVIEW (DINÁMICO Y CON FRACCIONES):
        private double[,] LeerMatriz()
        {
            
            int filas = dgvMatriz.Rows.Cast<DataGridViewRow>()
                .Count(r => !r.IsNewRow);

            
            int cols = dgvMatriz.Columns.Count;

            
            if (filas == 0 || cols < 2)
                throw new Exception("Debe agregar valores a la matriz antes de continuar.");

            
            double[,] matriz = new double[filas, cols];

            
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string valor = dgvMatriz.Rows[i].Cells[j].Value?.ToString().Trim() ?? "0";
                    matriz[i, j] = ParseValor(valor, i, j);
                }
            }

            return matriz;
        }



        // MÉTODO PARA INTERPRETAR FRACCIONES O DECIMALES:
        private double ParseValor(string valor, int fila, int col)
        {
            double resultado;

            // Permitir fracciones:
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


        // FUNCIONALIDAD DEL BOTÓN GAUSS-SEIDEL:
        private void btnGaussSeidel_Click(object sender, EventArgs e)
        {
            if (dgvMatriz.Rows.Count == 0)
            {
                MessageBox.Show("Primero establezca la matriz antes de continuar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FormGaussSeidel formSeidel = new FormGaussSeidel();

                
                double[,] matriz = LeerMatriz();

                formSeidel.RecibirMatriz(matriz);
                formSeidel.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
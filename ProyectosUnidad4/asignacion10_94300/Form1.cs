using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace asignacion10_94300
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configurar controles al iniciar
            this.Load += Form1_Load;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            btnCalcular.Click += btnCalcular_Click;
        }

        // EVENTO AL CARGAR EL FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
            // Llenar tipos de regresión
            cmbTipo.Items.Add("Regresión Polinomial");
            cmbTipo.Items.Add("Regresión Lineal Múltiple");

            // Ocultar campos no usados al inicio
            nudGrado.Visible = false;
            nudVariables.Visible = false;

            // Configurar DataGridView
            dgvPuntos.AllowUserToAddRows = true;
            dgvPuntos.RowHeadersVisible = false;
            dgvPuntos.ColumnCount = 2;
            dgvPuntos.Columns[0].HeaderText = "X";
            dgvPuntos.Columns[1].HeaderText = "Y";

            // Agregar 10 filas vacías visibles
            for (int i = 0; i < 10; i++)
                dgvPuntos.Rows.Add();
        }

        // EVENTO AL CAMBIAR TIPO DE REGRESIÓN
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipo.SelectedItem.ToString();

            nudGrado.Visible = false;
            nudVariables.Visible = false;

            dgvPuntos.Columns.Clear();
            dgvPuntos.Rows.Clear();

            if (tipo == "Regresión Polinomial")
            {
                dgvPuntos.Columns.Add("X", "X");
                dgvPuntos.Columns.Add("Y", "Y");
                nudGrado.Visible = true;
                nudGrado.Value = 1;
            }
            else if (tipo == "Regresión Lineal Múltiple")
            {
                nudVariables.Visible = true;
                nudVariables.Value = 2;
                ConfigurarColumnasLinealMultiple((int)nudVariables.Value);
                nudVariables.ValueChanged -= nudVariables_ValueChanged;
                nudVariables.ValueChanged += nudVariables_ValueChanged;
            }

            // Mostrar siempre 10 filas vacías para capturar datos
            if (dgvPuntos.Rows.Count < 10)
            {
                for (int i = dgvPuntos.Rows.Count; i < 10; i++)
                    dgvPuntos.Rows.Add();
            }
        }

        // Método auxiliar: crea columnas dinámicas para lineal múltiple
        private void ConfigurarColumnasLinealMultiple(int numVars)
        {
            dgvPuntos.Columns.Clear();
            for (int i = 1; i <= numVars; i++)
                dgvPuntos.Columns.Add($"X{i}", $"X{i}");
            dgvPuntos.Columns.Add("Y", "Y");
        }

        // Evento al cambiar número de variables
        private void nudVariables_ValueChanged(object sender, EventArgs e)
        {
            ConfigurarColumnasLinealMultiple((int)nudVariables.Value);
        }

        // -------- BOTÓN CALCULAR --------
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de regresión.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvPuntos.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese al menos un punto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipo = cmbTipo.SelectedItem.ToString();
            var regresion = new implementacion.RegresionMinCuad();

            try
            {
                // Limpiar resultados previos
                rtbResultado.Clear();
                dgvMatriz.DataSource = null;

                // Leer los puntos desde el DataGridView
                double[][] puntos = LeerPuntos();

                (string ecuacion, DataTable matriz) resultado;

                if (tipo == "Regresión Polinomial")
                {
                    int grado = (int)nudGrado.Value;
                    resultado = regresion.RegresionPolinomial(puntos, grado);
                }
                else
                {
                    resultado = regresion.RegresionLinealMultiple(puntos);
                }

                // Mostrar resultados
                dgvMatriz.DataSource = resultado.matriz;
                rtbResultado.Text = resultado.ecuacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método auxiliar: leer puntos del DataGridView
        private double[][] LeerPuntos()
        {
            var lista = new List<double[]>();

            foreach (DataGridViewRow fila in dgvPuntos.Rows)
            {
                if (fila.IsNewRow) continue;

                List<double> valores = new List<double>();
                bool valido = true;

                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value == null || !double.TryParse(celda.Value.ToString(), out double v))
                    {
                        valido = false;
                        break;
                    }
                    valores.Add(v);
                }

                if (valido)
                    lista.Add(valores.ToArray());
            }

            if (lista.Count == 0)
                throw new Exception("No hay datos válidos en la tabla.");

            return lista.ToArray();
        }
    }
}
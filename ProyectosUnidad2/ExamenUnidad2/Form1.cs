using System;
using System.Windows.Forms;

namespace ExamenUnidad2
{
    public partial class Form1 : Form
    {
        // INSTANCIA DE LA CLASE CON LOS MÉTODOS:
        private Implementaciones.MetodosRaices mr;

        public Form1()
        {
            InitializeComponent();

            dgvResultados.RowHeadersVisible = false;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            mr = new Implementaciones.MetodosRaices();

            // OPCIONES DE MÉTODOS:
            cmbMetodo.Items.Add("Bisección");
            cmbMetodo.Items.Add("Regla Falsa");
            cmbMetodo.Items.Add("Newton-Raphson");
            cmbMetodo.Items.Add("Secante");
            cmbMetodo.SelectedIndex = 0;

            // OPCIONES DE FUNCIONES:
            cmbFuncion.Items.Add("f(x) = 4x³ - 6x² + 7x - 2.3");
            cmbFuncion.Items.Add("f(x) = x² * √|cos(x)| - 5");
            cmbFuncion.Items.Add("f(x) = e^x");
            cmbFuncion.Items.Add("f(x) = ln(x+3)²");
            cmbFuncion.Items.Add("f(x) = ln(x) / x");
            cmbFuncion.SelectedIndex = 0;

            // Configurar columnas por defecto (Bisección)
            ConfigurarColumnas("Bisección");
        }

        // Configura las columnas según el método
        private void ConfigurarColumnas(string metodo)
        {
            foreach (DataGridViewColumn col in dgvResultados.Columns)
                col.Visible = false;

            dgvResultados.Columns["Iteracion"].Visible = true;

            switch (metodo)
            {
                case "Bisección":
                    dgvResultados.Columns["Xi"].Visible = true;
                    dgvResultados.Columns["Xf"].Visible = true;
                    dgvResultados.Columns["Xr"].Visible = true;
                    dgvResultados.Columns["Fxi"].Visible = true;
                    dgvResultados.Columns["Fxr"].Visible = true;
                    dgvResultados.Columns["fxiporfxr"].Visible = true;
                    dgvResultados.Columns["Ea"].Visible = true;
                    break;

                case "Regla Falsa":
                    dgvResultados.Columns["Xi"].Visible = true;
                    dgvResultados.Columns["Xf"].Visible = true;
                    dgvResultados.Columns["Xr"].Visible = true;
                    dgvResultados.Columns["Fxi"].Visible = true;
                    dgvResultados.Columns["Fxf"].Visible = true;
                    dgvResultados.Columns["Fxr"].Visible = true;
                    dgvResultados.Columns["fxiporfxr"].Visible = true;
                    dgvResultados.Columns["Ea"].Visible = true;
                    break;

                case "Newton-Raphson":
                    dgvResultados.Columns["Xi"].Visible = true;
                    dgvResultados.Columns["Fxi"].Visible = true;
                    dgvResultados.Columns["DerivadaX"].Visible = true;
                    dgvResultados.Columns["Ea"].Visible = true;
                    break;

                case "Secante":
                    dgvResultados.Columns["X1"].Visible = true;
                    dgvResultados.Columns["X2"].Visible = true;
                    dgvResultados.Columns["FX1"].Visible = true;
                    dgvResultados.Columns["FX2"].Visible = true;
                    dgvResultados.Columns["Xr"].Visible = true;
                    dgvResultados.Columns["Ea"].Visible = true;
                    break;
            }
        }


        // Cambiar campos habilitados según método:
        private void cmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilitar/deshabilitar campos según método
            txtXi.Enabled = true;
            txtXf.Enabled = true;

            if (cmbMetodo.SelectedIndex == 2) // Newton-Raphson
                txtXf.Enabled = false;

            ConfigurarColumnas(cmbMetodo.SelectedItem.ToString());
        }


        // FUNCIONALIDAD DEL BOTON "CALCULAR":
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtXi.Text) ||
                    string.IsNullOrWhiteSpace(txtEmax.Text) ||
                    string.IsNullOrWhiteSpace(txtDecimales.Text) ||
                    (cmbMetodo.SelectedIndex != 2 && string.IsNullOrWhiteSpace(txtXf.Text)))
                {
                    MessageBox.Show("Debes ingresar todos los valores requeridos.",
                        "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Leer datos
                double xi = double.Parse(txtXi.Text);
                double xf = string.IsNullOrWhiteSpace(txtXf.Text) ? 0 : double.Parse(txtXf.Text);
                double emax = double.Parse(txtEmax.Text);
                int decimales = int.Parse(txtDecimales.Text);
                string formato = "F" + decimales;


                // Función seleccionada
                var f = mr.SeleccionarFuncion(cmbFuncion.SelectedIndex);
                var df = (cmbMetodo.SelectedIndex == 2) ? mr.SeleccionarDerivada(cmbFuncion.SelectedIndex) : null;

                double raiz = 0;


                // Elegir método
                switch (cmbMetodo.SelectedIndex)
                {
                    case 0: raiz = mr.Biseccion(f, xi, xf, emax); break;
                    case 1: raiz = mr.ReglaFalsa(f, xi, xf, emax); break;
                    case 2: raiz = mr.NewtonRaphson(f, df, xi, emax); break;
                    case 3: raiz = mr.Secante(f, xi, xf, emax); break;
                }


                // Mostrar resultados en DataGridView
                dgvResultados.Rows.Clear();

                ConfigurarColumnas(cmbMetodo.SelectedItem.ToString());

                foreach (var it in mr.Iteraciones)
                {
                    int rowIndex = dgvResultados.Rows.Add();
                    var row = dgvResultados.Rows[rowIndex];

                    // Columna de iteración
                    row.Cells["Iteracion"].Value = it.Numero;

                    // Bisección / Regla falsa
                    row.Cells["Xi"].Value = it.Xi?.ToString(formato);
                    row.Cells["Xf"].Value = it.Xf?.ToString(formato);
                    row.Cells["Xr"].Value = it.Xr?.ToString(formato);
                    row.Cells["Fxi"].Value = it.Fxi?.ToString(formato);
                    row.Cells["Fxf"].Value = it.Fxf?.ToString(formato);
                    row.Cells["Fxr"].Value = it.Fxr?.ToString(formato);
                    row.Cells["fxiporfxr"].Value = it.FxiporFxr?.ToString(formato);

                    // Newton
                    row.Cells["DerivadaX"].Value = it.DerivadaX?.ToString(formato);

                    // Secante
                    row.Cells["X1"].Value = it.X1?.ToString(formato);
                    row.Cells["X2"].Value = it.X2?.ToString(formato);
                    row.Cells["FX1"].Value = it.FX1?.ToString(formato);
                    row.Cells["FX2"].Value = it.FX2?.ToString(formato);

                    // Error
                    row.Cells["Ea"].Value = it.Ea.HasValue ? it.Ea.Value.ToString(formato) + "%" : "";
                }


                // Mensaje de confirmación
                MessageBox.Show($"✔️ {cmbMetodo.SelectedItem}\nRaíz: {raiz.ToString(formato)}\n" +
                                $"f(raíz) = {f(raiz).ToString("F" + decimales)}\n" +
                                $"Iteraciones: {mr.Iteraciones.Count}",
                                "Cálculo completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Ingresa solo valores numéricos.",
                    "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // FUNCIONALIDAD DEL BOTON "COMPARAR":
        private void btnComparar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtXi.Text) ||
                    string.IsNullOrWhiteSpace(txtXf.Text) ||
                    string.IsNullOrWhiteSpace(txtEmax.Text) ||
                    string.IsNullOrWhiteSpace(txtDecimales.Text))
                {
                    MessageBox.Show("Debes ingresar todos los valores requeridos.",
                        "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double xi = double.Parse(txtXi.Text);
                double xf = double.Parse(txtXf.Text);
                double emax = double.Parse(txtEmax.Text);
                int decimales = int.Parse(txtDecimales.Text);
                string formato = "F" + decimales;

                var f = mr.SeleccionarFuncion(cmbFuncion.SelectedIndex);
                var df = mr.SeleccionarDerivada(cmbFuncion.SelectedIndex);

                // Obtener resultados
                var comparacion = mr.CompararTodos(f, df, xi, xf, emax, decimales);

                // Configurar columnas visibles solo para la comparación
                foreach (DataGridViewColumn col in dgvResultados.Columns)
                    col.Visible = false;

                dgvResultados.Columns["Metodo"].Visible = true;
                dgvResultados.Columns["Iteraciones"].Visible = true;
                dgvResultados.Columns["Raiz"].Visible = true;
                dgvResultados.Columns["YRaiz"].Visible = true;
                dgvResultados.Columns["Eaproximado"].Visible = true;

                // Mostrar resultados
                dgvResultados.Rows.Clear();

                foreach (var it in comparacion)
                {
                    int rowIndex = dgvResultados.Rows.Add();
                    var row = dgvResultados.Rows[rowIndex];

                    // Solo mostramos las columnas de comparación
                    row.Cells["Metodo"].Value = it.Metodo;
                    row.Cells["Iteraciones"].Value = it.Iteraciones;
                    row.Cells["Raiz"].Value = it.Raiz?.ToString(formato);
                    row.Cells["YRaiz"].Value = it.YRaiz?.ToString(formato);
                    row.Cells["Eaproximado"].Value = it.Eaproximado?.ToString(formato) + "%";
                }

                MessageBox.Show("Comparación realizada con éxito.",
                    "Comparación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
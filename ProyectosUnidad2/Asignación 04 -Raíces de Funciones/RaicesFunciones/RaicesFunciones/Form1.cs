using RaicesFunciones.Implementaciones;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RaicesFunciones
{
    public partial class Form1 : Form
    {
        private Implementaciones.RaicesFunciones rf;

        public Form1()
        {
            InitializeComponent();
            rf = new Implementaciones.RaicesFunciones();


            // OPCIONES EN EL COMBOBOX:
            cmbMetodo.Items.Add("Método de Bisección");
            cmbMetodo.Items.Add("Método de la Regla Falsa");
            cmbMetodo.SelectedIndex = 0;



            // CONFIGURACION DE DATAGRIDVIEW:
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvResultados.RowHeadersVisible = false;
        }



        // FUNCIONALIDAD DEL BOTON "CALCULAR":
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // VALIDACION DE ENTRADA:
            try
            {
                if (string.IsNullOrWhiteSpace(txtXi.Text) ||
                    string.IsNullOrWhiteSpace(txtXf.Text) ||
                    string.IsNullOrWhiteSpace(txtEmax.Text))
                {
                    MessageBox.Show("Debes agregar valores en todos los campos.",
                        "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                // DATOS DE ENTRADA
                double xi = double.Parse(txtXi.Text);
                double xf = double.Parse(txtXf.Text);
                double emax = double.Parse(txtEmax.Text);
                int decimales = int.Parse(txtDecimales.Text);
                string formato = "F" + decimales;

                Func<double, double> funcion;
                List<Iteracion> tabla;



                // SELECCION DEL METODO Y LA FUNCION CORRESPONDIENTE:
                if (cmbMetodo.SelectedIndex == 0)
                {
                    // Ejemplo de la función de la actividad 03 :  y = 4x³- 6x² + 7x - 2.3:
                    funcion = x => 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;
                    tabla = rf.BiseccionTabla(funcion, xi, xf, emax);
                }
                else
                {
                    //Hacemos la función de la actividad 03 :  y = x² * √|cos(x)| - 5 en un lambda:
                    funcion = x => Math.Pow(x, 2) * Math.Sqrt(Math.Abs(Math.Cos(x))) - 5;
                    tabla = rf.ReglaFalsaTabla(funcion, xi, xf, emax); // ← la pasamos como parametro "g"
                }



                // MOSTRAR RESULTADOS EN EL DATAGRIDVIEW:
                dgvResultados.Rows.Clear();
                foreach (var it in tabla)
                {
                    dgvResultados.Rows.Add(
                        it.N,
                        it.Xi.ToString(formato),
                        it.Xf.ToString(formato),
                        it.Xr.ToString(formato),
                        it.Fxi.ToString(formato),
                        it.Fxf.ToString(formato),
                        it.Fxr.ToString(formato),
                        it.Producto.ToString(formato),
                        it.Ea.ToString(formato) + "%"
                    );
                }
            }

            // MANEJO DE ERRORES:
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

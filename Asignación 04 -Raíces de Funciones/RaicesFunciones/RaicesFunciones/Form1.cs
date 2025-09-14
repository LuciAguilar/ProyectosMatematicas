using System;
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
        }

        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtXi.Text) ||
                    string.IsNullOrWhiteSpace(txtXf.Text) ||
                    string.IsNullOrWhiteSpace(txtEmax.Text) ||
                    string.IsNullOrWhiteSpace(txtDecimales.Text))
                {
                    MessageBox.Show("Debes agregar valores en todos los campos.",
                        "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // DATOS DE ENTRADA:
                double xi = double.Parse(txtXi.Text);
                double xf = double.Parse(txtXf.Text);
                double emax = double.Parse(txtEmax.Text);
                int decimales = int.Parse(txtDecimales.Text);


                Func<double, double> funcion;
                double raiz = 0;

                // Selección del método y de la función correspondiente
                if (cmbMetodo.SelectedIndex == 0)
                {

                    // Ejemplo de la función de la actividad 03 :  y = 4x³- 6x² + 7x - 2.3:
                    funcion = x => 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;
                    raiz = rf.Biseccion(funcion, xi, xf, emax);

                }
                else // Regla Falsa → función trigonométrica
                {

                    //Hacemos la función de la actividad 03 :  y = x² * √|cos(x)| - 5 en un lambda:
                    funcion = x => Math.Pow(x, 2) * Math.Sqrt(Math.Abs(Math.Cos(x))) - 5;
                    raiz = rf.ReglaFalsa(funcion, xi, xf, emax); // ← la pasamos como parametro "g"

                }

                string formato = "F" + decimales;

                // RESULTADOS
                rtbResultados.Text = $"Método: {cmbMetodo.SelectedItem}\n" +
                                     $"Raíz encontrada: {raiz.ToString(formato)}\n" +
                                     $"f(raíz) = {funcion(raiz).ToString(formato)}\n" +
                                     $"Iteraciones: {rf.GetIteraciones()}\n" +
                                     $"Error aproximado: {rf.GetError():F4}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos, se aceptan solo números: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Para limpiar los campos de texto cuando se cierra el mensaje de Error:
            txtXi.Clear();
            txtXf.Clear();
            txtEmax.Clear();
            txtDecimales.Clear();
        }
    }
}

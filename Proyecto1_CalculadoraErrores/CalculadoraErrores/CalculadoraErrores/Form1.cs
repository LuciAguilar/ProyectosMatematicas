using CalculadoraErrores.Implementaciones;
using System;
using System.Windows.Forms;

namespace CalculadoraErrores
{
    public partial class Form1 : Form
    {
        private Errores errores;

        public Form1()
        {
            InitializeComponent();
            errores = new Errores();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double valorVerdadero = double.Parse(txtValorVerdadero.Text);
                double valorAproximado = double.Parse(txtValorAprox.Text);

                string resultado = errores.Calcular(valorVerdadero, valorAproximado);
                rtbResultados.Text = resultado;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos, se aceptan solo números: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Para limpiar los campos de texto cuando se cierra el mensaje de Error:
            txtValorAprox.Clear();
            txtValorVerdadero.Clear();
        }

        private void txt_valor_Click(object sender, EventArgs e)
        {

        }


    }
}

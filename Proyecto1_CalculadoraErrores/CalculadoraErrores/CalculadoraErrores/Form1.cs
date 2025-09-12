using CalculadoraErrores.Implementaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                MessageBox.Show("Error en los datos: " + ex.Message);
            }
        }

        private void txt_valor_Click(object sender, EventArgs e)
        {

        }

        
    }
}

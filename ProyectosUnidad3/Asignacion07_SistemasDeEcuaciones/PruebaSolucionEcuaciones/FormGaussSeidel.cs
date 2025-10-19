using PruebaSolucionEcuaciones.Implementaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSolucionEcuaciones
{
    public partial class FormGaussSeidel : Form
    {

        private double[,] matrizActual; // <- almacenamos la matriz recibida
        private SolucionEcuaciones solver = new SolucionEcuaciones();

        public FormGaussSeidel()
        {
            InitializeComponent();
        }

        public void RecibirMatriz(double[,] matriz)
        {
            matrizActual = matriz;
        }



        // FUNCIONALIDAD DEL BOTÓN "CALCULAR":
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrizActual == null)
                {
                    MessageBox.Show("No se ha recibido ninguna matriz.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!double.TryParse(txtErrorMaximo.Text, out double errorMax))
                {
                    MessageBox.Show("Ingrese un valor numérico válido para el error máximo.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (errorMax <= 0)
                {
                    MessageBox.Show("El error máximo debe ser mayor que cero.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                solver.GaussSeidel(matrizActual, errorMax, dgvIteraciones);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

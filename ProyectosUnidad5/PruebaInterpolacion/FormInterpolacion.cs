using PruebaInterpolacion.implementaciones;
using System;
using System.Windows.Forms;

namespace PruebaInterpolacion
{
    public partial class FormInterpolacion : Form
    {
        Interpolacion interp = new Interpolacion();

        public FormInterpolacion()
        {
            InitializeComponent();
            txtGrado.KeyPress += SoloNumeros;
            txtX.KeyPress += SoloNumeros;
            dgvPuntos.EditingControlShowing += dgvPuntos_EditingControlShowing;
        }



        /// <summary>
        /// Evento del botón para realizar la interpolación de Lagrange.
        /// </summary>
        private void btnInterpolarLagrange_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtGrado.Text);
                double x = double.Parse(txtX.Text);
                double[,] puntos = new double[n + 1, 2];

                for (int i = 0; i <= n; i++)
                {
                    puntos[i, 0] = Convert.ToDouble(dgvPuntos.Rows[i].Cells[0].Value);
                    puntos[i, 1] = Convert.ToDouble(dgvPuntos.Rows[i].Cells[1].Value);
                }

                interp.InterpolacionLagrange(puntos, n, x, rtbResultado);
            }
            catch
            {
                MessageBox.Show("Verifica que todos los campos estén correctamente llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Evento del botón para realizar la interpolación de Newton.
        /// </summary>
        private void btnInterpolarNewton_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtGrado.Text);
                double x = double.Parse(txtX.Text);
                double[,] puntos = new double[n + 1, 2];

                for (int i = 0; i <= n; i++)
                {
                    puntos[i, 0] = Convert.ToDouble(dgvPuntos.Rows[i].Cells[0].Value);
                    puntos[i, 1] = Convert.ToDouble(dgvPuntos.Rows[i].Cells[1].Value);
                }

                interp.InterpolacionNewton(puntos, n, x, rtbResultado);
            }
            catch
            {
                MessageBox.Show("Verifica los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Evento del botón para limpiar los campos de entrada y salida.
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtGrado.Clear();
            txtX.Clear();
            rtbResultado.Clear();
            dgvPuntos.Rows.Clear();
        }



        /// <summary>
        /// Evento para permitir solo la entrada de números en los TextBox.
        /// </summary>
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Contains("."))
                e.Handled = true;
        }



        /// <summary>
        /// Evento para manejar la edición en el DataGridView y permitir solo números.
        /// </summary>
        private void dgvPuntos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox txt)
            {
                txt.KeyPress -= SoloNumeros;
                txt.KeyPress += SoloNumeros;
            }
        }
    }
}
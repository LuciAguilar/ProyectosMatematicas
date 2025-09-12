namespace CalculadoraErrores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblVerdadero = new System.Windows.Forms.Label();
            this.txtValorVerdadero = new System.Windows.Forms.TextBox();
            this.txtValorAprox = new System.Windows.Forms.TextBox();
            this.lblAproximado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblVerdadero
            // 
            this.lblVerdadero.AutoSize = true;
            this.lblVerdadero.BackColor = System.Drawing.Color.Transparent;
            this.lblVerdadero.Font = new System.Drawing.Font("Bunya PERSONAL", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerdadero.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblVerdadero.Location = new System.Drawing.Point(20, 39);
            this.lblVerdadero.Name = "lblVerdadero";
            this.lblVerdadero.Size = new System.Drawing.Size(141, 25);
            this.lblVerdadero.TabIndex = 0;
            this.lblVerdadero.Text = "Valor verdadero";
            this.lblVerdadero.Click += new System.EventHandler(this.txt_valor_Click);
            // 
            // txtValorVerdadero
            // 
            this.txtValorVerdadero.BackColor = System.Drawing.Color.GhostWhite;
            this.txtValorVerdadero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVerdadero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVerdadero.Location = new System.Drawing.Point(182, 39);
            this.txtValorVerdadero.Name = "txtValorVerdadero";
            this.txtValorVerdadero.Size = new System.Drawing.Size(182, 26);
            this.txtValorVerdadero.TabIndex = 1;
            // 
            // txtValorAprox
            // 
            this.txtValorAprox.BackColor = System.Drawing.Color.GhostWhite;
            this.txtValorAprox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorAprox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAprox.Location = new System.Drawing.Point(182, 95);
            this.txtValorAprox.Name = "txtValorAprox";
            this.txtValorAprox.Size = new System.Drawing.Size(182, 26);
            this.txtValorAprox.TabIndex = 2;
            // 
            // lblAproximado
            // 
            this.lblAproximado.AutoSize = true;
            this.lblAproximado.BackColor = System.Drawing.Color.Transparent;
            this.lblAproximado.Font = new System.Drawing.Font("Bunya PERSONAL", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAproximado.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblAproximado.Location = new System.Drawing.Point(20, 97);
            this.lblAproximado.Name = "lblAproximado";
            this.lblAproximado.Size = new System.Drawing.Size(156, 25);
            this.lblAproximado.TabIndex = 3;
            this.lblAproximado.Text = "Valor aproximado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Lavender;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnCalcular.FlatAppearance.BorderSize = 3;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Bunya PERSONAL", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCalcular.Image = global::CalculadoraErrores.Properties.Resources.calculadora;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCalcular.Location = new System.Drawing.Point(154, 178);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 47);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rtbResultados
            // 
            this.rtbResultados.BackColor = System.Drawing.Color.GhostWhite;
            this.rtbResultados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResultados.Location = new System.Drawing.Point(57, 264);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.Size = new System.Drawing.Size(307, 153);
            this.rtbResultados.TabIndex = 5;
            this.rtbResultados.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::CalculadoraErrores.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.rtbResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAproximado);
            this.Controls.Add(this.txtValorAprox);
            this.Controls.Add(this.txtValorVerdadero);
            this.Controls.Add(this.lblVerdadero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de errores absolutos y relativos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerdadero;
        private System.Windows.Forms.TextBox txtValorVerdadero;
        private System.Windows.Forms.TextBox txtValorAprox;
        private System.Windows.Forms.Label lblAproximado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox rtbResultados;
    }
}


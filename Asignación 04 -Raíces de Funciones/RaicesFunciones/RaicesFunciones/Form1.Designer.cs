namespace RaicesFunciones
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDecimales = new System.Windows.Forms.TextBox();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.BackgroundImage = global::RaicesFunciones.Properties.Resources.boton;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Location = new System.Drawing.Point(247, 259);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 47);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtXi
            // 
            this.txtXi.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXi.Location = new System.Drawing.Point(247, 86);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(134, 28);
            this.txtXi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(65, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor inicial (xi)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(75, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor final (xf)";
            // 
            // txtXf
            // 
            this.txtXf.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXf.Location = new System.Drawing.Point(247, 120);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(134, 28);
            this.txtXf.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Error máximo (εmáx)";
            // 
            // txtEmax
            // 
            this.txtEmax.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmax.Location = new System.Drawing.Point(247, 154);
            this.txtEmax.Name = "txtEmax";
            this.txtEmax.Size = new System.Drawing.Size(134, 28);
            this.txtEmax.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(133, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Método";
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Location = new System.Drawing.Point(247, 46);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(232, 29);
            this.cmbMetodo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label5.Location = new System.Drawing.Point(116, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Decimales";
            // 
            // txtDecimales
            // 
            this.txtDecimales.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimales.Location = new System.Drawing.Point(247, 190);
            this.txtDecimales.Name = "txtDecimales";
            this.txtDecimales.Size = new System.Drawing.Size(134, 28);
            this.txtDecimales.TabIndex = 10;
            // 
            // rtbResultados
            // 
            this.rtbResultados.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.rtbResultados.Location = new System.Drawing.Point(149, 312);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.Size = new System.Drawing.Size(298, 115);
            this.rtbResultados.TabIndex = 11;
            this.rtbResultados.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(574, 445);
            this.Controls.Add(this.rtbResultados);
            this.Controls.Add(this.txtDecimales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMetodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtXf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.btnCalcular);
            this.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bisección y Regla Falsa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDecimales;
        private System.Windows.Forms.RichTextBox rtbResultados;
    }
}


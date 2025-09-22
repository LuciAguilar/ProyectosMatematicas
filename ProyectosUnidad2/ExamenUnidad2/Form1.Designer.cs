namespace ExamenUnidad2
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
            System.Windows.Forms.Label lblFuncion;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fxf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fxr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DerivadaX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fx1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fx2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxiporfxr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iteraciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YRaiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eaproximado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDecimales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.cmbFuncion = new System.Windows.Forms.ComboBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            lblFuncion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFuncion.ForeColor = System.Drawing.Color.DarkSlateGray;
            lblFuncion.Location = new System.Drawing.Point(13, 80);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new System.Drawing.Size(91, 27);
            lblFuncion.TabIndex = 24;
            lblFuncion.Text = "Función";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.Xi,
            this.Xf,
            this.Xr,
            this.Fxi,
            this.Fxf,
            this.Fxr,
            this.DerivadaX,
            this.x1,
            this.x2,
            this.Fx1,
            this.Fx2,
            this.fxiporfxr,
            this.Ea,
            this.Metodo,
            this.Iteraciones,
            this.Raiz,
            this.YRaiz,
            this.Eaproximado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultados.EnableHeadersVisualStyles = false;
            this.dgvResultados.Location = new System.Drawing.Point(397, 12);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResultados.Size = new System.Drawing.Size(760, 605);
            this.dgvResultados.TabIndex = 23;
            // 
            // Iteracion
            // 
            this.Iteracion.HeaderText = "Iteración";
            this.Iteracion.Name = "Iteracion";
            this.Iteracion.ReadOnly = true;
            // 
            // Xi
            // 
            this.Xi.HeaderText = "Xi";
            this.Xi.Name = "Xi";
            this.Xi.ReadOnly = true;
            // 
            // Xf
            // 
            this.Xf.HeaderText = "Xf";
            this.Xf.Name = "Xf";
            this.Xf.ReadOnly = true;
            // 
            // Xr
            // 
            this.Xr.HeaderText = "Xr";
            this.Xr.Name = "Xr";
            this.Xr.ReadOnly = true;
            // 
            // Fxi
            // 
            this.Fxi.HeaderText = "F(Xi)";
            this.Fxi.Name = "Fxi";
            this.Fxi.ReadOnly = true;
            // 
            // Fxf
            // 
            this.Fxf.HeaderText = "F(Xf)";
            this.Fxf.Name = "Fxf";
            this.Fxf.ReadOnly = true;
            // 
            // Fxr
            // 
            this.Fxr.HeaderText = "F(Xr)";
            this.Fxr.Name = "Fxr";
            this.Fxr.ReadOnly = true;
            // 
            // DerivadaX
            // 
            this.DerivadaX.HeaderText = "F\'(x)";
            this.DerivadaX.Name = "DerivadaX";
            this.DerivadaX.ReadOnly = true;
            // 
            // x1
            // 
            this.x1.HeaderText = "X1";
            this.x1.Name = "x1";
            this.x1.ReadOnly = true;
            // 
            // x2
            // 
            this.x2.HeaderText = "X2";
            this.x2.Name = "x2";
            this.x2.ReadOnly = true;
            // 
            // Fx1
            // 
            this.Fx1.HeaderText = "F(X1)";
            this.Fx1.Name = "Fx1";
            this.Fx1.ReadOnly = true;
            // 
            // Fx2
            // 
            this.Fx2.HeaderText = "F(X2)";
            this.Fx2.Name = "Fx2";
            this.Fx2.ReadOnly = true;
            // 
            // fxiporfxr
            // 
            this.fxiporfxr.HeaderText = "F(Xi)*F(Xr)";
            this.fxiporfxr.Name = "fxiporfxr";
            this.fxiporfxr.ReadOnly = true;
            // 
            // Ea
            // 
            this.Ea.HeaderText = "Ea (%)";
            this.Ea.Name = "Ea";
            this.Ea.ReadOnly = true;
            // 
            // Metodo
            // 
            this.Metodo.HeaderText = "Método";
            this.Metodo.Name = "Metodo";
            this.Metodo.ReadOnly = true;
            // 
            // Iteraciones
            // 
            this.Iteraciones.HeaderText = "Iteraciones";
            this.Iteraciones.Name = "Iteraciones";
            this.Iteraciones.ReadOnly = true;
            // 
            // Raiz
            // 
            this.Raiz.HeaderText = "Raíz";
            this.Raiz.Name = "Raiz";
            this.Raiz.ReadOnly = true;
            // 
            // YRaiz
            // 
            this.YRaiz.HeaderText = "Y(Raíz)";
            this.YRaiz.Name = "YRaiz";
            this.YRaiz.ReadOnly = true;
            // 
            // Eaproximado
            // 
            this.Eaproximado.HeaderText = "Error Aproximado";
            this.Eaproximado.Name = "Eaproximado";
            this.Eaproximado.ReadOnly = true;
            // 
            // txtDecimales
            // 
            this.txtDecimales.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimales.Location = new System.Drawing.Point(241, 326);
            this.txtDecimales.Name = "txtDecimales";
            this.txtDecimales.Size = new System.Drawing.Size(134, 28);
            this.txtDecimales.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label5.Location = new System.Drawing.Point(12, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 27);
            this.label5.TabIndex = 21;
            this.label5.Text = "Decimales";
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Location = new System.Drawing.Point(121, 12);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(256, 29);
            this.cmbMetodo.TabIndex = 20;
            this.cmbMetodo.SelectedIndexChanged += new System.EventHandler(this.cmbMetodo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "Método";
            // 
            // txtEmax
            // 
            this.txtEmax.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmax.Location = new System.Drawing.Point(243, 266);
            this.txtEmax.Name = "txtEmax";
            this.txtEmax.Size = new System.Drawing.Size(134, 28);
            this.txtEmax.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(12, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Error máximo (εmáx)";
            // 
            // txtXf
            // 
            this.txtXf.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXf.Location = new System.Drawing.Point(243, 209);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(134, 28);
            this.txtXf.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(13, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Valor final (xf)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(13, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Valor inicial (xi)";
            // 
            // txtXi
            // 
            this.txtXi.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXi.Location = new System.Drawing.Point(243, 151);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(134, 28);
            this.txtXi.TabIndex = 13;
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncion.FormattingEnabled = true;
            this.cmbFuncion.Location = new System.Drawing.Point(121, 78);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(256, 26);
            this.cmbFuncion.TabIndex = 25;
            // 
            // btnComparar
            // 
            this.btnComparar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnComparar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnComparar.FlatAppearance.BorderSize = 2;
            this.btnComparar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnComparar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnComparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComparar.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.ForeColor = System.Drawing.Color.Black;
            this.btnComparar.Image = global::ExamenUnidad2.Properties.Resources.comparar;
            this.btnComparar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComparar.Location = new System.Drawing.Point(219, 558);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(156, 58);
            this.btnComparar.TabIndex = 26;
            this.btnComparar.TabStop = false;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComparar.UseVisualStyleBackColor = false;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnCalcular.FlatAppearance.BorderSize = 2;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Image = global::ExamenUnidad2.Properties.Resources.calculadora;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(31, 559);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 58);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.TabStop = false;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1166, 641);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.cmbFuncion);
            this.Controls.Add(lblFuncion);
            this.Controls.Add(this.dgvResultados);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.TextBox txtDecimales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmbFuncion;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fxf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fxr;
        private System.Windows.Forms.DataGridViewTextBoxColumn DerivadaX;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fx2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxiporfxr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn YRaiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eaproximado;
    }
}


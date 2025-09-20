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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.A1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.J1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.BackgroundImage = global::RaicesFunciones.Properties.Resources.boton;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Location = new System.Drawing.Point(389, 264);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 47);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.TabStop = false;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtXi
            // 
            this.txtXi.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXi.Location = new System.Drawing.Point(234, 142);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(134, 28);
            this.txtXi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(52, 193);
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
            this.label2.Location = new System.Drawing.Point(62, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor final (xf)";
            // 
            // txtXf
            // 
            this.txtXf.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXf.Location = new System.Drawing.Point(234, 193);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(134, 28);
            this.txtXf.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(403, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Error máximo (εmáx)";
            // 
            // txtEmax
            // 
            this.txtEmax.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmax.Location = new System.Drawing.Point(635, 142);
            this.txtEmax.Name = "txtEmax";
            this.txtEmax.Size = new System.Drawing.Size(134, 28);
            this.txtEmax.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(268, 46);
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
            this.cmbMetodo.Location = new System.Drawing.Point(375, 42);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(232, 29);
            this.cmbMetodo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label5.Location = new System.Drawing.Point(507, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Decimales";
            // 
            // txtDecimales
            // 
            this.txtDecimales.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimales.Location = new System.Drawing.Point(635, 190);
            this.txtDecimales.Name = "txtDecimales";
            this.txtDecimales.Size = new System.Drawing.Size(134, 28);
            this.txtDecimales.TabIndex = 10;
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A1,
            this.B1,
            this.C1,
            this.D1,
            this.E1,
            this.J1,
            this.F1,
            this.G1,
            this.H1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultados.EnableHeadersVisualStyles = false;
            this.dgvResultados.Location = new System.Drawing.Point(12, 328);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResultados.Size = new System.Drawing.Size(843, 346);
            this.dgvResultados.TabIndex = 11;
            // 
            // A1
            // 
            this.A1.HeaderText = "Iteración";
            this.A1.Name = "A1";
            this.A1.ReadOnly = true;
            // 
            // B1
            // 
            this.B1.HeaderText = "Xi";
            this.B1.Name = "B1";
            this.B1.ReadOnly = true;
            // 
            // C1
            // 
            this.C1.HeaderText = "Xf";
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            // 
            // D1
            // 
            this.D1.HeaderText = "Xr";
            this.D1.Name = "D1";
            this.D1.ReadOnly = true;
            // 
            // E1
            // 
            this.E1.HeaderText = "f(Xi)";
            this.E1.Name = "E1";
            this.E1.ReadOnly = true;
            // 
            // J1
            // 
            this.J1.HeaderText = "f(Xf)";
            this.J1.Name = "J1";
            this.J1.ReadOnly = true;
            // 
            // F1
            // 
            this.F1.HeaderText = "f(Xr)";
            this.F1.Name = "F1";
            this.F1.ReadOnly = true;
            // 
            // G1
            // 
            this.G1.HeaderText = "f(Xi)*f(Xr)";
            this.G1.Name = "G1";
            this.G1.ReadOnly = true;
            // 
            // H1
            // 
            this.H1.HeaderText = "Ea (error relativo)";
            this.H1.Name = "H1";
            this.H1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(867, 686);
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
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bisección y Regla Falsa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn A1;
        private System.Windows.Forms.DataGridViewTextBoxColumn B1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D1;
        private System.Windows.Forms.DataGridViewTextBoxColumn E1;
        private System.Windows.Forms.DataGridViewTextBoxColumn J1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F1;
        private System.Windows.Forms.DataGridViewTextBoxColumn G1;
        private System.Windows.Forms.DataGridViewTextBoxColumn H1;
    }
}


namespace asignacion10_94300
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.nudGrado = new System.Windows.Forms.NumericUpDown();
            this.nudVariables = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.lblEcuacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Louis George Cafe", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(18, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(352, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ajuste por Mínimos Cuadrados";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Louis George Cafe", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(12, 73);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(188, 25);
            this.cmbTipo.TabIndex = 1;
            // 
            // nudGrado
            // 
            this.nudGrado.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.nudGrado.Font = new System.Drawing.Font("Louis George Cafe", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGrado.Location = new System.Drawing.Point(206, 71);
            this.nudGrado.Name = "nudGrado";
            this.nudGrado.Size = new System.Drawing.Size(44, 27);
            this.nudGrado.TabIndex = 2;
            this.nudGrado.Visible = false;
            // 
            // nudVariables
            // 
            this.nudVariables.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.nudVariables.Font = new System.Drawing.Font("Louis George Cafe", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudVariables.Location = new System.Drawing.Point(256, 71);
            this.nudVariables.Name = "nudVariables";
            this.nudVariables.Size = new System.Drawing.Size(44, 27);
            this.nudVariables.TabIndex = 3;
            this.nudVariables.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(147)))), ((int)(((byte)(69)))));
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(147)))), ((int)(((byte)(69)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Louis George Cafe", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(306, 70);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(113, 29);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Louis George Cafe", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Louis George Cafe", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPuntos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPuntos.Location = new System.Drawing.Point(12, 117);
            this.dgvPuntos.Name = "dgvPuntos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Louis George Cafe", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPuntos.Size = new System.Drawing.Size(407, 364);
            this.dgvPuntos.TabIndex = 5;
            // 
            // rtbResultado
            // 
            this.rtbResultado.Font = new System.Drawing.Font("Louis George Cafe", 11.25F, System.Drawing.FontStyle.Bold);
            this.rtbResultado.Location = new System.Drawing.Point(425, 70);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(407, 149);
            this.rtbResultado.TabIndex = 6;
            this.rtbResultado.Text = "";
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Louis George Cafe", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Louis George Cafe", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMatriz.Location = new System.Drawing.Point(425, 225);
            this.dgvMatriz.Name = "dgvMatriz";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Louis George Cafe", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriz.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMatriz.Size = new System.Drawing.Size(407, 256);
            this.dgvMatriz.TabIndex = 7;
            // 
            // lblEcuacion
            // 
            this.lblEcuacion.AutoSize = true;
            this.lblEcuacion.Font = new System.Drawing.Font("Louis George Cafe", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEcuacion.Location = new System.Drawing.Point(421, 27);
            this.lblEcuacion.Name = "lblEcuacion";
            this.lblEcuacion.Size = new System.Drawing.Size(96, 21);
            this.lblEcuacion.TabIndex = 8;
            this.lblEcuacion.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(839, 488);
            this.Controls.Add(this.lblEcuacion);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.dgvPuntos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudVariables);
            this.Controls.Add(this.nudGrado);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVariables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown nudGrado;
        private System.Windows.Forms.NumericUpDown nudVariables;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvPuntos;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Label lblEcuacion;
    }
}


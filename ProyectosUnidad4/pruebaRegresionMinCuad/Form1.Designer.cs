namespace pruebaRegresionMinCuad
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbTipoRegresion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.chartRegresion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.lblResultado = new System.Windows.Forms.Label();
            this.nudGrado = new System.Windows.Forms.NumericUpDown();
            this.nudVariables = new System.Windows.Forms.NumericUpDown();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblVariables = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.pnlResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRegresion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVariables)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Louis George Cafe", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(151)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(8, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa los puntos:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(201)))), ((int)(((byte)(179)))));
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Louis George Cafe", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Louis George Cafe", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.Location = new System.Drawing.Point(12, 151);
            this.dgvDatos.Name = "dgvDatos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Louis George Cafe", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.Size = new System.Drawing.Size(391, 350);
            this.dgvDatos.TabIndex = 1;
            this.dgvDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyDown);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 7;
            this.X.Name = "X";
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 7;
            this.Y.Name = "Y";
            this.Y.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(227)))));
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(227)))));
            this.btnCalcular.FlatAppearance.BorderSize = 2;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Louis George Cafe", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Purple;
            this.btnCalcular.Location = new System.Drawing.Point(147, 526);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 41);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbTipoRegresion
            // 
            this.cmbTipoRegresion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRegresion.Font = new System.Drawing.Font("Louis George Cafe", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoRegresion.FormattingEnabled = true;
            this.cmbTipoRegresion.Location = new System.Drawing.Point(12, 58);
            this.cmbTipoRegresion.Name = "cmbTipoRegresion";
            this.cmbTipoRegresion.Size = new System.Drawing.Size(273, 29);
            this.cmbTipoRegresion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Louis George Cafe", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(116)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de regresión:";
            // 
            // pnlResultados
            // 
            this.pnlResultados.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlResultados.Controls.Add(this.chartRegresion);
            this.pnlResultados.Controls.Add(this.btnGraficar);
            this.pnlResultados.Controls.Add(this.rtbResultados);
            this.pnlResultados.Controls.Add(this.dgvResultados);
            this.pnlResultados.Controls.Add(this.lblResultado);
            this.pnlResultados.Location = new System.Drawing.Point(435, 23);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.Size = new System.Drawing.Size(466, 753);
            this.pnlResultados.TabIndex = 4;
            this.pnlResultados.Visible = false;
            // 
            // chartRegresion
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRegresion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRegresion.Legends.Add(legend1);
            this.chartRegresion.Location = new System.Drawing.Point(13, 534);
            this.chartRegresion.Name = "chartRegresion";
            this.chartRegresion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chartRegresion.Size = new System.Drawing.Size(436, 207);
            this.chartRegresion.TabIndex = 10;
            this.chartRegresion.Text = "chart1";
            // 
            // btnGraficar
            // 
            this.btnGraficar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGraficar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGraficar.FlatAppearance.BorderSize = 2;
            this.btnGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficar.Font = new System.Drawing.Font("Louis George Cafe", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGraficar.Location = new System.Drawing.Point(334, 8);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(115, 35);
            this.btnGraficar.TabIndex = 9;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = false;
            // 
            // rtbResultados
            // 
            this.rtbResultados.Font = new System.Drawing.Font("Louis George Cafe", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResultados.Location = new System.Drawing.Point(13, 55);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.Size = new System.Drawing.Size(436, 186);
            this.rtbResultados.TabIndex = 2;
            this.rtbResultados.Text = "";
            // 
            // dgvResultados
            // 
            this.dgvResultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Louis George Cafe", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Louis George Cafe", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResultados.Location = new System.Drawing.Point(13, 247);
            this.dgvResultados.Name = "dgvResultados";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Louis George Cafe", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResultados.Size = new System.Drawing.Size(436, 281);
            this.dgvResultados.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Louis George Cafe", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(151)))), ((int)(((byte)(116)))));
            this.lblResultado.Location = new System.Drawing.Point(13, 22);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(96, 21);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // nudGrado
            // 
            this.nudGrado.Font = new System.Drawing.Font("Louis George Cafe", 14.25F);
            this.nudGrado.Location = new System.Drawing.Point(291, 58);
            this.nudGrado.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudGrado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrado.Name = "nudGrado";
            this.nudGrado.Size = new System.Drawing.Size(49, 29);
            this.nudGrado.TabIndex = 5;
            this.nudGrado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrado.Visible = false;
            // 
            // nudVariables
            // 
            this.nudVariables.Font = new System.Drawing.Font("Louis George Cafe", 14.25F);
            this.nudVariables.Location = new System.Drawing.Point(354, 58);
            this.nudVariables.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudVariables.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVariables.Name = "nudVariables";
            this.nudVariables.Size = new System.Drawing.Size(49, 29);
            this.nudVariables.TabIndex = 6;
            this.nudVariables.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVariables.Visible = false;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(162)))), ((int)(((byte)(197)))));
            this.lblGrado.Location = new System.Drawing.Point(278, 23);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(56, 17);
            this.lblGrado.TabIndex = 7;
            this.lblGrado.Text = "Grado";
            this.lblGrado.Visible = false;
            // 
            // lblVariables
            // 
            this.lblVariables.AutoSize = true;
            this.lblVariables.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.lblVariables.Location = new System.Drawing.Point(351, 23);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(78, 17);
            this.lblVariables.TabIndex = 8;
            this.lblVariables.Text = "Variables";
            this.lblVariables.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(913, 788);
            this.Controls.Add(this.lblVariables);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.nudVariables);
            this.Controls.Add(this.nudGrado);
            this.Controls.Add(this.pnlResultados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoRegresion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.pnlResultados.ResumeLayout(false);
            this.pnlResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRegresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVariables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmbTipoRegresion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.NumericUpDown nudGrado;
        private System.Windows.Forms.NumericUpDown nudVariables;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRegresion;
        private System.Windows.Forms.Button btnGraficar;
    }
}


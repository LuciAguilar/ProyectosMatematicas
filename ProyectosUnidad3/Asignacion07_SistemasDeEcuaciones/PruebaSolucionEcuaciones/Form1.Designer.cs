namespace PruebaSolucionEcuaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_dimension = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstabMatriz = new System.Windows.Forms.Button();
            this.numericRows = new System.Windows.Forms.NumericUpDown();
            this.numericCols = new System.Windows.Forms.NumericUpDown();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRellenarCeros = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGauss = new System.Windows.Forms.Button();
            this.btnGaussJordan = new System.Windows.Forms.Button();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGaussSeidel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dimension
            // 
            this.lbl_dimension.AutoSize = true;
            this.lbl_dimension.Font = new System.Drawing.Font("Louis George Cafe", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dimension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.lbl_dimension.Location = new System.Drawing.Point(12, 32);
            this.lbl_dimension.Name = "lbl_dimension";
            this.lbl_dimension.Size = new System.Drawing.Size(217, 21);
            this.lbl_dimension.TabIndex = 0;
            this.lbl_dimension.Text = "Dimensión de la matriz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Louis George Cafe", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(304, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // btnEstabMatriz
            // 
            this.btnEstabMatriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnEstabMatriz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(117)))), ((int)(((byte)(189)))));
            this.btnEstabMatriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstabMatriz.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstabMatriz.Location = new System.Drawing.Point(462, 27);
            this.btnEstabMatriz.Name = "btnEstabMatriz";
            this.btnEstabMatriz.Size = new System.Drawing.Size(144, 26);
            this.btnEstabMatriz.TabIndex = 4;
            this.btnEstabMatriz.Text = "Establecer Matriz";
            this.btnEstabMatriz.UseVisualStyleBackColor = false;
            this.btnEstabMatriz.Click += new System.EventHandler(this.btnEstabMatriz_Click);
            // 
            // numericRows
            // 
            this.numericRows.Font = new System.Drawing.Font("Louis George Cafe", 12F);
            this.numericRows.Location = new System.Drawing.Point(235, 27);
            this.numericRows.Name = "numericRows";
            this.numericRows.Size = new System.Drawing.Size(61, 26);
            this.numericRows.TabIndex = 5;
            // 
            // numericCols
            // 
            this.numericCols.Font = new System.Drawing.Font("Louis George Cafe", 12F);
            this.numericCols.Location = new System.Drawing.Point(334, 27);
            this.numericCols.Name = "numericCols";
            this.numericCols.Size = new System.Drawing.Size(61, 26);
            this.numericCols.TabIndex = 6;
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToDeleteRows = false;
            this.dgvMatriz.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(187)))), ((int)(((byte)(215)))));
            this.dgvMatriz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMatriz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Louis George Cafe", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X1,
            this.X2,
            this.X3,
            this.X4,
            this.b});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Louis George Cafe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatriz.Location = new System.Drawing.Point(16, 77);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Louis George Cafe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriz.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatriz.Size = new System.Drawing.Size(485, 156);
            this.dgvMatriz.TabIndex = 7;
            // 
            // X1
            // 
            this.X1.HeaderText = "x1";
            this.X1.Name = "X1";
            this.X1.ReadOnly = true;
            this.X1.Width = 80;
            // 
            // X2
            // 
            this.X2.HeaderText = "x2";
            this.X2.Name = "X2";
            this.X2.ReadOnly = true;
            this.X2.Width = 80;
            // 
            // X3
            // 
            this.X3.HeaderText = "x3";
            this.X3.Name = "X3";
            this.X3.ReadOnly = true;
            this.X3.Width = 80;
            // 
            // X4
            // 
            this.X4.HeaderText = "x4";
            this.X4.Name = "X4";
            this.X4.ReadOnly = true;
            this.X4.Width = 80;
            // 
            // b
            // 
            this.b.HeaderText = "b";
            this.b.Name = "b";
            this.b.ReadOnly = true;
            this.b.Width = 80;
            // 
            // btnRellenarCeros
            // 
            this.btnRellenarCeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(169)))), ((int)(((byte)(221)))));
            this.btnRellenarCeros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(169)))), ((int)(((byte)(221)))));
            this.btnRellenarCeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRellenarCeros.Font = new System.Drawing.Font("Louis George Cafe", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRellenarCeros.Location = new System.Drawing.Point(523, 117);
            this.btnRellenarCeros.Name = "btnRellenarCeros";
            this.btnRellenarCeros.Size = new System.Drawing.Size(237, 37);
            this.btnRellenarCeros.TabIndex = 8;
            this.btnRellenarCeros.Text = "Rellenar celdas vacías con ceros";
            this.btnRellenarCeros.UseVisualStyleBackColor = false;
            this.btnRellenarCeros.Click += new System.EventHandler(this.btnRellenarCeros_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(169)))), ((int)(((byte)(221)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(169)))), ((int)(((byte)(221)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(523, 77);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 34);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGauss
            // 
            this.btnGauss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(210)))));
            this.btnGauss.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(210)))));
            this.btnGauss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGauss.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGauss.Location = new System.Drawing.Point(523, 199);
            this.btnGauss.Name = "btnGauss";
            this.btnGauss.Size = new System.Drawing.Size(83, 34);
            this.btnGauss.TabIndex = 11;
            this.btnGauss.Text = "Gauss";
            this.btnGauss.UseVisualStyleBackColor = false;
            this.btnGauss.Click += new System.EventHandler(this.btnGauss_Click);
            // 
            // btnGaussJordan
            // 
            this.btnGaussJordan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(91)))), ((int)(((byte)(169)))));
            this.btnGaussJordan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(91)))), ((int)(((byte)(169)))));
            this.btnGaussJordan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGaussJordan.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaussJordan.Location = new System.Drawing.Point(633, 199);
            this.btnGaussJordan.Name = "btnGaussJordan";
            this.btnGaussJordan.Size = new System.Drawing.Size(127, 34);
            this.btnGaussJordan.TabIndex = 12;
            this.btnGaussJordan.Text = "Gauss - Jordan";
            this.btnGaussJordan.UseVisualStyleBackColor = false;
            this.btnGaussJordan.Click += new System.EventHandler(this.btnGaussJordan_Click);
            // 
            // rtbResultado
            // 
            this.rtbResultado.BackColor = System.Drawing.Color.White;
            this.rtbResultado.Font = new System.Drawing.Font("Louis George Cafe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResultado.Location = new System.Drawing.Point(16, 272);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.ReadOnly = true;
            this.rtbResultado.Size = new System.Drawing.Size(499, 447);
            this.rtbResultado.TabIndex = 13;
            this.rtbResultado.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Louis George Cafe", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Resultados paso a paso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Louis George Cafe", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(519, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Métodos:";
            // 
            // btnGaussSeidel
            // 
            this.btnGaussSeidel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGaussSeidel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGaussSeidel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGaussSeidel.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaussSeidel.ForeColor = System.Drawing.Color.Snow;
            this.btnGaussSeidel.Location = new System.Drawing.Point(633, 239);
            this.btnGaussSeidel.Name = "btnGaussSeidel";
            this.btnGaussSeidel.Size = new System.Drawing.Size(127, 34);
            this.btnGaussSeidel.TabIndex = 16;
            this.btnGaussSeidel.Text = "Gauss-Seidel";
            this.btnGaussSeidel.UseVisualStyleBackColor = false;
            this.btnGaussSeidel.Click += new System.EventHandler(this.btnGaussSeidel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(211)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(793, 742);
            this.Controls.Add(this.btnGaussSeidel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.btnGaussJordan);
            this.Controls.Add(this.btnGauss);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRellenarCeros);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.numericCols);
            this.Controls.Add(this.numericRows);
            this.Controls.Add(this.btnEstabMatriz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_dimension);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dimension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEstabMatriz;
        private System.Windows.Forms.NumericUpDown numericRows;
        private System.Windows.Forms.NumericUpDown numericCols;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnRellenarCeros;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGauss;
        private System.Windows.Forms.Button btnGaussJordan;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn X3;
        private System.Windows.Forms.DataGridViewTextBoxColumn X4;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGaussSeidel;
    }
}


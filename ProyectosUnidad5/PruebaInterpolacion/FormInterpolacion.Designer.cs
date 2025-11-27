namespace PruebaInterpolacion
{
    partial class FormInterpolacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInterpolacion));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnInterpolarLagrange = new System.Windows.Forms.Button();
            this.btnInterpolarNewton = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Louis George Cafe", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(174, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Interpolación";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.Location = new System.Drawing.Point(23, 61);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(188, 17);
            this.lblGrado.TabIndex = 1;
            this.lblGrado.Text = "Grado del polinomio (n):";
            // 
            // txtGrado
            // 
            this.txtGrado.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrado.Location = new System.Drawing.Point(217, 58);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(55, 26);
            this.txtGrado.TabIndex = 2;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold);
            this.lblPuntos.Location = new System.Drawing.Point(23, 101);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(107, 17);
            this.lblPuntos.TabIndex = 3;
            this.lblPuntos.Text = "Puntos (x, y):";
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuntos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(182)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPuntos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPuntos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPuntos.Location = new System.Drawing.Point(26, 130);
            this.dgvPuntos.Name = "dgvPuntos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPuntos.RowHeadersVisible = false;
            this.dgvPuntos.Size = new System.Drawing.Size(246, 304);
            this.dgvPuntos.TabIndex = 4;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(309, 58);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(180, 17);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "Valor de X a interpolar:";
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(495, 55);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(125, 26);
            this.txtX.TabIndex = 6;
            // 
            // btnInterpolarLagrange
            // 
            this.btnInterpolarLagrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.btnInterpolarLagrange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.btnInterpolarLagrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterpolarLagrange.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold);
            this.btnInterpolarLagrange.Location = new System.Drawing.Point(26, 440);
            this.btnInterpolarLagrange.Name = "btnInterpolarLagrange";
            this.btnInterpolarLagrange.Size = new System.Drawing.Size(120, 55);
            this.btnInterpolarLagrange.TabIndex = 7;
            this.btnInterpolarLagrange.Text = "Interpolar con Lagrange";
            this.btnInterpolarLagrange.UseVisualStyleBackColor = false;
            this.btnInterpolarLagrange.Click += new System.EventHandler(this.btnInterpolarLagrange_Click);
            // 
            // btnInterpolarNewton
            // 
            this.btnInterpolarNewton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(87)))), ((int)(((byte)(179)))));
            this.btnInterpolarNewton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(87)))), ((int)(((byte)(179)))));
            this.btnInterpolarNewton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterpolarNewton.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold);
            this.btnInterpolarNewton.Location = new System.Drawing.Point(152, 440);
            this.btnInterpolarNewton.Name = "btnInterpolarNewton";
            this.btnInterpolarNewton.Size = new System.Drawing.Size(120, 55);
            this.btnInterpolarNewton.TabIndex = 8;
            this.btnInterpolarNewton.Text = "Interpolar con Newton";
            this.btnInterpolarNewton.UseVisualStyleBackColor = false;
            this.btnInterpolarNewton.Click += new System.EventHandler(this.btnInterpolarNewton_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(309, 101);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(110, 17);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado (y):";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(171)))), ((int)(((byte)(179)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(171)))), ((int)(((byte)(179)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(312, 466);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(147, 29);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // rtbResultado
            // 
            this.rtbResultado.Font = new System.Drawing.Font("Louis George Cafe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResultado.Location = new System.Drawing.Point(312, 130);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.ReadOnly = true;
            this.rtbResultado.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbResultado.Size = new System.Drawing.Size(358, 308);
            this.rtbResultado.TabIndex = 12;
            this.rtbResultado.Text = "";
            // 
            // FormInterpolacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(214)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(695, 520);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnInterpolarNewton);
            this.Controls.Add(this.btnInterpolarLagrange);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.dgvPuntos);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInterpolacion";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.DataGridView dgvPuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnInterpolarLagrange;
        private System.Windows.Forms.Button btnInterpolarNewton;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RichTextBox rtbResultado;
    }
}


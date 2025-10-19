namespace PruebaSolucionEcuaciones
{
    partial class FormGaussSeidel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGaussSeidel));
            this.dgvIteraciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtErrorMaximo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ea1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ea2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ea3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIteraciones
            // 
            this.dgvIteraciones.AllowUserToAddRows = false;
            this.dgvIteraciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Louis George Cafe", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIteraciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIteraciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iter,
            this.x1,
            this.x2,
            this.x3,
            this.ea1,
            this.ea2,
            this.ea3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Louis George Cafe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIteraciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIteraciones.Location = new System.Drawing.Point(36, 93);
            this.dgvIteraciones.Name = "dgvIteraciones";
            this.dgvIteraciones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Louis George Cafe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIteraciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIteraciones.Size = new System.Drawing.Size(645, 380);
            this.dgvIteraciones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Louis George Cafe", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Error maximo:";
            // 
            // txtErrorMaximo
            // 
            this.txtErrorMaximo.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorMaximo.Location = new System.Drawing.Point(175, 38);
            this.txtErrorMaximo.Name = "txtErrorMaximo";
            this.txtErrorMaximo.Size = new System.Drawing.Size(100, 26);
            this.txtErrorMaximo.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(189)))), ((int)(((byte)(109)))));
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(133)))), ((int)(((byte)(64)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(574, 36);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 35);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // iter
            // 
            this.iter.HeaderText = "iter";
            this.iter.Name = "iter";
            this.iter.ReadOnly = true;
            // 
            // x1
            // 
            this.x1.HeaderText = "x1";
            this.x1.Name = "x1";
            this.x1.ReadOnly = true;
            // 
            // x2
            // 
            this.x2.HeaderText = "x2";
            this.x2.Name = "x2";
            this.x2.ReadOnly = true;
            // 
            // x3
            // 
            this.x3.HeaderText = "x3";
            this.x3.Name = "x3";
            this.x3.ReadOnly = true;
            // 
            // ea1
            // 
            this.ea1.HeaderText = "ea1";
            this.ea1.Name = "ea1";
            this.ea1.ReadOnly = true;
            // 
            // ea2
            // 
            this.ea2.HeaderText = "ea2";
            this.ea2.Name = "ea2";
            this.ea2.ReadOnly = true;
            // 
            // ea3
            // 
            this.ea3.HeaderText = "ea3";
            this.ea3.Name = "ea3";
            this.ea3.ReadOnly = true;
            // 
            // FormGaussSeidel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(219)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(720, 504);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtErrorMaximo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIteraciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGaussSeidel";
            this.Text = "FormGaussSeidel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteraciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIteraciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtErrorMaximo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn iter;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2;
        private System.Windows.Forms.DataGridViewTextBoxColumn x3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ea1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ea2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ea3;
    }
}
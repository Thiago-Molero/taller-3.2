namespace p1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSeleccionComparacion = new System.Windows.Forms.Button();
            this.btnSeleccionRango = new System.Windows.Forms.Button();
            this.btnSeleccionPertenencia = new System.Windows.Forms.Button();
            this.btnProyeccionBasica = new System.Windows.Forms.Button();
            this.btnProyeccionSinDuplicados = new System.Windows.Forms.Button();
            this.btnProyeccionSubconjunto = new System.Windows.Forms.Button();
            this.btnRenombramientoSimple = new System.Windows.Forms.Button();
            this.btnRenombramientoEstructurado = new System.Windows.Forms.Button();
            this.btnRenombramientoCalculado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSeleccionComparacion
            // 
            this.btnSeleccionComparacion.Location = new System.Drawing.Point(28, 40);
            this.btnSeleccionComparacion.Name = "btnSeleccionComparacion";
            this.btnSeleccionComparacion.Size = new System.Drawing.Size(103, 39);
            this.btnSeleccionComparacion.TabIndex = 1;
            this.btnSeleccionComparacion.Text = "1. Predicado de Comparación";
            this.btnSeleccionComparacion.UseVisualStyleBackColor = true;
            this.btnSeleccionComparacion.Click += new System.EventHandler(this.btnSeleccionComparacion_Click);
            // 
            // btnSeleccionRango
            // 
            this.btnSeleccionRango.Location = new System.Drawing.Point(137, 40);
            this.btnSeleccionRango.Name = "btnSeleccionRango";
            this.btnSeleccionRango.Size = new System.Drawing.Size(88, 39);
            this.btnSeleccionRango.TabIndex = 2;
            this.btnSeleccionRango.Text = "2. Predicado de Rango";
            this.btnSeleccionRango.UseVisualStyleBackColor = true;
            this.btnSeleccionRango.Click += new System.EventHandler(this.btnSeleccionRango_Click);
            // 
            // btnSeleccionPertenencia
            // 
            this.btnSeleccionPertenencia.Location = new System.Drawing.Point(231, 40);
            this.btnSeleccionPertenencia.Name = "btnSeleccionPertenencia";
            this.btnSeleccionPertenencia.Size = new System.Drawing.Size(95, 39);
            this.btnSeleccionPertenencia.TabIndex = 3;
            this.btnSeleccionPertenencia.Text = "3. Predicado de Pertenencia";
            this.btnSeleccionPertenencia.UseVisualStyleBackColor = true;
            this.btnSeleccionPertenencia.Click += new System.EventHandler(this.btnSeleccionPertenencia_Click);
            // 
            // btnProyeccionBasica
            // 
            this.btnProyeccionBasica.Location = new System.Drawing.Point(484, 39);
            this.btnProyeccionBasica.Name = "btnProyeccionBasica";
            this.btnProyeccionBasica.Size = new System.Drawing.Size(85, 39);
            this.btnProyeccionBasica.TabIndex = 4;
            this.btnProyeccionBasica.Text = "1. Columnas Específicas";
            this.btnProyeccionBasica.UseVisualStyleBackColor = true;
            this.btnProyeccionBasica.Click += new System.EventHandler(this.btnProyeccionBasica_Click);
            // 
            // btnProyeccionSinDuplicados
            // 
            this.btnProyeccionSinDuplicados.Location = new System.Drawing.Point(575, 38);
            this.btnProyeccionSinDuplicados.Name = "btnProyeccionSinDuplicados";
            this.btnProyeccionSinDuplicados.Size = new System.Drawing.Size(93, 40);
            this.btnProyeccionSinDuplicados.TabIndex = 5;
            this.btnProyeccionSinDuplicados.Text = "2. Eliminar Duplicados";
            this.btnProyeccionSinDuplicados.UseVisualStyleBackColor = true;
            this.btnProyeccionSinDuplicados.Click += new System.EventHandler(this.btnProyeccionSinDuplicados_Click);
            // 
            // btnProyeccionSubconjunto
            // 
            this.btnProyeccionSubconjunto.Location = new System.Drawing.Point(674, 39);
            this.btnProyeccionSubconjunto.Name = "btnProyeccionSubconjunto";
            this.btnProyeccionSubconjunto.Size = new System.Drawing.Size(88, 40);
            this.btnProyeccionSubconjunto.TabIndex = 6;
            this.btnProyeccionSubconjunto.Text = "3. Subconjunto Relevante";
            this.btnProyeccionSubconjunto.UseVisualStyleBackColor = true;
            this.btnProyeccionSubconjunto.Click += new System.EventHandler(this.btnProyeccionSubconjunto_Click);
            // 
            // btnRenombramientoSimple
            // 
            this.btnRenombramientoSimple.Location = new System.Drawing.Point(248, 131);
            this.btnRenombramientoSimple.Name = "btnRenombramientoSimple";
            this.btnRenombramientoSimple.Size = new System.Drawing.Size(95, 39);
            this.btnRenombramientoSimple.TabIndex = 7;
            this.btnRenombramientoSimple.Text = "1. Renombrar Productos";
            this.btnRenombramientoSimple.UseVisualStyleBackColor = true;
            this.btnRenombramientoSimple.Click += new System.EventHandler(this.btnRenombramientoSimple_Click);
            // 
            // btnRenombramientoEstructurado
            // 
            this.btnRenombramientoEstructurado.Location = new System.Drawing.Point(359, 132);
            this.btnRenombramientoEstructurado.Name = "btnRenombramientoEstructurado";
            this.btnRenombramientoEstructurado.Size = new System.Drawing.Size(85, 39);
            this.btnRenombramientoEstructurado.TabIndex = 8;
            this.btnRenombramientoEstructurado.Text = "2. Renombrar Clientes";
            this.btnRenombramientoEstructurado.UseVisualStyleBackColor = true;
            this.btnRenombramientoEstructurado.Click += new System.EventHandler(this.btnRenombramientoEstructurado_Click);
            // 
            // btnRenombramientoCalculado
            // 
            this.btnRenombramientoCalculado.Location = new System.Drawing.Point(450, 130);
            this.btnRenombramientoCalculado.Name = "btnRenombramientoCalculado";
            this.btnRenombramientoCalculado.Size = new System.Drawing.Size(110, 42);
            this.btnRenombramientoCalculado.TabIndex = 9;
            this.btnRenombramientoCalculado.Text = "3. Renombrar y Combinar";
            this.btnRenombramientoCalculado.UseVisualStyleBackColor = true;
            this.btnRenombramientoCalculado.Click += new System.EventHandler(this.btnRenombramientoCalculado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = " Selección (σ)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Proyección (π)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Renombramiento (ρ)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenombramientoCalculado);
            this.Controls.Add(this.btnRenombramientoEstructurado);
            this.Controls.Add(this.btnRenombramientoSimple);
            this.Controls.Add(this.btnProyeccionSubconjunto);
            this.Controls.Add(this.btnProyeccionSinDuplicados);
            this.Controls.Add(this.btnProyeccionBasica);
            this.Controls.Add(this.btnSeleccionPertenencia);
            this.Controls.Add(this.btnSeleccionRango);
            this.Controls.Add(this.btnSeleccionComparacion);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSeleccionComparacion;
        private System.Windows.Forms.Button btnSeleccionRango;
        private System.Windows.Forms.Button btnSeleccionPertenencia;
        private System.Windows.Forms.Button btnProyeccionBasica;
        private System.Windows.Forms.Button btnProyeccionSinDuplicados;
        private System.Windows.Forms.Button btnProyeccionSubconjunto;
        private System.Windows.Forms.Button btnRenombramientoSimple;
        private System.Windows.Forms.Button btnRenombramientoEstructurado;
        private System.Windows.Forms.Button btnRenombramientoCalculado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


namespace pubs
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
            this.btnUnionUbicaciones = new System.Windows.Forms.Button();
            this.btnUnionPersonas = new System.Windows.Forms.Button();
            this.btnUnionPrecios = new System.Windows.Forms.Button();
            this.btnDiferenciaAutores = new System.Windows.Forms.Button();
            this.btnDiferenciaAnticipos = new System.Windows.Forms.Button();
            this.btnDiferenciaEditores = new System.Windows.Forms.Button();
            this.btnCartesianoAutoresEditores = new System.Windows.Forms.Button();
            this.btnCartesianoTiendasCargos = new System.Windows.Forms.Button();
            this.btnCartesianoAutoresLibros = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnionUbicaciones
            // 
            this.btnUnionUbicaciones.Location = new System.Drawing.Point(51, 36);
            this.btnUnionUbicaciones.Name = "btnUnionUbicaciones";
            this.btnUnionUbicaciones.Size = new System.Drawing.Size(75, 23);
            this.btnUnionUbicaciones.TabIndex = 0;
            this.btnUnionUbicaciones.Text = "1. Unión Autores (CA y UT)";
            this.btnUnionUbicaciones.UseVisualStyleBackColor = true;
            this.btnUnionUbicaciones.Click += new System.EventHandler(this.btnUnionUbicaciones_Click);
            // 
            // btnUnionPersonas
            // 
            this.btnUnionPersonas.Location = new System.Drawing.Point(147, 36);
            this.btnUnionPersonas.Name = "btnUnionPersonas";
            this.btnUnionPersonas.Size = new System.Drawing.Size(75, 23);
            this.btnUnionPersonas.TabIndex = 1;
            this.btnUnionPersonas.Text = "2. Unión Autores + Empleados";
            this.btnUnionPersonas.UseVisualStyleBackColor = true;
            this.btnUnionPersonas.Click += new System.EventHandler(this.btnUnionPersonas_Click);
            // 
            // btnUnionPrecios
            // 
            this.btnUnionPrecios.Location = new System.Drawing.Point(228, 36);
            this.btnUnionPrecios.Name = "btnUnionPrecios";
            this.btnUnionPrecios.Size = new System.Drawing.Size(75, 23);
            this.btnUnionPrecios.TabIndex = 2;
            this.btnUnionPrecios.Text = "3. Unión Precios Extremos";
            this.btnUnionPrecios.UseVisualStyleBackColor = true;
            this.btnUnionPrecios.Click += new System.EventHandler(this.btnUnionPrecios_Click);
            // 
            // btnDiferenciaAutores
            // 
            this.btnDiferenciaAutores.Location = new System.Drawing.Point(51, 101);
            this.btnDiferenciaAutores.Name = "btnDiferenciaAutores";
            this.btnDiferenciaAutores.Size = new System.Drawing.Size(75, 23);
            this.btnDiferenciaAutores.TabIndex = 3;
            this.btnDiferenciaAutores.Text = "1. Autores fuera de CA";
            this.btnDiferenciaAutores.UseVisualStyleBackColor = true;
            this.btnDiferenciaAutores.Click += new System.EventHandler(this.btnDiferenciaAutores_Click);
            // 
            // btnDiferenciaAnticipos
            // 
            this.btnDiferenciaAnticipos.Location = new System.Drawing.Point(147, 101);
            this.btnDiferenciaAnticipos.Name = "btnDiferenciaAnticipos";
            this.btnDiferenciaAnticipos.Size = new System.Drawing.Size(75, 23);
            this.btnDiferenciaAnticipos.TabIndex = 4;
            this.btnDiferenciaAnticipos.Text = "2. Buen Anticipo pero no Caros";
            this.btnDiferenciaAnticipos.UseVisualStyleBackColor = true;
            this.btnDiferenciaAnticipos.Click += new System.EventHandler(this.btnDiferenciaAnticipos_Click);
            // 
            // btnDiferenciaEditores
            // 
            this.btnDiferenciaEditores.Location = new System.Drawing.Point(240, 101);
            this.btnDiferenciaEditores.Name = "btnDiferenciaEditores";
            this.btnDiferenciaEditores.Size = new System.Drawing.Size(75, 23);
            this.btnDiferenciaEditores.TabIndex = 5;
            this.btnDiferenciaEditores.Text = "3. Editores USA (Excluyendo NY)";
            this.btnDiferenciaEditores.UseVisualStyleBackColor = true;
            this.btnDiferenciaEditores.Click += new System.EventHandler(this.btnDiferenciaEditores_Click);
            // 
            // btnCartesianoAutoresEditores
            // 
            this.btnCartesianoAutoresEditores.Location = new System.Drawing.Point(51, 162);
            this.btnCartesianoAutoresEditores.Name = "btnCartesianoAutoresEditores";
            this.btnCartesianoAutoresEditores.Size = new System.Drawing.Size(75, 23);
            this.btnCartesianoAutoresEditores.TabIndex = 6;
            this.btnCartesianoAutoresEditores.Text = "1. Autores × Editores";
            this.btnCartesianoAutoresEditores.UseVisualStyleBackColor = true;
            this.btnCartesianoAutoresEditores.Click += new System.EventHandler(this.btnCartesianoAutoresEditores_Click);
            // 
            // btnCartesianoTiendasCargos
            // 
            this.btnCartesianoTiendasCargos.Location = new System.Drawing.Point(147, 162);
            this.btnCartesianoTiendasCargos.Name = "btnCartesianoTiendasCargos";
            this.btnCartesianoTiendasCargos.Size = new System.Drawing.Size(75, 23);
            this.btnCartesianoTiendasCargos.TabIndex = 7;
            this.btnCartesianoTiendasCargos.Text = "2. Tiendas × Cargos";
            this.btnCartesianoTiendasCargos.UseVisualStyleBackColor = true;
            this.btnCartesianoTiendasCargos.Click += new System.EventHandler(this.btnCartesianoTiendasCargos_Click);
            // 
            // btnCartesianoAutoresLibros
            // 
            this.btnCartesianoAutoresLibros.Location = new System.Drawing.Point(240, 162);
            this.btnCartesianoAutoresLibros.Name = "btnCartesianoAutoresLibros";
            this.btnCartesianoAutoresLibros.Size = new System.Drawing.Size(75, 23);
            this.btnCartesianoAutoresLibros.TabIndex = 8;
            this.btnCartesianoAutoresLibros.Text = "3. Autores × Libros";
            this.btnCartesianoAutoresLibros.UseVisualStyleBackColor = true;
            this.btnCartesianoAutoresLibros.Click += new System.EventHandler(this.btnCartesianoAutoresLibros_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(42, 208);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(731, 230);
            this.dgv1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnCartesianoAutoresLibros);
            this.Controls.Add(this.btnCartesianoTiendasCargos);
            this.Controls.Add(this.btnCartesianoAutoresEditores);
            this.Controls.Add(this.btnDiferenciaEditores);
            this.Controls.Add(this.btnDiferenciaAnticipos);
            this.Controls.Add(this.btnDiferenciaAutores);
            this.Controls.Add(this.btnUnionPrecios);
            this.Controls.Add(this.btnUnionPersonas);
            this.Controls.Add(this.btnUnionUbicaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnionUbicaciones;
        private System.Windows.Forms.Button btnUnionPersonas;
        private System.Windows.Forms.Button btnUnionPrecios;
        private System.Windows.Forms.Button btnDiferenciaAutores;
        private System.Windows.Forms.Button btnDiferenciaAnticipos;
        private System.Windows.Forms.Button btnDiferenciaEditores;
        private System.Windows.Forms.Button btnCartesianoAutoresEditores;
        private System.Windows.Forms.Button btnCartesianoTiendasCargos;
        private System.Windows.Forms.Button btnCartesianoAutoresLibros;
        private System.Windows.Forms.DataGridView dgv1;
    }
}


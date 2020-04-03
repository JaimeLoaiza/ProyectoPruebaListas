namespace Proyecto_Lista
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
            this.lbllistas = new System.Windows.Forms.Label();
            this.lblvaloragregar = new System.Windows.Forms.Label();
            this.lblposicion = new System.Windows.Forms.Label();
            this.txtvaloragregar = new System.Windows.Forms.TextBox();
            this.txtposicion = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btneliminarde = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.LISTA = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbllistas
            // 
            this.lbllistas.AutoSize = true;
            this.lbllistas.Location = new System.Drawing.Point(146, 37);
            this.lbllistas.Name = "lbllistas";
            this.lbllistas.Size = new System.Drawing.Size(44, 13);
            this.lbllistas.TabIndex = 0;
            this.lbllistas.Text = "LISTAS";
            // 
            // lblvaloragregar
            // 
            this.lblvaloragregar.AutoSize = true;
            this.lblvaloragregar.Location = new System.Drawing.Point(37, 75);
            this.lblvaloragregar.Name = "lblvaloragregar";
            this.lblvaloragregar.Size = new System.Drawing.Size(102, 13);
            this.lblvaloragregar.TabIndex = 1;
            this.lblvaloragregar.Text = "VALOR AGREGAR:";
            // 
            // lblposicion
            // 
            this.lblposicion.AutoSize = true;
            this.lblposicion.Location = new System.Drawing.Point(215, 75);
            this.lblposicion.Name = "lblposicion";
            this.lblposicion.Size = new System.Drawing.Size(61, 13);
            this.lblposicion.TabIndex = 2;
            this.lblposicion.Text = "POSICIÓN:";
            // 
            // txtvaloragregar
            // 
            this.txtvaloragregar.Location = new System.Drawing.Point(40, 100);
            this.txtvaloragregar.Name = "txtvaloragregar";
            this.txtvaloragregar.Size = new System.Drawing.Size(100, 20);
            this.txtvaloragregar.TabIndex = 3;
            // 
            // txtposicion
            // 
            this.txtposicion.Location = new System.Drawing.Point(198, 100);
            this.txtposicion.Name = "txtposicion";
            this.txtposicion.Size = new System.Drawing.Size(100, 20);
            this.txtposicion.TabIndex = 4;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(40, 146);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(105, 23);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(40, 185);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(105, 23);
            this.btninsertar.TabIndex = 6;
            this.btninsertar.Text = "INSERTAR";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btneliminarde
            // 
            this.btneliminarde.Location = new System.Drawing.Point(40, 223);
            this.btneliminarde.Name = "btneliminarde";
            this.btneliminarde.Size = new System.Drawing.Size(105, 23);
            this.btneliminarde.TabIndex = 7;
            this.btneliminarde.Text = "ELIMINAR DE";
            this.btneliminarde.UseVisualStyleBackColor = true;
            this.btneliminarde.Click += new System.EventHandler(this.btneliminarde_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(40, 261);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(105, 23);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(40, 298);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(105, 23);
            this.btnmostrar.TabIndex = 9;
            this.btnmostrar.Text = "MOSTRAR";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // LISTA
            // 
            this.LISTA.FormattingEnabled = true;
            this.LISTA.Location = new System.Drawing.Point(174, 148);
            this.LISTA.Name = "LISTA";
            this.LISTA.Size = new System.Drawing.Size(162, 173);
            this.LISTA.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 350);
            this.Controls.Add(this.LISTA);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneliminarde);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtposicion);
            this.Controls.Add(this.txtvaloragregar);
            this.Controls.Add(this.lblposicion);
            this.Controls.Add(this.lblvaloragregar);
            this.Controls.Add(this.lbllistas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllistas;
        private System.Windows.Forms.Label lblvaloragregar;
        private System.Windows.Forms.Label lblposicion;
        private System.Windows.Forms.TextBox txtvaloragregar;
        private System.Windows.Forms.TextBox txtposicion;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btneliminarde;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.ListBox LISTA;
    }
}


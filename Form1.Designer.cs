namespace GestionBiblioteca
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
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.textAño = new System.Windows.Forms.TextBox();
            this.textUbicacion = new System.Windows.Forms.TextBox();
            this.textFormato = new System.Windows.Forms.TextBox();
            this.textTamañoArchivo = new System.Windows.Forms.TextBox();
            this.comboTipoLibro = new System.Windows.Forms.ComboBox();
            this.buttonAgregarLibro = new System.Windows.Forms.Button();
            this.dataGridViewLibro = new System.Windows.Forms.DataGridView();
            this.buttonEliminarLibro = new System.Windows.Forms.Button();
            this.buttonRegistrarPrestamo = new System.Windows.Forms.Button();
            this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
            this.buttonDevolverLibro = new System.Windows.Forms.Button();
            this.dataGridViewDevoluciones = new System.Windows.Forms.DataGridView();
            this.textNombreMiembro = new System.Windows.Forms.TextBox();
            this.textNumeroMiembro = new System.Windows.Forms.TextBox();
            this.buttonAgregarMiembro = new System.Windows.Forms.Button();
            this.comboMiembros = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(32, 23);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(95, 22);
            this.textTitulo.TabIndex = 0;
            this.textTitulo.Tag = "Título";
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(32, 77);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(95, 22);
            this.textAutor.TabIndex = 1;
            this.textAutor.Tag = "Autor";
            // 
            // textAño
            // 
            this.textAño.Location = new System.Drawing.Point(32, 125);
            this.textAño.Name = "textAño";
            this.textAño.Size = new System.Drawing.Size(95, 22);
            this.textAño.TabIndex = 2;
            this.textAño.Tag = "Año";
            // 
            // textUbicacion
            // 
            this.textUbicacion.Location = new System.Drawing.Point(32, 175);
            this.textUbicacion.Name = "textUbicacion";
            this.textUbicacion.Size = new System.Drawing.Size(95, 22);
            this.textUbicacion.TabIndex = 3;
            this.textUbicacion.Tag = "Ubicación";
            // 
            // textFormato
            // 
            this.textFormato.Location = new System.Drawing.Point(32, 261);
            this.textFormato.Name = "textFormato";
            this.textFormato.Size = new System.Drawing.Size(95, 22);
            this.textFormato.TabIndex = 4;
            this.textFormato.Tag = "Formato";
            // 
            // textTamañoArchivo
            // 
            this.textTamañoArchivo.Location = new System.Drawing.Point(32, 217);
            this.textTamañoArchivo.Name = "textTamañoArchivo";
            this.textTamañoArchivo.Size = new System.Drawing.Size(95, 22);
            this.textTamañoArchivo.TabIndex = 5;
            // 
            // comboTipoLibro
            // 
            this.comboTipoLibro.FormattingEnabled = true;
            this.comboTipoLibro.Location = new System.Drawing.Point(168, 23);
            this.comboTipoLibro.Name = "comboTipoLibro";
            this.comboTipoLibro.Size = new System.Drawing.Size(141, 24);
            this.comboTipoLibro.TabIndex = 6;
            // 
            // buttonAgregarLibro
            // 
            this.buttonAgregarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAgregarLibro.Location = new System.Drawing.Point(168, 66);
            this.buttonAgregarLibro.Name = "buttonAgregarLibro";
            this.buttonAgregarLibro.Size = new System.Drawing.Size(139, 33);
            this.buttonAgregarLibro.TabIndex = 7;
            this.buttonAgregarLibro.Text = "Agregar Libro";
            this.buttonAgregarLibro.UseVisualStyleBackColor = false;
            this.buttonAgregarLibro.Click += new System.EventHandler(this.buttonAgregarLibro_Click);
            // 
            // dataGridViewLibro
            // 
            this.dataGridViewLibro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibro.Location = new System.Drawing.Point(337, 23);
            this.dataGridViewLibro.Name = "dataGridViewLibro";
            this.dataGridViewLibro.RowHeadersWidth = 51;
            this.dataGridViewLibro.RowTemplate.Height = 24;
            this.dataGridViewLibro.Size = new System.Drawing.Size(567, 150);
            this.dataGridViewLibro.TabIndex = 8;
            // 
            // buttonEliminarLibro
            // 
            this.buttonEliminarLibro.BackColor = System.Drawing.Color.Red;
            this.buttonEliminarLibro.Location = new System.Drawing.Point(168, 117);
            this.buttonEliminarLibro.Name = "buttonEliminarLibro";
            this.buttonEliminarLibro.Size = new System.Drawing.Size(139, 33);
            this.buttonEliminarLibro.TabIndex = 9;
            this.buttonEliminarLibro.Text = "Eliminar Libro";
            this.buttonEliminarLibro.UseVisualStyleBackColor = false;
            this.buttonEliminarLibro.Click += new System.EventHandler(this.buttonEliminarLibro_Click);
            // 
            // buttonRegistrarPrestamo
            // 
            this.buttonRegistrarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonRegistrarPrestamo.Location = new System.Drawing.Point(168, 177);
            this.buttonRegistrarPrestamo.Name = "buttonRegistrarPrestamo";
            this.buttonRegistrarPrestamo.Size = new System.Drawing.Size(139, 33);
            this.buttonRegistrarPrestamo.TabIndex = 10;
            this.buttonRegistrarPrestamo.Text = "Registrar Préstamo";
            this.buttonRegistrarPrestamo.UseVisualStyleBackColor = false;
            this.buttonRegistrarPrestamo.Click += new System.EventHandler(this.buttonRegistrarPrestamo_Click);
            // 
            // dataGridViewPrestamos
            // 
            this.dataGridViewPrestamos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamos.Location = new System.Drawing.Point(337, 180);
            this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            this.dataGridViewPrestamos.RowHeadersWidth = 51;
            this.dataGridViewPrestamos.RowTemplate.Height = 24;
            this.dataGridViewPrestamos.Size = new System.Drawing.Size(567, 150);
            this.dataGridViewPrestamos.TabIndex = 11;
            // 
            // buttonDevolverLibro
            // 
            this.buttonDevolverLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDevolverLibro.Location = new System.Drawing.Point(168, 227);
            this.buttonDevolverLibro.Name = "buttonDevolverLibro";
            this.buttonDevolverLibro.Size = new System.Drawing.Size(139, 33);
            this.buttonDevolverLibro.TabIndex = 12;
            this.buttonDevolverLibro.Text = "Devolver Libro";
            this.buttonDevolverLibro.UseVisualStyleBackColor = false;
            this.buttonDevolverLibro.Click += new System.EventHandler(this.buttonDevolverLibro_Click);
            // 
            // dataGridViewDevoluciones
            // 
            this.dataGridViewDevoluciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevoluciones.Location = new System.Drawing.Point(337, 340);
            this.dataGridViewDevoluciones.Name = "dataGridViewDevoluciones";
            this.dataGridViewDevoluciones.RowHeadersWidth = 51;
            this.dataGridViewDevoluciones.RowTemplate.Height = 24;
            this.dataGridViewDevoluciones.Size = new System.Drawing.Size(567, 145);
            this.dataGridViewDevoluciones.TabIndex = 13;
            // 
            // textNombreMiembro
            // 
            this.textNombreMiembro.Location = new System.Drawing.Point(32, 299);
            this.textNombreMiembro.Name = "textNombreMiembro";
            this.textNombreMiembro.Size = new System.Drawing.Size(95, 22);
            this.textNombreMiembro.TabIndex = 14;
            this.textNombreMiembro.Tag = "Nombre de Miembro";
            // 
            // textNumeroMiembro
            // 
            this.textNumeroMiembro.Location = new System.Drawing.Point(32, 340);
            this.textNumeroMiembro.Name = "textNumeroMiembro";
            this.textNumeroMiembro.Size = new System.Drawing.Size(95, 22);
            this.textNumeroMiembro.TabIndex = 15;
            this.textNumeroMiembro.Tag = "Numero de miembro";
            // 
            // buttonAgregarMiembro
            // 
            this.buttonAgregarMiembro.Location = new System.Drawing.Point(32, 419);
            this.buttonAgregarMiembro.Name = "buttonAgregarMiembro";
            this.buttonAgregarMiembro.Size = new System.Drawing.Size(139, 33);
            this.buttonAgregarMiembro.TabIndex = 16;
            this.buttonAgregarMiembro.Text = "Agregar Miembro";
            this.buttonAgregarMiembro.UseVisualStyleBackColor = true;
            this.buttonAgregarMiembro.Click += new System.EventHandler(this.buttonAgregarMiembro_Click);
            // 
            // comboMiembros
            // 
            this.comboMiembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.comboMiembros.FormattingEnabled = true;
            this.comboMiembros.Location = new System.Drawing.Point(168, 320);
            this.comboMiembros.Name = "comboMiembros";
            this.comboMiembros.Size = new System.Drawing.Size(141, 24);
            this.comboMiembros.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(969, 531);
            this.Controls.Add(this.comboMiembros);
            this.Controls.Add(this.buttonAgregarMiembro);
            this.Controls.Add(this.textNumeroMiembro);
            this.Controls.Add(this.textNombreMiembro);
            this.Controls.Add(this.dataGridViewDevoluciones);
            this.Controls.Add(this.buttonDevolverLibro);
            this.Controls.Add(this.dataGridViewPrestamos);
            this.Controls.Add(this.buttonRegistrarPrestamo);
            this.Controls.Add(this.buttonEliminarLibro);
            this.Controls.Add(this.dataGridViewLibro);
            this.Controls.Add(this.buttonAgregarLibro);
            this.Controls.Add(this.comboTipoLibro);
            this.Controls.Add(this.textTamañoArchivo);
            this.Controls.Add(this.textFormato);
            this.Controls.Add(this.textUbicacion);
            this.Controls.Add(this.textAño);
            this.Controls.Add(this.textAutor);
            this.Controls.Add(this.textTitulo);
            this.Name = "Form1";
            this.Text = "Gestión de Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.TextBox textAño;
        private System.Windows.Forms.TextBox textUbicacion;
        private System.Windows.Forms.TextBox textFormato;
        private System.Windows.Forms.TextBox textTamañoArchivo;
        private System.Windows.Forms.ComboBox comboTipoLibro;
        private System.Windows.Forms.Button buttonAgregarLibro;
        private System.Windows.Forms.DataGridView dataGridViewLibro;
        private System.Windows.Forms.Button buttonEliminarLibro;
        private System.Windows.Forms.Button buttonRegistrarPrestamo;
        private System.Windows.Forms.DataGridView dataGridViewPrestamos;
        private System.Windows.Forms.Button buttonDevolverLibro;
        private System.Windows.Forms.DataGridView dataGridViewDevoluciones;
        private System.Windows.Forms.TextBox textNombreMiembro;
        private System.Windows.Forms.TextBox textNumeroMiembro;
        private System.Windows.Forms.Button buttonAgregarMiembro;
        private System.Windows.Forms.ComboBox comboMiembros;
    }
}

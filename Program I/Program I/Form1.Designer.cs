
namespace Program_I
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
            this.grbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.idAlumno = new System.Windows.Forms.Label();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.lblDireccionAlumno = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblidAlumno = new System.Windows.Forms.Label();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosAlumno = new System.Windows.Forms.Label();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.grbBusquedaAlumno = new System.Windows.Forms.GroupBox();
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.grdAlumnos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosAlumno.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.grbEdicionAlumno.SuspendLayout();
            this.grbBusquedaAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosAlumno
            // 
            this.grbDatosAlumno.Controls.Add(this.idAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblCodigoAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtCodigoAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblidAlumno);
            this.grbDatosAlumno.Enabled = false;
            this.grbDatosAlumno.Location = new System.Drawing.Point(30, 24);
            this.grbDatosAlumno.Name = "grbDatosAlumno";
            this.grbDatosAlumno.Size = new System.Drawing.Size(432, 398);
            this.grbDatosAlumno.TabIndex = 0;
            this.grbDatosAlumno.TabStop = false;
            this.grbDatosAlumno.Text = "Datos";
            // 
            // idAlumno
            // 
            this.idAlumno.AutoSize = true;
            this.idAlumno.Location = new System.Drawing.Point(127, 45);
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.Size = new System.Drawing.Size(46, 17);
            this.idAlumno.TabIndex = 10;
            this.idAlumno.Text = "label6";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(153, 314);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(267, 22);
            this.txtTelefonoAlumno.TabIndex = 9;
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(153, 252);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(267, 22);
            this.txtDireccionAlumno.TabIndex = 8;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(153, 191);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(267, 22);
            this.txtNombreAlumno.TabIndex = 7;
            // 
            // lblTelefonoAlumno
            // 
            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(6, 316);
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            this.lblTelefonoAlumno.Size = new System.Drawing.Size(93, 20);
            this.lblTelefonoAlumno.TabIndex = 6;
            this.lblTelefonoAlumno.Text = "Telefono: ";
            // 
            // lblDireccionAlumno
            // 
            this.lblDireccionAlumno.AutoSize = true;
            this.lblDireccionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionAlumno.Location = new System.Drawing.Point(6, 249);
            this.lblDireccionAlumno.Name = "lblDireccionAlumno";
            this.lblDireccionAlumno.Size = new System.Drawing.Size(102, 20);
            this.lblDireccionAlumno.TabIndex = 5;
            this.lblDireccionAlumno.Text = "Direccion: ";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(6, 191);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(86, 20);
            this.lblNombreAlumno.TabIndex = 4;
            this.lblNombreAlumno.Text = "Nombre: ";
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAlumno.Location = new System.Drawing.Point(6, 126);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(73, 20);
            this.lblCodigoAlumno.TabIndex = 3;
            this.lblCodigoAlumno.Text = "Codigo:";
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(153, 126);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(267, 22);
            this.txtCodigoAlumno.TabIndex = 2;
            // 
            // lblidAlumno
            // 
            this.lblidAlumno.AutoSize = true;
            this.lblidAlumno.Location = new System.Drawing.Point(40, 45);
            this.lblidAlumno.Name = "lblidAlumno";
            this.lblidAlumno.Size = new System.Drawing.Size(25, 17);
            this.lblidAlumno.TabIndex = 1;
            this.lblidAlumno.Text = "ID:";
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.lblnRegistrosAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(30, 468);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(432, 100);
            this.grbNavegacionAlumno.TabIndex = 1;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegacion";
            // 
            // lblnRegistrosAlumno
            // 
            this.lblnRegistrosAlumno.AutoSize = true;
            this.lblnRegistrosAlumno.Location = new System.Drawing.Point(173, 50);
            this.lblnRegistrosAlumno.Name = "lblnRegistrosAlumno";
            this.lblnRegistrosAlumno.Size = new System.Drawing.Size(46, 17);
            this.lblnRegistrosAlumno.TabIndex = 4;
            this.lblnRegistrosAlumno.Text = "x de n";
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoAlumno.Location = new System.Drawing.Point(304, 36);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(65, 42);
            this.btnUltimoAlumno.TabIndex = 3;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            this.btnUltimoAlumno.Click += new System.EventHandler(this.btnUltimoAlumno_Click_1);
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(233, 36);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(65, 42);
            this.btnSiguienteAlumno.TabIndex = 2;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            this.btnSiguienteAlumno.Click += new System.EventHandler(this.btnSiguienteAlumno_Click_1);
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(98, 36);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(65, 42);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            this.btnAnteriorAlumno.Click += new System.EventHandler(this.btnAnteriorAlumno_Click_1);
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(27, 36);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(65, 42);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.UseVisualStyleBackColor = true;
            this.btnPrimeroAlumno.Click += new System.EventHandler(this.btnPrimeroAlumno_Click_1);
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnAgregarAlumno);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(468, 468);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Size = new System.Drawing.Size(432, 100);
            this.grbEdicionAlumno.TabIndex = 4;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Edicion";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(290, 36);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(107, 42);
            this.btnEliminarAlumno.TabIndex = 2;
            this.btnEliminarAlumno.Text = "ELIMINAR";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click_1);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.Location = new System.Drawing.Point(156, 36);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(128, 42);
            this.btnModificarAlumno.TabIndex = 1;
            this.btnModificarAlumno.Text = "MODIFICAR";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click_1);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(45, 36);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(105, 42);
            this.btnAgregarAlumno.TabIndex = 0;
            this.btnAgregarAlumno.Text = "NUEVO";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click_1);
            // 
            // grbBusquedaAlumno
            // 
            this.grbBusquedaAlumno.Controls.Add(this.grdAlumnos);
            this.grbBusquedaAlumno.Controls.Add(this.txtBuscarAlumnos);
            this.grbBusquedaAlumno.Location = new System.Drawing.Point(486, 33);
            this.grbBusquedaAlumno.Name = "grbBusquedaAlumno";
            this.grbBusquedaAlumno.Size = new System.Drawing.Size(549, 389);
            this.grbBusquedaAlumno.TabIndex = 5;
            this.grbBusquedaAlumno.TabStop = false;
            this.grbBusquedaAlumno.Text = "Busqueda Alumno";
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(20, 43);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(507, 22);
            this.txtBuscarAlumnos.TabIndex = 0;
            this.txtBuscarAlumnos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarAlumnos_KeyUp);
            // 
            // grdAlumnos
            // 
            this.grdAlumnos.AllowUserToAddRows = false;
            this.grdAlumnos.AllowUserToDeleteRows = false;
            this.grdAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdAlumnos.Location = new System.Drawing.Point(6, 88);
            this.grdAlumnos.Name = "grdAlumnos";
            this.grdAlumnos.ReadOnly = true;
            this.grdAlumnos.RowHeadersWidth = 51;
            this.grdAlumnos.RowTemplate.Height = 24;
            this.grdAlumnos.Size = new System.Drawing.Size(537, 285);
            this.grdAlumnos.TabIndex = 1;
            this.grdAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAlumnos_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "idAlumno";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 200;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TEL";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 594);
            this.Controls.Add(this.grbBusquedaAlumno);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosAlumno);
            this.Name = "Form1";
            this.Text = "ADMINISTRACION DE ALUMNOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosAlumno.ResumeLayout(false);
            this.grbDatosAlumno.PerformLayout();
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.grbEdicionAlumno.ResumeLayout(false);
            this.grbBusquedaAlumno.ResumeLayout(false);
            this.grbBusquedaAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label lblidAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.Label lblDireccionAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.Label idAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Label lblnRegistrosAlumno;
        private System.Windows.Forms.GroupBox grbBusquedaAlumno;
        private System.Windows.Forms.DataGridView grdAlumnos;
        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}


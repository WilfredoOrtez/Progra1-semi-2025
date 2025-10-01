
namespace Program_I
{
    partial class Form2
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
            this.grbBusquedaProfesor = new System.Windows.Forms.GroupBox();
            this.grdProfesor = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarProfesor = new System.Windows.Forms.TextBox();
            this.grbEdicionProfesor = new System.Windows.Forms.GroupBox();
            this.btnEliminarProfesor = new System.Windows.Forms.Button();
            this.btnModificarProfesor = new System.Windows.Forms.Button();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.grbNavegacionProfesor = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosProfesor = new System.Windows.Forms.Label();
            this.btnUltimoProfesor = new System.Windows.Forms.Button();
            this.btnSiguienteProfesor = new System.Windows.Forms.Button();
            this.btnAnteriorProfesor = new System.Windows.Forms.Button();
            this.btnPrimeroProfesor = new System.Windows.Forms.Button();
            this.grbDatosProfesor = new System.Windows.Forms.GroupBox();
            this.idProfesor = new System.Windows.Forms.Label();
            this.txtTelefonoProfesor = new System.Windows.Forms.TextBox();
            this.txtDireccionProfesor = new System.Windows.Forms.TextBox();
            this.txtNombreProfesor = new System.Windows.Forms.TextBox();
            this.lblTelefonoProfesor = new System.Windows.Forms.Label();
            this.lblDireccionProfesor = new System.Windows.Forms.Label();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.lblCodigoProfesor = new System.Windows.Forms.Label();
            this.txtCodigoProfesor = new System.Windows.Forms.TextBox();
            this.lblidProfesor = new System.Windows.Forms.Label();
            this.grbBusquedaProfesor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesor)).BeginInit();
            this.grbEdicionProfesor.SuspendLayout();
            this.grbNavegacionProfesor.SuspendLayout();
            this.grbDatosProfesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaProfesor
            // 
            this.grbBusquedaProfesor.Controls.Add(this.grdProfesor);
            this.grbBusquedaProfesor.Controls.Add(this.txtBuscarProfesor);
            this.grbBusquedaProfesor.Location = new System.Drawing.Point(500, 26);
            this.grbBusquedaProfesor.Name = "grbBusquedaProfesor";
            this.grbBusquedaProfesor.Size = new System.Drawing.Size(549, 389);
            this.grbBusquedaProfesor.TabIndex = 9;
            this.grbBusquedaProfesor.TabStop = false;
            this.grbBusquedaProfesor.Text = "Busqueda Profesor";
            // 
            // grdProfesor
            // 
            this.grdProfesor.AllowUserToAddRows = false;
            this.grdProfesor.AllowUserToDeleteRows = false;
            this.grdProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdProfesor.Location = new System.Drawing.Point(6, 88);
            this.grdProfesor.Name = "grdProfesor";
            this.grdProfesor.ReadOnly = true;
            this.grdProfesor.RowHeadersWidth = 51;
            this.grdProfesor.RowTemplate.Height = 24;
            this.grdProfesor.Size = new System.Drawing.Size(537, 285);
            this.grdProfesor.TabIndex = 1;
            this.grdProfesor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProfesor_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "idProfesor";
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
            // txtBuscarProfesor
            // 
            this.txtBuscarProfesor.Location = new System.Drawing.Point(20, 43);
            this.txtBuscarProfesor.Name = "txtBuscarProfesor";
            this.txtBuscarProfesor.Size = new System.Drawing.Size(507, 22);
            this.txtBuscarProfesor.TabIndex = 0;
            this.txtBuscarProfesor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProfesor_KeyUp);
            // 
            // grbEdicionProfesor
            // 
            this.grbEdicionProfesor.Controls.Add(this.btnEliminarProfesor);
            this.grbEdicionProfesor.Controls.Add(this.btnModificarProfesor);
            this.grbEdicionProfesor.Controls.Add(this.btnAgregarProfesor);
            this.grbEdicionProfesor.Location = new System.Drawing.Point(482, 461);
            this.grbEdicionProfesor.Name = "grbEdicionProfesor";
            this.grbEdicionProfesor.Size = new System.Drawing.Size(432, 100);
            this.grbEdicionProfesor.TabIndex = 8;
            this.grbEdicionProfesor.TabStop = false;
            this.grbEdicionProfesor.Text = "Edicion";
            // 
            // btnEliminarProfesor
            // 
            this.btnEliminarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProfesor.Location = new System.Drawing.Point(290, 36);
            this.btnEliminarProfesor.Name = "btnEliminarProfesor";
            this.btnEliminarProfesor.Size = new System.Drawing.Size(107, 42);
            this.btnEliminarProfesor.TabIndex = 2;
            this.btnEliminarProfesor.Text = "ELIMINAR";
            this.btnEliminarProfesor.UseVisualStyleBackColor = true;
            this.btnEliminarProfesor.Click += new System.EventHandler(this.btnEliminarProfesor_Click);
            // 
            // btnModificarProfesor
            // 
            this.btnModificarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProfesor.Location = new System.Drawing.Point(156, 36);
            this.btnModificarProfesor.Name = "btnModificarProfesor";
            this.btnModificarProfesor.Size = new System.Drawing.Size(128, 42);
            this.btnModificarProfesor.TabIndex = 1;
            this.btnModificarProfesor.Text = "MODIFICAR";
            this.btnModificarProfesor.UseVisualStyleBackColor = true;
            this.btnModificarProfesor.Click += new System.EventHandler(this.btnModificarProfesor_Click);
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProfesor.Location = new System.Drawing.Point(45, 36);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(105, 42);
            this.btnAgregarProfesor.TabIndex = 0;
            this.btnAgregarProfesor.Text = "NUEVO";
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            // 
            // grbNavegacionProfesor
            // 
            this.grbNavegacionProfesor.Controls.Add(this.lblnRegistrosProfesor);
            this.grbNavegacionProfesor.Controls.Add(this.btnUltimoProfesor);
            this.grbNavegacionProfesor.Controls.Add(this.btnSiguienteProfesor);
            this.grbNavegacionProfesor.Controls.Add(this.btnAnteriorProfesor);
            this.grbNavegacionProfesor.Controls.Add(this.btnPrimeroProfesor);
            this.grbNavegacionProfesor.Location = new System.Drawing.Point(44, 461);
            this.grbNavegacionProfesor.Name = "grbNavegacionProfesor";
            this.grbNavegacionProfesor.Size = new System.Drawing.Size(432, 100);
            this.grbNavegacionProfesor.TabIndex = 7;
            this.grbNavegacionProfesor.TabStop = false;
            this.grbNavegacionProfesor.Text = "Navegacion";
            // 
            // lblnRegistrosProfesor
            // 
            this.lblnRegistrosProfesor.AutoSize = true;
            this.lblnRegistrosProfesor.Location = new System.Drawing.Point(173, 50);
            this.lblnRegistrosProfesor.Name = "lblnRegistrosProfesor";
            this.lblnRegistrosProfesor.Size = new System.Drawing.Size(46, 17);
            this.lblnRegistrosProfesor.TabIndex = 4;
            this.lblnRegistrosProfesor.Text = "x de n";
            // 
            // btnUltimoProfesor
            // 
            this.btnUltimoProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoProfesor.Location = new System.Drawing.Point(304, 36);
            this.btnUltimoProfesor.Name = "btnUltimoProfesor";
            this.btnUltimoProfesor.Size = new System.Drawing.Size(65, 42);
            this.btnUltimoProfesor.TabIndex = 3;
            this.btnUltimoProfesor.Text = ">|";
            this.btnUltimoProfesor.UseVisualStyleBackColor = true;
            this.btnUltimoProfesor.Click += new System.EventHandler(this.btnUltimoProfesor_Click);
            // 
            // btnSiguienteProfesor
            // 
            this.btnSiguienteProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteProfesor.Location = new System.Drawing.Point(233, 36);
            this.btnSiguienteProfesor.Name = "btnSiguienteProfesor";
            this.btnSiguienteProfesor.Size = new System.Drawing.Size(65, 42);
            this.btnSiguienteProfesor.TabIndex = 2;
            this.btnSiguienteProfesor.Text = ">";
            this.btnSiguienteProfesor.UseVisualStyleBackColor = true;
            this.btnSiguienteProfesor.Click += new System.EventHandler(this.btnSiguienteProfesor_Click);
            // 
            // btnAnteriorProfesor
            // 
            this.btnAnteriorProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorProfesor.Location = new System.Drawing.Point(98, 36);
            this.btnAnteriorProfesor.Name = "btnAnteriorProfesor";
            this.btnAnteriorProfesor.Size = new System.Drawing.Size(65, 42);
            this.btnAnteriorProfesor.TabIndex = 1;
            this.btnAnteriorProfesor.Text = "<";
            this.btnAnteriorProfesor.UseVisualStyleBackColor = true;
            this.btnAnteriorProfesor.Click += new System.EventHandler(this.btnAnteriorProfesor_Click);
            // 
            // btnPrimeroProfesor
            // 
            this.btnPrimeroProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroProfesor.Location = new System.Drawing.Point(27, 36);
            this.btnPrimeroProfesor.Name = "btnPrimeroProfesor";
            this.btnPrimeroProfesor.Size = new System.Drawing.Size(65, 42);
            this.btnPrimeroProfesor.TabIndex = 0;
            this.btnPrimeroProfesor.Text = "|<";
            this.btnPrimeroProfesor.UseVisualStyleBackColor = true;
            this.btnPrimeroProfesor.Click += new System.EventHandler(this.btnPrimeroProfesor_Click);
            // 
            // grbDatosProfesor
            // 
            this.grbDatosProfesor.Controls.Add(this.idProfesor);
            this.grbDatosProfesor.Controls.Add(this.txtTelefonoProfesor);
            this.grbDatosProfesor.Controls.Add(this.txtDireccionProfesor);
            this.grbDatosProfesor.Controls.Add(this.txtNombreProfesor);
            this.grbDatosProfesor.Controls.Add(this.lblTelefonoProfesor);
            this.grbDatosProfesor.Controls.Add(this.lblDireccionProfesor);
            this.grbDatosProfesor.Controls.Add(this.lblNombreProfesor);
            this.grbDatosProfesor.Controls.Add(this.lblCodigoProfesor);
            this.grbDatosProfesor.Controls.Add(this.txtCodigoProfesor);
            this.grbDatosProfesor.Controls.Add(this.lblidProfesor);
            this.grbDatosProfesor.Enabled = false;
            this.grbDatosProfesor.Location = new System.Drawing.Point(44, 17);
            this.grbDatosProfesor.Name = "grbDatosProfesor";
            this.grbDatosProfesor.Size = new System.Drawing.Size(432, 398);
            this.grbDatosProfesor.TabIndex = 6;
            this.grbDatosProfesor.TabStop = false;
            this.grbDatosProfesor.Text = "Datos";
            // 
            // idProfesor
            // 
            this.idProfesor.AutoSize = true;
            this.idProfesor.Location = new System.Drawing.Point(127, 45);
            this.idProfesor.Name = "idProfesor";
            this.idProfesor.Size = new System.Drawing.Size(46, 17);
            this.idProfesor.TabIndex = 10;
            this.idProfesor.Text = "label6";
            // 
            // txtTelefonoProfesor
            // 
            this.txtTelefonoProfesor.Location = new System.Drawing.Point(153, 314);
            this.txtTelefonoProfesor.Name = "txtTelefonoProfesor";
            this.txtTelefonoProfesor.Size = new System.Drawing.Size(267, 22);
            this.txtTelefonoProfesor.TabIndex = 9;
            // 
            // txtDireccionProfesor
            // 
            this.txtDireccionProfesor.Location = new System.Drawing.Point(153, 252);
            this.txtDireccionProfesor.Name = "txtDireccionProfesor";
            this.txtDireccionProfesor.Size = new System.Drawing.Size(267, 22);
            this.txtDireccionProfesor.TabIndex = 8;
            // 
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.Location = new System.Drawing.Point(153, 191);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.Size = new System.Drawing.Size(267, 22);
            this.txtNombreProfesor.TabIndex = 7;
            // 
            // lblTelefonoProfesor
            // 
            this.lblTelefonoProfesor.AutoSize = true;
            this.lblTelefonoProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoProfesor.Location = new System.Drawing.Point(6, 316);
            this.lblTelefonoProfesor.Name = "lblTelefonoProfesor";
            this.lblTelefonoProfesor.Size = new System.Drawing.Size(93, 20);
            this.lblTelefonoProfesor.TabIndex = 6;
            this.lblTelefonoProfesor.Text = "Telefono: ";
            // 
            // lblDireccionProfesor
            // 
            this.lblDireccionProfesor.AutoSize = true;
            this.lblDireccionProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionProfesor.Location = new System.Drawing.Point(6, 249);
            this.lblDireccionProfesor.Name = "lblDireccionProfesor";
            this.lblDireccionProfesor.Size = new System.Drawing.Size(102, 20);
            this.lblDireccionProfesor.TabIndex = 5;
            this.lblDireccionProfesor.Text = "Direccion: ";
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesor.Location = new System.Drawing.Point(6, 191);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(86, 20);
            this.lblNombreProfesor.TabIndex = 4;
            this.lblNombreProfesor.Text = "Nombre: ";
            // 
            // lblCodigoProfesor
            // 
            this.lblCodigoProfesor.AutoSize = true;
            this.lblCodigoProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProfesor.Location = new System.Drawing.Point(6, 126);
            this.lblCodigoProfesor.Name = "lblCodigoProfesor";
            this.lblCodigoProfesor.Size = new System.Drawing.Size(73, 20);
            this.lblCodigoProfesor.TabIndex = 3;
            this.lblCodigoProfesor.Text = "Codigo:";
            // 
            // txtCodigoProfesor
            // 
            this.txtCodigoProfesor.Location = new System.Drawing.Point(153, 126);
            this.txtCodigoProfesor.Name = "txtCodigoProfesor";
            this.txtCodigoProfesor.Size = new System.Drawing.Size(267, 22);
            this.txtCodigoProfesor.TabIndex = 2;
            // 
            // lblidProfesor
            // 
            this.lblidProfesor.AutoSize = true;
            this.lblidProfesor.Location = new System.Drawing.Point(40, 45);
            this.lblidProfesor.Name = "lblidProfesor";
            this.lblidProfesor.Size = new System.Drawing.Size(25, 17);
            this.lblidProfesor.TabIndex = 1;
            this.lblidProfesor.Text = "ID:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 590);
            this.Controls.Add(this.grbBusquedaProfesor);
            this.Controls.Add(this.grbEdicionProfesor);
            this.Controls.Add(this.grbNavegacionProfesor);
            this.Controls.Add(this.grbDatosProfesor);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grbBusquedaProfesor.ResumeLayout(false);
            this.grbBusquedaProfesor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesor)).EndInit();
            this.grbEdicionProfesor.ResumeLayout(false);
            this.grbNavegacionProfesor.ResumeLayout(false);
            this.grbNavegacionProfesor.PerformLayout();
            this.grbDatosProfesor.ResumeLayout(false);
            this.grbDatosProfesor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaProfesor;
        private System.Windows.Forms.DataGridView grdProfesor;
        private System.Windows.Forms.TextBox txtBuscarProfesor;
        private System.Windows.Forms.GroupBox grbEdicionProfesor;
        private System.Windows.Forms.Button btnEliminarProfesor;
        private System.Windows.Forms.Button btnModificarProfesor;
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.GroupBox grbNavegacionProfesor;
        private System.Windows.Forms.Label lblnRegistrosProfesor;
        private System.Windows.Forms.Button btnUltimoProfesor;
        private System.Windows.Forms.Button btnSiguienteProfesor;
        private System.Windows.Forms.Button btnAnteriorProfesor;
        private System.Windows.Forms.Button btnPrimeroProfesor;
        private System.Windows.Forms.GroupBox grbDatosProfesor;
        private System.Windows.Forms.Label idProfesor;
        private System.Windows.Forms.TextBox txtTelefonoProfesor;
        private System.Windows.Forms.TextBox txtDireccionProfesor;
        private System.Windows.Forms.TextBox txtNombreProfesor;
        private System.Windows.Forms.Label lblTelefonoProfesor;
        private System.Windows.Forms.Label lblDireccionProfesor;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.Label lblCodigoProfesor;
        private System.Windows.Forms.TextBox txtCodigoProfesor;
        private System.Windows.Forms.Label lblidProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}
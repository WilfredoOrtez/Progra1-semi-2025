
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
            this.lblPie_Cuadrado = new System.Windows.Forms.Label();
            this.lblinicio = new System.Windows.Forms.Label();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cboAconv = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPie_Cuadrado
            // 
            this.lblPie_Cuadrado.AutoSize = true;
            this.lblPie_Cuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPie_Cuadrado.Location = new System.Drawing.Point(67, 284);
            this.lblPie_Cuadrado.Name = "lblPie_Cuadrado";
            this.lblPie_Cuadrado.Size = new System.Drawing.Size(131, 24);
            this.lblPie_Cuadrado.TabIndex = 0;
            this.lblPie_Cuadrado.Text = "Respuesta: ?";
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicio.Location = new System.Drawing.Point(215, 46);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(306, 25);
            this.lblinicio.TabIndex = 7;
            this.lblinicio.Text = "Conversor de area (superficie)";
            // 
            // cboOrigen
            // 
            this.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectareas"});
            this.cboOrigen.Location = new System.Drawing.Point(461, 130);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(184, 24);
            this.cboOrigen.TabIndex = 8;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(233, 130);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(186, 22);
            this.txtNum1.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(411, 244);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(209, 152);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cboAconv
            // 
            this.cboAconv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAconv.FormattingEnabled = true;
            this.cboAconv.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectareas"});
            this.cboAconv.Location = new System.Drawing.Point(461, 173);
            this.cboAconv.Name = "cboAconv";
            this.cboAconv.Size = new System.Drawing.Size(184, 24);
            this.cboAconv.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 509);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.cboAconv);
            this.Controls.Add(this.cboOrigen);
            this.Controls.Add(this.lblinicio);
            this.Controls.Add(this.lblPie_Cuadrado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPie_Cuadrado;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cboAconv;
    }
}


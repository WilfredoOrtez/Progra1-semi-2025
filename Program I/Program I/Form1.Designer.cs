
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblIsss = new System.Windows.Forms.Label();
            this.lblAfp = new System.Windows.Forms.Label();
            this.lblIsr = new System.Windows.Forms.Label();
            this.lblTotalDeducciones = new System.Windows.Forms.Label();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUELDO:";
            // 
            // lblIsss
            // 
            this.lblIsss.AutoSize = true;
            this.lblIsss.Location = new System.Drawing.Point(53, 121);
            this.lblIsss.Name = "lblIsss";
            this.lblIsss.Size = new System.Drawing.Size(54, 17);
            this.lblIsss.TabIndex = 1;
            this.lblIsss.Text = "ISSS: ?";
            // 
            // lblAfp
            // 
            this.lblAfp.AutoSize = true;
            this.lblAfp.Location = new System.Drawing.Point(53, 183);
            this.lblAfp.Name = "lblAfp";
            this.lblAfp.Size = new System.Drawing.Size(50, 17);
            this.lblAfp.TabIndex = 2;
            this.lblAfp.Text = "AFP: ?";
            // 
            // lblIsr
            // 
            this.lblIsr.AutoSize = true;
            this.lblIsr.Location = new System.Drawing.Point(53, 237);
            this.lblIsr.Name = "lblIsr";
            this.lblIsr.Size = new System.Drawing.Size(46, 17);
            this.lblIsr.TabIndex = 3;
            this.lblIsr.Text = "ISR: ?";
            // 
            // lblTotalDeducciones
            // 
            this.lblTotalDeducciones.AutoSize = true;
            this.lblTotalDeducciones.Location = new System.Drawing.Point(53, 284);
            this.lblTotalDeducciones.Name = "lblTotalDeducciones";
            this.lblTotalDeducciones.Size = new System.Drawing.Size(142, 17);
            this.lblTotalDeducciones.TabIndex = 4;
            this.lblTotalDeducciones.Text = "Total Deducciones: ?";
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Location = new System.Drawing.Point(53, 336);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(102, 17);
            this.lblSueldoNeto.TabIndex = 5;
            this.lblSueldoNeto.Text = "Sueldo Neto: ?";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(443, 222);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(211, 106);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(178, 70);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(201, 22);
            this.txtSueldo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 432);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.lblTotalDeducciones);
            this.Controls.Add(this.lblIsr);
            this.Controls.Add(this.lblAfp);
            this.Controls.Add(this.lblIsss);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIsss;
        private System.Windows.Forms.Label lblAfp;
        private System.Windows.Forms.Label lblIsr;
        private System.Windows.Forms.Label lblTotalDeducciones;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSueldo;
    }
}


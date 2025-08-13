
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.grpopciones = new System.Windows.Forms.GroupBox();
            this.optsuma = new System.Windows.Forms.RadioButton();
            this.optresta = new System.Windows.Forms.RadioButton();
            this.optmulti = new System.Windows.Forms.RadioButton();
            this.optdivi = new System.Windows.Forms.RadioButton();
            this.optexponente = new System.Windows.Forms.RadioButton();
            this.optporcentaje = new System.Windows.Forms.RadioButton();
            this.optfacto = new System.Windows.Forms.RadioButton();
            this.cboopciones = new System.Windows.Forms.ComboBox();
            this.btncalcularopciones = new System.Windows.Forms.Button();
            this.grpopciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(27, 35);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(53, 17);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Num 1:";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(27, 95);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(53, 17);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Num 2:";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(195, 178);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(88, 17);
            this.lblrespuesta.TabIndex = 2;
            this.lblrespuesta.Text = "Respuesta : ";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(144, 250);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(185, 91);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(119, 35);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(308, 22);
            this.txtnum1.TabIndex = 4;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(119, 92);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(308, 22);
            this.txtnum2.TabIndex = 5;
            // 
            // grpopciones
            // 
            this.grpopciones.Controls.Add(this.optfacto);
            this.grpopciones.Controls.Add(this.optporcentaje);
            this.grpopciones.Controls.Add(this.optexponente);
            this.grpopciones.Controls.Add(this.optdivi);
            this.grpopciones.Controls.Add(this.optmulti);
            this.grpopciones.Controls.Add(this.optresta);
            this.grpopciones.Controls.Add(this.optsuma);
            this.grpopciones.Location = new System.Drawing.Point(465, 44);
            this.grpopciones.Name = "grpopciones";
            this.grpopciones.Size = new System.Drawing.Size(200, 297);
            this.grpopciones.TabIndex = 6;
            this.grpopciones.TabStop = false;
            this.grpopciones.Text = "Opciones";
            // 
            // optsuma
            // 
            this.optsuma.AutoSize = true;
            this.optsuma.Checked = true;
            this.optsuma.Location = new System.Drawing.Point(19, 61);
            this.optsuma.Name = "optsuma";
            this.optsuma.Size = new System.Drawing.Size(63, 21);
            this.optsuma.TabIndex = 0;
            this.optsuma.TabStop = true;
            this.optsuma.Text = "suma";
            this.optsuma.UseVisualStyleBackColor = true;
            // 
            // optresta
            // 
            this.optresta.AutoSize = true;
            this.optresta.Location = new System.Drawing.Point(19, 88);
            this.optresta.Name = "optresta";
            this.optresta.Size = new System.Drawing.Size(61, 21);
            this.optresta.TabIndex = 1;
            this.optresta.Text = "resta";
            this.optresta.UseVisualStyleBackColor = true;
            // 
            // optmulti
            // 
            this.optmulti.AutoSize = true;
            this.optmulti.Location = new System.Drawing.Point(19, 119);
            this.optmulti.Name = "optmulti";
            this.optmulti.Size = new System.Drawing.Size(58, 21);
            this.optmulti.TabIndex = 2;
            this.optmulti.Text = "multi";
            this.optmulti.UseVisualStyleBackColor = true;
            // 
            // optdivi
            // 
            this.optdivi.AutoSize = true;
            this.optdivi.Location = new System.Drawing.Point(19, 153);
            this.optdivi.Name = "optdivi";
            this.optdivi.Size = new System.Drawing.Size(76, 21);
            this.optdivi.TabIndex = 3;
            this.optdivi.Text = "division";
            this.optdivi.UseVisualStyleBackColor = true;
            // 
            // optexponente
            // 
            this.optexponente.AutoSize = true;
            this.optexponente.Location = new System.Drawing.Point(19, 185);
            this.optexponente.Name = "optexponente";
            this.optexponente.Size = new System.Drawing.Size(95, 21);
            this.optexponente.TabIndex = 4;
            this.optexponente.Text = "exponente";
            this.optexponente.UseVisualStyleBackColor = true;
            // 
            // optporcentaje
            // 
            this.optporcentaje.AutoSize = true;
            this.optporcentaje.Location = new System.Drawing.Point(19, 222);
            this.optporcentaje.Name = "optporcentaje";
            this.optporcentaje.Size = new System.Drawing.Size(96, 21);
            this.optporcentaje.TabIndex = 5;
            this.optporcentaje.Text = "porcentaje";
            this.optporcentaje.UseVisualStyleBackColor = true;
            // 
            // optfacto
            // 
            this.optfacto.AutoSize = true;
            this.optfacto.Location = new System.Drawing.Point(19, 260);
            this.optfacto.Name = "optfacto";
            this.optfacto.Size = new System.Drawing.Size(79, 21);
            this.optfacto.TabIndex = 6;
            this.optfacto.Text = "factorial";
            this.optfacto.UseVisualStyleBackColor = true;
            // 
            // cboopciones
            // 
            this.cboopciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboopciones.FormattingEnabled = true;
            this.cboopciones.Items.AddRange(new object[] {
            "suma",
            "resta",
            "multiplicacion",
            "division",
            "exponecioasion",
            "porcentaje",
            "factorial"});
            this.cboopciones.Location = new System.Drawing.Point(741, 57);
            this.cboopciones.Name = "cboopciones";
            this.cboopciones.Size = new System.Drawing.Size(218, 24);
            this.cboopciones.TabIndex = 7;
            // 
            // btncalcularopciones
            // 
            this.btncalcularopciones.Location = new System.Drawing.Point(757, 97);
            this.btncalcularopciones.Name = "btncalcularopciones";
            this.btncalcularopciones.Size = new System.Drawing.Size(185, 91);
            this.btncalcularopciones.TabIndex = 8;
            this.btncalcularopciones.Text = "Calcular";
            this.btncalcularopciones.UseVisualStyleBackColor = true;
            this.btncalcularopciones.Click += new System.EventHandler(this.btncalcularopciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 377);
            this.Controls.Add(this.btncalcularopciones);
            this.Controls.Add(this.cboopciones);
            this.Controls.Add(this.grpopciones);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpopciones.ResumeLayout(false);
            this.grpopciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.GroupBox grpopciones;
        private System.Windows.Forms.RadioButton optdivi;
        private System.Windows.Forms.RadioButton optmulti;
        private System.Windows.Forms.RadioButton optresta;
        private System.Windows.Forms.RadioButton optsuma;
        private System.Windows.Forms.RadioButton optexponente;
        private System.Windows.Forms.RadioButton optporcentaje;
        private System.Windows.Forms.RadioButton optfacto;
        private System.Windows.Forms.ComboBox cboopciones;
        private System.Windows.Forms.Button btncalcularopciones;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btncalcular_Click(object sender, EventArgs e)
         {
            double num1, num2, respuesta = 0;
            num1 = Double.Parse(txtnum1.Text);
            num2 = Double.Parse(txtnum2.Text);

            if (optsuma.Checked){
                    respuesta = num1 + num2;
             }

            if (optresta.Checked)
            {
                respuesta = num1 - num2;
            }

            if (optmulti.Checked)
            {
                respuesta = num1 * num2;
            }

            if (optdivi.Checked)
            {
                respuesta = num1 / num2;
            }

            if (optexponente.Checked)
            {
                respuesta = Math.Pow(num1, num2);
            }

            if (optporcentaje.Checked)
            {
                respuesta = (num1 / num2) * 100;
            }
            lblrespuesta.Text = "respuesta: " + respuesta;
        }

        private void btncalcularopciones_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = double.Parse(txtnum1.Text);
            num2 = double.Parse(txtnum2.Text);

            switch (cboopciones.SelectedIndex)
            {
                case 0:
                    respuesta = num1 + num2;
                    break;

                case 1:
                    respuesta = num1 - num2;
                    break;

                case 2:
                    respuesta = num1 * num2;
                    break;

                case 3:
                    respuesta = num1 / num2;
                    break;
            }
            lblrespuesta.Text = "respuesta: " + respuesta;
        }
    }
}

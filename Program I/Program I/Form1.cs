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

        private void btncalcular_Click_1(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = Double.Parse(txtnum1.Text);
            num2 = Double.Parse(txtnum2.Text);

            if (optsuma.Checked)
            {
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

            if (optfacto.Checked)
            {
                respuesta = (int)num1;
                for (int i = (int)num1; i > 1; i--)
                {
                    respuesta *= i;
                }
            }

            lblrespuesta.Text = "Respuesta: " + respuesta;

            if (optprimo.Checked)
            {
                int i = 1, acum = 0;
                while (i <= num1 & acum < 3)
                {
                    if (num1 % 1 == 0)
                    {
                        acum++;
                    }
                    i++;
                }
                if (acum <= 2)
                {
                    lblrespuesta.Text = "Respuesta" + num1 + " es primo";
                }
                else
                {
                    lblrespuesta.Text = "Respuesta" + num1 + " No es primo";
                }

            }

            lblrespuesta.Text = "respuesta: " + respuesta;
        }
    }
    
}

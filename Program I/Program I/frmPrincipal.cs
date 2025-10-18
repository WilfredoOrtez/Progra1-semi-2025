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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objAlumnos = new Form1();
            objAlumnos.MdiParent = this;
            objAlumnos.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias objMateria = new frmMaterias();
            objMateria.MdiParent = this;
            objMateria.Show();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodos objPeriodo = new frmPeriodos();
            objPeriodo.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 objProfesor = new Form2();
            objProfesor.MdiParent = this;
            objProfesor.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmNotas objNota = new frmNotas();
            objNota.MdiParent = this;
            objNota.Show();
        }
    }
}

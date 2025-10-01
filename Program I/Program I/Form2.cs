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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Conexion objconexion2 = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        public void actualizarDs()
        {
            objDs.Clear();//limpiar dataset
            objDs = objconexion2.obtenerDatos();
            objDt = objDs.Tables["Profesor"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idProfesor"] };

            grdProfesor.DataSource = objDt.DefaultView;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idProfesor.Text = objDt.Rows[posicion]["idProfesor"].ToString();
                txtCodigoProfesor.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreProfesor.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionProfesor.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoProfesor.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblnRegistrosProfesor.Text = (posicion + 1) + "de" + objDt.Rows.Count;
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnSiguienteProfesor_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorProfesor_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoProfesor_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPrimeroProfesor_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosProfesor.Enabled = estado;
            grbNavegacionProfesor.Enabled = !estado;
            btnEliminarProfesor.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idProfesor.Text = "";
            txtCodigoProfesor.Text = "";
            txtNombreProfesor.Text = "";
            txtDireccionProfesor.Text = "";
            txtTelefonoProfesor.Text = "";
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            if (btnAgregarProfesor.Text == "Nuevo")
            {
                btnAgregarProfesor.Text = "Guardar";
                btnModificarProfesor.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] alumnos = {
                    idProfesor.Text, txtCodigoProfesor.Text, txtNombreProfesor.Text, txtDireccionProfesor.Text,
                    txtTelefonoProfesor.Text
                };
                String respuesta = objconexion2.administrarDatosAlumnos(alumnos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarProfesor.Text = "Nuevo";
                    btnModificarProfesor.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnModificarProfesor_Click(object sender, EventArgs e)
        {
            if (btnModificarProfesor.Text == "Modificar")
            {
                btnAgregarProfesor.Text = "Guardar";
                btnModificarProfesor.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarProfesor.Text = "Nuevo";
                btnModificarProfesor.Text = "Modificar";
            }
        }

        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreProfesor.Text,
                "Eliminando alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objconexion2.administrarDatosAlumnos(
                    new String[] { idProfesor.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void txtBuscarProfesor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarProfesor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void filtrarDatos(string valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;
                objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '" + valor + "%'";
                grdProfesor.DataSource = objDv;
                seleccionarProfesor();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void seleccionarProfesor()
        {
            try
            {
                if (grdProfesor.CurrentRow == null)
                {
                    MessageBox.Show("No hay filas");
                    return;
                }
                string id = grdProfesor.CurrentRow.Cells["id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void grdProfesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarProfesor();
        }

        
    }
}

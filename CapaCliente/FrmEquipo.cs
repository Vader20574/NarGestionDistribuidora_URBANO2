using Servicios.Implementacion;
using Servicios.Interfaces.Equipo;
using Servicios.Interfaces.Equipo.Peticiones;
using Servicios.Interfaces.Equipo.Respuestas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaCliente
{

    

    public partial class FrmEquipo : Form
    {

        IGestorDeEquipo gestorDeVenta = new GestorDeEquipo();
        int FLAG = 0;

        public FrmEquipo()
        {
            InitializeComponent();
        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, false);
            Limpiar();
            bloquea(true);
            FLAG = 0;
        }


        void Limpiar()
        {
            txtCodigo.Text = "";
            txtDesc1.Text = "";
            txtDesc2.Text = "";
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {

            dgvEquipo.DataSource= gestorDeVenta.Listar();
            BOTONES(true, false, true, true, true);
            bloquea(false);
        }

        void bloquea(Boolean estado)
        {
            txtCodigo.Enabled = estado;
            txtDesc1.Enabled = estado;
            txtDesc2.Enabled = estado;
        }


        void BOTONES(bool NUEVO, bool GUARDAR, bool MODIFICAR, bool ELIMINAR, bool BUSCAR)
        {
            BTNNUEVO.Enabled = NUEVO;
            BTNGUARDAR.Enabled = GUARDAR;
            BTNMODIFICAR.Enabled = MODIFICAR;
            BTNELIMINAR.Enabled = ELIMINAR;
        
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {


            if (FLAG == 0)
            {

                EquipoRegistrado registroGuardos;
                registroGuardos = gestorDeVenta.FindById(Convert.ToString(txtCodigo.Text));

                if (registroGuardos != null)
                {
                    MessageBox.Show("Equipo Existe");
                    return;
                }


                EquipoNuevo nuevoEquipo = new EquipoNuevo();
            nuevoEquipo.Codigo = txtCodigo.Text;
            nuevoEquipo.Descripcion = txtDesc1.Text;
            nuevoEquipo.Descripcion2 = txtDesc2.Text;
            gestorDeVenta.Registrar(nuevoEquipo);
            dgvEquipo.DataSource = gestorDeVenta.Listar();

            }

            if (FLAG == 1)
            {
                EquipoActualizar actualizarEquipo = new EquipoActualizar();
                actualizarEquipo.Codigo = txtCodigo.Text;
                actualizarEquipo.Descripcion = txtDesc1.Text;
                actualizarEquipo.Descripcion2 = txtDesc2.Text;
                gestorDeVenta.Actualizar(actualizarEquipo);
                dgvEquipo.DataSource = gestorDeVenta.Listar();
            }




            BOTONES(true, false, true, true, true);
            bloquea(false);

        }

        private void dgvEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEquipo_DoubleClick(object sender, EventArgs e)
        {


            txtCodigo.Text = dgvEquipo.CurrentRow.Cells[0].Value.ToString();
            txtDesc1.Text = dgvEquipo.CurrentRow.Cells[1].Value.ToString();
            txtDesc2.Text = dgvEquipo.CurrentRow.Cells[2].Value.ToString();


        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, true);
            FLAG = 1;
            bloquea(true);
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Length > 0)
            {

            gestorDeVenta.Borrar(txtCodigo.Text.ToString());
            BOTONES(true, false, true, true, true);
            Limpiar();
            bloquea(false);
            dgvEquipo.DataSource = gestorDeVenta.Listar();

            }
            else
            {
                MessageBox.Show("Codigo equipo esta vacio");
            }



        }

        private void BTNCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

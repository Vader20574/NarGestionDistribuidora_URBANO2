using Servicios.Implementacion;
using Servicios.Interfaces.Equipo;
using Servicios.Interfaces.Equipo.Peticiones;
using Servicios.Interfaces.Equipo.Respuestas;
using Servicios.Interfaces.EquipoVendedor;
using Servicios.Interfaces.EquipoVendedor.Peticiones;
using Servicios.Interfaces.EquipoVendedor.Respuestas;
using Servicios.Interfaces.Vendedor;
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

    

    public partial class FrmEquipoVendedor : Form
    {

        IGestoDeEquipoVendedor gestorDeEquipoVendedor = new GestoDeEquipoVendedor();
        int FLAG = 0;

        public FrmEquipoVendedor()
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
        
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {

            dgvEquipoVend.DataSource= gestorDeEquipoVendedor.Listar();


            IGestorDeEquipo gestordeEquipo = new GestorDeEquipo();
            cbEquipo.DataSource = gestordeEquipo.Listar();
            cbEquipo.ValueMember = "Codigo";
            cbEquipo.DisplayMember = "Descripcion";

            IGestorDeVendedor gestordeVend = new GestorDeVendedor();
            cbVendedor.DataSource = gestordeVend.Listar();
            cbVendedor.ValueMember = "CODVEND";
            cbVendedor.DisplayMember = "DSVEND";


            BOTONES(true, false, true, true, true);
            bloquea(false);





        }

        void bloquea(Boolean estado)
        {
           
            cbEquipo.Enabled = estado;
            cbVendedor.Enabled = estado;
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

                Equipo_VendedorRegistrado registroGuardos;
                //registroGuardos = gestorDeEquipoVendedor.FindById(Convert.ToInt16( txtCodigo.Text));

                //if (registroGuardos != null)
                //{
                //    MessageBox.Show("Equipo Existe");
                //    return;
                //}


                Equipo_VendedorNuevo nuevoEquipoVend = new Equipo_VendedorNuevo();
                /*nuevoEquipoVend.Id =Convert.ToInt32(txtCodigo.Text)*/;
                nuevoEquipoVend.CodEquipo = cbEquipo.SelectedValue.ToString();
                nuevoEquipoVend.CodVend= cbVendedor.SelectedValue.ToString();
                gestorDeEquipoVendedor.Registrar(nuevoEquipoVend);
            dgvEquipoVend.DataSource = gestorDeEquipoVendedor.Listar();

            }

            if (FLAG == 1)
            {
                Equipo_VendedorActualizar actualizarEquipo = new Equipo_VendedorActualizar();
                actualizarEquipo.Id = Convert.ToInt32( txtCodigo.Text);
                actualizarEquipo.CodEquipo= cbEquipo.SelectedValue.ToString();
                actualizarEquipo.CodVend = cbVendedor.SelectedValue.ToString();
                gestorDeEquipoVendedor.Actualizar(actualizarEquipo);
                dgvEquipoVend.DataSource = gestorDeEquipoVendedor.Listar();
            }




            BOTONES(true, false, true, true, true);
            bloquea(false);

        }

        private void dgvEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEquipo_DoubleClick(object sender, EventArgs e)
        {


            txtCodigo.Text = dgvEquipoVend.CurrentRow.Cells[0].Value.ToString();
            cbEquipo.SelectedValue = dgvEquipoVend.CurrentRow.Cells[1].Value.ToString();
            cbVendedor.SelectedValue = dgvEquipoVend.CurrentRow.Cells[2].Value.ToString();


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

                gestorDeEquipoVendedor.Borrar(Convert.ToInt32(txtCodigo.Text));
            BOTONES(true, false, true, true, true);
            Limpiar();
            bloquea(false);
            dgvEquipoVend.DataSource = gestorDeEquipoVendedor.Listar();

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
    }
}

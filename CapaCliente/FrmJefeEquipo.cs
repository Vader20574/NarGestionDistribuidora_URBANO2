using CapaDatafirst.Reportes;
using Servicios.Implementacion;
using Servicios.Interfaces.Equipo;
using Servicios.Interfaces.Equipo.Peticiones;
using Servicios.Interfaces.Equipo.Respuestas;
using Servicios.Interfaces.Jefe_Equipo;
using Servicios.Interfaces.Jefe_Equipo.Peticiones;
using Servicios.Interfaces.Jefe_Equipo.Respuestas;
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


    public partial class FrmJefeEquipo : Form
    {

        IGestorDeJefe_Equipo gestorDeEquipVend = new GestorDeJefe_Equipo();
        int FLAG = 0;

        public FrmJefeEquipo()
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
            txtNombJefe.Text = "";
            txtDatoPerso.Text = "";
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            IGestorDeEquipo gestordeEquipo = new GestorDeEquipo();
            cbEquipo.DataSource = gestordeEquipo.Listar();
            cbEquipo.ValueMember = "Codigo";
            cbEquipo.DisplayMember = "Descripcion";

          
            dgvJefeEquipo.DataSource= gestorDeEquipVend.Listar();
            BOTONES(true, false, true, true, true);
            bloquea(false);
        }

        void bloquea(Boolean estado)
        {
           
            txtNombJefe.Enabled = estado;
            txtDatoPerso.Enabled = estado;
            cbEquipo.Enabled = estado;
         
            dtpFechaIni.Enabled = estado;
            dtpFin.Enabled = estado;
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
                
                //Jefe_EquipoRegistro registroGuardos;
                //registroGuardos = gestorDeEquipVend.FindById(Convert.ToInt32(txtCodigo.Text));

                //if (registroGuardos != null)
                //{
                //    MessageBox.Show("Equipo Existe");
                //    return;
                //}


                Jefe_EquipoNuevo nuevoEquipoVend = new Jefe_EquipoNuevo();
                //nuevoEquipoVend.Id= Convert.ToInt32(txtCodigo.Text);
                nuevoEquipoVend.NombreJefe= txtNombJefe.Text;
                nuevoEquipoVend.DatosPersonales = txtDatoPerso.Text;          
                nuevoEquipoVend.CodEquipoVend = cbEquipo.SelectedValue.ToString();

                //DateTime f = this.dtpFechaIni.Value;
                //DateTime f2 = this.dtpFin.Value;

                //String fECHAI = String.Format(f.ToShortDateString(), "dd/mm/aaaa");
                //String fECHAF = String.Format(f2.ToShortDateString(), "dd/mm/aaaa");



                nuevoEquipoVend.Fecha_Inicio = this.dtpFechaIni.Value;
                nuevoEquipoVend.Fecha_Fin = this.dtpFin.Value;

                gestorDeEquipVend.Registrar(nuevoEquipoVend);
                dgvJefeEquipo.DataSource = gestorDeEquipVend.Listar();

            }

            if (FLAG == 1)
            {
                Jefe_EquipoActualizar actualizarEquipoVend = new Jefe_EquipoActualizar();
                actualizarEquipoVend.Id = Convert.ToInt32(txtCodigo.Text);
                actualizarEquipoVend.NombreJefe = txtNombJefe.Text;
                actualizarEquipoVend.DatosPersonales = txtDatoPerso.Text;
                actualizarEquipoVend.Fecha_Inicio = this.dtpFechaIni.Value;
                actualizarEquipoVend.Fecha_Fin = this.dtpFin.Value;
                actualizarEquipoVend.CodEquipoVend = cbEquipo.SelectedValue.ToString();

                gestorDeEquipVend.Actualizar(actualizarEquipoVend);
                dgvJefeEquipo.DataSource = gestorDeEquipVend.Listar();
            }




            BOTONES(true, false, true, true, true);
            bloquea(false);

        }

        private void dgvEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEquipo_DoubleClick(object sender, EventArgs e)
        {
            txtCodigo.Text = dgvJefeEquipo.CurrentRow.Cells[0].Value.ToString();
            txtNombJefe.Text = dgvJefeEquipo.CurrentRow.Cells[1].Value.ToString();
            txtDatoPerso.Text = dgvJefeEquipo.CurrentRow.Cells[2].Value.ToString();
            cbEquipo.SelectedValue = dgvJefeEquipo.CurrentRow.Cells[3].Value.ToString();     
            dtpFechaIni.Value= Convert.ToDateTime(String.Format(dgvJefeEquipo.CurrentRow.Cells[4].Value.ToString(), "dd/mm/aaaa"));
            dtpFin.Value = Convert.ToDateTime(String.Format(dgvJefeEquipo.CurrentRow.Cells[5].Value.ToString(), "dd/mm/aaaa"));





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

             gestorDeEquipVend.Borrar(Convert.ToInt32(txtCodigo.Text));
            BOTONES(true, false, true, true, true);
            Limpiar();
            bloquea(false);
            dgvJefeEquipo.DataSource = gestorDeEquipVend.Listar();

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {

            FrmRpt_EquipoVentas frm = new FrmRpt_EquipoVentas();
            frm.ShowDialog();

          
        }
    }
}

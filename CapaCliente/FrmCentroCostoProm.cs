using Servicios.Implementacion;
using Servicios.Interfaces.CentroCostoPromo;
using Servicios.Interfaces.CentroCostoPromo.Peticiones;
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

    public partial class FrmCentroCostoProm : Form
    {

        IGestorDeCentroCostoPromo gestorDeCentroCostoPromo = new GestorDeCentroCostoPromo();
        int FLAG = 0;

        public FrmCentroCostoProm()
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
           
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {

            dgvEquipo.DataSource= gestorDeCentroCostoPromo.Listar();
            BOTONES(true, false, true, true, true);
            bloquea(false);
        }

        void bloquea(Boolean estado)
        {
          
            txtDesc1.Enabled = estado;
            
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

                //EquipoRegistrado registroGuardos;
                //registroGuardos = gestorDeCentroCostoPromo.FindById(Convert.ToInt64(txtCodigo.Text));

                //if (registroGuardos != null)
                //{
                //    MessageBox.Show("Equipo Existe");
                //    return;
                //}


                CentroCostoPromoNuevo nuevoCentroCostoPromo = new CentroCostoPromoNuevo();
             
                nuevoCentroCostoPromo.NombCentroProm = txtDesc1.Text;
                gestorDeCentroCostoPromo.Registrar(nuevoCentroCostoPromo);
            dgvEquipo.DataSource = gestorDeCentroCostoPromo.Listar();

            }

            if (FLAG == 1)
            {
                CentroCostoPromoActualizar actualizarCentroCostoPromo = new CentroCostoPromoActualizar();
                actualizarCentroCostoPromo.Id =Convert.ToInt16(txtCodigo.Text);
                actualizarCentroCostoPromo.NombCentroProm = txtDesc1.Text;
                gestorDeCentroCostoPromo.Actualizar(actualizarCentroCostoPromo);
                dgvEquipo.DataSource = gestorDeCentroCostoPromo.Listar();
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

            gestorDeCentroCostoPromo.Borrar(Convert.ToInt16(txtCodigo.Text));
            BOTONES(true, false, true, true, true);
            Limpiar();
            bloquea(false);
            dgvEquipo.DataSource = gestorDeCentroCostoPromo.Listar();

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

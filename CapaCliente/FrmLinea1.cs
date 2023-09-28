using Servicios.Implementacion;
using Servicios.Interfaces.Linea;
using Servicios.Interfaces.Linea.Peticiones;
using Servicios.Interfaces.TipoProducto;
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
    public partial class FrmLinea1 : Form
    {
        public FrmLinea1()
        {
            InitializeComponent();
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
      

            IGestorDeLinea gestorDeLinea = new GestorDeLinea();
            LineaNuevo nuevolinea = new LineaNuevo();
            nuevolinea.CODEMPRESA = "01";
            nuevolinea.CODLINEA = txtcod.Text;
            nuevolinea.DESLINEA = txtdescripcion.Text;
            nuevolinea.ESTADO = true;
            nuevolinea.CODTIPOPROD = cbotipoprod.SelectedValue.ToString();
            nuevolinea.CORRELATIVO =  Convert.ToDecimal(TxtCorrelat.Text);
            gestorDeLinea.Registrar(nuevolinea);
            BOTONES(true, false, false, false, true);
            LimpiarTextBox(this);
            LimpiarCajas(GroupBox2);
            cbotipoprod.Enabled = false;

            MessageBox.Show("Hola");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            IGestorDeTipoProd gestorDeTipoProd = new GestorDeTipoProd();
            cbotipoprod.DataSource = gestorDeTipoProd.Listar();
            cbotipoprod.ValueMember = "CODTIPOPRO";
            cbotipoprod.DisplayMember = "DESCRIP";
        }


        void BOTONES(bool NUEVO, bool GUARDAR, bool MODIFICAR, bool ELIMINAR, bool BUSCAR)
        {
            BTNNUEVO.Enabled = NUEVO;
            BTNGUARDAR.Enabled = GUARDAR;
            BTNMODIFICAR.Enabled = MODIFICAR;
            BTNELIMINAR.Enabled = ELIMINAR;
            btnbuscar.Enabled = BUSCAR;
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarLinea frm = new FrmBuscarLinea();
            frm.VIE = this;
            frm.ShowDialog();
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            IGestorDeLinea gestorDeLinea = new GestorDeLinea();
            LineaActualizar lineaActualizar = new LineaActualizar();
            lineaActualizar.CODEMPRESA = "01";
            lineaActualizar.CODLINEA= txtcod.Text;
            lineaActualizar.DESLINEA= txtdescripcion.Text;
            lineaActualizar.CODTIPOPROD = cbotipoprod.SelectedValue.ToString();
            lineaActualizar.CORRELATIVO = Convert.ToDecimal(TxtCorrelat.Text);
            gestorDeLinea.Actualizar(lineaActualizar);

        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            IGestorDeLinea gestorDeLinea = new GestorDeLinea();
            gestorDeLinea.Borrar(Convert.ToInt32(txtcod.Text));

        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, false);
            txtcod.Enabled = true;
            txtdescripcion.Enabled = true;
            TxtCorrelat.Enabled = true;
            cbotipoprod.Enabled = true;
            txtcod.Focus();
            LimpiarTextBox(this);
            LimpiarCajas(GroupBox2);
        }

        private void LimpiarTextBox(Form ofrm)
        {
            // hace un chequeo por todos los textbox del formulario
            foreach (Control oControls in ofrm.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // eliminar el texto
                   
                }

            }
        }



        void LimpiarCajas(System.Windows.Forms.GroupBox Grupo)
        {
            TextBox caja = default(TextBox);
            foreach (Control ctrl in Grupo.Controls)
            {
                caja = ctrl as TextBox;
                if ((caja != null))
                {
                    caja.Clear();
                }
            }
        }


        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            BOTONES(true, false, false, false, true);
            LimpiarTextBox(this);
            txtcod.Enabled = false;
            txtdescripcion.Enabled = false;
            cbotipoprod.Enabled = false;
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

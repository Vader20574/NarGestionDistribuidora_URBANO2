using Servicios.Implementacion;
using Servicios.Interfaces.Facturacion;
using Servicios.Interfaces.Facturacion.VentaCab;
using Servicios.Interfaces.Facturacion.VentaCab.Peticiones;
using Servicios.Interfaces.TipoDoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace CapaCliente
{


     
    
    public partial class FrmDocAnulados : Form
    {
     public string codlinea; 
      Boolean agregar = false;
        public FrmDocAnulados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        void BOTONES(bool NUEVO, bool GUARDAR, bool MODIFICAR, bool ELIMINAR, bool BUSCAR)
        {
            BTNNUEVO.Enabled = NUEVO;
            BTNGUARDAR.Enabled = GUARDAR;
            BTNMODIFICAR.Enabled = MODIFICAR;
            BTNELIMINAR.Enabled = ELIMINAR;
            btnBuscarDocAnulados.Enabled = BUSCAR;
        }



        public enum TipoDoc
        {
            Nota_Pedido = 6,
            Factura = 1,
            Boleta = 3
        }

        public class Prueba
        {
            private int _key;
            public int Key
            {
                get
                {
                    return _key;
                }
                set
                {
                    _key = value;
                }
            }


            private string _value;
            public string Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }
        }





        private void FrmDocAnulados_Load(object sender, EventArgs e)
        {


                List<Prueba> result = new List<Prueba>();

                foreach (int item in Enum.GetValues(typeof(TipoDoc)))
                {
                    Prueba _prueba = new Prueba();
                    _prueba.Key = item;
                    _prueba.Value = Enum.GetName(typeof(TipoDoc), item);

                    result.Add(_prueba);
                }
           


            cmbTipoDoc.ValueMember = "key";
            cmbTipoDoc.DisplayMember = "value";
            cmbTipoDoc.DataSource = result;
           




            BOTONES(true, false, false, false, true);

            txtCod.Enabled = false;
            txtNroDoc.Enabled = false;
            cmbTipoDoc.Enabled = false;

        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            if(agregar == true){
            IGestorDeFacturacionVentaCab gestorDeVenta = new GestorDeFacturacionVentaCabA();
            NuevaVentacab nuevoRegistro = new NuevaVentacab();
            nuevoRegistro.NRODOCU = txtNroDoc.Text;
            nuevoRegistro.CODTIPODOC =  "0" + cmbTipoDoc.SelectedValue.ToString();
            nuevoRegistro.CODVEND = codlinea;


            using (TransactionScope scope = new TransactionScope())
            {
                    gestorDeVenta.CrearVentaCab(nuevoRegistro);
                    scope.Complete();
            }

            }
            else
            {

                IGestorDeFacturacionVentaCab gestorDeLinea = new GestorDeFacturacionVentaCabA();
                VentacabActualizar lineaActualizar = new VentacabActualizar();
                lineaActualizar.ID = Convert.ToInt32(txtCod.Text);
                lineaActualizar.NRODOCU = txtNroDoc.Text;
                lineaActualizar.CODTIPODOC = "0" + cmbTipoDoc.SelectedValue.ToString();

                using (TransactionScope scope = new TransactionScope())
                {
                    gestorDeLinea.Actualizar(lineaActualizar);
                    scope.Complete();
                }

            }

            txtCod.Enabled = false;
            txtNroDoc.Enabled = false;
            cmbTipoDoc.Enabled = false;

            txtNroDoc.Text = "";
            BOTONES(true, false, false, false, true);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {



        }

        private void btnBuscarDocAnulados_Click(object sender, EventArgs e)
        {
            FrmBuscarAnulados frmbus = new FrmBuscarAnulados();
            frmbus.VIE = this;
            frmbus.codlinea = codlinea;
            BOTONES(true, false, true, true, true);
            frmbus.ShowDialog();
        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, false);

            txtCod.Enabled = false;
            txtNroDoc.Enabled = true;
            cmbTipoDoc.Enabled = true;
            txtNroDoc.Text = "";
            txtNroDoc.Focus();

            agregar = true;
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            IGestorDeFacturacionVentaCab gestorDeLinea = new GestorDeFacturacionVentaCabA();
            NuevaVentacab nuevoRegistro = new NuevaVentacab();
            //nuevoRegistro.CodDoc = 1;
            nuevoRegistro.ID = Convert.ToInt32(txtCod.Text);
            using (TransactionScope scope = new TransactionScope())
            {
                gestorDeLinea.Borrar(nuevoRegistro);
                scope.Complete();
            }

            txtCod.Enabled = false;
            txtNroDoc.Enabled = false;
            cmbTipoDoc.Enabled = false;
            txtCod.Text = "";
            txtNroDoc.Text = "";
            txtNroDoc.Focus();

        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, false);
            txtNroDoc.Enabled = true;
            cmbTipoDoc.Enabled = true;
            agregar = false;
        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            BOTONES(true, false, false, false, true);

            txtCod.Text = "";
            txtNroDoc.Text = "";
            txtCod.Enabled = false;
            txtNroDoc.Enabled = false;
            cmbTipoDoc.Enabled = false;
     
        }

        private void BTNCERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNroDoc_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtNroDoc_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

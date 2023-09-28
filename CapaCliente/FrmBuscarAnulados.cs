using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios.Interfaces.Facturacion;
using Servicios.Implementacion;
using Servicios.Interfaces.Facturacion.VentaCab;
using Servicios.Interfaces.Linea.Respuestas;
using Servicios.Interfaces.Facturacion.VentaCab.Respuestas;
using Servicios.Interfaces.TipoDoc;

namespace CapaCliente
{
    public partial class FrmBuscarAnulados : Form
    {
        public FrmDocAnulados VIE = new FrmDocAnulados();
        public string codlinea; 

        public FrmBuscarAnulados()
        {
            InitializeComponent();
        }

        private void txtdato_TextChanged(object sender, EventArgs e)
        {

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



        private void FrmBuscarAnulados_Load(object sender, EventArgs e)
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

            llenar();


        }

        void llenar()
        {
            IGestorDeFacturacionVentaCab gestorDefactanul = new GestorDeFacturacionVentaCabA();
            VentaCabRegistrado nuevoregistrador = new VentaCabRegistrado();

            DgvDocAnulados.AutoGenerateColumns = false;

            nuevoregistrador.NRODOCU = txtdato.Text;
            nuevoregistrador.CODTIPODOC =    "0"+ cmbTipoDoc.SelectedValue.ToString();
            nuevoregistrador.CODVEND = codlinea;
            DgvDocAnulados.DataSource = gestorDefactanul.Filtrar(nuevoregistrador);

            //if (DgvLinea.CurrentRow != null)
            //{
            //    this.DgvLinea.Columns["NRODOCU"].Visible = false;
            //}

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenar();
        }

        private void txtdato_KeyDown(object sender, KeyEventArgs e)
        {
             
        }

        private void txtdato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                llenar();
            }
        }

        private void DgvLinea_DoubleClick(object sender, EventArgs e)
        {

            VIE.txtCod.Text = DgvDocAnulados.CurrentRow.Cells[0].Value.ToString();
            VIE.txtNroDoc.Text = DgvDocAnulados.CurrentRow.Cells[1].Value.ToString();


            VIE.cmbTipoDoc.SelectedValue = Convert.ToInt32(DgvDocAnulados.CurrentRow.Cells[2].Value.ToString());


            this.Close();
        }

        private void DgvDocAnulados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenar();
        }
    }
}

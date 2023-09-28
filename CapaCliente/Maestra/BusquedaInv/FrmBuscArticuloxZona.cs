using Servicios.Implementacion;
using Servicios.Interfaces.Articulo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaCliente.Maestra.BusquedaInv
{
    public partial class FrmBuscArticuloxZona : Form
    {

        public bool DEVOLVER;
        public string CODZONA;
        public string DESZONA;

        public FrmBuscArticuloxZona()
        {
            InitializeComponent();
        }

        private void FrmBuscArticuloxZona_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + "  en la Zona " + DESZONA;

            CargarGridForm();

        }

        void CargarGridForm()
        {

            IGestorDeArticulo gestdeart= new GestorDeArticulo();
            dgvArticulo.DataSource= gestdeart.SP_LISTA_ARTICULO_FACT("01", CODZONA, 0);

        }

        private void dgvArticulo_DoubleClick(object sender, EventArgs e)
        {
            DEVOLVER = true;
            Close();
        }

        private void dgvArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtdato_TextChanged(object sender, EventArgs e)
        {
        //    If Me.rbcodigo.Checked = True Then
        //  TABLEART = TmpListarDatos("SP_LISTA_ARTICULO_FACT_FILTRO  '" & codempresa & "','" & CODZONA & "','" & 0 & "','" & txtdato.Text & "'")
        //    GridArt.DataSource = TABLEART
        //Else
        //    TABLEART = TmpListarDatos("SP_LISTA_ARTICULO_FACT_FILTRO  '" & codempresa & "','" & CODZONA & "','" & 1 & "','" & txtdato.Text & "'")
        //    GridArt.DataSource = TABLEART
        //End If


            if (rbcodigo.Checked == true)
            {
                IGestorDeArticulo gestdeart = new GestorDeArticulo();
                dgvArticulo.DataSource = gestdeart.SP_LISTA_ARTICULO_FACT_FILTRO("01", CODZONA, 0, txtdato.Text);
            }
            else
            {
                IGestorDeArticulo gestdeart = new GestorDeArticulo();
                dgvArticulo.DataSource = gestdeart.SP_LISTA_ARTICULO_FACT_FILTRO("01", CODZONA, 1, txtdato.Text);
            }

          
        }
    }
}

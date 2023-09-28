using CapaCliente.Reportes;
using CapaDatafirst;
using Servicios.Implementacion;
using Servicios.Interfaces.Vendedor;
using Servicios.Interfaces.Vendedor.Respuestas;
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
    public partial class FrmPedidoxVendedor : Form
    {

        List<VendedorRegistrado> ListaV = new List<VendedorRegistrado>();
        List<VendedorRegistrado> ListaV2 = new List<VendedorRegistrado>();


        int i;

        public FrmPedidoxVendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            string cORRE =  rnd.Next().ToString();

            using (NARGESTEntities context = new NARGESTEntities())
            {
                context.SP_DELETE_TMP_VENDEDOR(cORRE);
                for (int a = 0; a <= this.ListaV2.Count - 1; a++)
                {
                    context.SP_INSERT_TMP_VENDEDOR(Int32.Parse(cORRE), ListaV2[a].CODVEND);
                }
            }

            using (NARGESTEntities context = new NARGESTEntities())
            {
                DateTime f = this.dtpfechaD.Value;
                DateTime f2 = this.dtpfechaH.Value;

                string fECHAD = String.Format(f.ToShortDateString(), "dd/mm/aaaa");
                string fECHAH = String.Format(f2.ToShortDateString(), "dd/mm/aaaa");
                context.SP_PEDIDO_XVENDEDOR(fECHAD, fECHAH, cORRE);
            }

            FrmRpt_PedidoxVendedor frm = new FrmRpt_PedidoxVendedor(cORRE);
            frm.Show();

        }

        private void btnpasdet_Click(object sender, EventArgs e)
        {
            for (int k = 0; k <= ListaV.Count - 1; k++)
            {
                ListaV2.Add(ListaV[k]);
            }
            ListaV.Clear();
            Actualizar(1);
        }

        private void Actualizar(Int16 a)
        {
            switch (a)
            {
                case 0:
                    break;
                //Me.lbfuerza1.DataSource = Nothing
                //Me.lbfuerza2.DataSource = Nothing
                //Me.lbfuerza1.DataSource = ListaF
                //Me.lbfuerza2.DataSource = ListaF2
                case 1:
                    this.lbvende1.DataSource = null;
                    this.lbvende2.DataSource = null;
                    this.lbvende1.DataSource = ListaV;
                    this.lbvende1.DisplayMember = "DSVEND";
                    this.lbvende2.DataSource = ListaV2;
                    this.lbvende2.DisplayMember = "DSVEND";
                    break;
                case 2:
                    break;
                    //Me.lbruta1.DataSource = Nothing
                    //Me.lbruta2.DataSource = Nothing
                    //Me.lbruta1.DataSource = ListaR
                    //Me.lbruta2.DataSource = ListaR2
            }

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            IGestorDeVendedor GestordeLinea = new GestorDeVendedor();

           

            ListaV = GestordeLinea.Listar();
            ///dataGridView1.DataSource = ListaV;
            lbvende1.DataSource = ListaV;
            lbvende1.DisplayMember = "DSVEND";


        
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnpasde_Click(object sender, EventArgs e)
        {
            i = this.lbvende1.SelectedIndex;
            if (i < 0)
                return;
            ListaV2.Add(ListaV[i]);
            ListaV.RemoveAt(i);
            Actualizar(1);
        }

        private void btnpassiz_Click(object sender, EventArgs e)
        {
            i = this.lbvende2.SelectedIndex;
            if (i < 0)
                return;
            ListaV.Add(ListaV2[i]);
            ListaV2.RemoveAt(i);
            Actualizar(1);
        }

        private void btnpassizt_Click(object sender, EventArgs e)
        {
            for (int k = 0; k <= ListaV2.Count - 1; k++)
            {
                ListaV.Add(ListaV2[k]);
            }
            ListaV2.Clear();
            Actualizar(1);
        }
    }
}

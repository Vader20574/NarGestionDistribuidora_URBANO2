using Servicios.Implementacion;
using Servicios.Interfaces.Linea;
using Servicios.Interfaces.Linea.Respuestas;
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
    
    

    public partial class FrmBuscarLinea : Form
    {
        public FrmLinea1 VIE = new FrmLinea1();
     


        public FrmBuscarLinea()
        {
            InitializeComponent();
        }

        private void FrmBuscarLinea_Load(object sender, EventArgs e)
        {


            IGestorDeLinea gestorDeLinea = new GestorDeLinea();

            using (TransactionScope scope = new TransactionScope())
            {
                DgvLinea.DataSource = gestorDeLinea.Listar();
                scope.Complete();
            }

            ////this.DgvLinea.ColumnCount = 3;
            //this.DgvLinea.Columns[0].Name = "CODLINEA";
            //this.DgvLinea.Columns[1].Name = "DESLINEA";
            //this.DgvLinea.Columns[2].Name = "CORRELATIVO";

        }

        private void txtdato_TextChanged(object sender, EventArgs e)
        {

            llenar();

        }

        void llenar()
        {
            IGestorDeLinea gestorDeLinea = new GestorDeLinea();
            LineaRegistrado nuevoregistrador = new LineaRegistrado();

            if (RadioButton1.Checked == true)
                {
                nuevoregistrador.CODLINEA = txtdato.Text;
                DgvLinea.DataSource = gestorDeLinea.Filtrar(nuevoregistrador);
                }
            else
            {
                nuevoregistrador.DESLINEA = txtdato.Text;
                DgvLinea.DataSource = gestorDeLinea.Filtrar(nuevoregistrador);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            IGestorDeLinea gestorDeLinea = new GestorDeLinea();
            LineaRegistrado nuevoregistrador = new LineaRegistrado();
            nuevoregistrador.CODLINEA = txtdato.Text;
            DgvLinea.DataSource = gestorDeLinea.Filtrar(nuevoregistrador);

        }

        private void DgvLinea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           


        }

        private void DgvLinea_DoubleClick(object sender, EventArgs e)
        {
            VIE.txtcod.Text =DgvLinea.CurrentRow.Cells[1].Value.ToString();
            VIE.txtdescripcion.Text = DgvLinea.CurrentRow.Cells[2].Value.ToString();
            VIE.cbotipoprod.SelectedValue = DgvLinea.CurrentRow.Cells[4].Value.ToString();
            VIE.TxtCorrelat.Text = DgvLinea.CurrentRow.Cells[5].Value.ToString();
            this.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

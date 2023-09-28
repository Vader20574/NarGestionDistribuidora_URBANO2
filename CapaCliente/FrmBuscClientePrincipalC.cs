using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios.Implementacion;
using Servicios.Interfaces.Cliente;
using Servicios.Interfaces.Cliente.Respuestas;
using System.Data.Linq.SqlClient;

namespace CapaCliente
{


    public partial class FrmBuscClientePrincipalC : Form
    {

        public bool DEVOLVER;
        public FrmClienteC ViewClieC = new FrmClienteC();


            IGestorDeCliente gestorDeCliente = new GestorDeCliente();
            
            List<CIienteSelecionado1> lista = new List<CIienteSelecionado1>();


        public FrmBuscClientePrincipalC()
        {
            InitializeComponent();
        }

        private void FrmBuscClientePrincipalC_Load(object sender, EventArgs e)
        {
            CIienteSelecionado1 nuevoregistrador = new CIienteSelecionado1();

            lista = gestorDeCliente.FiltrarxTodos2(nuevoregistrador);

            //DGridCli.DataSource = lista;

            filtra();

        }

        void filtra()
        {

            if (txtdato.Text == "")
            {
               DGridCli.DataSource = lista.ToList();
            }
            else
            {
                if (rbcodigo.Checked == true)
                {
                    var items = from item in lista
                                where (item.codcliente.Contains(txtdato.Text))
                                select item;

                    DGridCli.DataSource = items.ToList();
                }

                if (rbdescripcion.Checked == true)
                {
                  
                    var items = from item in lista
                                    //where SqlMethods.Like(item.DATOADJUNTO, txtdato.Text + "%")
                                where (item.DATOADJUNTO.ToLower().Contains(txtdato.Text.ToLower()))
                                orderby item.DATOADJUNTO ascending
                                select item;

                    DGridCli.DataSource = items.ToList();

                }

                if (rbdireccion.Checked == true)
                {
 
                    var items = from item in lista
                                where (item.direccion.ToLower().Contains(txtdato.Text.ToLower()))
                                select item;

                    DGridCli.DataSource = items.ToList();
                }

                if (rbruc.Checked == true)
                {
                  
                    var items = from item in lista
                                where (item.ruc.Contains(txtdato.Text))
                                select item;

                    DGridCli.DataSource = items.ToList();

                }

            }

        }

        private void txtdato_TextChanged(object sender, EventArgs e)
        {
            filtra();
        }

        private void DGridCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGridCli_DoubleClick(object sender, EventArgs e)
        {

            ViewClieC.tcodigo.Text = DGridCli.CurrentRow.Cells[0].Value.ToString();
            DEVOLVER = true;
            this.Close();

        }
    }
}

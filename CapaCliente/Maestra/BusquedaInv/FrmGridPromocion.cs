using Servicios.Implementacion;
using Servicios.Interfaces.PromoDeSoles;
using Servicios.Interfaces.PromoDeSoles.Respuestas;
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

  

    public partial class FrmGridPromocion : Form
    {

        public bool DEVOLVER;

        public FrmPromociones vie = new FrmPromociones();

        IGestorPromoDeSoles gestpromsol=new GestorPromoDeSoles();
        List<PromoDeSolesRegistrado> listpromdesoles= new List<PromoDeSolesRegistrado>();


        public FrmGridPromocion()
        {
            InitializeComponent();
        }

        private void FrmGridPromocion_Load(object sender, EventArgs e)
        {
            listpromdesoles=gestpromsol.Listar();      
          
            filtra();


        }

        void filtra()
        {
            if (txtdato.Text == "")
            {
                dgvpromodesoles.DataSource = listpromdesoles;
            }
            else
            {
                if (rbcodigo.Checked == true)
                {
                    var items = from item in listpromdesoles
                                where (item.CODPROMO.Contains(txtdato.Text))
                                select item;

                    dgvpromodesoles.DataSource = items.ToList();
                }

                if (rbdescripcion.Checked == true)
                {
                    var items = from item in listpromdesoles
                                    //where SqlMethods.Like(item.DATOADJUNTO, txtdato.Text + "%")
                                where (item.DESPROMO.ToLower().Contains(txtdato.Text.ToLower()))
                                orderby item.DESPROMO ascending
                                select item;
                    dgvpromodesoles.DataSource = items.ToList();

                }

             

            }



        }

        private void txtdato_TextChanged(object sender, EventArgs e)
        {
            filtra();
        }

        private void dgvpromodesoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvpromodesoles_DoubleClick(object sender, EventArgs e)
        {
            vie.txtCodPromo.Text = dgvpromodesoles.CurrentRow.Cells[1].Value.ToString();
            DEVOLVER = true;
            this.Close();
        }
    }
}

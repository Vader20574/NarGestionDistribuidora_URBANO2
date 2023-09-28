using CapaDatafirst;
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
    public partial class FrmTransFacturacionG : Form
    {
        public FrmTransFacturacionG()
        {
            InitializeComponent();
        }

        private void FrmTransFacturacion_Load(object sender, EventArgs e)
        {

        


        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

            using (NARGESTEntities db = new NARGESTEntities())
            {

                DateTime f = this.dtpfechaD.Value;
                DateTime f2 = this.dtpfechaH.Value;

                String FechaD = String.Format(f.ToShortDateString(),"dd/mm/aaaa");
                String FechaH = String.Format(f2.ToShortDateString(), "dd/mm/aaaa");

                sPSELECTFACTURASResultBindingSource.DataSource = db.SP_SELECT_FACTURAS(FechaD, FechaH);

                var courses = db.SP_TOTAL_FACTURAS("01").FirstOrDefault();
                var courses2 = db.SP_TOTAL_FACTURAS("03").FirstOrDefault();


                if (db.SP_TOTAL_FACTURAS("01").FirstOrDefault() != null)
                {
                    lblTboleta.Text = Convert.ToString(db.SP_TOTAL_FACTURAS("01").FirstOrDefault());
                }
                else
                {
                    lblTboleta.Text = "0";
                }



                if (db.SP_TOTAL_FACTURAS("03").FirstOrDefault() != null)
                {
                    Label3.Text = Convert.ToString(db.SP_TOTAL_FACTURAS("03").FirstOrDefault());
                }
                else
                {
                    Label3.Text = "0";
                }


                if (db.SP_TOTAL_FACTURAS_TODO("01").FirstOrDefault() != null)
                {
                    Label5.Text = Convert.ToString(db.SP_TOTAL_FACTURAS_TODO("01").FirstOrDefault());
                }
                else
                {
                    Label5.Text = "0";
                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDocAnulados frm = new FrmDocAnulados()  ;
            frm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
 
                FrmLinea1 frm = new FrmLinea1();
            frm.ShowDialog();

        }
    }
}

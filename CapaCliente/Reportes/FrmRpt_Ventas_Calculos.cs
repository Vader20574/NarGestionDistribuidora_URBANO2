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

namespace CapaCliente.Reportes
{
    public partial class FrmRpt_Ventas_Calculos : Form
    {

        string Empresa;
        string Usuario;
        string FechaInicio;
        string FechaHasta;
        string FuerzaVenta;
        string Ruta;
        string rand;



        public FrmRpt_Ventas_Calculos(string Empresa, string Usuario, string FechaInicio, string FechaHasta, string FuerzaVenta, string Ruta, string rand)
        {
            InitializeComponent();
            this.Empresa = Empresa;
            this.Usuario = Usuario;
            this.FechaInicio = FechaInicio;
            this.FechaHasta = FechaHasta;
            this.FuerzaVenta = FuerzaVenta;
            this.Ruta = Ruta;
            this.rand = rand;
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void FrmRpt_Ventas_Calculos_Load(object sender, EventArgs e)
        {


            using (NARGESTEntities db = new NARGESTEntities())
            {
            //    bindingSource2.DataSource = db.SP_RPT_VENTAS_DETALLE_POR_DOCU(rand).ToList();

                List<SP_RPT_VENTAS_DETALLE_POR_DOCU_Result> list = new List<SP_RPT_VENTAS_DETALLE_POR_DOCU_Result>();
                list= db.SP_RPT_VENTAS_DETALLE_POR_DOCU(rand).ToList();

                Rpt_Ventas_Calculos1.SetDataSource(list);
                Rpt_Ventas_Calculos1.SetParameterValue("Empresa", Empresa);
                Rpt_Ventas_Calculos1.SetParameterValue("Usuario", Usuario);
                Rpt_Ventas_Calculos1.SetParameterValue("FechaInicio", FechaInicio);
                Rpt_Ventas_Calculos1.SetParameterValue("FechaHasta", FechaHasta);
                Rpt_Ventas_Calculos1.SetParameterValue("FuerzaVenta", FuerzaVenta);
                Rpt_Ventas_Calculos1.SetParameterValue("Ruta", Ruta);

                crystalReportViewer1.Refresh();

            }

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

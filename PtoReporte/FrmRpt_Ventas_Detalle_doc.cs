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




namespace PtoReporte
{
    public partial class FrmRpt_Ventas_Detalle_doc : Form
    {
        List<SP_RPT_VENTAS_DETALLE_POR_DOCU_Result> list;

        string Empresa;
        string Usuario;
        string FechaInicio;
        string FechaHasta;
        string FuerzaVenta;
        string Ruta;
        int rand;



        public FrmRpt_Ventas_Detalle_doc(string Empresa , string Usuario, string FechaInicio, string FechaHasta, string FuerzaVenta, string Ruta, int rand)
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

        private void FrmRpt_Ventas_Detalle_doc_Load(object sender, EventArgs e)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                bindingSource2.DataSource = db.SP_RPT_VENTAS_DETALLE_POR_DOCU(rand).ToList();

                List<SP_RPT_VENTAS_DETALLE_POR_DOCU_Result> list = bindingSource2.DataSource as List<SP_RPT_VENTAS_DETALLE_POR_DOCU_Result>;

                Rpt_Ventas_Detalle_doc1.SetDataSource(list);
                Rpt_Ventas_Detalle_doc1.SetParameterValue("Empresa", Empresa);
                Rpt_Ventas_Detalle_doc1.SetParameterValue("Usuario", Usuario);
                Rpt_Ventas_Detalle_doc1.SetParameterValue("FechaInicio", FechaInicio);
                Rpt_Ventas_Detalle_doc1.SetParameterValue("FechaHasta", FechaHasta);
                Rpt_Ventas_Detalle_doc1.SetParameterValue("FuerzaVenta", FuerzaVenta);
                Rpt_Ventas_Detalle_doc1.SetParameterValue("Ruta", Ruta);

            crystalReportViewer1.Refresh();

            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

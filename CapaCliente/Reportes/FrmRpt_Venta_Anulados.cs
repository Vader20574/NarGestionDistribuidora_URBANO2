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
    public partial class FrmRpt_Venta_Anulados : Form
    {
        int rand;
        public FrmRpt_Venta_Anulados(int rand)
        {
            this.rand = rand;
            InitializeComponent();
        }

        private void FrmRpt_Venta_Anulados_Load(object sender, EventArgs e)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                //bindingSource1.DataSource = db.SP_RPT_VTA_ANUL(rand).ToList();

                //List<SP_RPT_VTA_ANUL_Result> list = bindingSource1.DataSource as List<SP_RPT_VTA_ANUL_Result>;

                List<SP_RPT_VTA_ANUL_Result> list = new List<SP_RPT_VTA_ANUL_Result>();
                list = db.SP_RPT_VTA_ANUL(rand).ToList();

                var todo = (from r in list
                            select new
                            {
                                FECHA = r.FECHA,
                                TIPODOC = r.TIPODOC,
                                SERIE = r.SERIE,
                                NUMERO = r.NUMERO,
                                RUC = r.RUC,
                                DNI = r.DNI,
                                RAZONSOCIAL = r.RAZONSOCIAL,
                                VALORVTA = r.VALORVTA,
                                IGV = r.IGV,
                                TOTAL = r.TOTAL,
                                DESTIPOANULA = r.DESTIPOANULA,
                                CODCLIENTE = r.CODCLIENTE,
                                DSDISTRITO = r.DSDISTRITO,
                                RUTACODIGO = r.RUTACODIGO,
                                RUTANOMBRE = r.RUTANOMBRE,
                                CODPROD = r.CODPROD,
                                NOMBPROD = r.NOMBPROD,
                                NROGUIA = r.NROGUIA,
                                DSTIPOPRE = r.DSTIPOPRE,
                                MONTO_RECHAZO = r.MONTO_RECHAZO,
                                OBSV = r.OBSV,
                                NOMBVEND = r.NOMBVEND,
                                CAT_ABC = r.CAT_ABC,
                                HORA = r.hora,
                                CDTIPORECHAZO = r.CDTIPORECHAZO,
                                DESTIPORECHAZO = r.DESTIPORECHAZO,
                                CDLIQUIDADOR = r.CDLIQUIDADOR,
                                DESLIQUIDADOR = r.DESLIQUIDADOR,
                                ESTLIQUIDADOR = r.ESTLIQUIDADOR,

                                CDREPARTIDOR = r.CDREPARTIDOR,
                                DESREPARTIDOR = r.DESREPARTIDOR,
                                ESTREPARTIDOR = r.ESTREPARTIDOR,

  




    }).ToList();

                Rpt_Venta_Anulados1.SetDataSource(todo);
                //Rpt_Ventas_Detalle_doc1.SetParameterValue("Empresa", Empresa);
                //Rpt_Ventas_Detalle_doc1.SetParameterValue("Usuario", Usuario);
                //Rpt_Ventas_Detalle_doc1.SetParameterValue("FechaInicio", FechaInicio);
                //Rpt_Ventas_Detalle_doc1.SetParameterValue("FechaHasta", FechaHasta);
                //Rpt_Ventas_Detalle_doc1.SetParameterValue("FuerzaVenta", FuerzaVenta);
                //Rpt_Ventas_Detalle_doc1.SetParameterValue("Ruta", Ruta);

                crystalReportViewer1.Refresh();

            }
        }

        private void Rpt_Venta_Anulados1_InitReport(object sender, EventArgs e)
        {

        }
    }
}

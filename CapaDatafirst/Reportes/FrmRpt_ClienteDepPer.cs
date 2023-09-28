using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatafirst.Reportes
{
    public partial class FrmRpt_ClienteDepPer : Form
    {

        string CodEmpresa;

        public FrmRpt_ClienteDepPer(string CodEmpresa)
        {
            InitializeComponent();
            this.CodEmpresa = CodEmpresa;
        }

        private void Rpt_ClienteDepPer1_InitReport(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void FrmRpt_ClienteDepPer_Load(object sender, EventArgs e)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                List<SP_REPORTE_CLIENTEDEP_PERCEP_Result> list = new List<SP_REPORTE_CLIENTEDEP_PERCEP_Result>();
                list = db.SP_REPORTE_CLIENTEDEP_PERCEP(CodEmpresa).ToList();

                var todo = (from r in list
                            select new
                            {
                                CODCLIENTE = r.CODCLIENTE,
                                DATOADJUNTO = r.DATOADJUNTO,
                                RUC = r.RUC,
                                DIRECCION = r.DIRECCION,
                                RUTA = r.RUTA,
                                coddis = r.coddis,
                                MPERCEP = r.MPERCEP,
                                CODVENDEDOR = r.CODVENDEDOR,
                               
                            }).ToList();
                
                Rpt_ClienteDepPer1.SetDataSource(todo);
                crystalReportViewer1.Refresh();

            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

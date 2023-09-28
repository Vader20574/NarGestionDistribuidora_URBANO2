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
    public partial class FrmRpt_Clientes : Form
    {
        string CodEmpresa;
        string DesEmpresa;
        string Usuario;
        public FrmRpt_Clientes(string CodEmpresa,string DesEmpresa,string Usuario)
        {
            this.CodEmpresa = CodEmpresa;
            this.DesEmpresa = DesEmpresa;
            this.Usuario = Usuario;

            InitializeComponent();
        }

        private void FrmRpt_Clientes_Load(object sender, EventArgs e)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {

                List<SP_RPT_CLIENTE_Result> list = new List<SP_RPT_CLIENTE_Result>();
                list = db.SP_RPT_CLIENTE(CodEmpresa).ToList();
                Rpt_Clientes1.SetDataSource(list);
                crystalReportViewer1.Refresh();

            }
        }

        private void Rpt_Clientes1_InitReport(object sender, EventArgs e)
        {

        }
    }
}

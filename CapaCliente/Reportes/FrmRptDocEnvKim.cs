using CapaCliente.Facturacion.Respuestas;
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
    public partial class FrmRptDocEnvKim : Form
    {

        List<RespBuscarDocRegistrado> ListRespBuscarDocReg = new List<RespBuscarDocRegistrado>();
        public FrmRptDocEnvKim(List<RespBuscarDocRegistrado> list )
        {
            ListRespBuscarDocReg = list;
            InitializeComponent();
        }

        private void FrmRptDocEnvKim_Load(object sender, EventArgs e)
        {
            RptDocEnvKim cr = new RptDocEnvKim();
            cr.SetDataSource(ListRespBuscarDocReg);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}

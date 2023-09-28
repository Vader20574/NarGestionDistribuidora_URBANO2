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
    public partial class FrmRpt_PedidoxVendedor : Form
    {

        string rand;
        public FrmRpt_PedidoxVendedor(string rand)
        {
            InitializeComponent();
            this.rand = rand;
        }

        private void FrmPedidoxVendedor_Load(object sender, EventArgs e)
        {
            NARGESTEntities db = new NARGESTEntities();
            Rpt_PedidoxVendedor cr = new Rpt_PedidoxVendedor();
            cr.SetDataSource(db.TMP_PEDIDO_XVENDEDOR.Where(s => s.CORREL == this.rand).ToList());
            crystalReportViewer1.ReportSource = cr;

        }
    }
}

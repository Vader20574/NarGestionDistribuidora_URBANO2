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
    public partial class FrmRpt_DescExter : Form
    {
        public FrmRpt_DescExter()
        {
            InitializeComponent();
        }

        private void FrmRpt_DescExter_Load(object sender, EventArgs e)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                Rpt_DescExter1.SetDataSource(db.NSP_RPT_DESCEXT().ToList());
                crystalReportViewer1.Refresh();
            }
        }
    }
}

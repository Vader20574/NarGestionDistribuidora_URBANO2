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
    public partial class FrmRpt_DescExt : Form
    {
        public FrmRpt_DescExt()
        {
            InitializeComponent();
        }

        private void FrmRpt_DescExt_Load(object sender, EventArgs e)
        {
            using (NARGESTEntities db = new NARGESTEntities())
            {
                Rpt_DescExt1.SetDataSource(db.ZSP_RPT_DESCEXT().ToList());
                crystalReportViewer1.Refresh();
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

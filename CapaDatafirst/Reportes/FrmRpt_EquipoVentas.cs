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
    public partial class FrmRpt_EquipoVentas : Form
    {
        public FrmRpt_EquipoVentas()
        {
            InitializeComponent();
        }

        private void FrmRpt_EquipoVentas_Load(object sender, EventArgs e)
        {

            using (NARGESTEntities db = new NARGESTEntities())
            {
                RptEquipoVentas1.SetDataSource(db.NSP_RPT_EQUIPOVENTAS().ToList());
                crystalReportViewer1.Refresh();
            }

        }
    }
}

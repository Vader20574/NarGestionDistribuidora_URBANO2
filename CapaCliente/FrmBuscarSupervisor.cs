using Dominio.Contextos.Models;
using Servicios.Implementacion;
using Servicios.Interfaces.Supervisor;
using Servicios.Interfaces.SupervisorVendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaCliente
{
    public partial class FrmBuscarSupervisor : Form
    {
        public FrmSupervisor VIE = new FrmSupervisor();
        IGestorDeSupervisor gestorDeSupervisor = new GestorDeSupervisor();
        IGestorDeSupervisorVendedor gestorDeSupervisorVendedor = new GestorDeSupervisorVendedor();
        
        public FrmBuscarSupervisor()
        {
            InitializeComponent();
    
        }

        private void FrmBuscarSupervisor_Load(object sender, EventArgs e)
        {
          
            DgvSupervisor.DataSource= gestorDeSupervisor.Listar();


        }

        private void DgvSupervisor_DoubleClick(object sender, EventArgs e)
        {
            VIE.txtCodigo.Text = DgvSupervisor.CurrentRow.Cells[1].Value.ToString();
            VIE.txtSupervisor.Text = DgvSupervisor.CurrentRow.Cells[2].Value.ToString();
            VIE.txtDireccion.Text = DgvSupervisor.CurrentRow.Cells[3].Value.ToString();
            VIE.txtCorrelFact.Text = DgvSupervisor.CurrentRow.Cells[4].Value.ToString();
            VIE.txtCorrelBol.Text = DgvSupervisor.CurrentRow.Cells[5].Value.ToString();
            VIE.txtCorrelNp.Text = DgvSupervisor.CurrentRow.Cells[6].Value.ToString();
            VIE.txtCorrelFactRef.Text = DgvSupervisor.CurrentRow.Cells[7].Value.ToString();
            VIE.txtCorrelBolRef.Text = DgvSupervisor.CurrentRow.Cells[8].Value.ToString();
            VIE.txtCorrelNpRef.Text = DgvSupervisor.CurrentRow.Cells[9].Value.ToString();
            VIE.chkEDESE.Checked = bool.Parse(DgvSupervisor.CurrentRow.Cells[10].Value.ToString());
            VIE.chkGIEF.Checked = bool.Parse(DgvSupervisor.CurrentRow.Cells[11].Value.ToString());
            VIE.chkGIEB.Checked = bool.Parse(DgvSupervisor.CurrentRow.Cells[12].Value.ToString());
            this.Close();
        }
    }
}

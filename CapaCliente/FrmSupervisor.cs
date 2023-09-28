using Dominio.Contextos.Models;
using Servicios.Implementacion;
using Servicios.Interfaces.Supervisor;
using Servicios.Interfaces.Supervisor.Peticiones;
using Servicios.Interfaces.Supervisor.Respuestas;
using Servicios.Interfaces.SupervisorVendedor;
using Servicios.Interfaces.SupervisorVendedor.Peticiones;
using Servicios.Interfaces.SupervisorVendedor.Respuestas;
using Servicios.Interfaces.Vendedor;
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
    public partial class FrmSupervisor : Form
    {

        int FLAG = 0;
        IGestorDeVendedor gestorDeVendedor = new GestorDeVendedor();
        IGestorDeSupervisor gestorDeSupervisor = new GestorDeSupervisor();
        IGestorDeSupervisorVendedor gestorDeSupervisorVendedor = new GestorDeSupervisorVendedor();

        List<SupervisorVendedorRegistrado> ListSupervisorVendedor = new List<SupervisorVendedorRegistrado>();

        public FrmSupervisor()
        {
            InitializeComponent();
         
        }

        private void FrmSupervisor_Load(object sender, EventArgs e)
        {
        
            cboVendedor.DataSource = gestorDeVendedor.Listar();
            cboVendedor.DisplayMember = "DSVEND";
            cboVendedor.ValueMember = "CODVEND";

            BOTONES(true, false, true, true, true);
            bloquea(false);


        }





        void BOTONES(bool NUEVO, bool GUARDAR, bool MODIFICAR, bool ELIMINAR, bool BUSCAR)
        {
            BTNNUEVO.Enabled = NUEVO;
            BTNGUARDAR.Enabled = GUARDAR;
            BTNMODIFICAR.Enabled = MODIFICAR;
            BTNELIMINAR.Enabled = ELIMINAR;

        }

        void Limpiar()
        {
            txtCodigo.Text = "";
            txtSupervisor.Text = "";
            txtDireccion.Text = "";
        
            txtCorrelFact.Text = "";
            txtCorrelBol.Text = "";
            txtCorrelNp.Text = "";
            txtCorrelFactRef.Text = "";
            txtCorrelBolRef.Text = "";
            txtCorrelNpRef.Text = "";
            chkEDESE.Checked = false;
            chkGIEF.Checked = false;
            chkGIEB.Checked = false;

            ListSupervisorVendedor.Clear();
            DgvSupervrxVend.DataSource = ListSupervisorVendedor.ToList();

        }
        void bloquea(Boolean estado)
        {
            txtCodigo.Enabled = estado;
            txtSupervisor.Enabled = estado;
            txtDireccion.Enabled = estado;
            txtCorrelFact.Enabled = estado;
            txtCorrelBol.Enabled = estado;
            txtCorrelNp.Enabled = estado;
            txtCorrelFactRef.Enabled = estado;
            txtCorrelBolRef.Enabled = estado;
            txtCorrelNpRef.Enabled = estado;
            chkEDESE.Enabled = estado;
            chkGIEF.Enabled = estado;
            chkGIEB.Enabled = estado;

            panel1.Enabled = estado;


        }


        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, false);
            Limpiar();
            bloquea(true);
            FLAG = 0;
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {

            if (FLAG == 0)
            {
                
                SupervisorNuevo supervReg = new SupervisorNuevo();
                supervReg.Codempresa = "01";
                supervReg.Codsuperv = txtCodigo.Text;
                supervReg.Dssuperv = txtSupervisor.Text;
                supervReg.Direccion = txtDireccion.Text;


 
                supervReg.nrofac = Math.Round(Convert.ToDecimal(txtCorrelFact.Text), 2);
                supervReg.nrobol = Math.Round(Convert.ToDecimal(txtCorrelBol.Text), 2);
                supervReg.nroped = Math.Round(Convert.ToDecimal(txtCorrelNp.Text), 2);
                supervReg.nrofacRef = Math.Round(Convert.ToDecimal(txtCorrelFactRef.Text), 2);
                supervReg.nrobolRef = Math.Round(Convert.ToDecimal(txtCorrelBolRef.Text), 2);
                supervReg.nropedRef = Math.Round(Convert.ToDecimal(txtCorrelNpRef.Text), 2);

                if (chkEDESE.Checked == true)
                {
                    supervReg.EDESE = true;
                }
                else
                {
                    supervReg.EDESE = false;
                }


                if (chkGIEF.Checked == true)
                {
                    supervReg.GIEF = true;
                }
                else
                {
                    supervReg.GIEF = false;
                }


                if (chkGIEB.Checked == true)
                {
                    supervReg.GIEB = true;
                }
                else
                {
                    supervReg.GIEB = false;
                }

                gestorDeSupervisor.Registrar(supervReg);


                foreach (SupervisorVendedorRegistrado s in ListSupervisorVendedor)
                {
                    SupervisorVendedorNuevo supervVendNuevo = new SupervisorVendedorNuevo();
                    supervVendNuevo.Codempresa = "01";
                    supervVendNuevo.Codsupervisor= txtCodigo.Text;
                    supervVendNuevo.Codvendedor = s.Codvendedor;
                    supervVendNuevo.Dsvend = s.Dsvend;
                
                    gestorDeSupervisorVendedor.Registrar(supervVendNuevo);
                }
            }

            if (FLAG == 1)
            {
              
                SupervisorActualizar supervReg = new SupervisorActualizar();
                supervReg.Codempresa = "01";
                supervReg.Codsuperv = txtCodigo.Text;
                supervReg.Dssuperv = txtSupervisor.Text;
                supervReg.Direccion = txtDireccion.Text;

           

                supervReg.nrofac = Math.Round(Convert.ToDecimal(txtCorrelFact.Text), 2);
                supervReg.nrobol = Math.Round(Convert.ToDecimal(txtCorrelBol.Text), 2);
                supervReg.nroped = Math.Round(Convert.ToDecimal(txtCorrelNp.Text), 2);
                supervReg.nrofacRef = Math.Round(Convert.ToDecimal(txtCorrelFactRef.Text), 2);
                supervReg.nrobolRef = Math.Round(Convert.ToDecimal(txtCorrelBolRef.Text), 2);
                supervReg.nropedRef = Math.Round(Convert.ToDecimal(txtCorrelNpRef.Text), 2);

                if (chkEDESE.Checked == true)
                {
                    supervReg.EDESE = true;
                }
                else
                {
                    supervReg.EDESE = false;
                }


                if (chkGIEF.Checked == true)
                {
                    supervReg.GIEF = true;
                }
                else
                {
                    supervReg.GIEF = false;
                }


                if (chkGIEB.Checked == true)
                {
                    supervReg.GIEB = true;
                }
                else
                {
                    supervReg.GIEB = false;
                }

                gestorDeSupervisor.Actualizar(supervReg);

                //primero borrar todo
                List<SupervisorVendedorRegistrado> list = new List<SupervisorVendedorRegistrado>();

                list=gestorDeSupervisorVendedor.ListarxCodSupervisor(txtCodigo.Text);

                foreach (SupervisorVendedorRegistrado s in list)
                {
                    gestorDeSupervisorVendedor.Borrar(s.Id);
                }

                //segundo insertar todo

                foreach (SupervisorVendedorRegistrado s in ListSupervisorVendedor)
                {
                    SupervisorVendedorNuevo supervVendNuevo = new SupervisorVendedorNuevo();
                    supervVendNuevo.Codempresa = "01";
                    supervVendNuevo.Codsupervisor = txtCodigo.Text;
                    supervVendNuevo.Codvendedor = s.Codvendedor;
                    supervVendNuevo.Dsvend = s.Dsvend;

                    gestorDeSupervisorVendedor.Registrar(supervVendNuevo);
                }


            }

            BOTONES(true, false, true, true, true);
            bloquea(false);

        }

        private void btnBusqSupervisor_Click(object sender, EventArgs e)
        {
            FrmBuscarSupervisor frm = new FrmBuscarSupervisor();
            frm.VIE = this;
            frm.ShowDialog();


            ListSupervisorVendedor = gestorDeSupervisorVendedor.ListarxCodSupervisor(txtCodigo.Text);
            DgvSupervrxVend.DataSource = ListSupervisorVendedor;


        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, true);
            FLAG = 1;
            bloquea(true);
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 0)
            {
                //primero borrar de la tabla SupervisorVendedor ya q tiene un foring key con  la tabla Supervisor
                List<SupervisorVendedorRegistrado> list = new List<SupervisorVendedorRegistrado>();

                list = gestorDeSupervisorVendedor.ListarxCodSupervisor(txtCodigo.Text);

                foreach (SupervisorVendedorRegistrado s in list)
                {
                    gestorDeSupervisorVendedor.Borrar(s.Id);
                }

                //luego borrar de  tabla Supervisor
                gestorDeSupervisor.Borrar(txtCodigo.Text);




            }
            else
            {
                MessageBox.Show("Codigo equipo esta vacio");
            }

            BOTONES(true, false, true, true, true);
            Limpiar();
            bloquea(false);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            SupervisorVendedorRegistrado supvendnew = new SupervisorVendedorRegistrado();
            supvendnew.Codempresa = "01";
            supvendnew.Codsupervisor = txtCodigo.Text;
            supvendnew.Codvendedor = cboVendedor.SelectedValue.ToString();
            supvendnew.Dsvend = cboVendedor.Text.ToString();
            ListSupervisorVendedor.Add(supvendnew);
            DgvSupervrxVend.DataSource = ListSupervisorVendedor.ToList();

            //gestorDeSupervisorVendedor.Registrar(supvendnew);

           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
 
            ListSupervisorVendedor.RemoveAt(DgvSupervrxVend.CurrentRow.Index);
            DgvSupervrxVend.DataSource = ListSupervisorVendedor.ToList();
 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkNGIE_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

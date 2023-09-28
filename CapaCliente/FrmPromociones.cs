using CapaCliente.Maestra.BusquedaInv;
using LinqToExcel;
using Servicios.Implementacion;
using Servicios.Interfaces.Almacen;
using Servicios.Interfaces.Articulo;
using Servicios.Interfaces.Articulo.Respuestas;
using Servicios.Interfaces.Artipresent;
using Servicios.Interfaces.ClienteXPromo.Peticiones;
using Servicios.Interfaces.ClienteXPromo.Respuestas;
using Servicios.Interfaces.PromoDeSoles;
using Servicios.Interfaces.PromoDeSoles.Peticiones;
using Servicios.Interfaces.PromoDeSoles.Respuestas;
using Servicios.Interfaces.TipoPago;
using Servicios.Interfaces.TipoPagoXPromocion;
using Servicios.Interfaces.TipoPagoXPromocion.Peticiones;
using Servicios.Interfaces.TipoPagoXPromocion.Respuestas;
using Servicios.Interfaces.TipoPrecio;
using Servicios.Interfaces.TipoPrecioXPromocion;
using Servicios.Interfaces.TipoPrecioXPromocion.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromocion.Respuestas;
using Servicios.Interfaces.TipoPrecioXPromoSoles;
using Servicios.Interfaces.TipoPrecioXPromoSoles.Peticiones;
using Servicios.Interfaces.TipoPrecioXPromoSoles.Respuestas;
using Servicios.Interfaces.Zona;
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
    public partial class FrmPromociones : Form
    {
        int INTFLAG_R = 0;
        IGestorDeTipoPrecioXPromoSoles gestdetipopreprom = new GestorDeTipoPrecioXPromoSoles();
        IGestorDeTipoPagoXProm gestdetipopagoprom = new GestorDeTipoPagoXProm();
        IGestorPromoDeSoles gestpromsol= new GestorPromoDeSoles();
        GestorClienteXPromo gestclientxprom = new GestorClienteXPromo();

        string ruta;
        List<ClienteXPromoNuevo> resultado;
        List<ClienteXPromoRegistrado> ClientpromReg;

        public FrmPromociones()
        {
            InitializeComponent();
        }



        public static void bloqueatextbox(Form frm)
        {

            foreach (Control ctrtextbox in frm.Controls)
            {
                if (ctrtextbox is TextBox)
                    ctrtextbox.Enabled = false;

                if (ctrtextbox is GroupBox)
                {

                    foreach (Control OBJTEXT in ctrtextbox.Controls)
                    {
                        if (OBJTEXT is TextBox)
                            OBJTEXT.Enabled = false;
                        if (OBJTEXT is GroupBox)
                        {
                            foreach (Control OBJTEXT2 in OBJTEXT.Controls)
                            {
                                if (OBJTEXT2 is TextBox)
                                    OBJTEXT2.Enabled = false;
                            }
                        }
                    }
                }
            }



            foreach (Control ctrcombo in frm.Controls)
            {
                if (ctrcombo is ComboBox)
                    ctrcombo.Enabled = false;

                if (ctrcombo is GroupBox)
                {
                    foreach (Control OBJTEXT in ctrcombo.Controls)
                    {
                        if (OBJTEXT is ComboBox)
                            OBJTEXT.Enabled = false;
                    }
                }
            }

        }




        private void FrmPromociones_Load(object sender, EventArgs e)
        {

            //IGestorDeAlmacen gestalm= new GestorDeAlmacen();
            //CboZona.DataSource = gestalm.Listar();
            //CboZona.DisplayMember = "DESALMACEN";
            //CboZona.ValueMember = "CODALMACEN";

            IGestorDeZona gestzona= new GestorDeZona();
            CboZona.DataSource = gestzona.Listar();
            CboZona.DisplayMember = "deszona";
            CboZona.ValueMember = "codzona";


            IGestorDeTipoPrecio gestipopre = new GestorDeTipoPrecio();
            CboTipoPrecio.DataSource= gestipopre.Listar();
            CboTipoPrecio.DisplayMember = "DSTIPOPRE";
            CboTipoPrecio.ValueMember = "CODTIPOPRE";


            IGestorDeTipoPago gestipopago = new GestorDeTipoPago();
            cbTipoPago.DataSource = gestipopago.Listar();
            cbTipoPago.DisplayMember = "DSTIPOPAGO";
            cbTipoPago.ValueMember = "CODTIPOPAGO";


            bloqueatextbox(this);
            BOTONES(true, false, false, false, true);
        }




        private void button3_Click(object sender, EventArgs e)
        {
            var frmbusqartxzona = new FrmBuscArticuloxZona();
            frmbusqartxzona.CODZONA = CboZona.SelectedValue.ToString();
            frmbusqartxzona.DESZONA = CboZona.Text.ToString();
            frmbusqartxzona.ShowDialog();

            if (frmbusqartxzona.DEVOLVER == false)
            {
                return;
            }
            txtProdPromoCod.Text = frmbusqartxzona.dgvArticulo.CurrentRow.Cells[0].Value.ToString();
            lbProductoPromo.Text = frmbusqartxzona.dgvArticulo.CurrentRow.Cells[1].Value.ToString();


            if (txtProdVtaCod.Text.Trim().Length > 0)
            {
                IGestorDeArtipresent gestdeartipresent = new GestorDeArtipresent();
                CboPresentProm.DataSource = gestdeartipresent.SelectPRECIART_Presentxproc2("01", txtProdPromoCod.Text.Trim().ToString());
                CboPresentProm.DisplayMember = "DESPRES";
                CboPresentProm.ValueMember = "CODPRES";
            }


            txtProfPromoCant.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBuscArticuloxZona frmbusqartxzona = new FrmBuscArticuloxZona();
            frmbusqartxzona.CODZONA = CboZona.SelectedValue.ToString();
            frmbusqartxzona.DESZONA = CboZona.Text.ToString();
            frmbusqartxzona.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBuscArticuloxZona frmbusqartxzona = new FrmBuscArticuloxZona();
            frmbusqartxzona.CODZONA = CboZona.SelectedValue.ToString();
            frmbusqartxzona.DESZONA = CboZona.Text.ToString();
            frmbusqartxzona.ShowDialog();
        }

        private void btnBusqProdVta_Click(object sender, EventArgs e)
        {
            var frmbusqartxzona = new FrmBuscArticuloxZona();
            frmbusqartxzona.CODZONA = CboZona.SelectedValue.ToString();
            frmbusqartxzona.DESZONA = CboZona.Text.ToString();
            frmbusqartxzona.ShowDialog();

            if (frmbusqartxzona.DEVOLVER == false)
            {
                return;
            }
            txtProdVtaCod.Text = frmbusqartxzona.dgvArticulo.CurrentRow.Cells[0].Value.ToString();
            lbProductoVta.Text = frmbusqartxzona.dgvArticulo.CurrentRow.Cells[1].Value.ToString();
         

            if (txtProdVtaCod.Text.Trim().Length > 0)
            {
                IGestorDeArtipresent gestdeartipresent= new GestorDeArtipresent();
                CboPresentVta.DataSource= gestdeartipresent.SelectPRECIART_Presentxproc2("01", txtProdVtaCod.Text.Trim().ToString());
                CboPresentVta.DisplayMember= "DESPRES";
                CboPresentVta.ValueMember = "CODPRES";
            }


            txtProdVtaSoles.Focus();

        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {

            desbloqueatextbox(this);
            GrpVta.Enabled = true;
            GrpPromo.Enabled = true;
            LimpiarData();
            BOTONES(false, true, false, false,true);
            INTFLAG_R = 0;
            txtCodPromo.ReadOnly = false;
        }


        void LimpiarData()
        {


            txtCodPromo.Text = "";
            txtDescripción.Text = "";
            txtPrecio.Text = "";
            

            txtProdVtaCod.Text = "";
            lbProductoVta.Text = "";
            CboPresentVta.SelectedValue = "";
            txtProdVtaSoles.Text = "0";
            chkEscala.Checked = false;
            txtEscDesde.Text = "0";
            txtEscHasta.Text = "0";

            txtProdPromoCod.Text = "";
            lbProductoPromo.Text = "";
            CboPresentProm.SelectedValue = "";
            txtProfPromoCant.Text = "";

            txtStockProm.Text = "";
            txtruta.Text = "";
            resultado = null;
            //if (tmp_ventreg != null)
            //{
            //}
            ChkXTipoPre.Checked = false;
            ChkXCliente.Checked = false;


            dgvTipoPrecio.DataSource = gestdetipopreprom.Listar("01", "777", txtCodPromo.Text.ToString());
            dgvTipoPago.DataSource = gestdetipopagoprom.Listar("777");
            dgvClienteXPromo.DataSource = null;


        }


        public static void desbloqueatextbox(Form frm)
        {

            foreach (Control ctrtextbox in frm.Controls)
            {
                if (ctrtextbox is TextBox)
                    ctrtextbox.Enabled = true;

                if (ctrtextbox is GroupBox)
                {
               
                    foreach (Control OBJTEXT   in ctrtextbox.Controls)
                    {
                        if (OBJTEXT is TextBox)
                            OBJTEXT.Enabled = true;
                        if (OBJTEXT is GroupBox)
                        {
                            foreach (Control OBJTEXT2 in OBJTEXT.Controls)
                            {
                                if (OBJTEXT2 is TextBox)
                                    OBJTEXT2.Enabled = true;
                            }
                        }
                    }
                }
            }



            foreach (Control ctrcombo in frm.Controls)
            {
                if (ctrcombo is ComboBox)
                    ctrcombo.Enabled = true;

                if (ctrcombo is GroupBox)
                {
                    foreach (Control OBJTEXT in ctrcombo.Controls)
                    {
                        if (OBJTEXT is ComboBox)
                            OBJTEXT.Enabled = false;
                    }
                }
            }

        }

        private void btnAgregarPresent_Click(object sender, EventArgs e)
        {

            if (txtCodPromo.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Falta el Codigo");
                return;
            }


            TipoPrecioXPromoSolesNuevo nuevotipopreprom = new TipoPrecioXPromoSolesNuevo();
            nuevotipopreprom.CODEMPRESA = "01";
            nuevotipopreprom.CODARTI= txtProdVtaCod.Text.ToString();
            nuevotipopreprom.DESARTI = lbProductoVta.Text.ToString();
            nuevotipopreprom.CODTIPOPRE = CboTipoPrecio.SelectedValue.ToString();
            nuevotipopreprom.DSTIPOPRE = CboTipoPrecio.Text.ToString();
            nuevotipopreprom.CODIGO = txtCodPromo.Text.ToString();
            gestdetipopreprom.Registrar(nuevotipopreprom);

           
            dgvTipoPrecio.DataSource = gestdetipopreprom.Listar("01", txtProdVtaCod.Text.ToString(), txtCodPromo.Text.ToString());

        }

        private void btnAgregarTipoPag_Click(object sender, EventArgs e)
        {


            if (txtCodPromo.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Falta el Codigo");
                return;
            }





            TipoPagoXPromNuevo nuevotipopreprom = new TipoPagoXPromNuevo();
            nuevotipopreprom.CODPROMO = txtCodPromo.Text.ToString();
            nuevotipopreprom.CODTIPOPAGO = cbTipoPago.SelectedValue.ToString();
            gestdetipopagoprom.Registrar(nuevotipopreprom);

            dgvTipoPago.DataSource = gestdetipopagoprom.Listar(txtCodPromo.Text.ToString());


        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {

            if (txtCodPromo.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Falta el Codigo");
                return;
            }

            if (txtPrecio.Text.Trim().Length == 0)
                txtPrecio.Text = "0";

            if (Convert.ToDouble(txtPrecio.Text.ToString()) != 0.01)
            {
                MessageBox.Show("el precio de la promocion tiene q ser 0.01");
                return;
            }



            if (txtEscDesde.Text.Trim().Length == 0)
                txtEscDesde.Text = "0";

            if (txtEscHasta.Text.Trim().Length == 0)
                txtEscHasta.Text = "0";

            if (txtProdVtaSoles.Text.Trim().Length == 0)
                txtProdVtaSoles.Text = "0";

            if (txtProfPromoCant.Text.Trim().Length == 0)
                txtProfPromoCant.Text = "0";

            if (txtStockProm.Text.Trim().Length == 0)
                txtStockProm.Text = "0";

            IGestorPromoDeSoles GestorProm = new GestorPromoDeSoles();






           if (INTFLAG_R == 0)
            {

            PromoDeSolesNuevo promnuevosol= new PromoDeSolesNuevo();

            promnuevosol.CODEMPRESA = "01";
            promnuevosol.CODPROMO = txtCodPromo.Text.ToString();
            promnuevosol.DESPROMO = txtDescripción.Text.ToString();
            promnuevosol.PRECIO_PROMO =Convert.ToDecimal(txtPrecio.Text.ToString());
            promnuevosol.CODZONA = CboZona.SelectedValue.ToString();
            promnuevosol.CODARTI_VTA = txtProdVtaCod.Text.ToString();
            promnuevosol.CODPRESVTA = CboPresentVta.SelectedValue.ToString();
            promnuevosol.ESCALA= chkEscala.Checked;
            promnuevosol.DESDE_SOLES_ART = Convert.ToDecimal(txtEscDesde.Text.ToString());
            promnuevosol.HASTA_SOLES_ART = Convert.ToDecimal(txtEscHasta.Text.ToString());
            promnuevosol.SOLES_ART_VTA= Convert.ToDecimal(txtProdVtaSoles.Text.ToString());
            promnuevosol.CODARTI_PROMO= txtProdPromoCod.Text.ToString();
            promnuevosol.CODPRESPROM = CboPresentProm.SelectedValue.ToString();
            promnuevosol.CANT_ARTI_PROMO= Convert.ToDecimal(txtProfPromoCant.Text.ToString());
            promnuevosol.STOCK_PROMO = Convert.ToDecimal(txtStockProm.Text.ToString());
            promnuevosol.FEC_INI=Convert.ToDateTime(dtpFechaIni.Value.ToShortDateString());
            promnuevosol.FEC_FIN = Convert.ToDateTime(dtpFechaFin.Value.ToShortDateString());
            promnuevosol.activar = ChkActivar.Checked;
                promnuevosol.XTIPOPRE= ChkXTipoPre.Checked;
                promnuevosol.XCLIENTE = ChkXCliente.Checked;

                GestorProm.Registrar(promnuevosol);


         if (resultado !=  null)
          { 
            foreach (ClienteXPromoNuevo lista in resultado)
            {
                    gestclientxprom.Registrar(lista);
            }
          }


        }
            else
            {
                PromoDeSolesActualizar promactualizarsol = new PromoDeSolesActualizar();
                promactualizarsol.CODEMPRESA = "01";
                promactualizarsol.CODPROMO = txtCodPromo.Text.ToString();
                promactualizarsol.DESPROMO = txtDescripción.Text.ToString();
                promactualizarsol.PRECIO_PROMO = Convert.ToDecimal(txtPrecio.Text.ToString());
                promactualizarsol.CODZONA = CboZona.SelectedValue.ToString();
                promactualizarsol.CODARTI_VTA = txtProdVtaCod.Text.ToString();
                promactualizarsol.CODPRESVTA = CboPresentVta.SelectedValue.ToString();
                promactualizarsol.ESCALA = chkEscala.Checked;
                promactualizarsol.DESDE_SOLES_ART = Convert.ToDecimal(txtEscDesde.Text.ToString());
                promactualizarsol.HASTA_SOLES_ART = Convert.ToDecimal(txtEscHasta.Text.ToString());
                promactualizarsol.SOLES_ART_VTA = Convert.ToDecimal(txtProdVtaSoles.Text.ToString());
                promactualizarsol.CODARTI_PROMO = txtProdPromoCod.Text.ToString();
                promactualizarsol.CODPRESPROM = CboPresentProm.SelectedValue.ToString();
                promactualizarsol.CANT_ARTI_PROMO = Convert.ToDecimal(txtProfPromoCant.Text.ToString());
                promactualizarsol.STOCK_PROMO = Convert.ToDecimal(txtStockProm.Text.ToString());
                promactualizarsol.FEC_INI = Convert.ToDateTime(dtpFechaIni.Value.ToShortDateString());
                promactualizarsol.FEC_FIN = Convert.ToDateTime(dtpFechaFin.Value.ToShortDateString());
                promactualizarsol.activar = ChkActivar.Checked;
                promactualizarsol.XTIPOPRE = ChkXTipoPre.Checked;
                promactualizarsol.XCLIENTE = ChkXCliente.Checked;
                GestorProm.Actualizar(promactualizarsol);


                if (resultado != null) 
                {
                  foreach (ClienteXPromoRegistrado lista in ClientpromReg)
                  {
                    gestclientxprom.Borrar(Convert.ToInt32(lista.ID));
                  }

                 foreach (ClienteXPromoNuevo lista in resultado)
                 {
                   gestclientxprom.Registrar(lista);
                 }
                }


                


            }


            BOTONES(true, false, false, false, true);
            bloqueatextbox(this);
            LimpiarData();
            GrpPromo.Enabled = false;
            GrpVta.Enabled = false;
            CboZona.Enabled = false;






            

        }

        private void btnQuitarPrest_Click(object sender, EventArgs e)
        {
            int codcliedep;
            codcliedep =Convert.ToInt32(dgvTipoPrecio.Rows[dgvTipoPrecio.CurrentRow.Index].Cells[6].Value.ToString());
            gestdetipopreprom.Borrar(codcliedep);
                 dgvTipoPrecio.DataSource = gestdetipopreprom.Listar("01", txtProdVtaCod.Text.ToString(), txtCodPromo.Text.ToString());



        }

        private void btnQuitarTipoPag_Click(object sender, EventArgs e)
        {
            int idtipopagoprom;
            idtipopagoprom = Convert.ToInt32(dgvTipoPago.Rows[dgvTipoPago.CurrentRow.Index].Cells[2].Value.ToString());
            gestdetipopagoprom.Borrar(idtipopagoprom);
            dgvTipoPago.DataSource = gestdetipopagoprom.Listar(txtCodPromo.Text.ToString());

        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
           
            if (INTFLAG_R == 0)
            {
               LimpiarData();
               BOTONES(true, false, false, false, true);
            }
            else
            {
                BOTONES(true, false, false, false, true);
            }

            bloqueatextbox(this);
        }


        public void BOTONES(bool NUEVO, bool GUARDAR, bool MODIFICAR, bool ELIMINAR, bool BUSCAR)
        {
            BTNNUEVO.Enabled = NUEVO;
            BTNGUARDAR.Enabled = GUARDAR;
            BTNMODIFICAR.Enabled = MODIFICAR;
            BTNELIMINAR.Enabled = ELIMINAR;
            btnBusqPromo.Enabled = BUSCAR;
            btnBusqProdVta.Enabled = BUSCAR;
            btnBusqProdBonif.Enabled = BUSCAR;
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            desbloqueatextbox(this);
            BOTONES(false, true, false, false, true);
            INTFLAG_R = 1;
            BTNCANCELAR.Enabled = true;
            GrpPromo.Enabled = true;
            GrpVta.Enabled = true;
            CboZona.Enabled = true;
            dtpFechaIni.Enabled = true;
            dtpFechaFin.Enabled = true;
            txtStockProm.Enabled = true;

        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO DE ELIMINAR EL REGISTRO", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                gestpromsol.Borrar("01", txtCodPromo.Text.ToString());

                List<TipoPrecioXPromoSolesReg> listtipopreprom = new List<TipoPrecioXPromoSolesReg>();
                listtipopreprom = gestdetipopreprom.Listar("01", txtProdVtaCod.Text.ToString(), txtCodPromo.Text.ToString());
                foreach (TipoPrecioXPromoSolesReg s in listtipopreprom)
                {
                    gestdetipopreprom.Borrar(s.Id);
                }


                List<TipoPagoXPromRegistrado> listtipopagrom = new List<TipoPagoXPromRegistrado>();
                listtipopagrom = gestdetipopagoprom.Listar( txtCodPromo.Text.ToString());
                foreach (TipoPagoXPromRegistrado s in listtipopagrom)
                {
                    gestdetipopagoprom.Borrar(s.Id);
                }


                if (ClientpromReg != null)
                {
                    foreach (ClienteXPromoRegistrado lista in ClientpromReg)
                    {
                        gestclientxprom.Borrar(Convert.ToInt32(lista.ID));
                    }
                }




            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            BOTONES(true, false, false, false, true);
        }

        private void btnBusqPromo_Click(object sender, EventArgs e)
        {

             BOTONES(true, false, true, true, true);


            FrmGridPromocion frmgridprom= new FrmGridPromocion();
            frmgridprom.vie = this;
            frmgridprom.ShowDialog();
            txtCodPromo.ReadOnly = true;




            if (frmgridprom.DEVOLVER == true)
            {
                PromoDeSolesRegistrado promsolreg = new PromoDeSolesRegistrado();
                promsolreg = gestpromsol.FindById(txtCodPromo.Text.ToString());

                if (promsolreg != null)
                {
                    txtDescripción.Text = promsolreg.DESPROMO;
                    txtPrecio.Text = promsolreg.PRECIO_PROMO.ToString();
                    CboZona.SelectedValue = promsolreg.CODZONA.ToString();
                    txtProdVtaCod.Text = promsolreg.CODARTI_VTA.ToString();
    
                    IGestorDeArticulo gestdeart = new GestorDeArticulo();
             
                    lbProductoVta.Text = gestdeart.SP_LISTA_ARTICULO_FACT_FILTRO("01", CboZona.SelectedValue.ToString(),0, txtProdVtaCod.Text).FirstOrDefault().DESARTI;


                    if (txtProdVtaCod.Text.Trim().Length > 0)
                    {
                        IGestorDeArtipresent gestdeartipresent = new GestorDeArtipresent();
                        CboPresentVta.DataSource = gestdeartipresent.SelectPRECIART_Presentxproc2("01", txtProdVtaCod.Text.Trim().ToString());
                        CboPresentVta.DisplayMember = "DESPRES";
                        CboPresentVta.ValueMember = "CODPRES";
                        CboPresentVta.SelectedValue = promsolreg.CODPRESVTA;
                    }

                    txtProdVtaSoles.Text = promsolreg.SOLES_ART_VTA.ToString();
                    chkEscala.Checked= promsolreg.ESCALA;
                    txtEscDesde.Text = promsolreg.DESDE_SOLES_ART.ToString();
                    txtEscHasta.Text = promsolreg.HASTA_SOLES_ART.ToString();

                    txtProdPromoCod.Text= promsolreg.CODARTI_PROMO.ToString();
                    lbProductoPromo.Text = gestdeart.SP_LISTA_ARTICULO_FACT_FILTRO("01", CboZona.SelectedValue.ToString(), 0, txtProdPromoCod.Text).FirstOrDefault().DESARTI;

                    if (txtProdPromoCod.Text.Trim().Length > 0)
                    {
                        IGestorDeArtipresent gestdeartipresent = new GestorDeArtipresent();
                        CboPresentProm.DataSource = gestdeartipresent.SelectPRECIART_Presentxproc2("01", txtProdPromoCod.Text.Trim().ToString());
                        CboPresentProm.DisplayMember = "DESPRES";
                        CboPresentProm.ValueMember = "CODPRES";
                        CboPresentProm.SelectedValue = promsolreg.CODPRESPROM;
                    }
                    txtProfPromoCant.Text =  promsolreg.CANT_ARTI_PROMO.ToString();
                    txtStockProm.Text = promsolreg.STOCK_PROMO.ToString();
                    dtpFechaIni.Value = promsolreg.FEC_INI;
                    dtpFechaFin.Value = promsolreg.FEC_FIN;
                    txtStockProm.Text = promsolreg.STOCK_PROMO.ToString();
                    ChkActivar.Checked = Convert.ToBoolean(promsolreg.activar.ToString());
                    ChkXTipoPre.Checked = promsolreg.XTIPOPRE;
                    ChkXCliente.Checked = promsolreg.XCLIENTE;


                    dgvTipoPrecio.DataSource = gestdetipopreprom.Listar("01", txtProdVtaCod.Text.ToString(), txtCodPromo.Text.ToString());
                    dgvTipoPago.DataSource = gestdetipopagoprom.Listar(txtCodPromo.Text.ToString());

                    ClientpromReg = gestclientxprom.Listar(txtCodPromo.Text.ToString());


                    dgvClienteXPromo.DataSource = ClientpromReg;






                }

            }



        }

        private void CboPresentVta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsele_Click(object sender, EventArgs e)
        {

            if (txtCodPromo.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Falta el Codigo");
                return;
            }


            if (txtProdVtaCod.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Falta el Codigo de Venta de articulo");
                return;
            }


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName.ToString();
                txtruta.Text = ruta;

                var fichero = @ruta;
                resultado = ToEntidadHojaExcelList(fichero, "clientexpromo");
                dgvClienteXPromo.DataSource = resultado;
            }
        }

        public List<ClienteXPromoNuevo> ToEntidadHojaExcelList(string pathDelFicheroExcel, string hoja)
        {
            var book = new ExcelQueryFactory(pathDelFicheroExcel);
            var resultado = (from row in book.Worksheet(hoja)
                             let item = new ClienteXPromoNuevo
                             {
                                 CODPROMO = txtCodPromo.Text,
                                 CODCLIENTE = row["CODCLIENTE"].Cast<string>(),
                                 RAZONSOCIAL = row["RAZONSOCIAL"].Cast<string>(), 
                                 CODARTI_VTA = txtProdVtaCod.Text,
                             }
                             select item).ToList();

            book.Dispose();
            return resultado;
        }


    }
}

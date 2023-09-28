using Servicios.Implementacion;
using Servicios.Interfaces.Departamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios.Interfaces.Pais;
using Servicios.Interfaces.Distrito;
using Servicios.Interfaces.Ciudad;
using Servicios.Interfaces.Ciudad.Respuesta;
using Servicios.Interfaces.Departamento.Respuestas;
using Servicios.Interfaces.Distrito.Respuestas;
using Servicios.Interfaces.TipoNegocio;
using Servicios.Interfaces.TipoPrecio;
using Servicios.Interfaces.Ruta;
using Servicios.Interfaces.Cliente;
using Servicios.Interfaces.Cliente.Peticiones;
using Servicios.Interfaces.Cliente.Respuestas;
using Servicios.Interfaces.CliDep;
using Servicios.Interfaces.CliDep.Peticiones;
using Servicios.Interfaces.CliDep.Respuestas;
using CapaDatafirst;
using Servicios.Interfaces.Configsis;
using Servicios.Interfaces.Configsis.Respuestas;
using Servicios.Interfaces.TipoPago;
using Servicios.Interfaces.Moneda;
using Servicios.Interfaces.SegmentoCliente;
using Servicios.Interfaces.CategoriaCliente;
using Servicios.Interfaces.FuerzaVenta;
using Servicios.Interfaces.ClieFuerza;
using Servicios.Interfaces.ClieFuerza.Respuestas;
using Servicios.Interfaces.ClieFuerza.Peticiones;
using Servicios.Interfaces.TipoCredito;
using Servicios.Interfaces.Cierre_Mes_Inv.Respuestas;
using Servicios.Interfaces.Cierre_Mes_Inv;
using Servicios.Interfaces.Facturacion.VentaCab.Respuestas;
using Servicios.Interfaces.HistoVentas;
using CapaDatafirst.Reportes;
using Common.Services;
using Servicios.Interfaces.EntregaMercas.Respuestas;
using Servicios.Interfaces.EntregaMercas;

namespace CapaCliente
{
    public partial class FrmClienteC : Form
    {

        int ACTIVO_ORT;
        int EMP;
        int indice;
        int FLAG, AINTOP;
        bool ACTIVOCLIENTE;
        string msj;

        List<DistritoRegistrado> listDistrito = new List<DistritoRegistrado>();
        List<CliDepRegistradoMasOK> ListCliDep = new List<CliDepRegistradoMasOK>();
        List<ClieFuerzaListar> ListCliefuerzaList = new List<ClieFuerzaListar>();
        ConfigsisRegistrado configRegis = new ConfigsisRegistrado();
        IGestorDeConfigsis gestorDeConfigsis = new GestorDeConfigsis();
        ClienteRegistrado registroGuardos = new ClienteRegistrado();
        IGestorDeCliDep gestordeclidep = new GestorCliDep();
        IGestorDeCliente gestorDeCliente = new GestorDeCliente();
        

        int COOLER;

        public FrmClienteC()
        {
            InitializeComponent();
        }


        public void limpia()
        {
            foreach (TabPage item in TabControl1.TabPages)
            {
                foreach (Control control in item.Controls)
                {
                    if (control is TextBox)
                        control.Text = "";
                    //if (control is ComboBox)
                    //    ((ComboBox)control).SelectedIndex = 1;
                }
            }

            this.tcredito.Text = "0";
            this.tdescuento.Text = "0";
            this.tsaldo.Text = "0";

            ChkActivo.Checked = false;

            chkOr.Checked = false;
            ChkActivoClientDep.Checked = false;
            ck_Nota_Pedido.Checked = false;
            ck_ort.Checked = false;


            ChkLunes.Checked = false;
            ChkMartes.Checked = false;
            ChkMiercoles.Checked = false;
            ChkJueves.Checked = false;
            ChkViernes.Checked = false;
            ChkSabado.Checked = false;
            ChkDomingo.Checked = false;


            ListCliDep.Clear();
            ListCliefuerzaList.Clear();
            dgvClidep.DataSource = ListCliDep;
            dgvMatrizFuerzas.DataSource = ListCliefuerzaList;


        }



        public void bloquea(bool p, bool p1)
        {
            foreach (TabPage item in TabControl1.TabPages)
            {
                foreach (Control control in item.Controls)
                {
                    if (control is TextBox)
                        control.Enabled= p;
                    if (control is ComboBox)
                        ((ComboBox)control).Enabled = p;
                    if (control is Button)
                        ((Button)control).Enabled = p;
                    if (control is GroupBox)
                        ((GroupBox)control).Enabled = p;
                    if (control is CheckBox)
                        ((CheckBox)control).Enabled = p;
                    if (control is DataGridView)
                        ((DataGridView)control).Enabled = p;

                    


                }
            }

            btnbuscar.Enabled = p1;
        }









        private void FrmClienteC_Load(object sender, EventArgs e)
        {

            IGestorDePais gestorDePais = new GestorDePais();
            cbopais.DataSource = gestorDePais.Listar();
            cbopais.ValueMember = "CODPAIS";
            cbopais.DisplayMember = "DESPAIS";


            IGestorDeTipoNegocio gestortiponegocio = new GestorDeTipoNegocio();
            CboTipoNegocio.DataSource = gestortiponegocio.Listar();
            CboTipoNegocio.ValueMember = "CODIGO";
            CboTipoNegocio.DisplayMember = "DESCRIPCION";

            IGestorDeTipoPrecio gestortipoprecion = new GestorDeTipoPrecio();
            CboTipoprecio.DataSource = gestortipoprecion.Listar();
            CboTipoprecio.ValueMember = "CODTIPOPRE";
            CboTipoprecio.DisplayMember = "DSTIPOPRE";


            IGestorDeRuta gestorderuta = new GestorDeRuta();
            comboRuta.DataSource = gestorderuta.Listar();
            comboRuta.ValueMember = "CODIGO";
            comboRuta.DisplayMember = "DESCRIPCION";


            IGestorDeRuta gestorderuta2 = new GestorDeRuta();
            CboRutaDep.DataSource = gestorderuta2.Listar();
            CboRutaDep.ValueMember = "CODIGO";
            CboRutaDep.DisplayMember = "DESCRIPCION";



            IGestorDeTipoPago gestordeTipoPago = new GestorDeTipoPago();
            ctipopago.DataSource = gestordeTipoPago.Listar();
            ctipopago.ValueMember = "CODTIPOPAGO";
            ctipopago.DisplayMember = "DSTIPOPAGO";


            IGestorDeMoneda gestordeMoneda = new GestorDeMoneda();
            cmbmoneda.DataSource = gestordeMoneda.Listar();
            cmbmoneda.ValueMember = "CODMON";
            cmbmoneda.DisplayMember = "DSMONEDA";


            IGestorSegmentoCliente gestorSegmentoCliente = new GestorSegmentoCliente();
            CboSegClient.DataSource = gestorSegmentoCliente.Listar();
            CboSegClient.ValueMember = "Codigo";
            CboSegClient.DisplayMember = "Descripcion";


            //IGestorCategoriaCliente gestorCategoriaCliente = new GestorCategoriaCliente();
            //CboCatClient.DataSource = gestorCategoriaCliente.Listar();
            //CboCatClient.ValueMember = "Codigo";
            //CboCatClient.DisplayMember = "Descripcion";


            IGestorDeFuerzaVenta gestordeFuerzaVenta = new GestorDeFuerzaVenta();
            cbFuerzaVta.DataSource = gestordeFuerzaVenta.Listar();
            cbFuerzaVta.ValueMember = "CODIGO";
            cbFuerzaVta.DisplayMember = "DESCRIPCION";

            IGestorDeTipoCredito gestordeTipoCredito = new GestorDeTipoCredito();
            CmbForPago.DataSource = gestordeTipoCredito.Listar();
            CmbForPago.ValueMember = "TIPCREDFAC";
            CmbForPago.DisplayMember = "DESCREDFAC";

            //IGestorDeEntregaMerca gestorDeEntregaMerca = new GestorDeEntregaMerca();
            //CboEntregaMerca.DataSource = gestorDeEntregaMerca.Listar();
            //CboEntregaMerca.ValueMember = "Id";
            //CboEntregaMerca.DisplayMember = "Descripcion";



            ListarEntregaMerca();
            ListarClasificacion1();
            ListarClasificacion2();
            ListarClasificacion3();


            bloquea(false, true);
            BOTONES(true, false, false, false, true);
            BTNCANCELAR.Enabled = false;
            btnbuscar.Enabled = true;


            AINTOP = 0;


        }


        private async void ListarEntregaMerca()
        {

            IApiService apiService = new ApiService();

            List<EntregaMercaRegistrado> nn = new List<EntregaMercaRegistrado>();
           
            string url;
            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();


            var response = await apiService.GetListAsync<EntregaMercaRegistrado>(
             url,
             "api",
             "/EntregaMerca");

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }
            else
            {

                nn = (List<EntregaMercaRegistrado>)response.Result;

                if (nn != null)
                {
                    CboEntregaMerca.DataSource = nn;
                    CboEntregaMerca.ValueMember = "Id";
                    CboEntregaMerca.DisplayMember = "Descripcion";
                }
            }

        
        }



        private async void ListarClasificacion1()
        {
            IApiService apiService = new ApiService();

            List<EntregaMercaRegistrado> nn = new List<EntregaMercaRegistrado>();

            string url;
            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();

            var response = await apiService.GetListAsync<EntregaMercaRegistrado>(
             url,
             "api",
             "/Clasificacion1");

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }
            else
            {

                nn = (List<EntregaMercaRegistrado>)response.Result;

                if (nn != null)
                {
                    CboClasificacion1.DataSource = nn;
                    CboClasificacion1.ValueMember = "Id";
                    CboClasificacion1.DisplayMember = "Descripcion";
                }
            }
        }


        private async void ListarClasificacion2()
        {
            IApiService apiService = new ApiService();

            List<EntregaMercaRegistrado> nn = new List<EntregaMercaRegistrado>();

            string url;
            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();

            var response = await apiService.GetListAsync<EntregaMercaRegistrado>(
             url,
             "api",
             "/Clasificacion2");

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }
            else
            {

                nn = (List<EntregaMercaRegistrado>)response.Result;

                if (nn != null)
                {
                    CboClasificacion2.DataSource = nn;
                    CboClasificacion2.ValueMember = "Id";
                    CboClasificacion2.DisplayMember = "Descripcion";
                }
            }
        }


        private async void ListarClasificacion3()
        {
            IApiService apiService = new ApiService();

            List<EntregaMercaRegistrado> nn = new List<EntregaMercaRegistrado>();

            string url;
            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();

            var response = await apiService.GetListAsync<EntregaMercaRegistrado>(
             url,
             "api",
             "/Clasificacion3");

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }
            else
            {

                nn = (List<EntregaMercaRegistrado>)response.Result;

                if (nn != null)
                {
                    CboClasificacion3.DataSource = nn;
                    CboClasificacion3.ValueMember = "Id";
                    CboClasificacion3.DisplayMember = "Descripcion";
                }
            }
        }




        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cdepa_SelectedIndexChanged(object sender, EventArgs e)
        {

            CiudadRegistrado ciudad_Registrado = new CiudadRegistrado();
            ciudad_Registrado.CODPAIS = cbopais.SelectedValue.ToString();
            ciudad_Registrado.iddepa = cdepa.SelectedValue.ToString();

            IGestorDeCiudad gestorDeCiudad = new GestorDeCiudad();

            List<CiudadRegistrado> listaCiudad = new List<CiudadRegistrado>();
            listaCiudad= gestorDeCiudad.Filtrar(ciudad_Registrado);

            cciud.DataSource = listaCiudad;
            cciud.ValueMember = "CODCIUDAD";
            cciud.DisplayMember = "DESCIUDAD";

            cmbciudad.DataSource = listaCiudad;
            cmbciudad.ValueMember = "CODCIUDAD";
            cmbciudad.DisplayMember = "DESCIUDAD";

        }

        private void cciud_SelectedIndexChanged(object sender, EventArgs e)
        {

            DistritoRegistrado distritoregistrado  = new DistritoRegistrado();
            distritoregistrado.CODPAIS= cbopais.SelectedValue.ToString();
            distritoregistrado.iddepa = cdepa.SelectedValue.ToString();
            distritoregistrado.codprovi = cciud.SelectedValue.ToString();

            IGestorDeDistrito gestorDeDistrito = new GestorDeDistrito();
            listDistrito = gestorDeDistrito.Filtrar(distritoregistrado);
            cdistrito.DataSource = listDistrito;
            cdistrito.ValueMember = "CodDis";
            cdistrito.DisplayMember = "Descripcion";


            cmbdist.DataSource = listDistrito;
            cmbdist.ValueMember = "CodDis";
            cmbdist.DisplayMember = "Descripcion";




        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {





        }

        private void cbopais_SelectedIndexChanged(object sender, EventArgs e)
        {

            DepartamentoRegistrado departamento_Registrado = new DepartamentoRegistrado();
            departamento_Registrado.codpais = cbopais.SelectedValue.ToString();

            IGestorDeDepartamento gestorDeDepartamento = new GestorDeDepartamento();
            cdepa.DataSource = gestorDeDepartamento.Filtrar(departamento_Registrado);
            cdepa.ValueMember = "iddepa";
            cdepa.DisplayMember = "depa";
        }



        private bool ValidarCamposAguardar()
        {
            bool Valor = true;

            if (cciud.Text == "")
            {
                MessageBox.Show("SELECIONE CIUDAD  ", "DesEmpresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Valor = false;
            }
            if (tdni.Text.Trim() != "")
            {
                if (tdni.Text.Trim().Length < 8)
                {
                    MessageBox.Show("complete los digitos para el DNI del cliente  ", "DesEmpresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Valor = false;
                }

                if (tdni.Text.Trim().Length > 8)
                {
                    MessageBox.Show("los digitos para el DNI SOBRE PASAN del cliente  ", "DesEmpresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Valor = false;
                }
            }
            if (truc.Text.Trim() != "")
            {
                if (truc.Text.Trim().Length < 11)
                {
                    MessageBox.Show("complete los digitos para el ruc del cliente  ", "DesEmpresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Valor = false;
                }
            }

            return Valor;
        }


        public  bool ValidationRUC(string ruc)
        {          
            msj = string.Empty;

            if (ruc.Length != 11)
            {
                msj = "NUMERO DE DIGITOS INVALIDO!!!.";
                return false;
            }

            int dig01 = Convert.ToInt32(ruc.Substring(0, 1)) * 5;
            int dig02 = Convert.ToInt32(ruc.Substring(1, 1)) * 4;
            int dig03 = Convert.ToInt32(ruc.Substring(2, 1)) * 3;
            int dig04 = Convert.ToInt32(ruc.Substring(3, 1)) * 2;
            int dig05 = Convert.ToInt32(ruc.Substring(4, 1)) * 7;
            int dig06 = Convert.ToInt32(ruc.Substring(5, 1)) * 6;
            int dig07 = Convert.ToInt32(ruc.Substring(6, 1)) * 5;
            int dig08 = Convert.ToInt32(ruc.Substring(7, 1)) * 4;
            int dig09 = Convert.ToInt32(ruc.Substring(8, 1)) * 3;
            int dig10 = Convert.ToInt32(ruc.Substring(9, 1)) * 2;
            int dig11 = Convert.ToInt32(ruc.Substring(10, 1));

            int suma = dig01 + dig02 + dig03 + dig04 + dig05 + dig06 + dig07 + dig08 + dig09 + dig10;
            int residuo = suma % 11;
            int resta = 11 - residuo;

            int digChk = 0;
            if (resta == 10)
            {
                digChk = 0;
            }
            else if (resta == 11)
            {
                digChk = 1;
            }
            else
            {
                digChk = resta;
            }

            if (dig11 == digChk)
            {
                return true;
            }
            else
            {
                msj = "NUMERO DE RUC INVALIDO!!!.";
                return false;
            }
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            bool ValidaCampos;
            ValidaCampos = ValidarCamposAguardar();

            if (ValidaCampos == false)
            {
                return;
            }

            bool ValidaRuc;

            if (truc.Text.Trim().ToString() != "")
            {
              ValidaRuc=ValidationRUC(truc.Text);
              if (ValidaRuc == false)
              {
                MessageBox.Show(msj);
                return;
              }
            }

            string ck_lunes;
            string ck_martes;
            string ck_miercoles;
            string ck_jueves;
            string ck_viernes;
            string ck_sabado;
            string ck_domingo;

            if (ChkLunes.Checked == true)
                ck_lunes = "1";
            else
                ck_lunes = "0";

            if (ChkMartes.Checked == true)
                ck_martes = "1";
            else
                ck_martes = "0";

            if (ChkMiercoles.Checked == true)
                ck_miercoles = "1";
            else
                ck_miercoles = "0";

            if (ChkJueves.Checked == true)
                ck_jueves = "1";
            else
                ck_jueves = "0";

            if (ChkViernes.Checked == true)
                ck_viernes = "1";
            else
                ck_viernes = "0";

            if (ChkSabado.Checked == true)
                ck_sabado = "1";
            else
                ck_sabado = "0";

            if (ChkDomingo.Checked == true)
                ck_domingo = "0";
            else
                ck_domingo = "0";

            string diasvisita;

            diasvisita = ck_lunes + ck_martes + ck_miercoles + ck_jueves + ck_viernes + ck_sabado + ck_domingo;

            trazon.Text = trazon.Text.Replace ("'", "´");

            //if (tcodigo.Text != "888")
            //{
            //    if (tcodigo.Text.Trim().Length < 8)
            //    {
            //        MessageBox.Show("El Codigo tiene q tener 8 digistos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        tcodigo.Focus();
            //        return;
            //    }

            //    int ultimodigito;
            //    ultimodigito = Int32.Parse(tcodigo.Text.Substring(this.tcodigo.Text.Length - 1));
                
            //    if (ultimodigito > 0)
            //    {
            //        MessageBox.Show("El ultimo digito del codigo de cliente tiene q ser cero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        tcodigo.Focus();
            //        return;
            //    }
            //}

            //if (tcodigo.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Ingrese el Codigo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    tcodigo.Focus();
            //    return;
            //}

            if (CheckBox1.Checked == true)
            {
                if (trazon.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese la Razón Social", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trazon.Focus();
                    return;
                }

                if (truc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese el Ruc", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    truc.Focus();
                    return;
                }
            }

            if (CheckBox1.Checked == false)
            {
                if (tpaterno.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese el Apellido Paterno", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tpaterno.Focus();
                    return;
                }

                if (tmaterno.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese el Apellido Materno", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tmaterno.Focus();
                    return;
                }

                if (tnombre.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese el Nombre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tnombre.Focus();
                    return;
                }

                if (tdni.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese el DNI", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tdni.Focus();
                    return;
                }
            }

            if (ctipopago.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un Tipo Pago", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctipopago.Focus();
                return;
            }

            if (CboRutaDep.SelectedValue == null)
            {
                MessageBox.Show("La Ruta ha sido eliminada de la Base de Datos. Elija otra o consulte a su proveedor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (CboTipoNegocio.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una Tipo Negocio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboTipoNegocio.Focus();
                return;
            }

            if (CboTipoprecio.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una Tipo Precio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboTipoprecio.Focus();
                return;
            }

            if (TxtTotLimCred.Text.Trim().Length == 0)
                TxtTotLimCred.Text = "0";

            if (TxtTotSaldoDisp.Text.Trim().Length == 0)
                TxtTotSaldoDisp.Text = "0";

            if (tdescuento.Text.Trim().Length == 0)
                tdescuento.Text = "0";

            if (cbopais.SelectedValue == null)
            {
                MessageBox.Show("Selecione un Pais...");
                cbopais.Focus();
                return;
            }

            if (cdepa.SelectedValue == null)
            {
                MessageBox.Show("Selecione un Departamento...");
                cdepa.Focus();
                return;
            }

            if (cciud.SelectedValue == null)
            {
                MessageBox.Show("Selecione una Ciudad...");
                cciud.Focus();
                return;
            }

            if (cdistrito.SelectedValue == null)
            {
                MessageBox.Show("Selecione un Distrito...");
                cdistrito.Focus();
                return;
            }

            if (CboTipoNegocio.SelectedValue == null)
            {
                MessageBox.Show("Selecione un Tipo Negocio...");
                CboTipoNegocio.Focus();
                return;
            }

            if (CboTipoprecio.SelectedValue == null)
            {
                MessageBox.Show("Selecione un Tipo Precio...");
                CboTipoprecio.Focus();
                return;
            }

            if (cmbmoneda.SelectedValue == null)
            {
                MessageBox.Show("Selecione una Moneda...");
                cmbmoneda.Focus();
                return;
            }

            //if (CboEntregaMerca.SelectedValue == null)
            //{
            //    MessageBox.Show("Selecione un Tipo de Hora de Entrega Mercaderia :...");
            //    CboEntregaMerca.Focus();
            //    return;
            //}

            //if (CboClasificacion1.SelectedValue == null)
            //{
            //    MessageBox.Show("Selecione un Clasificacion1 :...");
            //    CboClasificacion1.Focus();
            //    return;
            //}


            //if (CboClasificacion2.SelectedValue == null)
            //{
            //    MessageBox.Show("Selecione un Clasificacion2 :...");
            //    CboClasificacion2.Focus();
            //    return;
            //}

            //if (CboClasificacion3.SelectedValue == null)
            //{
            //    MessageBox.Show("Selecione un Clasificacion3 :...");
            //    CboClasificacion3.Focus();
            //    return;
            //}


            string formaPago;

            if (ctipopago.SelectedValue.ToString() == "06")
            {
                if (CmbForPago.SelectedValue.ToString() == null)
                {
                    MessageBox.Show("Selecione una Forma Pago...");
                    CmbForPago.Focus();
                    return;
                }
                else
                {
                    formaPago = CmbForPago.SelectedValue.ToString();
                }
            }
            else
            {
                formaPago = "0";
            }

          
            ClienteRegistrado clientreg = new ClienteRegistrado() ;
            List<ClienteRegistrado> list = new List<ClienteRegistrado>();



            //GUARDAR 
            if (FLAG == 0)
            {
                //if (this.tdni.Text.Trim() != "")
                //{
                //    clientreg.dni = tdni.Text.ToString();
                //    list= gestorDeCliente.FiltrarxTodos(clientreg);

                //    if (list.Count > 0)
                //    {
                //        MessageBox.Show("Dni ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}

                //if (this.truc.Text.Trim() != "")
                //{
                //    clientreg.ruc = truc.Text.ToString();
                //    list = gestorDeCliente.FiltrarxTodos(clientreg);

                //    if (list.Count > 0)
                //    {
                //        MessageBox.Show("Ruc ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}


                //if (truc.Text.Trim() == "")
                //{
                //    list = gestorDeCliente.FiltrarxDatoAdjunto1(tpaterno.Text + " " + tmaterno.Text + " " + tnombre.Text);
                //    if (list.Count > 0)
                //    {
                //        MessageBox.Show("El nombre y apellidos ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}
                //else
                //{
                //    list = gestorDeCliente.FiltrarxDatoAdjunto1(trazon.Text);
                //    if (list.Count > 0)
                //    {
                //        MessageBox.Show("la razon social ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}



         

                configRegis.EMPRESA = "01";

                int codclientepri;
                configRegis = gestorDeConfigsis.FindById("01");
                codclientepri = Convert.ToInt32(configRegis.CodClientePri);


                registroGuardos = gestorDeCliente.FindById(Convert.ToString(codclientepri));

                if (registroGuardos != null)
                {
                    MessageBox.Show("Cliente Existe");
                    return;
                }

                //Buscar si ya existe esa razon social en los cliente dependiente
                foreach (CliDepRegistradoMasOK s in ListCliDep)
                {              
                    string Dependiente;    
                    Dependiente = gestordeclidep.Busq_dep_DatoAdjunto("01", s.DATOADJUNTO);

                    if (Dependiente != null)
                    {
                        MessageBox.Show("YA EXISTE LA RAZON SOCIAL EN EL CLIENTE DEPENDIENTE: "  + s.DATOADJUNTO, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }


           ClienteNuevo cliente = new ClienteNuevo();

            cliente.DESCUENTO =  Convert.ToDecimal(tdescuento.Text);
            cliente.CTA_LET = tctaletra.Text;
            cliente.CTA_ANT = tctaanticipo.Text;
            cliente.CTA_VTA = tctaventa.Text;
            cliente.SALDODISPONIBLE = Convert.ToDecimal(TxtTotSaldoDisp.Text);
            cliente.MTOLIMCRED = Convert.ToDecimal(TxtTotLimCred.Text);
            cliente.telefono = ttelefono.Text;
            cliente.ruc = truc.Text;
            cliente.direccion = tdireccion.Text;
            cliente.codcliente = codclientepri.ToString();
            cliente.CODTIPOPAGO = ctipopago.SelectedValue.ToString();
            cliente.CODTIPCLI = "0";
            cliente.CODCIUDAD = cciud.SelectedValue.ToString();
            cliente.CODEMPRESA = "01";
            cliente.CuotaT = 0;
            cliente.CuotaS = 0;
            cliente.cuotaD = 0;
            cliente.razonsocial = trazon.Text;
            cliente.materno = tmaterno.Text;
            cliente.paterno = tpaterno.Text;
            cliente.nombres = tnombre.Text;
            cliente.codzona = "";
            cliente.dni = tdni.Text;
            cliente.email = tmail.Text;
            cliente.TIPCREDFAC = formaPago;
            cliente.MONEDACRED = cmbmoneda.SelectedValue.ToString();
            cliente.pais = cbopais.SelectedValue.ToString();
            cliente.contacto = txtcontacto.Text;
            cliente.telecont = txttelefonoc.Text;
            cliente.celucont = txtcelularc.Text;
            cliente.emailcont = txtemailc.Text;
            cliente.faxcliente = txtfax.Text;
            cliente.iddepa = cdepa.SelectedValue.ToString();
            cliente.coddis=cdistrito.SelectedValue.ToString();
            cliente.empleado =Convert.ToBoolean(EMP);
            cliente.RUTA = comboRuta.SelectedValue.ToString();
            cliente.TIPONEGOCIO = CboTipoNegocio.SelectedValue.ToString();
            cliente.CODTIPOPRE = CboTipoprecio.SelectedValue.ToString();
            cliente.imagen = "";
            cliente.imagen2 = "";
            cliente.ORT = Convert.ToBoolean(ACTIVO_ORT);
            cliente.CodCatCliente = CboEntregaMerca.SelectedValue.ToString();
            cliente.CODSegCliente = CboSegClient.SelectedValue.ToString();
            cliente.Visicoolers = COOLER;
            cliente.Cantidad = "";
            cliente.Observacion = "";
            cliente.CoordenadasX = txt_Cordenadas_X.Text;
            cliente.CoordenadasY = txt_Cordenadas_Y.Text;
            cliente.DiasVisita = diasvisita;
            cliente.DATOADJUNTO = tpaterno.Text + " " + tmaterno.Text + " " + tnombre.Text + " " + trazon.Text;
            cliente.ESTADO = ACTIVOCLIENTE;
            cliente.TRANS = false;
            cliente.creacion = DateTime.Now;
            cliente.Ubigeo = txtUbigeo.Text;
            cliente.IdClasif1 =int.Parse(CboClasificacion1.SelectedValue.ToString());
            cliente.IdClasif2 = int.Parse(CboClasificacion2.SelectedValue.ToString());
            cliente.IdClasif3 = int.Parse(CboClasificacion3.SelectedValue.ToString());


                gestorDeCliente.Registrar(cliente);
            gestorDeConfigsis.Actualizar_codclientepri(configRegis);


            foreach (CliDepRegistradoMasOK s in ListCliDep)
            {
             int codclientedep;
             configRegis = gestorDeConfigsis.FindById("01");
             codclientedep = Convert.ToInt32(configRegis.CodClienteDep);

             registroGuardos = gestorDeCliente.FindById(Convert.ToString(codclientedep));

             if (registroGuardos != null)
                {
                  MessageBox.Show("Cliente dependiente Existe");
                  return;
                }
                ClienteNuevo clientedep = new ClienteNuevo();
                clientedep.DESCUENTO = Convert.ToDecimal(tdescuento.Text);
                clientedep.CTA_LET = tctaletra.Text;
                clientedep.CTA_ANT = tctaanticipo.Text;
                clientedep.CTA_VTA = tctaventa.Text;
                clientedep.SALDODISPONIBLE = Convert.ToDecimal(TxtTotSaldoDisp.Text);
                clientedep.MTOLIMCRED = Convert.ToDecimal(TxtTotSaldoDisp.Text);
                clientedep.telefono = ttelefono.Text;
                clientedep.ruc = s.ruc;/// dependiente
                clientedep.direccion = s.direccion; /// dependiente
                clientedep.codcliente = Convert.ToString(codclientedep); /// dependiente
                clientedep.CODTIPOPAGO = ctipopago.SelectedValue.ToString();
                clientedep.CODTIPCLI = "0";
                clientedep.CODCIUDAD = s.CODCIUDAD; /// dependiente
                clientedep.CODEMPRESA = "01";
                clientedep.CuotaT = 0;
                clientedep.CuotaS = 0;
                clientedep.cuotaD = 0;
                clientedep.razonsocial = s.DATOADJUNTO; /// dependiente
                clientedep.materno = "";
                clientedep.paterno = "";
                clientedep.nombres = "";
                clientedep.codzona = "";
                clientedep.dni = s.dni; /// dependiente
                clientedep.email = tmail.Text;
                clientedep.TIPCREDFAC = formaPago;
                clientedep.MONEDACRED = cmbmoneda.SelectedValue.ToString();
                clientedep.pais = cbopais.SelectedValue.ToString();
                clientedep.contacto = txtcontacto.Text;
                clientedep.telecont = txttelefonoc.Text;
                clientedep.celucont = txtcelularc.Text;
                clientedep.emailcont = txtemailc.Text;
                clientedep.faxcliente = txtfax.Text;
                clientedep.iddepa = cdepa.SelectedValue.ToString();
                clientedep.coddis = s.CODDISTRITO; /// dependiente
                clientedep.empleado = Convert.ToBoolean(EMP);
                clientedep.RUTA = s.CODRUTA; /// dependiente
                clientedep.TIPONEGOCIO = CboTipoNegocio.SelectedValue.ToString();
                clientedep.CODTIPOPRE = CboTipoprecio.SelectedValue.ToString();
                clientedep.imagen = "";
                clientedep.imagen2 = "";
                clientedep.ORT = Convert.ToBoolean(ACTIVO_ORT);
                clientedep.CodCatCliente = CboEntregaMerca.SelectedValue.ToString();
                clientedep.CODSegCliente = CboSegClient.SelectedValue.ToString();
                clientedep.Visicoolers = COOLER;
                clientedep.Cantidad = "";
                clientedep.Observacion = "";
                clientedep.CoordenadasX = txt_Cordenadas_X.Text;
                clientedep.CoordenadasY = txt_Cordenadas_Y.Text;
                clientedep.DiasVisita = diasvisita;
                clientedep.DATOADJUNTO = s.DATOADJUNTO; /// dependiente
                clientedep.MPERCEP = s.MPERCEP; /// dependiente
                clientedep.ORT = false;
                clientedep.creacion = DateTime.Now;
                clientedep.ESTADO = s.ACTIVO; /// dependiente
                clientedep.Ubigeo = txtUbigeo.Text;
                clientedep.IdClasif1 = int.Parse(CboClasificacion1.SelectedValue.ToString());
                clientedep.IdClasif2 = int.Parse(CboClasificacion2.SelectedValue.ToString());
                clientedep.IdClasif3 = int.Parse(CboClasificacion3.SelectedValue.ToString());


                    gestorDeCliente.Registrar(clientedep);


                gestorDeConfigsis.Actualizar_codclientedep(configRegis);

                    CliDepNuevo clidepReg = new CliDepNuevo();
                    clidepReg.CODEMPRESA = s.CODEMPRESA;
                    clidepReg.CODDEP = codclientepri.ToString();
                    clidepReg.CODCLIENTE = codclientedep.ToString();
                    clidepReg.ACTIVO = s.ACTIVO;
                    clidepReg.CODRUTA = s.CODRUTA;
                    clidepReg.CODDISTRITO = s.CODDISTRITO;
                    clidepReg.MPERCEP = s.MPERCEP;
                    clidepReg.notapedido = s.notapedido;
                    clidepReg.ORT = s.ORT;
                    gestordeclidep.Registrar(clidepReg);
                }

                tcodigo.Text = codclientepri.ToString();



                IGestorDeClieFuerza gestordeclifuerza = new GestorDeClieFuerza();            
                foreach (ClieFuerzaListar s in ListCliefuerzaList)
                {
                    ClieFuerzaNuevo clientfuerznuevo = new ClieFuerzaNuevo();
                    clientfuerznuevo.CODEMPRESA = "01";
                    clientfuerznuevo.CODCLIE = tcodigo.Text;
                    clientfuerznuevo.CODFUERZA = s.CODFUERZA;
                    clientfuerznuevo.SALDO_CREDF = s.SALDO_CREDF;
                    clientfuerznuevo.CREDITO_F = s.CREDITO_F;
                    gestordeclifuerza.Registrar(clientfuerznuevo);
                }

                MessageBox.Show("SE GUARDO CORRECTAMENTE EL CLIENTE : " + codclientepri.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //MODIFICAR
            if (FLAG == 1)
            {
                if (tcodigo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese el Codigo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tcodigo.Focus();
                    return;
                }
               


                //if (truc.Text.Trim() == "")
                //{
                //    list = gestorDeCliente.FiltrarxDatoAdjunto2(tpaterno.Text + " " + tmaterno.Text + " " + tnombre.Text, tcodigo.Text);
                //    if (list.Count > 0)
                //    {
                //        MessageBox.Show("El nombre y apellidos ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}
                //else
                //{
                //    list = gestorDeCliente.FiltrarxDatoAdjunto2(trazon.Text , tcodigo.Text);
                //    if (list.Count > 0)
                //    {
                //        MessageBox.Show("la razon social ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}



                //Buscar si ya existe esa razon social aparte de ese cliente dependiente
                //foreach (CliDepRegistradoMasOK s in ListCliDep)
                //{
                //    string Dependiente;
                   
                //    Dependiente = gestordeclidep.Busq_dep_DatoAdjunto2("01", s.DATOADJUNTO, s.CODCLIENTE);

                //    if (Dependiente != null)
                //    {
                //        MessageBox.Show("YA EXISTE LA RAZON SOCIAL EN EL CLIENTE DEPENDIENTE: " + s.CODCLIENTE  + " " + s.DATOADJUNTO, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}

                ClienteActualizar cliente = new ClienteActualizar();

                cliente.DESCUENTO = Convert.ToDecimal(tdescuento.Text);
                cliente.CTA_LET = tctaletra.Text;
                cliente.CTA_ANT = tctaanticipo.Text;
                cliente.CTA_VTA = tctaventa.Text;
                cliente.SALDODISPONIBLE = Convert.ToDecimal(TxtTotSaldoDisp.Text);
                cliente.MTOLIMCRED = Convert.ToDecimal(TxtTotLimCred.Text);
                cliente.telefono = ttelefono.Text;
                cliente.ruc = truc.Text;
                cliente.direccion = tdireccion.Text;
                cliente.codcliente = tcodigo.Text;
                cliente.CODTIPOPAGO = ctipopago.SelectedValue.ToString();
                cliente.CODTIPCLI = "0";
                cliente.CODCIUDAD = cciud.SelectedValue.ToString();
                cliente.CODEMPRESA = "01";
                cliente.CuotaT = 0;
                cliente.CuotaS = 0;
                cliente.cuotaD = 0;
                cliente.razonsocial = trazon.Text;
                cliente.materno = tmaterno.Text;
                cliente.paterno = tpaterno.Text;
                cliente.nombres = tnombre.Text;
                cliente.codzona = "";
                cliente.dni = tdni.Text;
                cliente.email = tmail.Text;
                cliente.TIPCREDFAC = formaPago;
                cliente.MONEDACRED = cmbmoneda.SelectedValue.ToString();
                cliente.pais = cbopais.SelectedValue.ToString();
                cliente.contacto = txtcontacto.Text;
                cliente.telecont = txttelefonoc.Text;
                cliente.celucont = txtcelularc.Text;
                cliente.emailcont = txtemailc.Text;
                cliente.faxcliente = txtfax.Text;
                cliente.iddepa = cdepa.SelectedValue.ToString();
                cliente.coddis = cdistrito.SelectedValue.ToString();
                cliente.empleado = Convert.ToBoolean(EMP);
                cliente.RUTA = comboRuta.SelectedValue.ToString();
                cliente.TIPONEGOCIO = CboTipoNegocio.SelectedValue.ToString();
                cliente.CODTIPOPRE = CboTipoprecio.SelectedValue.ToString();
                cliente.imagen = "";
                cliente.imagen2 = "";
                cliente.ORT = Convert.ToBoolean(ACTIVO_ORT);
                cliente.CodCatCliente = CboEntregaMerca.SelectedValue.ToString();
                cliente.CODSegCliente = CboSegClient.SelectedValue.ToString();
                cliente.Visicoolers = COOLER;
                cliente.Cantidad = "";
                cliente.Observacion = "";
                cliente.CoordenadasX = txt_Cordenadas_X.Text;
                cliente.CoordenadasY = txt_Cordenadas_Y.Text;
                cliente.DiasVisita = diasvisita;
                cliente.DATOADJUNTO = tpaterno.Text + " " + tmaterno.Text + " " + tnombre.Text + " " + trazon.Text;
                cliente.ESTADO = ACTIVOCLIENTE;
                cliente.TRANS = false;
                cliente.creacion = DateTime.Now;
                cliente.Ubigeo = txtUbigeo.Text;
                cliente.IdClasif1 = int.Parse(CboClasificacion1.SelectedValue.ToString());
                cliente.IdClasif2 = int.Parse(CboClasificacion2.SelectedValue.ToString());
                cliente.IdClasif3 = int.Parse(CboClasificacion3.SelectedValue.ToString());



                gestorDeCliente.Actualizar(cliente);

          
             
                foreach (CliDepRegistradoMasOK s in ListCliDep)
                {
               
                    ClienteRegistrado regCliGuardos = new ClienteRegistrado();
                    int codclientedep;

                    regCliGuardos = gestorDeCliente.FindById(s.CODCLIENTE);

                    if (regCliGuardos != null)
                    {
                        ClienteActualizar clientedep = new ClienteActualizar();
                        clientedep.DESCUENTO = Convert.ToDecimal(tdescuento.Text);
                        clientedep.CTA_LET = tctaletra.Text;
                        clientedep.CTA_ANT = tctaanticipo.Text;
                        clientedep.CTA_VTA = tctaventa.Text;
                        clientedep.SALDODISPONIBLE = Convert.ToDecimal(TxtTotSaldoDisp.Text);
                        clientedep.MTOLIMCRED = Convert.ToDecimal(TxtTotSaldoDisp.Text);
                        clientedep.telefono = ttelefono.Text;
                        clientedep.ruc = s.ruc;/// dependiente
                        clientedep.direccion = s.direccion; /// dependiente
                        clientedep.codcliente = s.CODCLIENTE; /// dependiente
                        clientedep.CODTIPOPAGO = ctipopago.SelectedValue.ToString();
                        clientedep.CODTIPCLI = "0";
                        clientedep.CODCIUDAD = s.CODCIUDAD; /// dependiente
                        clientedep.CODEMPRESA = "01";
                        clientedep.CuotaT = 0;
                        clientedep.CuotaS = 0;
                        clientedep.cuotaD = 0;
                        clientedep.razonsocial = s.DATOADJUNTO; /// dependiente
                        clientedep.CODEMPRESA = "01";
                        clientedep.materno = "";
                        clientedep.paterno = "";
                        clientedep.nombres = "";
                        clientedep.codzona = "";
                        clientedep.dni = s.dni; /// dependiente
                        clientedep.email = tmail.Text;
                        clientedep.TIPCREDFAC = formaPago;
                        clientedep.MONEDACRED = cmbmoneda.SelectedValue.ToString();
                        clientedep.pais = cbopais.SelectedValue.ToString();
                        clientedep.contacto = txtcontacto.Text;
                        clientedep.telecont = txttelefonoc.Text;
                        clientedep.celucont = txtcelularc.Text;
                        clientedep.emailcont = txtemailc.Text;
                        clientedep.faxcliente = txtfax.Text;
                        clientedep.iddepa = cdepa.SelectedValue.ToString();
                        clientedep.coddis = s.CODDISTRITO; /// dependiente
                        clientedep.empleado = Convert.ToBoolean(EMP);
                        clientedep.RUTA = s.CODRUTA; /// dependiente
                        clientedep.TIPONEGOCIO = CboTipoNegocio.SelectedValue.ToString();
                        clientedep.CODTIPOPRE = CboTipoprecio.SelectedValue.ToString();
                        clientedep.imagen = "";
                        clientedep.imagen2 = "";
                        clientedep.ORT = Convert.ToBoolean(ACTIVO_ORT);
                        clientedep.CodCatCliente = CboEntregaMerca.SelectedValue.ToString();
                        clientedep.CODSegCliente = CboSegClient.SelectedValue.ToString();
                        clientedep.Visicoolers = COOLER;
                        clientedep.Cantidad = "";
                        clientedep.Observacion = "";
                        clientedep.CoordenadasX = txt_Cordenadas_X.Text;
                        clientedep.CoordenadasY = txt_Cordenadas_Y.Text;
                        clientedep.DiasVisita = diasvisita;
                        clientedep.DATOADJUNTO = s.DATOADJUNTO; /// dependiente
                        clientedep.MPERCEP = s.MPERCEP; /// dependiente
                        clientedep.ORT = false;
                        clientedep.ESTADO = s.ACTIVO; /// dependiente
                        clientedep.creacion = DateTime.Now;
                        clientedep.Ubigeo = txtUbigeo.Text;
                        clientedep.IdClasif1 = int.Parse(CboClasificacion1.SelectedValue.ToString());
                        clientedep.IdClasif2 = int.Parse(CboClasificacion2.SelectedValue.ToString());
                        clientedep.IdClasif3 = int.Parse(CboClasificacion3.SelectedValue.ToString());

                        gestorDeCliente.Actualizar(clientedep);
                        

                        CliDepActualizar clidepReg = new CliDepActualizar();
                        clidepReg.CODEMPRESA = s.CODEMPRESA;
                        clidepReg.CODDEP = tcodigo.Text;
                        clidepReg.CODCLIENTE = s.CODCLIENTE;
                        clidepReg.ACTIVO = s.ACTIVO;
                        clidepReg.CODRUTA = s.CODRUTA;
                        clidepReg.CODDISTRITO = s.CODDISTRITO;
                        clidepReg.MPERCEP = s.MPERCEP;
                        clidepReg.notapedido = s.notapedido;
                        clidepReg.ORT = s.ORT;
                        gestordeclidep.Actualizar(clidepReg);

                    }
                    else
                    {
                        configRegis = gestorDeConfigsis.FindById("01");
                        codclientedep = Convert.ToInt32(configRegis.CodClienteDep);
                        registroGuardos = gestorDeCliente.FindById(Convert.ToString(codclientedep));
                        if (registroGuardos != null)
                        {
                            MessageBox.Show("Cliente dependiente Existe");
                            return;
                        }

                        ClienteNuevo clientedep = new ClienteNuevo();
                        clientedep.DESCUENTO = Convert.ToDecimal(tdescuento.Text);
                        clientedep.CTA_LET = tctaletra.Text;
                        clientedep.CTA_ANT = tctaanticipo.Text;
                        clientedep.CTA_VTA = tctaventa.Text;
                        clientedep.SALDODISPONIBLE = Convert.ToDecimal(TxtTotSaldoDisp.Text);
                        clientedep.MTOLIMCRED = Convert.ToDecimal(TxtTotSaldoDisp.Text);
                        clientedep.telefono = ttelefono.Text;
                        clientedep.ruc = s.ruc;/// dependiente
                        clientedep.direccion = s.direccion; /// dependiente
                        clientedep.codcliente = codclientedep.ToString(); /// dependiente
                        clientedep.CODTIPOPAGO = ctipopago.SelectedValue.ToString();
                        clientedep.CODTIPCLI = "0";
                        clientedep.CODCIUDAD = s.CODCIUDAD; /// dependiente
                        clientedep.CODEMPRESA = "01";
                        clientedep.CuotaT = 0;
                        clientedep.CuotaS = 0;
                        clientedep.cuotaD = 0;
                        clientedep.razonsocial = s.DATOADJUNTO; /// dependiente
                        clientedep.materno = "";
                        clientedep.paterno = "";
                        clientedep.nombres = "";
                        clientedep.codzona = "";
                        clientedep.dni = s.dni; /// dependiente
                        clientedep.email = tmail.Text;
                        clientedep.TIPCREDFAC = formaPago;
                        clientedep.MONEDACRED = cmbmoneda.SelectedValue.ToString();
                        clientedep.pais = cbopais.SelectedValue.ToString();
                        clientedep.contacto = txtcontacto.Text;
                        clientedep.telecont = txttelefonoc.Text;
                        clientedep.celucont = txtcelularc.Text;
                        clientedep.emailcont = txtemailc.Text;
                        clientedep.faxcliente = txtfax.Text;
                        clientedep.iddepa = cdepa.SelectedValue.ToString();
                        clientedep.coddis = s.CODDISTRITO; /// dependiente
                        clientedep.empleado = Convert.ToBoolean(EMP);
                        clientedep.RUTA = s.CODRUTA; /// dependiente
                        clientedep.TIPONEGOCIO = CboTipoNegocio.SelectedValue.ToString();
                        clientedep.CODTIPOPRE = CboTipoprecio.SelectedValue.ToString();
                        clientedep.imagen = "";
                        clientedep.imagen2 = "";
                        clientedep.ORT = Convert.ToBoolean(ACTIVO_ORT);
                        clientedep.CodCatCliente = CboEntregaMerca.SelectedValue.ToString();
                        clientedep.CODSegCliente = CboSegClient.SelectedValue.ToString();
                        clientedep.Visicoolers = COOLER;
                        clientedep.Cantidad = "";
                        clientedep.Observacion = "";
                        clientedep.CoordenadasX = txt_Cordenadas_X.Text;
                        clientedep.CoordenadasY = txt_Cordenadas_Y.Text;
                        clientedep.DiasVisita = diasvisita;
                        clientedep.DATOADJUNTO = s.DATOADJUNTO; /// dependiente
                        clientedep.MPERCEP = s.MPERCEP; /// dependiente
                        clientedep.ORT = false;
                        clientedep.creacion = DateTime.Now;
                        clientedep.ESTADO = s.ACTIVO; /// dependiente
                        clientedep.Ubigeo = txtUbigeo.Text;
                        clientedep.IdClasif1 = int.Parse(CboClasificacion1.SelectedValue.ToString());
                        clientedep.IdClasif2 = int.Parse(CboClasificacion2.SelectedValue.ToString());
                        clientedep.IdClasif3 = int.Parse(CboClasificacion3.SelectedValue.ToString());


                        gestorDeCliente.Registrar(clientedep);
                        gestorDeConfigsis.Actualizar_codclientedep(configRegis);

                        CliDepNuevo clidepReg = new CliDepNuevo();
                        clidepReg.CODEMPRESA = s.CODEMPRESA;
                        clidepReg.CODDEP = tcodigo.Text;
                        clidepReg.CODCLIENTE = codclientedep.ToString();
                        clidepReg.ACTIVO = s.ACTIVO;
                        clidepReg.CODRUTA = s.CODRUTA;
                        clidepReg.CODDISTRITO = s.CODDISTRITO;
                        clidepReg.MPERCEP = s.MPERCEP;
                        clidepReg.notapedido = s.notapedido;
                        clidepReg.ORT = s.ORT;
                        gestordeclidep.Registrar(clidepReg);

                    }

                }


               IGestorDeClieFuerza gestordeclifuerza = new GestorDeClieFuerza();
               gestordeclifuerza.EliminarXCliente(tcodigo.Text);

                foreach (ClieFuerzaListar s in ListCliefuerzaList)
                  {
                        ClieFuerzaNuevo clientfuerznuevo = new ClieFuerzaNuevo();
                        clientfuerznuevo.CODEMPRESA = "01";
                        clientfuerznuevo.CODCLIE = tcodigo.Text;
                        clientfuerznuevo.CODFUERZA =s.CODFUERZA;
                        clientfuerznuevo.SALDO_CREDF = s.SALDO_CREDF;
                        clientfuerznuevo.CREDITO_F = s.CREDITO_F;
                        gestordeclifuerza.Registrar(clientfuerznuevo);                  
                  }

                MessageBox.Show("SE MODIFICO CORRECTAMENTE EL CLIENTE : " + tcodigo.Text.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            BOTONES(true, false, true, false, true);
            bloquea(false, true);
            btnbuscar.Enabled = true;

            BTNCANCELAR.Enabled = true;
            AINTOP = 0;
            FLAG = 0;

            
            CliDepRegistradoMasOK clidepregist = new CliDepRegistradoMasOK();
            clidepregist.CODDEP = tcodigo.Text;
            clidepregist.CODEMPRESA = "01";

            ListCliDep = gestordeclidep.ListarXCodDep(clidepregist);
            dgvClidep.DataSource = ListCliDep.ToList();
            dgvClidep.Columns[0].Visible = true;

            //limpia();



            TabControl1.SelectedIndex = 0;

            PictureBox1.Image = null;
            PictureBox2.Image = null;

            ck_Nota_Pedido.Checked = false;

        }

        private void cdistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void BOTONES(bool NUEVO, bool GUARDAR, bool MODIFICAR, bool ELIMINAR, bool BUSCAR)
        {
            BTNNUEVO.Enabled = NUEVO;
            BTNGUARDAR.Enabled = GUARDAR;
            BTNMODIFICAR.Enabled = MODIFICAR;
          //BTNELIMINAR.Enabled = ELIMINAR;
            btnbuscar.Enabled = BUSCAR;
        }



        private void chkOr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOr.Checked == true) 
            {
                ACTIVO_ORT = 1;
            }
            else
            {
                ACTIVO_ORT = 0;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                EMP = 1;
            }
            else
            {
                EMP = 0;
            }
        }

        void BuscarCliente()
        {
            FrmBuscClientePrincipalC frmbuscClienteP = new FrmBuscClientePrincipalC();
            frmbuscClienteP.ViewClieC = this;
            frmbuscClienteP.ShowDialog();


            if (frmbuscClienteP.DEVOLVER == true)
            {

                string CodigoCliPrin;
                CodigoCliPrin = tcodigo.Text;

                CliDepRegistrado regClidepGuardos = new CliDepRegistrado();
               
                regClidepGuardos = gestordeclidep.FindById(tcodigo.Text);

                if (regClidepGuardos != null)
                {

                    CodigoCliPrin = regClidepGuardos.CODDEP;

                }
                
                List<ClienteRegistrado> list;

                List<ClienteRegistrado> listCliente = new List<ClienteRegistrado>();

                ClienteRegistrado registroGuardos = new ClienteRegistrado();
                registroGuardos.codcliente = tcodigo.Text;

                //listCliente = gestorDeCliente.FiltrarxCodCliente(registroGuardos);

                //registroGuardos.codcliente = tcodigo.Text;

                registroGuardos = gestorDeCliente.FindById(CodigoCliPrin);

                listCliente.Add(registroGuardos);

                tcodigo.Text = CodigoCliPrin;


                if (string.IsNullOrEmpty(registroGuardos.DATOADJUNTO))
                {
                    trazon.Text = "";
                }
                else
                {
                   trazon.Text= registroGuardos.DATOADJUNTO.ToString();
                }


                if (string.IsNullOrEmpty(registroGuardos.dni))
                {
                    tdni.Text = "";
                }
                else
                {
                    tdni.Text = registroGuardos.dni.ToString();
                }



                if (string.IsNullOrEmpty(registroGuardos.ruc))
                {
                    truc.Text = "";
                }
                else
                {
                    truc.Text = registroGuardos.ruc.ToString();
                }



                if (String.IsNullOrEmpty(registroGuardos.materno))
                {
                    tmaterno.Text = "";
                }

                else
                {
                    tmaterno.Text = registroGuardos.materno.ToString();
                }

                if (String.IsNullOrEmpty(registroGuardos.paterno))
                {
                    tpaterno.Text = "";
                }
                else
                {
                    tpaterno.Text = registroGuardos.paterno.ToString();
                }


                if (String.IsNullOrEmpty(registroGuardos.nombres))
                {
                    tnombre.Text = "";
                }
                else
                {
                    tnombre.Text = registroGuardos.nombres.ToString();
                }

                if (String.IsNullOrEmpty(registroGuardos.direccion))
                {
                    tdireccion.Text = "";
                }

                else
                {
                    tdireccion.Text = registroGuardos.direccion.ToString();
                }


                if (String.IsNullOrEmpty(registroGuardos.telefono))
                {
                    ttelefono.Text = "";
                }

                else
                {
                    ttelefono.Text = registroGuardos.telefono.ToString();
                }


                if (String.IsNullOrEmpty(registroGuardos.CoordenadasX))
                {
                    txt_Cordenadas_X.Text = "";
                }
                else
                {
                    txt_Cordenadas_X.Text = registroGuardos.CoordenadasX.ToString();
                }


                if (String.IsNullOrEmpty(registroGuardos.CoordenadasY))
                {
                    txt_Cordenadas_Y.Text = "";
                }
                else
                {
                    txt_Cordenadas_Y.Text = registroGuardos.CoordenadasY.ToString();
                }


                if (String.IsNullOrEmpty(registroGuardos.Ubigeo))
                {
                    txtUbigeo.Text = "";
                }
                else
                {
                    txtUbigeo.Text = registroGuardos.Ubigeo.ToString();
                }




                TxtTotLimCred.Text = registroGuardos.MTOLIMCRED.ToString();

                double ResulLineaUtilidad;
                ResulLineaUtilidad = gestorDeCliente.CobranzaXCliente("01", tcodigo.Text.ToString());
                TxtLineaUtilidad.Text = ResulLineaUtilidad.ToString();

                decimal ResulPedidoUtilizado;
                ResulPedidoUtilizado = gestorDeCliente.SumPedidos(tcodigo.Text.ToString());
                TxtPedidoUtilizado.Text = ResulPedidoUtilizado.ToString();

                cbopais.SelectedValue = registroGuardos.pais.ToString();
                cdepa.SelectedValue = registroGuardos.iddepa.ToString();
                cciud.SelectedValue = registroGuardos.CODCIUDAD.ToString();
                cdistrito.SelectedValue = registroGuardos.coddis;

                CboTipoNegocio.SelectedValue = registroGuardos.TIPONEGOCIO.ToString();
                CboTipoprecio.SelectedValue = registroGuardos.CODTIPOPRE.ToString();
                comboRuta.SelectedValue = registroGuardos.RUTA.ToString();
                COOLER = Convert.ToInt32(registroGuardos.Visicoolers);
                ctipopago.SelectedValue = registroGuardos.CODTIPOPAGO.ToString();
                CmbForPago.SelectedValue = registroGuardos.TIPCREDFAC.ToString();
                ChkActivo.Checked = Convert.ToBoolean(registroGuardos.ESTADO);
                CboEntregaMerca.SelectedValue = Convert.ToInt32(registroGuardos.CodCatCliente.ToString());
                CboClasificacion1.SelectedValue = Convert.ToInt32(registroGuardos.IdClasif1.ToString());
                CboClasificacion2.SelectedValue = Convert.ToInt32(registroGuardos.IdClasif2.ToString());
                CboClasificacion3.SelectedValue = Convert.ToInt32(registroGuardos.IdClasif3.ToString());


                string DiasVisita;
                DiasVisita=registroGuardos.DiasVisita.ToString();

                string lunes;
                lunes = DiasVisita.Substring(0, 1);

                string martes;
                martes = DiasVisita.Substring(1, 1);

                string miercoles;
                miercoles = DiasVisita.Substring(2, 1);

                string jueves;
                jueves = DiasVisita.Substring(3, 1);

                string viernes;
                viernes = DiasVisita.Substring(4, 1);

                string sabado;
                sabado = DiasVisita.Substring(5, 1);

                string domingo;
                domingo = DiasVisita.Substring(6, 1);

                if (lunes == "1")
                {
                    ChkLunes.Checked = true;
                }
                else
                {
                    ChkLunes.Checked = false;
                }



                if (martes == "1")
                {
                    ChkMartes.Checked = true;
                }
                else
                {
                    ChkMartes.Checked = false;
                }


                if (miercoles == "1")
                {
                    ChkMiercoles.Checked = true;
                }
                else
                {
                    ChkMiercoles.Checked = false;
                }


                if (jueves == "1")
                {
                    ChkJueves.Checked = true;
                }
                else
                {
                    ChkJueves.Checked = false;
                }



                if (viernes == "1")
                {
                    ChkViernes.Checked = true;
                }
                else
                {
                    ChkViernes.Checked = false;
                }

                if (sabado == "1")
                {
                    ChkSabado.Checked = true;
                }
                else
                {
                    ChkSabado.Checked = false;
                }

                if (domingo == "1")
                {
                    ChkDomingo.Checked = true;
                }
                else
                {
                    ChkDomingo.Checked = false;
                }

                CliDepRegistradoMasOK clidepregist = new CliDepRegistradoMasOK();
                clidepregist.CODDEP = tcodigo.Text;
                clidepregist.CODEMPRESA = "01";

                ListCliDep= gestordeclidep.ListarXCodDep(clidepregist);
                dgvClidep.DataSource = ListCliDep.ToList();

                IGestorDeClieFuerza gestordeclieF= new GestorDeClieFuerza();
                ClieFuerzaRegistrado cliefuerzareg  = new ClieFuerzaRegistrado();
                cliefuerzareg.CODCLIE = tcodigo.Text;
                cliefuerzareg.CODEMPRESA = "01";

                ListCliefuerzaList = gestordeclieF.ListarXClieFuerza(cliefuerzareg);
                dgvMatrizFuerzas.DataSource = ListCliefuerzaList.ToList();

            }



            if (truc.Text.Trim() == "")
            {
                if (tnombre.Text.Trim().Length == 0)
                {
                    tnombre.Text = trazon.Text;
                    trazon.Text = "";
                }
            }


            if (truc.Text.Trim() == "")
            {
            CheckBox1.Checked = false; 
            }
            else
            {
            CheckBox1.Checked = true;
            }



            tcredito.Enabled = false;
            tcodigo.Enabled = false;
            BTNCANCELAR.Enabled = true;


        }



        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (FLAG == 0)
            {
             limpia();
            }
                
            bloquea(false, true);
            BOTONES(true, false, true, false, true);        
            BTNCANCELAR.Enabled = false;
            BuscarCliente();
        }


        private bool ValidarCamposAguardarDep()
        {
            bool Valor = true;

            if (TxtDniDep.Text.Trim() != "")
            {
                if ((TxtDniDep.Text.Trim().Length) < 8)
                {
                    MessageBox.Show("complete los digitos para el DNI del cliente  ", "DesEmpresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Valor = false;
                    return Valor;
                }

                if ((TxtDniDep.Text.Trim().Length) > 8)
                {
                    MessageBox.Show("los digitos para el DNI SOBRE PASAN del cliente  ", "DesEmpresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Valor = false;
                    return Valor;
                }
            }



            if (TxtRucDep.Text.Trim() != "")
            {

                if ((TxtRucDep.Text.Trim().Length) < 11)
                {
                    MessageBox.Show("complete los digitos para el ruc del cliente  ", "DesEmpresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Valor = false;
                    return Valor;
                }
                else
                {
                Valor =ValidationRUC(this.TxtRucDep.Text);
                if (Valor==false)
                 {
                   MessageBox.Show("NUMERO DE RUC INVALIDO!!!.  ", "DesEmpresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   Valor = false;
                   return Valor;
                 }
                }
            }

            return Valor;
        }
        
        void limpiarCliDep()
        {
            TxtRucDep.Text = "";
            TxtDniDep.Text = "";
            TxtRzSocialDep.Text = "";
            TxtDirecDep.Text = ""; 
            txtMPercepcion.Text = "";
            ChkActivoClientDep.Checked = false;
            ck_Nota_Pedido.Checked = false;
            ck_ort.Checked = false;
        }


        private void BtnAgregDep_Click(object sender, EventArgs e)
        {

            if (TxtDniDep.Text.Trim().Length == 0)
            {
                if (TxtRucDep.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese el DNI del clientes dependiente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   tdni.Focus();
                }
            }

            if ((TxtRucDep.Text.Trim().Length == 0))
            {
                if ((TxtDniDep.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Ingrese el RUC del clientes dependiente", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtRucDep.Focus();
                    return;
                }
            }

            if ((TxtRucDep.Text.Length > 0))
            {
                if ((TxtDniDep.Text.Length > 0))
                {
                    MessageBox.Show("SI TIENE RUC NO PUEDE TENER DNI");
                    return;
                }

            }

            if ((TxtDniDep.Text.Length > 0))
            {
                if ((TxtRucDep.Text.Length > 0))
                {
                    MessageBox.Show("SI TIENE DNI NO PUEDE TENER RUC");
                    return;
                }

            }

            bool ValidaCampos;
            // Call formatotextbox(Me)
            ValidaCampos = ValidarCamposAguardarDep();
            if (ValidaCampos == false)
                return;


            if (cmbdist.SelectedValue == null)
            {
                MessageBox.Show("Tiene que selecionar un Distrito...");
                return;
            }

            if (txtMPercepcion.Text.Length == 0)
                txtMPercepcion.Text = "0.0";


            if (TxtRzSocialDep.Text.Length >= 40)
                MessageBox.Show("NO PUEDE SER MAYOR A 40");

            //if (TxtRucDep.Text.Trim().Length > 0)
            //{
            //    bool Estado_RucDep;
            //    Estado_RucDep = ModFunciones.FACT_GValidaRUC(this.TxtRucDep.Text);
            //    if (Estado_RucDep == false)
            //        return;
            //}

            if (this.TxtRucDep.Text.Trim() != "")
            {
            }

            if (TxtRzSocialDep.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Razon Social del Dependientes ...");
                TxtRzSocialDep.Focus();
                return;
            }


            ValidarCamposAguardarDep();


            if (FLAG == 0)
            {
                CliDepRegistradoMasOK clidepregist = new CliDepRegistradoMasOK();
                clidepregist.CODCLIENTE = "0";
                clidepregist.CODEMPRESA = "01";
                clidepregist.ruc = TxtRucDep.Text;
                clidepregist.dni = TxtDniDep.Text;
                clidepregist.DATOADJUNTO = TxtRzSocialDep.Text;
                clidepregist.direccion = TxtDirecDep.Text;
                clidepregist.CODCIUDAD = cmbciudad.SelectedValue.ToString();
                clidepregist.CODDISTRITO = cmbdist.SelectedValue.ToString();
                clidepregist.CODRUTA = CboRutaDep.SelectedValue.ToString();
                clidepregist.RUTA = CboRutaDep.Text.ToString();
                clidepregist.ACTIVO = ChkActivoClientDep.Checked;
                clidepregist.MPERCEP = Convert.ToDecimal(txtMPercepcion.Text);
                clidepregist.notapedido = ck_Nota_Pedido.Checked;
                clidepregist.ORT = ck_ort.Checked;
                ListCliDep.Add(clidepregist);
                dgvClidep.DataSource = ListCliDep.ToList();
                dgvClidep.Columns[0].Visible = false;
            }


            if (FLAG == 1)
            {



                CliDepRegistradoMasOK clidepregist = new CliDepRegistradoMasOK();
                clidepregist.CODCLIENTE = "0";
                clidepregist.CODEMPRESA = "01";
                clidepregist.ruc = TxtRucDep.Text;
                clidepregist.dni = TxtDniDep.Text;
                clidepregist.DATOADJUNTO = TxtRzSocialDep.Text;
                clidepregist.direccion = TxtDirecDep.Text;
                clidepregist.CODCIUDAD = cmbciudad.SelectedValue.ToString();
                clidepregist.CODDISTRITO = cmbdist.SelectedValue.ToString();
                clidepregist.CODRUTA = CboRutaDep.SelectedValue.ToString();
                clidepregist.RUTA = CboRutaDep.Text.ToString();
                clidepregist.ACTIVO = ChkActivoClientDep.Checked;
                clidepregist.MPERCEP = Convert.ToDecimal(txtMPercepcion.Text);
                clidepregist.notapedido = ck_Nota_Pedido.Checked;
                clidepregist.ORT = ck_ort.Checked;
                ListCliDep.Add(clidepregist);
                dgvClidep.DataSource = ListCliDep.ToList();
              
            }

            //IGestorDeConfigsis gestorDeConfigsis = new GestorDeConfigsis();
            //List<ConfigsisRegistrado> list = new List<ConfigsisRegistrado>();

            //ConfigsisRegistrado configRegis = new ConfigsisRegistrado();
            //configRegis.EMPRESA = "01";

            //int codclientedep;
            //configRegis = gestorDeConfigsis.FindById("01");
            //codclientedep =Convert.ToInt32(configRegis.CodClienteDep);
            //gestorDeConfigsis.Actualizar_codclientedep(configRegis);
            limpiarCliDep();
        }






        private void tcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ClienteRegistrado registroGuardos = new ClienteRegistrado();
                registroGuardos = gestorDeCliente.FindById(tcodigo.Text);

                if (registroGuardos != null)
                {
               
                    MessageBox.Show("Cliente Existe");
                    tcodigo.Focus();
                    return;

                }
                else
                {
                        this.tpaterno.Focus();
                        this.tpaterno.SelectAll();
                }

            }

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmbciudad_SelectedIndexChanged(object sender, EventArgs e)
        {

            DistritoRegistrado distritoregistrado = new DistritoRegistrado();
            distritoregistrado.CODPAIS = cbopais.SelectedValue.ToString();
            distritoregistrado.iddepa = cdepa.SelectedValue.ToString();


            if (cmbciudad.SelectedItem == null)
            {

                cmbciudad.SelectedIndex =-1;
              
            }
            else
            {

            distritoregistrado.codprovi = cmbciudad.SelectedValue.ToString();
            IGestorDeDistrito gestorDeDistrito = new GestorDeDistrito();
            listDistrito = gestorDeDistrito.Filtrar(distritoregistrado);
            cmbdist.DataSource = listDistrito;
            cmbdist.ValueMember = "CodDis";
            cmbdist.DisplayMember = "Descripcion";

            }

        }

        private void TxtRzSocialDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnQuitDep_Click(object sender, EventArgs e)
        {

            string MesAct, Anio;
            string VentaC, VentD, MoviD, MoviC;

            List<ListAñoMes> ListAMes = new List<ListAñoMes>();

            IGestorCierre_Mes_Inv gestorcierreinv = new GestorDeCierre_Mes_Inv();

            ListAMes = gestorcierreinv.ExtraerAñoMes("01");

            List<VentaCabRegistrado> lis = new List<VentaCabRegistrado>();
           
            IGestorDeHistoVentas gesthistoventas = new GestorDeHistoVentas();
            int cantidad;
            string codcliedep;
            codcliedep = dgvClidep.Rows[dgvClidep.CurrentRow.Index].Cells[0].Value.ToString();


            foreach (ListAñoMes s in ListAMes)
            {
                MesAct = "00" + s.MES;
                if (MesAct.Length == 4)
                {
                    MesAct = s.MES;
                }
                else
                {
                    MesAct = MesAct.Substring(1, MesAct.Length - 1);
                }
                Anio = s.AÑO;
                VentaC = "VENTC" + Anio + MesAct;
                VentD = "VENTD" + Anio + MesAct;
                MoviD = "MOVID" + Anio + MesAct;
                MoviC = "MOVIC" + Anio + MesAct;

                string venta;
                venta = gesthistoventas.HistoVentas(VentaC, "01");
                if (venta != null)
                {
                    cantidad = gestorDeCliente.Busq_cliedep_vta("01", codcliedep, VentaC);
                    if (cantidad > 0)
                    {
                        MessageBox.Show("ESTE CLIENTE NO SE PUEDE BORRAR TIENE DATOS EN VENTAS");
                        return;
                    }
                }
            }

            cantidad = gestorDeCliente.Busq_cliedep_vta("01", codcliedep, "0");
            if (cantidad > 0)
            {
                MessageBox.Show("ESTE CLIENTE NO SE PUEDE BORRAR TIENE DATOS EN VENTAS");
                return;
            }

            string dato;
            dato = gestorDeCliente.Busq_clie_ped("01", codcliedep);
            if (dato != null)
            {
                MessageBox.Show("ESTE CLIENTE NO SE PUEDE BORRAR ESTA EN PEDIDOS");
                return;
            }


            ListCliDep.RemoveAt(dgvClidep.CurrentRow.Index);
            dgvClidep.DataSource = ListCliDep;
            if (ListCliDep.Count > 0)
            {
                dgvClidep.DataSource = ListCliDep;
            }
            else
            {
                dgvClidep.DataSource = null;
                dgvClidep.DataSource = ListCliDep;
            }

            BtnAgregDep.Enabled = true;

        }


        private void dgvClidep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClidep_DoubleClick(object sender, EventArgs e)
        {

            indice = this.dgvClidep.CurrentRow.Index;

            TxtDniDep.Text = ListCliDep[indice].dni.ToString();
            TxtRzSocialDep.Text = ListCliDep[indice].DATOADJUNTO.ToString();
            TxtDirecDep.Text = ListCliDep[indice].direccion.ToString();
            cmbciudad.SelectedValue = ListCliDep[indice].CODCIUDAD.ToString();
            cmbdist.SelectedValue = ListCliDep[indice].CODDISTRITO.ToString();
            CboRutaDep.SelectedValue = ListCliDep[indice].CODRUTA.ToString();
            txtMPercepcion.Text = ListCliDep[indice].MPERCEP.ToString();
            ck_Nota_Pedido.Checked = ListCliDep[indice].notapedido.Value;
            ck_ort.Checked = ListCliDep[indice].ORT.Value;
            ChkActivoClientDep.Checked = ListCliDep[indice].ACTIVO;
            TxtRucDep.Text = ListCliDep[indice].ruc.ToString();

            BtnAgregDep.Enabled = false;


        }

        private void TxtDirecDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbdist_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void CboRutaDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMPercepcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void ck_ort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ck_Nota_Pedido_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkActivoClientDep_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            bloquea(false, true);

            if (FLAG == 0)
                {
                 limpia();
                BOTONES(true, false, false, false, true);
            }
            else
            {
                limpia();
                BOTONES(true, false, false, false,true);
            }

            AINTOP = 0;

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ChkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkActivo.Checked == true)
            {
               ACTIVOCLIENTE = true;
            }
            else
            {
               ACTIVOCLIENTE = false;
            }
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            AINTOP = 1;
            //pb_agregar = true;
            // MontoCred = tcredito.Text
            bloquea(true, false);
            tcodigo.Enabled = false;
            BOTONES(false, true, false, false, true);
            FLAG = 1;
            tpaterno.Focus();
            tpaterno.SelectAll();
            BTNCANCELAR.Enabled = true;
            CheckBox1_CheckedChanged(sender, e);
            tsaldo.ReadOnly = true;
            tcredito.Enabled = true;
            TxtLineaUtilidad.Enabled = false;
            TxtTotSaldoDisp.Enabled = false;
            //BtnQuitDep.Enabled = false;
            cmbciudad.SelectedIndex = 1;
            cmbdist.SelectedIndex = 1;

        }

        private void btnAgregarF_Click(object sender, EventArgs e)
        {

            double ejem = 0;

            if (double.TryParse(TxtTotLimCred.Text, out ejem))
            {

            }
            else
            {
                MessageBox.Show("El cliente tiene que tener crédito.","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtTotLimCred.Focus();
                return;
            }

           if (double.TryParse(tcredito.Text, out ejem))
            {

            }
            else
            {
                MessageBox.Show("Ingrese Límite de Crédito.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tcredito.Focus();
                return;
            }



            decimal MONTO = Convert.ToDecimal(tsaldo.Text);

            if (Convert.ToDecimal(tsaldo.Text) > Convert.ToDecimal(TxtTotLimCred.Text))
            {
                MessageBox.Show("El Saldo de Fuerza de Venta no puede ser Mayor a Total Limite Crédito.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (FLAG == 0)
            {

                foreach (ClieFuerzaListar s in ListCliefuerzaList)
                {
                    if (s.CODFUERZA == cbFuerzaVta.SelectedValue.ToString())
                    {
                        MessageBox.Show("Ya Existe Esta Fuerza de Venta.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    MONTO = MONTO + Convert.ToDecimal(s.CREDITO_F);
                    if (Convert.ToDecimal(MONTO) >= Convert.ToDecimal(TxtTotLimCred.Text))
                    {
                        MessageBox.Show("El Saldo de Fuerza de Venta no puede ser Mayor a Total Limite Crédito.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                ClieFuerzaListar cliefuerzalistar = new ClieFuerzaListar();
                cliefuerzalistar.CODFUERZA = cbFuerzaVta.SelectedValue.ToString();
                cliefuerzalistar.DESCRIPCION = cbFuerzaVta.Text;
                cliefuerzalistar.SALDO_CREDF = Convert.ToDecimal(tsaldo.Text);
                cliefuerzalistar.CREDITO_F = Convert.ToDecimal(tcredito.Text);
                ListCliefuerzaList.Add(cliefuerzalistar);
                dgvMatrizFuerzas.DataSource = ListCliefuerzaList.ToList();


            }
            else
            {


                foreach (ClieFuerzaListar s in ListCliefuerzaList)
                {
                    if (s.CODFUERZA== cbFuerzaVta.SelectedValue.ToString())
                    {
                        MessageBox.Show("Ya Existe Esta Fuerza de Venta.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                   MONTO = MONTO + Convert.ToDecimal(s.CREDITO_F);
                    if (Convert.ToDecimal(MONTO) >= Convert.ToDecimal(TxtTotLimCred.Text))
                    {
                        MessageBox.Show("El Saldo de Fuerza de Venta no puede ser Mayor a Total Limite Crédito.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                ClieFuerzaListar cliefuerzalistar = new ClieFuerzaListar();
                cliefuerzalistar.CODFUERZA = cbFuerzaVta.SelectedValue.ToString();
                cliefuerzalistar.DESCRIPCION = cbFuerzaVta.Text;
                cliefuerzalistar.SALDO_CREDF = Convert.ToDecimal(tsaldo.Text);
                cliefuerzalistar.CREDITO_F = Convert.ToDecimal(tcredito.Text);
                ListCliefuerzaList.Add(cliefuerzalistar);
                dgvMatrizFuerzas.DataSource = ListCliefuerzaList.ToList();


            }




        }

        //public void Sumar_Descuento(PlanillaOrdenDetE o)
        //{
        //    LblTotalAcuenta.Text = (System.Convert.ToDecimal(LblTotalAcuenta.Text) + o.DESCUENTO).ToString("c");

        //    LblDiferencia.Text = System.Convert.ToDecimal(LblTotalAcuenta.Text) - System.Convert.ToDecimal(LblTotalDescAutorizado.Text);
        //}



        private void btnQuitar_Click(object sender, EventArgs e)
        {
                var i = this.dgvMatrizFuerzas.RowCount;
                if (i > 0)
                {
                    ListCliefuerzaList.RemoveAt(dgvMatrizFuerzas.CurrentRow.Index);
                    dgvMatrizFuerzas.DataSource = ListCliefuerzaList.ToList();
                    //Calcula_Total();
                }
     
        }

        private void dgvMatrizFuerzas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMatrizFuerzas_DoubleClick(object sender, EventArgs e)
        {

            indice = this.dgvMatrizFuerzas.CurrentRow.Index;

            cbFuerzaVta.SelectedValue = ListCliefuerzaList[indice].CODFUERZA.ToString();
            tcredito.Text = ListCliefuerzaList[indice].CREDITO_F.ToString();
            tsaldo.Text = ListCliefuerzaList[indice].SALDO_CREDF.ToString();
            


        }

        private void tcredito_TextChanged(object sender, EventArgs e)
        {
            tsaldo.Text = tcredito.Text;
        }

        private void TxtLineaUtilidad_TextChanged(object sender, EventArgs e)
        {
            double totLimCred = 0;
            double tLineaUtilidad = 0;

           if (Double.TryParse(TxtTotLimCred.Text, out totLimCred) && Double.TryParse(TxtLineaUtilidad.Text, out tLineaUtilidad))
            {
             TxtTotSaldoDisp.Text = (totLimCred - tLineaUtilidad).ToString("N2");
            }
        }

        private void TxtPedidoUtilizado_TextChanged(object sender, EventArgs e)
        {

            double totLimCred = 0;
            double tLineaUtilidad = 0;
            double pedidoUtilizado = 0;
            if (Double.TryParse(TxtTotLimCred.Text, out totLimCred) && Double.TryParse(TxtLineaUtilidad.Text, out tLineaUtilidad) && Double.TryParse(TxtPedidoUtilizado.Text, out pedidoUtilizado))
            {
                TxtTotSaldoDisp2.Text = (totLimCred - tLineaUtilidad - pedidoUtilizado).ToString("N2");
            }

        }

        private void TxtTotSaldoDisp_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotSaldoDisp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctipopago_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ctipopago.SelectedValue.ToString() == "06")
            {
                //ModVariables.CAyuda.CargarDataCombo(CmbForPago, "NSP_SELECT_LISTATIPCREDF '" + ModVariables.codempresa + "'", "TIPCREDFAC", "DESCREDFAC");

                IGestorDeTipoCredito gestordeTipoCredito = new GestorDeTipoCredito();
                CmbForPago.DataSource = gestordeTipoCredito.Listar();
                CmbForPago.ValueMember = "TIPCREDFAC";
                CmbForPago.DisplayMember = "DESCREDFAC";


                Label16.Visible = true;
                tcredito.Visible = true;
                Label17.Visible = true;
                tsaldo.Visible = true;
                Label5.Visible = true;
                CmbForPago.Visible = true;
               



                TxtTotSaldoDisp.Enabled = false;
            }
            else
            {
                Label16.Visible = false;
                tcredito.Visible = false;
                Label17.Visible = false;
                tsaldo.Visible = false;
                Label5.Visible = false;
                CmbForPago.Visible = false;
            }
        }







        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (tcodigo.Enabled == true)
                tcodigo.Focus();

            if (AINTOP == 1)
            {
                if (this.CheckBox1.Checked == true)
                {
                    truc.ReadOnly = false;
                    trazon.ReadOnly = false;
                    tpaterno.ReadOnly = true;
                    tmaterno.ReadOnly = true;
                    tnombre.ReadOnly = true;
                    tdni.ReadOnly = true;
                    trazon.Focus();
                    trazon.SelectAll();

                    tpaterno.Text = "";
                    tmaterno.Text = "";
                    tnombre.Text = "";
                    tdni.Text = "";
                }
                else
                {
                    truc.Text = "";
                    trazon.Text = "";

                    truc.ReadOnly = true;
                    trazon.ReadOnly = true;
                    tpaterno.ReadOnly = false;
                    tmaterno.ReadOnly = false;
                    tnombre.ReadOnly = false;
                    tdni.ReadOnly = false;
                    tpaterno.Focus();
                    tpaterno.SelectAll();
                }
            }
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO DE ELIMINAR EL REGISTRO", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            string Dependiente;

            Dependiente = gestordeclidep.Busq_dep_cliente("01", tcodigo.Text);

            if (Dependiente != null) 
            {   
                MessageBox.Show("NO SE PUEDE ELIMINAR TIENE CLIENTE DEPENDIENTES PRIMERO TIENE Q ELIMINAR LOS DEPENDIENTES", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string MesAct, Anio;
            string VentaC, VentD, MoviD, MoviC;

            List<ListAñoMes> ListAMes = new List<ListAñoMes>();

            IGestorCierre_Mes_Inv gestorcierreinv = new GestorDeCierre_Mes_Inv();

            ListAMes=gestorcierreinv.ExtraerAñoMes("01");

            List<VentaCabRegistrado> lis = new List<VentaCabRegistrado>();
          
           IGestorDeHistoVentas gesthistoventas= new GestorDeHistoVentas();
           int cantidad;

            foreach (ListAñoMes s in ListAMes)
            {
                MesAct = "00" +s.MES;               
                if (MesAct.Length == 4)
                {
                    MesAct = s.MES;
                }
                else
                {
                    MesAct = MesAct.Substring(1, MesAct.Length - 1);
                }    
                Anio = s.AÑO;
                VentaC = "VENTC" + Anio + MesAct;
                VentD = "VENTD" + Anio + MesAct;
                MoviD = "MOVID" + Anio + MesAct;
                MoviC = "MOVIC" + Anio + MesAct;

                string venta;
                venta= gesthistoventas.HistoVentas(VentaC, "01");
                if (venta !=null)
                {      
                    cantidad = gestorDeCliente.Busq_clie_vta("01", tcodigo.Text, VentaC);
                    if (cantidad>0)
                    {
                        MessageBox.Show("ESTE CLIENTE NO SE PUEDE BORRAR TIENE DATOS EN VENTAS");
                        return;
                    }
                }
            }
          
            cantidad = gestorDeCliente.Busq_clie_vta("01", tcodigo.Text, "0");
            if (cantidad > 0)
            {
                MessageBox.Show("ESTE CLIENTE NO SE PUEDE BORRAR TIENE DATOS EN VENTAS");
                return;
            }

           IGestorDeClieFuerza gestordeclieF = new GestorDeClieFuerza();
           gestordeclieF.EliminarXCliente(tcodigo.Text.ToString());

           gestorDeCliente.EliminarCliente(tcodigo.Text.ToString());


            BOTONES(true, false, false, false, true);
           
            limpia();
            BTNCANCELAR.Enabled = false;
      
            bloquea(false, true);
            AINTOP = 0;


        }

        private void BTNNUEVO_Click_1(object sender, EventArgs e)
        {

            limpia();
            bloquea(true, false);
         
            BOTONES(false, true, false, false, false);
            FLAG = 0;
            BTNCANCELAR.Enabled = true;
            tcodigo.Enabled = false;


            CiudadRegistrado ciudad_Registrado = new CiudadRegistrado();
            ciudad_Registrado.iddepa = "10";

            IGestorDeDepartamento gestorDeDepartamento = new GestorDeDepartamento();
            cdepa.DataSource = gestorDeDepartamento.Listar();
            cdepa.ValueMember = "iddepa";
            cdepa.DisplayMember = "depa";

            AINTOP = 1;

        }

        private void tdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void tdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.truc.Focus();
                this.truc.SelectAll();
            }


        }

        private void truc_TextChanged(object sender, EventArgs e)
        {

        }

        private void truc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.tdireccion.Focus();
                this.tdireccion.SelectAll();
            }



        }

        private void TxtRucDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRucDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.TxtDniDep.Focus();
                this.TxtDniDep.SelectAll();
            }



        }

        private void TxtDniDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.TxtRzSocialDep.Focus();
                this.TxtRzSocialDep.SelectAll();
            }

        }

        private void txtMPercepcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                toolTip1.IsBalloon = true;
                toolTip1.Show("Solo se permiten numeros", txtMPercepcion, 3000);
                e.Handled = true;
            }
        }

        private void TxtTotLimCred_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotLimCred_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                toolTip1.IsBalloon = true;
                toolTip1.Show("Solo se permiten numeros", TxtTotLimCred, 3000);
                e.Handled = true;
            }
        }

        private void TxtLineaUtilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                toolTip1.IsBalloon = true;
                toolTip1.Show("Solo se permiten numeros", TxtLineaUtilidad, 3000);
                e.Handled = true;
            }
        }

        private void TxtPedidoUtilizado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                toolTip1.IsBalloon = true;
                toolTip1.Show("Solo se permiten numeros", TxtPedidoUtilizado, 3000);
                e.Handled = true;
            }
        }

        private void TxtTotSaldoDisp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                toolTip1.IsBalloon = true;
                toolTip1.Show("Solo se permiten numeros", TxtTotSaldoDisp, 3000);
                e.Handled = true;
            }
        }

        private void TxtTotSaldoDisp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                toolTip1.IsBalloon = true;
                toolTip1.Show("Solo se permiten numeros", TxtTotSaldoDisp2, 3000);
                e.Handled = true;
            }
        }

        private void tdescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void tdescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                toolTip1.IsBalloon = true;
                toolTip1.Show("Solo se permiten numeros", tdescuento, 3000);
                e.Handled = true;
            }
        }

        private void tcredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                toolTip1.IsBalloon = true;
                toolTip1.Show("Solo se permiten numeros", tcredito, 3000);
                e.Handled = true;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
         


        }

        private void BTNCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClidep_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //IGestorDeClieFuerza gestordeclifuerza = new GestorDeClieFuerza();

            //gestordeclifuerza.EliminarXCliente("7627");

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {


            FrmRpt_Clientes frm = new FrmRpt_Clientes("01","Narsistemas","2411");
            frm.ShowDialog();



        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FrmRpt_ClienteDepPer frm = new FrmRpt_ClienteDepPer("01");
            frm.ShowDialog();
        }

        private void tpaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
 
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.tmaterno.Focus();
                this.tmaterno.SelectAll();
            }

        }

        private void tmaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.tnombre.Focus();
                this.tnombre.SelectAll();
            }
        }

        private void tnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.trazon.Focus();
                this.trazon.SelectAll();
            }
        }

        private void trazon_TextChanged(object sender, EventArgs e)
        {

        }

        private void trazon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.tdni.Focus();
                this.tdni.SelectAll();
            }
        }

        private void tdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.ttelefono.Focus();
                this.ttelefono.SelectAll();
            }
        }

        private void ttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.txtfax.Focus();
                this.txtfax.SelectAll();
            }
        }

        private void txtfax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.tmail.Focus();
                this.tmail.SelectAll();
            }
        }

        private void tmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmail_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.cbopais.Focus();
                this.cbopais.SelectAll();
            }

        }

        private void TxtDniDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRzSocialDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.TxtDirecDep.Focus();
                this.TxtDirecDep.SelectAll();
            }
        }

        private void TxtDirecDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.cmbciudad.Focus();
                this.cmbciudad.SelectAll();
            }
        }

        private void txtcontacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.txttelefonoc.Focus();
                this.txttelefonoc.SelectAll();
            }

        }

        private void txttelefonoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefonoc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.txtcelularc.Focus();
                this.txtcelularc.SelectAll();
            }
        }

        private void txtcelularc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcelularc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }



            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.txtemailc.Focus();
                this.txtemailc.SelectAll();
            }
        }

        private void txtemailc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemailc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                this.ctipopago.Focus();
                this.ctipopago.SelectAll();
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex != 0)
            {
                if (FLAG == 1)
                {
                  if (tcodigo.Text.Trim() == "")
                   {
                    //Interaction.MsgBox("FALTA CODIGO DE CLIENTE..", MsgBoxStyle.Exclamation, "");

                    MessageBox.Show("FALTA CODIGO DE CLIENTE..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TabControl1.SelectedIndex = 0;
                   }
                }


            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rb_Si_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Si.Checked == true)
            {
                Label58.Visible = true;
                Label59.Visible = true;
                txtCantidad.Visible = true;
                txtObservacion.Visible = true;

                COOLER = 1;
            }

            if (rb_No.Checked == true)
            {
                Label58.Visible = false;
                Label59.Visible = false;
                txtCantidad.Visible = false;
                txtObservacion.Visible = false;

                COOLER = 0;
            }
        }

        private void txt_Cordenadas_X_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbForPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabPage4_Click(object sender, EventArgs e)
        {

        }

        private void ChkMiercoles_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

            ListCliDep[indice].dni = TxtDniDep.Text;
            ListCliDep[indice].DATOADJUNTO = TxtRzSocialDep.Text;
            ListCliDep[indice].direccion = TxtDirecDep.Text;
            ListCliDep[indice].CODCIUDAD = cmbciudad.SelectedValue.ToString();
            ListCliDep[indice].CODDISTRITO = cmbdist.SelectedValue.ToString();
            ListCliDep[indice].DISTRITO= cmbdist.Text.ToString();
            ListCliDep[indice].CODRUTA = CboRutaDep.SelectedValue.ToString();
            ListCliDep[indice].RUTA = CboRutaDep.Text.ToString();
            ListCliDep[indice].MPERCEP = Convert.ToDecimal(txtMPercepcion.Text);
            ListCliDep[indice].notapedido = ck_Nota_Pedido.Checked;
            ListCliDep[indice].ORT = ck_ort.Checked;
            ListCliDep[indice].ACTIVO = ChkActivoClientDep.Checked;
            ListCliDep[indice].ruc = TxtRucDep.Text;

            dgvClidep.DataSource = ListCliDep.ToList();

            AINTOP = 0;

            BtnAgregDep.Enabled = true;
            limpiarCliDep();
        }
    }

}

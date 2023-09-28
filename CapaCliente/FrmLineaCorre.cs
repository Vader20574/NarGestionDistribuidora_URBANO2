using Common.Services;
using Servicios.Implementacion;
using Servicios.Interfaces.Linea;
using Servicios.Interfaces.LineaCorreDoc.Peticiones;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaCliente
{
    public partial class FrmLineaCorre : Form
    {

         string url;

        List<LineaCorreDocNuevo> nn = new List<LineaCorreDocNuevo>();
        int FLAG = 0;

      
        IApiService apiService = new ApiService();



        public FrmLineaCorre()
        {
            InitializeComponent();
        }


 





       




        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {


            if (FLAG == 0)
            { 

                LineaCorreDocNuevo lineacorredocnuevo = new LineaCorreDocNuevo();
                lineacorredocnuevo.Codempresa = "01";
                lineacorredocnuevo.nrobol = Convert.ToDecimal(txtnrobol.Text);
                lineacorredocnuevo.nrofac = Convert.ToDecimal(txtnrofac.Text);
                lineacorredocnuevo.nrobolRef = Convert.ToDecimal(txtnrobolref.Text);
                lineacorredocnuevo.nrofacRef= Convert.ToDecimal(txtnrofacref.Text);


                if (chkEnviarElect.Checked == true)
                {
                    lineacorredocnuevo.EnviaElect = true;
                }
                else
                {
                    lineacorredocnuevo.EnviaElect = false;
                }
                lineacorredocnuevo.LineaCodlinea = cbolinea.SelectedValue.ToString(); 

                crearLineaCorre(lineacorredocnuevo);

            }

            if (FLAG == 1)
            {

                LineaCorreDocNuevo lineacorredocnuevo = new LineaCorreDocNuevo();
                lineacorredocnuevo.Id = int.Parse(txtId.Text);
                lineacorredocnuevo.Codempresa = "01";
                lineacorredocnuevo.nrobol = Convert.ToDecimal(txtnrobol.Text);
                lineacorredocnuevo.nrofac = Convert.ToDecimal(txtnrofac.Text);
                lineacorredocnuevo.nrobolRef = Convert.ToDecimal(txtnrobolref.Text);
                lineacorredocnuevo.nrofacRef = Convert.ToDecimal(txtnrofacref.Text);

                if (chkEnviarElect.Checked == true)
                {
                    lineacorredocnuevo.EnviaElect = true;
                }
                else
                {
                    lineacorredocnuevo.EnviaElect = false;
                }


                lineacorredocnuevo.LineaCodlinea = cbolinea.SelectedValue.ToString();




                modificarLineaCorre(lineacorredocnuevo);
            }







                //string resultado = Send<LineaCorreDocNuevo>(url, lineacorredocnuevo, "POST");



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

        private void FrmLineaCorre_Load(object sender, EventArgs e)
        {
          

            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();



            //client.BaseAddress = new Uri(url);
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //new MediaTypeWithQualityHeaderValue("application/json"));

            IGestorDeLinea gestdelinea = new GestorDeLinea();
            cbolinea.DataSource = gestdelinea.Listar();
            cbolinea.DisplayMember = "DESLINEA";
            cbolinea.ValueMember = "CODLINEA";

            BOTONES(true, false, true, true, true);
            bloquea(false);
        }

        void Limpiar()
        {
            txtId.Text = "";
            cbolinea.SelectedIndex = 1;
            txtnrobol.Text = "";
            txtnrofac.Text = "";
            txtnrobolref.Text = "";
            txtnrofacref.Text = "";
            chkEnviarElect.Checked = false;
        }


        void bloquea(Boolean estado)
        {
            txtId.Enabled = estado;
            cbolinea.Enabled = estado;
            txtnrobol.Enabled = estado;
            txtnrofac.Enabled = estado;
            txtnrobolref.Enabled = estado;
            txtnrofacref.Enabled = estado;
            chkEnviarElect.Enabled = estado;

           

        }

     
       

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, false);
            Limpiar();
            bloquea(true);
            FLAG = 0;
            txtId.Enabled = false;






        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
  

        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {

            BOTONES(false, true, false, false, true);
            FLAG = 1;
            bloquea(true);
        }

    
        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            
            LineaCorreDocNuevo lineacorredocnuevo = new LineaCorreDocNuevo();
            lineacorredocnuevo.Id = int.Parse(txtId.Text);
            lineacorredocnuevo.Codempresa = "01";
            lineacorredocnuevo.nrobol = Convert.ToDecimal(txtnrobol.Text);
            lineacorredocnuevo.nrofac = Convert.ToDecimal(txtnrofac.Text);
            lineacorredocnuevo.nrobolRef = Convert.ToDecimal(txtnrobolref.Text);
            lineacorredocnuevo.nrofacRef = Convert.ToDecimal(txtnrofacref.Text);

            if (chkEnviarElect.Checked == true)
            {
                lineacorredocnuevo.EnviaElect = true;
            }
            else
            {
                lineacorredocnuevo.EnviaElect = false;
            }

            lineacorredocnuevo.LineaCodlinea =cbolinea.SelectedValue.ToString();


            if (txtId.Text.Length > 0)
            {

                DeleteLineaCorre(lineacorredocnuevo);
                BOTONES(true, false, true, true, true);
                Limpiar();
                bloquea(false);
              

            }
            else
            {
                MessageBox.Show("Codigo equipo esta vacio");
            }





        }

        private async void crearLineaCorre(LineaCorreDocNuevo product)
        {


            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await CreateProductAsync(product);


            var response = await this.apiService.PostAsync(
                url,
               "api",
               "/LineaCorre",
               product
               );

            //this.IsLoading = false;

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }

        }

        private async void modificarLineaCorre(LineaCorreDocNuevo product)
        {


            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await UpdateProductAsync(product);
            var response = await this.apiService.PutAsync(
               url,
              "api",
              "/LineaCorre",
               product.Id,
              product
              );

            //this.IsLoading = false;

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }


        }

        private async void DeleteLineaCorre(LineaCorreDocNuevo product)
        {


            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await DeleteProductAsync(product.Id.ToString());

            //this.IsLoading = true;

            //var token = JsonConvert.DeserializeObject<TokenResponse>(Settings.Token);

            var response = await this.apiService.DeleteAsync(
                url,
                "api",
                "/LineaCorre",
                product.Id);

            //this.IsLoading = false;

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }

          


        }
    


        private void btnBusqPromo_Click(object sender, EventArgs e)
        {
            FrmBuscarLineaCorre frm = new FrmBuscarLineaCorre();
            frm.VIE = this;
            frm.urlok = url;
            frm.ShowDialog();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

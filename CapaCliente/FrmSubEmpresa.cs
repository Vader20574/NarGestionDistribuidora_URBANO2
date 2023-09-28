using Common.Services;
using Remotion.Mixins.Validation;
using Servicios.Interfaces.SubEmpresa.Peticiones;
using Servicios.Interfaces.SubEmpresa.Respuestas;
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
    public partial class FrmSubEmpresa : Form
    {

        int FLAG = 0;
        string url;
        IApiService apiService = new ApiService();

        public FrmSubEmpresa()
        {
            InitializeComponent();
        }

        private void FrmSubEmpresa_Load(object sender, EventArgs e)
        {
            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();



            //client.BaseAddress = new Uri(url);
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //new MediaTypeWithQualityHeaderValue("application/json"));

            //IGestorDeLinea gestdelinea = new GestorDeLinea();
            //cbolinea.DataSource = gestdelinea.Listar();
            //cbolinea.DisplayMember = "DESLINEA";
            //cbolinea.ValueMember = "CODLINEA";

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
            txtCodSubEmpresa.Text = "";
            txtNomSubEmpresa.Text = "";
            txtCorrelFact.Text = "";
            txtCorrelBol.Text = "";
            txtCorrelNp.Text = "";
            txtCorrelFactRef.Text = "";
            txtCorrelBolRef.Text = "";
            txtCorrelNpRef.Text = "";
            chkEDESE.Checked = false;
            chkNGIE.Checked = false;
        }

        void bloquea(Boolean estado)
        {
            txtCodSubEmpresa.Enabled = estado;
            txtNomSubEmpresa.Enabled = estado;
            txtCorrelFact.Enabled = estado;
            txtCorrelBol.Enabled = estado;
            txtCorrelNp.Enabled = estado;
            txtCorrelFactRef.Enabled = estado;
            txtCorrelBolRef.Enabled = estado;
            txtCorrelNpRef.Enabled = estado;

        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
     

            //if (chkEDESE.Checked == true && chkNGIE.Checked == true)
            //{
            //    MessageBox.Show("No puede seleccionar dos opciones");
            //    return;
            //}



            if (FLAG == 0)
            {

                SubEmpresaNuevo subempresanuevo = new SubEmpresaNuevo();
                subempresanuevo.Nombre= txtNomSubEmpresa.Text;
                subempresanuevo.nrofac = Convert.ToDecimal(txtCorrelFact.Text);
                subempresanuevo.nrobol = Convert.ToDecimal(txtCorrelBol.Text);
                subempresanuevo.nroped= Convert.ToDecimal(txtCorrelNp.Text);

                subempresanuevo.nrofacRef = Convert.ToDecimal(txtCorrelFactRef.Text);
                subempresanuevo.nrobolRef = Convert.ToDecimal(txtCorrelBolRef.Text);
                subempresanuevo.nropedRef = Convert.ToDecimal(txtCorrelNpRef.Text);
                

                if (chkEDESE.Checked == true)
                {
                    subempresanuevo.EDESE = true;
                }
                else
                {
                    subempresanuevo.EDESE = false;
                }


                if (chkNGIE.Checked == true)
                {
                    subempresanuevo.NGIE = true;
                }
                else
                {
                    subempresanuevo.NGIE = false;
                }




                crearSubEmpresaNuevo(subempresanuevo);

            }

            if (FLAG == 1)
            {

                SubEmpresaRegistrado subempresareg = new SubEmpresaRegistrado();
                subempresareg.Id = int.Parse(txtCodSubEmpresa.Text);
                subempresareg.Nombre = txtNomSubEmpresa.Text;
                subempresareg.nrofac = Convert.ToDecimal(txtCorrelFact.Text);
                subempresareg.nrobol = Convert.ToDecimal(txtCorrelBol.Text);
                subempresareg.nroped = Convert.ToDecimal(txtCorrelNp.Text);

                subempresareg.nrofacRef = Convert.ToDecimal(txtCorrelFactRef.Text);
                subempresareg.nrobolRef = Convert.ToDecimal(txtCorrelBolRef.Text);
                subempresareg.nropedRef = Convert.ToDecimal(txtCorrelNpRef.Text);


                if (chkEDESE.Checked == true)
                {
                    subempresareg.EDESE = true;
                }
                else
                {
                    subempresareg.EDESE = false;
                }


                if (chkNGIE.Checked == true)
                {
                    subempresareg.NGIE = true;
                }
                else
                {
                    subempresareg.NGIE = false;
                }


                modificarSubEmpresa(subempresareg);
            }



            //string resultado = Send<LineaCorreDocNuevo>(url, lineacorredocnuevo, "POST");


            BOTONES(true, false, true, true, true);
            bloquea(false);


        }



        private async void crearSubEmpresaNuevo(SubEmpresaNuevo subempresa)
        {

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await CreateProductAsync(product);

            var response = await this.apiService.PostAsync(
                url,
               "api",
               "/SubEmpresa",
               subempresa
               );

            //this.IsLoading = false;

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }

        }

        private async void modificarSubEmpresa(SubEmpresaRegistrado subempresa)
        {

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await UpdateProductAsync(product);
            var response = await this.apiService.PutAsync(
               url,
              "api",
              "/SubEmpresa",
               subempresa.Id,
              subempresa
              );

            //this.IsLoading = false;

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }

        }


        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, false);
            Limpiar();
            bloquea(true);
            FLAG = 0;
            txtCodSubEmpresa.Enabled = false;
        }

        private void btnBusqPromo_Click(object sender, EventArgs e)
        {
            FrmBuscarSubEmpresa frm = new FrmBuscarSubEmpresa();
            frm.VIE = this;
            //frm.urlok = url;
            frm.ShowDialog();
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, true);
            FLAG = 1;
            bloquea(true);
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            SubEmpresaRegistrado subempresaregistrado = new SubEmpresaRegistrado();
            subempresaregistrado.Id = int.Parse(txtCodSubEmpresa.Text);
            subempresaregistrado.Nombre = txtNomSubEmpresa.Text;
            subempresaregistrado.nrofac = Convert.ToDecimal(txtCorrelFact.Text);
            subempresaregistrado.nrobol = Convert.ToDecimal(txtCorrelBol.Text);
            subempresaregistrado.nroped = Convert.ToDecimal(txtCorrelNp.Text);
            subempresaregistrado.nrofacRef = Convert.ToDecimal(txtCorrelFactRef.Text);
            subempresaregistrado.nrobolRef = Convert.ToDecimal(txtCorrelBolRef.Text);
            subempresaregistrado.nropedRef = Convert.ToDecimal(txtCorrelNpRef.Text);

            if (chkEDESE.Checked == true)
            {
                subempresaregistrado.EDESE = true;
            }
            else
            {
                subempresaregistrado.EDESE = false;
            }


            if (chkNGIE.Checked == true)
            {
                subempresaregistrado.NGIE = true;
            }
            else
            {
                subempresaregistrado.NGIE = false;
            }


          

            if (txtCodSubEmpresa.Text.Length > 0)
            {

                DeleteSubEmpresa(subempresaregistrado);
                BOTONES(true, false, true, true, true);
                Limpiar();
                bloquea(false);


            }
            else
            {
                MessageBox.Show("Codigo equipo esta vacio");
            }

        }




        private async void DeleteSubEmpresa(SubEmpresaRegistrado product)
        {


            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await DeleteProductAsync(product.Id.ToString());

            //this.IsLoading = true;

            //var token = JsonConvert.DeserializeObject<TokenResponse>(Settings.Token);

            var response = await this.apiService.DeleteAsync(
                url,
                "api",
                "/SubEmpresa",
                product.Id);

            //this.IsLoading = false;

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

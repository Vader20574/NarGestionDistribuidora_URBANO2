using Common.Services;
using Servicios.Interfaces.EntregaMercas.Peticiones;
using Servicios.Interfaces.EntregaMercas.Respuestas;
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
    public partial class FrmRepartidor : Form
    {

        int FLAG = 0;
        string url;
        IApiService apiService = new ApiService();


    


        public FrmRepartidor()
        {
            InitializeComponent();
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {


            if (FLAG == 0)
            {

                EntregaMercaNuevo CatABCprodnuevo = new EntregaMercaNuevo();
                CatABCprodnuevo.Descripcion = txtDescripcion.Text;
                CatABCprodnuevo.Estado = chkEstado.Checked;
                crearCatABCprodNuevo(CatABCprodnuevo);

            }

            if (FLAG == 1)
            {

                EntregaMercaRegistrado catABCprodreg = new EntregaMercaRegistrado();
                catABCprodreg.Id = int.Parse(txtCodigo.Text);
                catABCprodreg.Descripcion = txtDescripcion.Text;
                catABCprodreg.Estado = chkEstado.Checked;
                modificarCatABCprod(catABCprodreg);
            }



            //string resultado = Send<LineaCorreDocNuevo>(url, lineacorredocnuevo, "POST");


            BOTONES(true, false, true, true, true);
            bloquea(false);

        }

        private async void crearCatABCprodNuevo(EntregaMercaNuevo catABCprod)
        {

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await CreateProductAsync(product);

            var response = await this.apiService.PostAsync(
                url,
               "api",
               "/Repartidor",
               catABCprod
               );

            //this.IsLoading = false;

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }

        }



        private async void modificarCatABCprod(EntregaMercaRegistrado catABCprod)
        {

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await UpdateProductAsync(product);
            var response = await this.apiService.PutAsync(
               url,
              "api",
              "/Repartidor",
               catABCprod.Id,
              catABCprod
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
            txtCodigo.Enabled = false;
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
            txtDescripcion.Text = "";
            
        }

        void bloquea(Boolean estado)
        {
            txtCodigo.Enabled = estado;
            txtDescripcion.Enabled = estado;
            chkEstado.Enabled = estado;
        }

        private void FrmCatABCprod_Load(object sender, EventArgs e)
        {
            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();
            
            BOTONES(true, false, true, true, true);
            bloquea(false);
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, true);
            FLAG = 1;
            bloquea(true);
        }

        private void btnBusqPromo_Click(object sender, EventArgs e)
        {
            FrmBuscarRepartidor frm = new FrmBuscarRepartidor();
            frm.VIE = this;
            //frm.urlok = url;
            frm.ShowDialog();
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            EntregaMercaRegistrado catABCprodRegistrado = new EntregaMercaRegistrado();
            catABCprodRegistrado.Id = int.Parse(txtCodigo.Text);
            catABCprodRegistrado.Descripcion = txtDescripcion.Text;
            catABCprodRegistrado.Estado = chkEstado.Checked;






            if (txtCodigo.Text.Length > 0)
            {

                DeleteCatABCprod(catABCprodRegistrado);
                BOTONES(true, false, true, true, true);
                Limpiar();
                bloquea(false);


            }
            else
            {
                MessageBox.Show("Codigo equipo esta vacio");
            }

        }


        private async void DeleteCatABCprod(EntregaMercaRegistrado catABCprod)
        {


            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await DeleteProductAsync(product.Id.ToString());

            //this.IsLoading = true;

            //var token = JsonConvert.DeserializeObject<TokenResponse>(Settings.Token);

            var response = await this.apiService.DeleteAsync(
                url,
                "api",
                "/Repartidor",
                catABCprod.Id);

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

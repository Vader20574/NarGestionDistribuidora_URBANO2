using Common.Services;
using Servicios.Interfaces.CatABCprod.Peticiones;
using Servicios.Interfaces.CatABCprod.Respuestas;
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
    public partial class FrmCatABCprod : Form
    {

        int FLAG = 0;
        string url;
        IApiService apiService = new ApiService();


    


        public FrmCatABCprod()
        {
            InitializeComponent();
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {


            if (FLAG == 0)
            {

                CatABCprodNuevo CatABCprodnuevo = new CatABCprodNuevo();
                CatABCprodnuevo.Descripcion = txtDescripcion.Text;






                crearCatABCprodNuevo(CatABCprodnuevo);

            }

            if (FLAG == 1)
            {

                CatABCprodRegistrado catABCprodreg = new CatABCprodRegistrado();
                catABCprodreg.Id = int.Parse(txtCodigo.Text);
                catABCprodreg.Descripcion = txtDescripcion.Text;

                modificarCatABCprod(catABCprodreg);
            }



            //string resultado = Send<LineaCorreDocNuevo>(url, lineacorredocnuevo, "POST");


            BOTONES(true, false, true, true, true);
            bloquea(false);

        }

        private async void crearCatABCprodNuevo(CatABCprodNuevo catABCprod)
        {

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await CreateProductAsync(product);

            var response = await this.apiService.PostAsync(
                url,
               "api",
               "/CatABCprod",
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



        private async void modificarCatABCprod(CatABCprodRegistrado catABCprod)
        {

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await UpdateProductAsync(product);
            var response = await this.apiService.PutAsync(
               url,
              "api",
              "/CatABCprod",
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
            FrmBuscarCatABCprod frm = new FrmBuscarCatABCprod();
            frm.VIE = this;
            //frm.urlok = url;
            frm.ShowDialog();
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            CatABCprodRegistrado catABCprodRegistrado = new CatABCprodRegistrado();
            catABCprodRegistrado.Id = int.Parse(txtCodigo.Text);
            catABCprodRegistrado.Descripcion = txtDescripcion.Text;
           

          



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


        private async void DeleteCatABCprod(CatABCprodRegistrado catABCprod)
        {


            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await DeleteProductAsync(product.Id.ToString());

            //this.IsLoading = true;

            //var token = JsonConvert.DeserializeObject<TokenResponse>(Settings.Token);

            var response = await this.apiService.DeleteAsync(
                url,
                "api",
                "/CatABCprod",
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

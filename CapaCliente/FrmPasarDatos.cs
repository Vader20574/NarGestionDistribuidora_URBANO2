using Common.Services;
using Servicios.Interfaces.Urbano.Peticiones;
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
    public partial class FrmPasarDatos : Form
    {
        string url;
        IApiService apiService = new ApiService();

        List<Clientex> lst = new List<Clientex>();


        public FrmPasarDatos()
        {
            InitializeComponent();
        }

        private void FrmPasarDatos_Load(object sender, EventArgs e)
        {
            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();
        }

        private void btnPasar_Click(object sender, EventArgs e)
        {
            Pasar_Datos();
        }



        private async void Pasar_Datos()
        {

            var response = await this.apiService.GetListAsync<Clientex>(
             url,
             "api",
             "/EnviaKimAUrba");

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }
            else
            {
                //this.Products = (List<LineaCorreDocRegistrado>)response.Result;
                //this.Products = this.Products.OrderBy(p => p.Name).ToList();

                lst = (List<Clientex>)response.Result;

                if (lst != null)
                {

                    MessageBox.Show("pasaron los datos");

                }
            }

            //this.Products = this.Products.OrderBy(p => p.Name).ToList();

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await CreateProductAsync(product);
        }

    }
}

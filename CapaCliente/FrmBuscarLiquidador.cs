using Common.Services;
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
    public partial class FrmBuscarLiquidador : Form
    {

        string url;
        IApiService apiService = new ApiService();

        List<CatABCprodRegistrado> nn = new List<CatABCprodRegistrado>();

        public FrmLiquidador VIE = new FrmLiquidador();

        public FrmBuscarLiquidador()
        {
            InitializeComponent();
        }

        private void FrmBuscarCatABCprod_Load(object sender, EventArgs e)
        {
            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();
            ListarCatABCprod();
        }


        private async void ListarCatABCprod()
        {

            var response = await this.apiService.GetListAsync<CatABCprodRegistrado>(
             url,
             "api",
             "/Liquidador");

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

                nn = (List<CatABCprodRegistrado>)response.Result;



                //nn.ForEach(dto =>
                //{
                //    var r = new LineaCorreDocRegistrado2
                //    {
                //        Id = dto.Id,
                //        Codempresa = dto.Codempresa,
                //        Deslinea = dto.Linea.DESLINEA,
                //        nrobol = dto.nrobol,
                //        nrofac = dto.nrofac,
                //        nrobolRef = dto.nrobolRef,
                //        nrofacRef = dto.nrofacRef,
                //        EnviaElect = dto.EnviaElect,
                //        LineaCodlinea = dto.LineaCodlinea
                //    };
                //    nn2.Add(r);
                //});



                if (nn != null)
                {
                    dataGridView1.DataSource = nn;
                }
            }

            //this.Products = this.Products.OrderBy(p => p.Name).ToList();

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await CreateProductAsync(product);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int indice;
            indice = this.dataGridView1.CurrentRow.Index;

            VIE.txtCodigo.Text = nn[indice].Id.ToString();
            VIE.txtDescripcion.Text = nn[indice].Descripcion.ToString();
            VIE.chkEstado.Checked = nn[indice].Estado;

            this.Close();
        }

        private void txtdato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

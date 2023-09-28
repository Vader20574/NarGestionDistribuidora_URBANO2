using Common.Services;
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
    public partial class FrmBuscarSubEmpresa : Form
    {

     
        string url;
        IApiService apiService = new ApiService();

       List<SubEmpresaRegistrado> nn = new List<SubEmpresaRegistrado>();
        //List<SubEmpresaRegistrado> nn2 = new List<LineaCorreDocRegistrado2>();
        public FrmSubEmpresa VIE = new FrmSubEmpresa();

        public FrmBuscarSubEmpresa()
        {
            InitializeComponent();
        }

        private void FrmBuscarSubEmpresa_Load(object sender, EventArgs e)
        {

            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();
            ListarSubEmpresa();
        }



        private async void ListarSubEmpresa()
        {

            var response = await this.apiService.GetListAsync<SubEmpresaRegistrado>(
             url,
             "api",
             "/SubEmpresa");

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

                nn = (List<SubEmpresaRegistrado>)response.Result;



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

            VIE.txtCodSubEmpresa.Text = nn[indice].Id.ToString();
            VIE.txtNomSubEmpresa.Text = nn[indice].Nombre.ToString();
            VIE.txtCorrelFact.Text = nn[indice].nrofac.ToString();
            VIE.txtCorrelBol.Text = nn[indice].nrobol.ToString();
            VIE.txtCorrelNp.Text = nn[indice].nroped.ToString();
            VIE.txtCorrelFactRef.Text = nn[indice].nrofacRef.ToString();
            VIE.txtCorrelBolRef.Text = nn[indice].nrobolRef.ToString();
            VIE.txtCorrelNpRef.Text = nn[indice].nropedRef.ToString();

            if (nn[indice].EDESE== true)
            {
                VIE.chkEDESE.Checked = true;
            }
            else
            {
                VIE.chkEDESE.Checked = false;
            }


            if (nn[indice].NGIE == true)
            {
                VIE.chkNGIE.Checked = true;
            }
            else
            {
                VIE.chkNGIE.Checked = false;
            }


            this.Close();
        }
    }
}

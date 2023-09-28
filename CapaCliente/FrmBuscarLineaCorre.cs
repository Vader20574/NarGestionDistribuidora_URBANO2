using Common.Services;

using Servicios.Interfaces.LineaCorreDoc.Respuestas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaCliente
{

    public partial class FrmBuscarLineaCorre : Form
    {
        private List<LineaCorreDocRegistrado> nn = new List<LineaCorreDocRegistrado>();
        private readonly List<LineaCorreDocRegistrado2> nn2 = new List<LineaCorreDocRegistrado2>();
        private readonly IApiService apiService = new ApiService();
        //IGestorDeConfigsis gestorDeConfigsis = new GestorDeConfigsis();


        public FrmLineaCorre VIE = new FrmLineaCorre();
        public string urlok;



        public FrmBuscarLineaCorre()
        {
            InitializeComponent();
        }

        private void FrmBuscarLineaCorre_Load(object sender, EventArgs e)
        {
            ListarLineaCorre();

        }


        private async void ListarLineaCorre()
        {

            var response = await this.apiService.GetListAsync<LineaCorreDocRegistrado>(
             urlok,
             "api",
             "/LineaCorre");

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

                nn = (List<LineaCorreDocRegistrado>)response.Result;



                nn.ForEach(dto =>
                {
                    var r = new LineaCorreDocRegistrado2
                    {
                        Id = dto.Id,
                        Codempresa = dto.Codempresa,
                        Deslinea = dto.Linea.DESLINEA,
                        nrobol = dto.nrobol,
                        nrofac = dto.nrofac,
                        nrobolRef = dto.nrobolRef,
                        nrofacRef = dto.nrofacRef,
                        EnviaElect = dto.EnviaElect,
                        LineaCodlinea = dto.LineaCodlinea
                    };
                    nn2.Add(r);
                });



                if (nn2 != null)
                {
                    dataGridView1.DataSource = nn2;
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

            VIE.txtId.Text = nn[indice].Id.ToString();
            VIE.cbolinea.SelectedValue = nn[indice].LineaCodlinea.ToString();
            VIE.txtnrobol.Text = nn[indice].nrobol.ToString();
            VIE.txtnrofac.Text = nn[indice].nrofac.ToString();
            VIE.txtnrobolref.Text = nn[indice].nrobolRef.ToString();
            VIE.txtnrofacref.Text = nn[indice].nrofacRef.ToString();

            if (nn[indice].EnviaElect == true)
            {
                VIE.chkEnviarElect.Checked = true;
            }
            else
            {
                VIE.chkEnviarElect.Checked = false;
            }

            this.Close();


        }
    }
}

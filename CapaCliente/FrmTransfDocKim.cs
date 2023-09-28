using CapaCliente.Facturacion.Respuestas;
using CapaCliente.Reportes;
using Common.Services;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CapaCliente
{
    public partial class FrmTransfDocKim : Form
    {
        string url;

        IApiService apiService = new ApiService();
        List<RespBuscarDocRegistrado> ListRespBuscarDocReg = new List<RespBuscarDocRegistrado>();
        public FrmTransfDocKim()
        {
            InitializeComponent();
        }

        class mensaje
        {
            public string codigo { get; set; }
            public string msj { get; set; }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            mensaje ms = new mensaje();
            ms.codigo = "01";
            ms.msj = "ja";

            btnTransferir.Enabled = false;
            //crearLineaCorre(ms);

            string resultado = Send<mensaje>(url + "api/EnviaDocKim", ms, "POST");

            MessageBox.Show(resultado);
            btnTransferir.Enabled = true;
        }
        private async void crearLineaCorre(mensaje m)
        {


            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await CreateProductAsync(product);
            //var codempresa2 = "01";

            var response = await this.apiService.PostAsync(
                url,
               "api",
               "/EnviaDocKim",
               m
               );

            //this.IsLoading = false;

            if (!response.IsSuccess)
            {

                
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");

                btnTransferir.Enabled = true;
             
            }
            else
            {
                //mensaje ms = new mensaje();
                ////ms.codigo = "01";
                ////ms.msj = "ja";
                mensaje nn = new mensaje();
                nn = (mensaje)response.Result;
                MessageBox.Show(nn.msj);

                btnTransferir.Enabled = true;
            }

        }

        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = "";

            try
            {

                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json";
                request.Timeout = 300000000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                result = e.Message;

            }

            return result;
        }

        private void FrmTransfDocKim_Load(object sender, EventArgs e)
        {
            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarFactEnviadas();
        }



        private async void ListarFactEnviadas()
        {

            var response = await this.apiService.GetListAsync<RespBuscarDocRegistrado>(
             url,
             "api",
             "/EnviaDocKim");

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

                ListRespBuscarDocReg = (List<RespBuscarDocRegistrado>)response.Result;


                if (ListRespBuscarDocReg != null)
                {



                    //dataGridView1.DataSource = ListRespBuscarDocReg;


                    //RptDocEnvKim cr = new RptDocEnvKim();
                    //cr.SetDataSource(ListRespBuscarDocReg);
                    //crystalReportViewer1.ReportSource = cr;

                    FrmRptDocEnvKim frm = new FrmRptDocEnvKim(ListRespBuscarDocReg);
                    frm.Show();

                    //var rptH = new ReportClass();
                    //rptH.FileName = Server.MapPath();

                }
            }

            //this.Products = this.Products.OrderBy(p => p.Name).ToList();

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await CreateProductAsync(product);
        }



    }
}

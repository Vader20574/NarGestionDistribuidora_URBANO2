using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaCliente
{
    public partial class FrmIntegraciónDistUrbano : Form
    {
        public FrmIntegraciónDistUrbano()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url;
            url = "http://test.geosales.cloud/monitoreoservicios/monitor/sdk/index.php/cargarCategoria";
            //url = "http://localhost/WebCore/api/LineaCorre";
            //PostFormUrlEncoded(url,"");
            getpost4(url);

           


        }


        public class LineaCorreDocNuevo
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("codempresa")]
            public string Codempresa { get; set; }

            [JsonProperty("nrofac")]
            public decimal nrofac { get; set; }

            [JsonProperty("nrobol")]
            public decimal nrobol { get; set; }

            [JsonProperty("nrofacref")]
            public decimal nrofacRef { get; set; }
            [JsonProperty("nrobolref")]
            public decimal nrobolRef { get; set; }
            [JsonProperty("enviaelect")]
            public bool EnviaElect { get; set; }
            [JsonProperty("lineacodlinea")]
            public string LineaCodlinea { get; set; }


        }


        public static string GetPost(string url)
        {

            LineaCorreDocNuevo ln = new LineaCorreDocNuevo();
            ln.Id = 0;
            ln.Codempresa = "01";
            ln.nrofac = 500000001;
            ln.nrobol = 500000001;
            ln.nrobol = 500000001;
            ln.nrofacRef = 500000001;
            ln.nrobolRef = 500000001;
            ln.EnviaElect = true;
            ln.LineaCodlinea = "001";

            string result = "";
            WebRequest oRequest = WebRequest.Create(url);
            oRequest.Method = "post";
            //oRequest.ContentType = "application/x-www-form-urlencoded";
            oRequest.ContentType = "application/json; charset=utf-8";
            using (var oSW = new StreamWriter(oRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(ln);
                oSW.Write(json);
                oSW.Flush();
                oSW.Close();
            }


            // Metodo modificado
            //string postData = "ListaCategoria=<ListaCategoria><CAB><compania>TEST003</compania><codigo_erp>001</codigo_erp><descripcion>GLORIA</descripcion>&origen=TEST003&token=kjsafhmJkhuIUHWQgvHJjbyBY56238g4gF2fh89ht5h6hHUYYFERRD4RrE91JnBVDrFDHljjsdpmnxhdjjd76jjaW91723HgTyTrQ509"; byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            //oRequest.ContentLength = byteArray.Length;
            //using (Stream dataStream = oRequest.GetRequestStream())
            //{
            //    using (StreamWriter stmw = new StreamWriter(dataStream))
            //    {
            //        stmw.Write(postData);
            //    }
            //    dataStream.Write(byteArray, 0, byteArray.Length);
            //}



            WebResponse oResponse = oRequest.GetResponse();
            using (var oSR = new StreamReader(oResponse.GetResponseStream()))
            {
                result = oSR.ReadToEnd().Trim();
            }

            return result;

        }


        public void GetPost2(string url)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            // Metodo modificado
            string postData = "ListaCategoria=<ListaCategoria><CAB><compania>TEST003</compania><codigo_erp>001</codigo_erp><descripcion>GLORIA</descripcion>&origen=TEST003&token=kjsafhmJkhuIUHWQgvHJjbyBY56238g4gF2fh89ht5h6hHUYYFERRD4RrE91JnBVDrFDHljjsdpmnxhdjjd76jjaW91723HgTyTrQ509"; byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;
            using (Stream dataStream = request.GetRequestStream())
            {
                using (StreamWriter stmw = new StreamWriter(dataStream))
                {
                    stmw.Write(postData);
                }
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string resp = reader.ReadToEnd();
            }
        }


        public void getpost3()
        {
            HttpWebRequest request = WebRequest.Create("http://test.geosales.cloud/monitoreoservicios/monitor/sdk/index.php/cargarCategoria") as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded"; //"application/json; charset=utf-8";
            request.Headers.Add("ListaCategoria", "<ListaCategoria><CAB><compania>TEST003</compania><codigo_erp>001</codigo_erp><descripcion>GLORIA</descripcion><activo>1</activo></CAB></ListaCategoria>");
            request.Headers.Add("origen", "TEST003");
            request.Headers.Add("token", "kjsafhmJkhuIUHWQgvHJjbyBY56238g4gF2fh89ht5h6hHUYYFERRD4RrE91JnBVDrFDHljjsdpmnxhdjjd76jjaW91723HgTyTrQ509");


            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string resp = reader.ReadToEnd();
        }


        //public static string makePostEncodedRequest(string url, string jsonparams)
        //{
        //    string ret = "";
        //    var httpwebrequest = (HttpWebRequest)WebRequest.Create(url);
        //    httpwebrequest.ContentType = "application/x-www-form-urlencoded";
        //    //httpwebrequest.Accept = Config.JsonHeaderAJ;
        //    httpwebrequest.Method = Methods.Post.ToString();

        //    byte[] bytearray = Encoding.UTF8.GetBytes(jsonparams);

        //    using (var streamWriter = new StreamWriter(httpwebrequest.GetRequestStream(), Encoding.ASCII))
        //    {
        //        streamWriter.Write(bytearray);
        //        streamWriter.Flush();
        //        streamWriter.Close();
        //    }

        //    var httpResponse = (HttpWebResponse)httpwebrequest.GetResponse();
        //    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        //    {
        //        ret = streamReader.ReadToEnd();
        //    }
        //    return ret;
        //}

        public static async Task<TResult> PostFormUrlEncoded<TResult>(string url, IEnumerable<KeyValuePair<string, string>> postData)
        {
            using (var httpClient = new HttpClient())
            {
                using (var content = new FormUrlEncodedContent(postData))
                {
                    content.Headers.Clear();
                    content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                    HttpResponseMessage response = await httpClient.PostAsync(url, content);

                    return await response.Content.ReadAsAsync<TResult>();
                }
            }
        }


        public class Response
        {
            public int Status { get; set; }

            public string Message { get; set; }

            public object Result { get; set; }
        }


        public class keyOrder
        {
            [JsonProperty("ListaCategoria")]
            public string ListaCategoria { get; set; }
            [JsonProperty("origen")]
            public string origen { get; set; }

            [JsonProperty("token")]
            public string token { get; set; }


        }



        public async void getpost4(string url_point)
        {

            //keyOrder key = new keyOrder();
            //key.ListaCategoria = "<ListaCategoria><CAB><compania>TEST003</compania><codigo_erp>001</codigo_erp><descripcion>GLORIA</descripcion><activo>1</activo></CAB></ListaCategoria>";
            //key.origen = "TEST003";
            //key.token = "kjsafhmJkhuIUHWQgvHJjbyBY56238g4gF2fh89ht5h6hHUYYFERRD4RrE91JnBVDrFDHljjsdpmnxhdjjd76jjaW91723HgTyTrQ509";

            //string json = "ListaCategoria:<ListaCategoria><CAB><compania>TEST003</compania><codigo_erp>001</codigo_erp><descripcion>GLORIA</descripcion><activo>1</activo></CAB></ListaCategoria>origen: TEST003token:kjsafhmJkhuIUHWQgvHJjbyBY56238g4gF2fh89ht5h6hHUYYFERRD4RrE91JnBVDrFDHljjsdpmnxhdjjd76jjaW91723HgTyTrQ509";

            //string json = "ListaCategoria:<ListaCategoria><CAB><compania>TEST003</compania><codigo_erp>001</codigo_erp><descripcion>GLORIA</descripcion><activo>1</activo></CAB></ListaCategoria>origen:TEST003token:kjsafhmJkhuIUHWQgvHJjbyBY56238g4gF2fh89ht5h6hHUYYFERRD4RrE91JnBVDrFDHljjsdpmnxhdjjd76jjaW91723HgTyTrQ509";
            ////request.ContentLength = byteArray.Length;

            string json = string.Format("ListaCategoria={0}&origen={1}&token={2}", "<ListaCategoria><CAB><compania>TEST003</compania><codigo_erp>614</codigo_erp><descripcion>GLORIA99</descripcion><activo>1</activo></CAB></ListaCategoria>", "TEST003", "kjsafhmJkhuIUHWQgvHJjbyBY56238g4gF2fh89ht5h6hHUYYFERRD4RrE91JnBVDrFDHljjsdpmnxhdjjd76jjaW91723HgTyTrQ509");


            Response res = new Response();

                var content = new StringContent(json, Encoding.UTF8, "application/x-www-form-urlencoded");

            using (var client = new HttpClient())
            {
                try
                {
                    var httpResponseMessage = client.PostAsync(url_point, content);
                    httpResponseMessage.Wait();

                    var Result = httpResponseMessage.Result;
                    var ResponseString = Result.Content.ReadAsStringAsync();
                    ResponseString.Wait();

                    res.Message = ResponseString.Result;
                    if (Result.IsSuccessStatusCode)
                    {
                        res.Status = 200;
                    }
                    else
                    {
                        res.Status = 0;
                    }
                    //res.CallApiTime = GetReadTime(stopWatch);
                }
                catch (OperationCanceledException ex)
                {
                    res.Status = 502;
                    res.Message = ex.Message;
                }
            }


        }



    }
}

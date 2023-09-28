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
using System.Windows.Forms;

namespace CapaCliente
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            getpost3();
        }
    }
}

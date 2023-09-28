using Common.Services;
using Servicios.Implementacion;
using Servicios.Interfaces.Linea;
using Servicios.Interfaces.SubEmpresa.Respuestas;
using Servicios.Interfaces.SubEmpresaXLinea.Peticiones;
using Servicios.Interfaces.SubEmpresaXLinea.Respuestas;
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
    public partial class FrmSubEmpresaXLinea : Form
    {

        string url;
        IApiService apiService = new ApiService();

        List<SubEmpresaRegistrado> nn = new List<SubEmpresaRegistrado>();

        List<RespSubEmpresaXLinea> listrespsubemp = new List<RespSubEmpresaXLinea>();

        List<RespSubEmpresaXLinea2> listrespsubemp2 = new List<RespSubEmpresaXLinea2>();

        int FLAG = 0;


        public FrmSubEmpresaXLinea()
        {
            InitializeComponent();
        }

        private void FrmSubEmpresaXLinea_Load(object sender, EventArgs e)
        {
            url = System.Configuration.ConfigurationManager.AppSettings["url"].ToString();

            CargarComboSubEmpresa();


            IGestorDeLinea gestdelinea = new GestorDeLinea();
            cbolinea.DataSource = gestdelinea.Listar();
            cbolinea.DisplayMember = "DESLINEA";
            cbolinea.ValueMember = "CODLINEA";

            BOTONES(true, false, true, true, true);
            bloquea(false);
        }


        void bloquea(Boolean estado)
        {
            cboSubEmpresa.Enabled = estado;
            panel1.Enabled = estado;
           

        }

        void BOTONES(bool NUEVO, bool GUARDAR, bool MODIFICAR, bool ELIMINAR, bool BUSCAR)
        {
            BTNNUEVO.Enabled = NUEVO;
            BTNGUARDAR.Enabled = GUARDAR;
            BTNMODIFICAR.Enabled = MODIFICAR;
            BTNELIMINAR.Enabled = ELIMINAR;

        }




        private async void CargarComboSubEmpresa()
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


                nn = (List<SubEmpresaRegistrado>)response.Result;

                if (nn != null)
                {
                    cboSubEmpresa.DataSource = nn;
                    cboSubEmpresa.DisplayMember = "Nombre";
                    cboSubEmpresa.ValueMember = "Id";
                }
            }

            //this.Products = this.Products.OrderBy(p => p.Name).ToList();

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await CreateProductAsync(product);
        }


        private async void ListaSubEmpresaxLinea(int Id)
        {

            var response = await this.apiService.GetListAsync<RespSubEmpresaXLinea>(
             url,
             "api",
             "/SubEmpresaXLinea/" +
             Id);

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }
            else
            {


                listrespsubemp = (List<RespSubEmpresaXLinea>)response.Result;

                if (listrespsubemp != null)
                {
                    dataGridView1.DataSource = listrespsubemp;
                   
                }
            }

            //this.Products = this.Products.OrderBy(p => p.Name).ToList();

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await CreateProductAsync(product);
        }


        private async void ExisteSubEmpresaxLinea(string codlinea, SubEmpXLineaNuevo subempxlinea)
        {

            var response = await this.apiService.GetListAsync<RespSubEmpresaXLinea2>(
             url,
             "api",
             "/SubEmpresaXLinea/GetExisteSubEmpresaXLinea/" +
             codlinea);

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }
            else
            {


                listrespsubemp2 = (List<RespSubEmpresaXLinea2>)response.Result;

                if (listrespsubemp2.Count > 0)
                {
                    //dataGridView1.DataSource = listrespsubemp;
                    MessageBox.Show("La linea ya pertene a una Sub Empresa ");
                }
                else
                {
                    crearSubEmpXLineaNuevo(subempxlinea);
                }
            }

            //this.Products = this.Products.OrderBy(p => p.Name).ToList();

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await CreateProductAsync(product);
        }





        private void button1_Click(object sender, EventArgs e)
        {

            SubEmpXLineaNuevo subempxlineanuevo = new SubEmpXLineaNuevo();
            subempxlineanuevo.SubEmpresaId =int.Parse( cboSubEmpresa.SelectedValue.ToString());
            subempxlineanuevo.LineaCodlinea = cbolinea.SelectedValue.ToString();

    
            if (chkGIDS.Checked == true)
            {
                subempxlineanuevo.GIDS = true;

            }
            else
            {
                subempxlineanuevo.GIDS = false;

            }


            ExisteSubEmpresaxLinea(cbolinea.SelectedValue.ToString(), subempxlineanuevo);

            

            //int id;
            //id = int.Parse(cboSubEmpresa.SelectedValue.ToString());
            //ListaSubEmpresaxLinea(id);
        }

        private async void crearSubEmpXLineaNuevo(SubEmpXLineaNuevo subempxlinea)
        {

            //var response = await client.DeleteAsync($"api/LineaCorre/{product.Id}");
            //var statusCode = await CreateProductAsync(product);

            var response = await this.apiService.PostAsync(
                url,
               "api",
               "/SubEmpresaXLinea",
               subempxlinea
               );

            //this.IsLoading = false;

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }
            else 
            {
                int id;
                id = int.Parse(cboSubEmpresa.SelectedValue.ToString());
                ListaSubEmpresaxLinea(id);
            }

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {


            int indice;
            indice = this.dataGridView1.CurrentRow.Index;
            //int Iddetalle;
            //Iddetalle = int.Parse(listrespsubemp[indice].Id.ToString());

            int Iddetalle;
            Iddetalle = int.Parse(dataGridView1.Rows[indice].Cells[0].Value.ToString());

            //MessageBox.Show(Iddetalle.ToString());
            DeleteSubEmpresaXLinea(Iddetalle);


           

        }

        private async void DeleteSubEmpresaXLinea(int Id)
        {


 
            var response = await this.apiService.DeleteAsync(
                url,
                "api",
                "/SubEmpresaXLinea",
                Id);

            //this.IsLoading = false;

            if (!response.IsSuccess)
            {
                //MessageBox.Show("Error", response.Message);
                MessageBox.Show("Error");
                return;
            }
            else 
            {
                int id;
                id = int.Parse(cboSubEmpresa.SelectedValue.ToString());
                ListaSubEmpresaxLinea(id);
            }

        }




        private void cboSubEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RespSubEmpresaXLinea respsubempxlineanuevo = new RespSubEmpresaXLinea();
            //respsubempxlineanuevo.Id = int.Parse(cboSubEmpresa.SelectedValue.ToString());

            if (FLAG == 1)
            {
                int id;
                id = int.Parse(cboSubEmpresa.SelectedValue.ToString());
                ListaSubEmpresaxLinea(id);

            }

        


        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, false);
            //Limpiar();
            bloquea(true);
            FLAG = 0;
            //txtCodSubEmpresa.Enabled = false;
        }

        private void cbolinea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            BOTONES(false, true, false, false, true);
            FLAG = 1;
            bloquea(true);

            if (FLAG == 1)
            {
                int id;
                id = int.Parse(cboSubEmpresa.SelectedValue.ToString());
                ListaSubEmpresaxLinea(id);

            }


        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            BOTONES(true, false, true, true, true);
            bloquea(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

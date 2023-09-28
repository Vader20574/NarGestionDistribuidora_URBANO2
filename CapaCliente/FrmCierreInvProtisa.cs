using LinqToExcel;
using Servicios.Implementacion;
using Servicios.Interfaces.Cierre_Inv_Gloria;
using Servicios.Interfaces.Cierre_Inv_Gloria.Peticiones;
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
    public partial class FrmCierreInvProtisa : Form
    {
        String ruta;
        List<Cierre_Inv_GloriaNuevo> resultado;


        public FrmCierreInvProtisa()
        {
            InitializeComponent();
        }

        private void btnsele_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName.ToString();
                txtruta.Text = ruta;

                var fichero = @ruta;
                resultado = ToEntidadHojaExcelList(fichero, "cierre_inventario_protisa");
                dataGridView1.DataSource = resultado;
            }
        }

        public List<Cierre_Inv_GloriaNuevo> ToEntidadHojaExcelList(string pathDelFicheroExcel, string hoja)
        {
            var book = new ExcelQueryFactory(pathDelFicheroExcel);
            var resultado = (from row in book.Worksheet(hoja)
                             let item = new Cierre_Inv_GloriaNuevo
                             {
                                 AÑO = row["AÑO"].Cast<string>(),
                                 MES = row["MES"].Cast<string>(),
                                 ARTICULO = row["ARTICULO"].Cast<string>(),
                                 STOCK = row["STOCK"].Cast<int>(),
                                 ALMACEN = row["ALMACEN"].Cast<string>(),
                                 FECHA = row["FECHA"].Cast<DateTime>()
                             }
                             select item).ToList();

            book.Dispose();
            return resultado;
        }



        private void btnProcesar_Click(object sender, EventArgs e)
        {
            IGestorDeCierre_Inv_Gloria gestorDeCierreInvProtisa= new GestorDeCierre_Inv_Protisa();

            gestorDeCierreInvProtisa.BorrarTodo();


            foreach (Cierre_Inv_GloriaNuevo lista in resultado)
            {
                gestorDeCierreInvProtisa.Registrar(lista);
            }

            MessageBox.Show("se guardo");
        }

        private void FrmCierreInvProtisa_Load(object sender, EventArgs e)
        {

        }
    }
}

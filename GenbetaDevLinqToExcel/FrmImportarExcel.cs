
using LinqToExcel;
using Servicios.Implementacion;
using Servicios.Interfaces.VentaxCobrar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenbetaDevLinqToExcel
{
    public partial class FrmImportarExcel : Form
    {
        String ruta;
        List<EntidadHojaExcel> resultado;

        public FrmImportarExcel()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

 
        public List<EntidadHojaExcel> ToEntidadHojaExcelList(string pathDelFicheroExcel, string hoja)
        {
            var book = new ExcelQueryFactory(pathDelFicheroExcel);
            var resultado = (from row in book.Worksheet(hoja)
                             let item = new EntidadHojaExcel
                             {
                                 CodCliente = row["CodCliente"].Cast<string>(),
                                 TipoDoc = row["TipoDoc"].Cast<string>(),
                                 NroDoc = row["NroDoc"].Cast<string>(),
                                 CodVend = row["CodVend"].Cast<string>()
                             }
                             select item).ToList();

            book.Dispose();
            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IGestorDeVentaxCobrar gestorDeVentaxCobrar = new GestorDeVentaxCobrar();
            foreach (EntidadHojaExcel lista in resultado)
            {
                gestorDeVentaxCobrar.ModificarCodVend(lista.TipoDoc.ToString(), System.Convert.ToDecimal(lista.NroDoc), lista.CodCliente.ToString(), lista.CodVend.ToString());
            }

            MessageBox.Show("se modificaron");
        }


        private void btnsele_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName.ToString();
                txtruta.Text = ruta;
             
    
                var fichero = @ruta;
                 resultado = ToEntidadHojaExcelList(fichero, "updateVentaxCobrar_imp");
                dataGridView1.DataSource = resultado;


            }
        }
    }
}

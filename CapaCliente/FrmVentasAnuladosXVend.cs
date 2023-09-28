using CapaCliente.Reportes;
using CapaDatafirst;
using Servicios.Implementacion;
using Servicios.Interfaces.Anulados;
using Servicios.Interfaces.HistoVentas;
using Servicios.Interfaces.TipoDoc;
using Servicios.Interfaces.TipoDoc.Respuestas;
using Servicios.Interfaces.Vendedor;
using Servicios.Interfaces.Vendedor.Respuestas;
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
    public partial class FrmVentasAnuladosXVend : Form
    {

        List<VendedorRegistrado> ListaV = new List<VendedorRegistrado>();
        List<VendedorRegistrado> ListaV2 = new List<VendedorRegistrado>();

        List<TipoDocRegistrado> ListaT = new List<TipoDocRegistrado>();
        List<TipoDocRegistrado> ListaT2 = new List<TipoDocRegistrado>();


        int i;

        DateTime fechaini;
        DateTime fechahas;
        int nromeses;

        public FrmVentasAnuladosXVend()
        {
            InitializeComponent();
        }
        private void Actualizar(Int16 a)
        {
            switch (a)
            {
                case 0:
                    break;
                //Me.lbfuerza1.DataSource = Nothing
                //Me.lbfuerza2.DataSource = Nothing
                //Me.lbfuerza1.DataSource = ListaF
                //Me.lbfuerza2.DataSource = ListaF2
                case 1:
                    this.lbvende1.DataSource = null;
                    this.lbvende2.DataSource = null;
                    this.lbvende1.DataSource = ListaV;
                    this.lbvende1.DisplayMember = "DSVEND";
                    this.lbvende2.DataSource = ListaV2;
                    this.lbvende2.DisplayMember = "DSVEND";
                    break;
                case 2:
                    this.lbtipodoc1.DataSource = null;
                    this.lbtipodoc2.DataSource = null;
                    this.lbtipodoc1.DataSource = ListaT;
                    this.lbtipodoc1.DisplayMember = "DSTIPODOC";
                    this.lbtipodoc2.DataSource = ListaT2;
                    this.lbtipodoc2.DisplayMember = "DSTIPODOC";
                    break;
            }

        }
        private void FrmVentasAnuladosXVend_Load(object sender, EventArgs e)
        {
            IGestorDeVendedor GestordeVend = new GestorDeVendedor();
            ListaV = GestordeVend.Listar();
            lbvende1.DataSource = ListaV;
            lbvende1.DisplayMember = "DSVEND";

            IGestorDeTipoDoc GestordeTipoDoc = new GestorDeTipoDoc();
            ListaT = GestordeTipoDoc.Listar();
            lbtipodoc1.DataSource = ListaT;
            lbtipodoc1.DisplayMember = "DSTIPODOC";

            

        }

        private void btnpasdet_Click(object sender, EventArgs e)
        {
            for (int k = 0; k <= ListaV.Count - 1; k++)
            {
                ListaV2.Add(ListaV[k]);
            }
            ListaV.Clear();
            Actualizar(1);
        }

        private void btnpasde_Click(object sender, EventArgs e)
        {
            i = this.lbvende1.SelectedIndex;
            if (i < 0)
                return;
            ListaV2.Add(ListaV[i]);
            ListaV.RemoveAt(i);
            Actualizar(1);
        }

        private void btnpassiz_Click(object sender, EventArgs e)
        {
            i = this.lbvende2.SelectedIndex;
            if (i < 0)
                return;
            ListaV.Add(ListaV2[i]);
            ListaV2.RemoveAt(i);
            Actualizar(1);
        }

        private void btnpassizt_Click(object sender, EventArgs e)
        {
            for (int k = 0; k <= ListaV2.Count - 1; k++)
            {
                ListaV.Add(ListaV2[k]);
            }
            ListaV2.Clear();
            Actualizar(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = this.lbtipodoc1.SelectedIndex;
            if (i < 0)
                return;
            ListaT2.Add(ListaT[i]);
            ListaT.RemoveAt(i);
            Actualizar(2);

           


        }

        private void btnpasdet2_Click(object sender, EventArgs e)
        {
            for (int k = 0; k <= ListaT.Count - 1; k++)
            {
                ListaT2.Add(ListaT[k]);
            }
            ListaT.Clear();
            Actualizar(2);
        }

        private void btnpassiz2_Click(object sender, EventArgs e)
        {
            i = this.lbtipodoc2.SelectedIndex;
            if (i < 0)
                return;
            ListaT.Add(ListaT2[i]);
            ListaT2.RemoveAt(i);
            Actualizar(2);
        }

        private void btnpassizt2_Click(object sender, EventArgs e)
        {
            for (int k = 0; k <= ListaT2.Count - 1; k++)
            {
                ListaT.Add(ListaT2[k]);
            }
            ListaT2.Clear();
            Actualizar(2);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //public void Up_Fechas()
        //{
        //    fechaini = this.dtpfechaD.Value.ToShortDateString();
        //    fechahas = this.dtpfechaH.Value.ToShortDateString();
        //    nromeses = DateTime.DateDiff("m", fechaini, fechahas);

        //    DateTime dt = DateTime.Parse(this.dtpfechaD.Value.ToShortDateString());
        //    DateTime dt1 = DateTime.Parse(this.dtpfechaH.Value.ToShortDateString());


        //    int daysDiff = ((month)(fechaini - fechahas)).m;

        //}

        public static decimal MonthDifference(DateTime FechaFin, DateTime FechaInicio)
        {
            return Math.Abs((FechaFin.Month - FechaInicio.Month) + 12 * (FechaFin.Year - FechaInicio.Year));

        }
        private void btnReporte_Click(object sender, EventArgs e)
        {


            Random rnd = new Random();
            // Obtiene un número natural (incluye el 0) aleatorio entre 0 e int.MaxValue
            int numerorand = rnd.Next();

            decimal nromeses;

            String cORRE;
            cORRE = Convert.ToString(numerorand);

            using (NARGESTEntities context = new NARGESTEntities())
            {
                context.SP_DELETE_TMP_VENDEDOR(cORRE);

                for (int a = 0; a <= this.ListaV2.Count - 1; a++)
                {
                    context.SP_INSERT_TMP_VENDEDOR(Int32.Parse(cORRE), ListaV2[a].CODVEND);
                }
            }

            string cadena = "";
            foreach (TipoDocRegistrado var in ListaT2)
            {
                if (cadena.Trim().Length == 0)
                    cadena = "'" + var.CODTIPODOC + "'";
                else
                    cadena = cadena + ",'" + var.CODTIPODOC + "'";
            }


            string NomTablaC;
            string NomTablaD;


            IGestorDeAnulados gestdeanul = new GestorDeAnulados();



            using (NARGESTEntities context = new NARGESTEntities())
            {
                DateTime f = this.dtpfechaD.Value;
                DateTime f2 = this.dtpfechaH.Value;

                String fECHAH = String.Format(f2.ToShortDateString(), "dd/mm/aaaa");

                fechaini = this.dtpfechaD.Value;
                fechahas = this.dtpfechaH.Value;

                nromeses = MonthDifference(fechaini, fechahas);


                string Day = "";
                string mes = "";
                string año = "";
                IGestorDeHistoVentas gesthistoventas = new GestorDeHistoVentas();


                context.SP_DELETE_TMP_RPT_REPOR_SUNA(cORRE);

                context.SP_DEL_TMP_DOC_ANULADOS(Int32.Parse(cORRE));
                context.SP_DEL_TMP_DATOSPROD(Int32.Parse(cORRE));
                context.SP_DEL_TMP_ARTIDEV(Int32.Parse(cORRE));



                for (int x = 0; x <= nromeses; x++)
                {

                    DateTime _date = new DateTime();
                    _date = fechaini.AddMonths(x);
                    var _dateString = _date.ToString("dd-MM-yyyy");
                    string[] Words = _dateString.Split(new char[] { '-' });

                    int count = 0;
                    foreach (string Word in Words)
                    {
                        count += 1;
                        if (count == 1) { Day = Word; }
                        if (count == 2) { mes = Word; }
                        if (count == 3) { año = Word; }
                    }
                    NomTablaC = "VENTC" + año + mes;
                    NomTablaD = "VENTD" + año + mes;


                    string venta;
                    venta = gesthistoventas.HistoVentas(NomTablaC, "01");
                    if (venta != null)
                    {
                        context.SP_INS_TMP_DOC_ANULADOS("01", f, f2, NomTablaD, 1, Int32.Parse(cORRE));
                        //context.CUR_TMP_DATOSPROD_HISTO("01", NomTablaD, 1, Int32.Parse(cORRE));
                        gestdeanul.cur_tmp_datosprod_histo("01", NomTablaD, 1, Int32.Parse(cORRE));
                    }
                }
                context.SP_INS_TMP_DOC_ANULADOS("01", f, f2, "", 0, Int32.Parse(cORRE));
                //context.CUR_TMP_DATOSPROD_HISTO("01", "VENTADET", 0, Int32.Parse(cORRE));
                gestdeanul.cur_tmp_datosprod_histo("01", "VENTADET", 0, Int32.Parse(cORRE));

                context.CUR_TMP_ARTIDEV_HISTO("01", "VENTADET", Int32.Parse(cORRE));
                context.CUR_TMP_ARTIDEV_HISTO2("01", Int32.Parse(cORRE));
                context.CUR_TMP_ARTIDEV_HISTO3("01", Int32.Parse(cORRE));
            }


            using (NARGESTEntities context = new NARGESTEntities())
            {
                DateTime f = this.dtpfechaD.Value;
                DateTime f2 = this.dtpfechaH.Value;

                String fECHAH = String.Format(f2.ToShortDateString(), "dd/mm/aaaa");

                fechaini = this.dtpfechaD.Value;
                fechahas = this.dtpfechaH.Value;

                nromeses = MonthDifference(fechaini, fechahas);


                string Day = "";
                string mes = "";
                string año = "";
                IGestorDeHistoVentas gesthistoventas = new GestorDeHistoVentas();


                context.SP_DELETE_TMP_RPT_REPOR_SUNA(cORRE);

                for (int x = 0; x <= nromeses; x++)
                {

                    DateTime _date = new DateTime();
                    _date = fechaini.AddMonths(x);
                    var _dateString = _date.ToString("dd-MM-yyyy");
                    string[] Words = _dateString.Split(new char[] { '-' });

                    int count = 0;
                    foreach (string Word in Words)
                    {
                        count += 1;
                        if (count == 1) { Day = Word; }
                        if (count == 2) { mes = Word; }
                        if (count == 3) { año = Word; }
                    }
                    NomTablaC = "VENTC" + año + mes;
                    NomTablaD = "VENTD" + año + mes;


                    string venta;
                    venta = gesthistoventas.HistoVentas(NomTablaC, "01");
                    if (venta != null)
                    {
                        context.SP_RPT_VTA_SUNA_ANUL("01", f, f2, cadena, Convert.ToInt32(cORRE), NomTablaC, NomTablaD);
                    }
                }
                context.SP_RPT_VTA_SUNA_ANUL("01", f, f2, cadena, Convert.ToInt32(cORRE), "VENTACAB", "VENTADET");

            }



            FrmRpt_Venta_Anulados frmreporteventasdetalle = new FrmRpt_Venta_Anulados(Int32.Parse(cORRE));
            frmreporteventasdetalle.ShowDialog();


        }


    }
}

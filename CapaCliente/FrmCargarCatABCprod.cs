using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace CapaCliente
{
    public partial class FrmCargarCatABCprod : Form
    {

        String ruta;
        DataSet ds = new DataSet();

        public FrmCargarCatABCprod()
        {
            InitializeComponent();
        }

        private void btnsele_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ds = new DataSet();

                ruta = openFileDialog1.FileName.ToString();
                txtruta.Text = ruta;

                string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + txtruta.Text.ToString() + " ;Extended Properties=\"Excel 8.0; HDR=Yes\"";

                OleDbConnection origen = default(OleDbConnection);
                origen = new OleDbConnection(conexion);

                OleDbCommand seleccion = default(OleDbCommand);
                seleccion = new OleDbCommand("Select * From [Hoja1$]", origen);

                OleDbDataAdapter adaptador = new OleDbDataAdapter();
                adaptador.SelectCommand = seleccion;

                adaptador.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                origen.Close();
            }
        }

        private void FrmCargarCatABCprod_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["Distribucion"].ConnectionString;
            SqlConnection conexion_destino = new SqlConnection();
            conexion_destino.ConnectionString = connection;

            SqlCommand command = new SqlCommand("Delete from TABLA_CAT_ABC", conexion_destino);
            command.Connection.Open();
            command.CommandTimeout = 7200;
            command.ExecuteNonQuery();
            command.Connection.Close();


            conexion_destino.Open();
            SqlBulkCopy importar = default(SqlBulkCopy);
            importar = new SqlBulkCopy(conexion_destino);
            importar.DestinationTableName = "TABLA_CAT_ABC";
            importar.WriteToServer(ds.Tables[0]);
            conexion_destino.Close();


            SqlCommand cmd = new SqlCommand("CUR_UPD_ART_CAT_ABC  ", conexion_destino);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion_destino.Open();
            cmd.CommandTimeout = 7200;
            cmd.ExecuteNonQuery();
            conexion_destino.Close();

            MessageBox.Show("- Se cargo con Exito");


        }
    }
}

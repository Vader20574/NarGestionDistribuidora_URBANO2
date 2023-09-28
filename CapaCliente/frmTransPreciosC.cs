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
    public partial class frmTransPreciosC : Form
    {

        String ruta;
        DataSet ds = new DataSet();
        public frmTransPreciosC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["Distribucion"].ConnectionString;
            SqlConnection conexion_destino = new SqlConnection();
            conexion_destino.ConnectionString = connection;

            SqlCommand command = new SqlCommand("Delete from Tabla_Precios", conexion_destino);
            command.Connection.Open();
            command.CommandTimeout = 7200;
            command.ExecuteNonQuery();
            command.Connection.Close();


            conexion_destino.Open();
            SqlBulkCopy importar = default(SqlBulkCopy);
            importar = new SqlBulkCopy(conexion_destino);
            importar.DestinationTableName = "Tabla_Precios";
            importar.WriteToServer(ds.Tables[0]);
            conexion_destino.Close();


            SqlCommand cmd = new SqlCommand("CUR_UPD_PRECIART  ", conexion_destino);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion_destino.Open();
            cmd.CommandTimeout = 7200;
            cmd.ExecuteNonQuery();
            conexion_destino.Close();

            MessageBox.Show("- Los Precios se Importaron con Exito");


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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

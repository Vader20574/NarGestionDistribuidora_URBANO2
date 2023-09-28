using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentacion.Wpf
{
    /// <summary>
    /// Lógica de interacción para ImportarInv.xaml
    /// </summary>
    public partial class ClienteUpdEstado : Window
    {

        DataSet ds = new DataSet();
        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public ClienteUpdEstado()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Excel Files |*.xls;*xlsx;*xlsm";
            of.Title = "Importar Datos";

            if (of.ShowDialog() == true)
            {
                //llamamos metodo ImportarArchivoExcel
                txtRuta.Text = of.FileName;
                dgvDatos.ItemsSource = ImportarArchivoExcel(of.FileName);

            }
        }


        DataView ImportarArchivoExcel(string ruta)
        {
            string conexion = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties = 'Excel 12.0 Macro;HDR=YES'; ", ruta);

            OleDbConnection origen = default(OleDbConnection);
            origen = new OleDbConnection(conexion);

            OleDbCommand seleccion = default(OleDbCommand);
            seleccion = new OleDbCommand("Select * From [Hoja1$]", origen);

            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = seleccion;

            ds = new DataSet();

            adaptador.Fill(ds);

            origen.Close();

            return ds.Tables[0].DefaultView;
        }

        private void btnMigrar_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conexion_destino = new SqlConnection();
            conexion_destino.ConnectionString = connection;

            SqlCommand command = new SqlCommand("Delete from dbo.ClienteX", conexion_destino);
            command.Connection.Open();
            command.CommandTimeout = 7200;
            command.ExecuteNonQuery();
            command.Connection.Close();


            conexion_destino.Open();
            SqlBulkCopy importar = default(SqlBulkCopy);
            importar = new SqlBulkCopy(conexion_destino);
            importar.DestinationTableName = "ClienteX";
            importar.WriteToServer(ds.Tables[0]);
            conexion_destino.Close();


            SqlCommand cmd = new SqlCommand("CUR_UPD_CLIENTE_ESTADO  ", conexion_destino);
          
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@CODEMPRESA", "01"));
            conexion_destino.Open();
            cmd.CommandTimeout = 7200;
            cmd.ExecuteNonQuery();
            conexion_destino.Close();

            MessageBox.Show("El Cambio fue con Exito");

        }
    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentacion.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataSet ds = new DataSet();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, RoutedEventArgs e)
        {
           
        }


   

        private void btnMigrar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

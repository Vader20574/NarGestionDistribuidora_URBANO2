using Infraestructura.Transformations;
using PresentacionNetFra.WPF.ViewModels;
using System;
using System.Collections.Generic;
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

namespace PresentacionNetFra.WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MantenimientoEquipoVM mantenimientoDeEquipoVm = new MantenimientoEquipoVM();


        public MainWindow()
        {
            InitializeComponent();
            MapperManager.Initialize();
            mantenimientoDeEquipoVm.CargarEquipo();
            this.DataContext = mantenimientoDeEquipoVm;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.mantenimientoDeEquipoVm.GrabarProducto();
        }
    }
}

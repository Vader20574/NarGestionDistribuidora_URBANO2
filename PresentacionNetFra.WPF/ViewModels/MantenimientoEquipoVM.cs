using Servicios.Implementacion;
using Servicios.Interfaces.Equipo;
using Servicios.Interfaces.Equipo.Peticiones;
using Servicios.Interfaces.Equipo.Respuestas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionNetFra.WPF.ViewModels
{
    public class MantenimientoEquipoVM : INotifyPropertyChanged
    {

        private EquipoNuevo _nuevoEquipo = new EquipoNuevo();
        public EquipoNuevo nuevoEquipo
        {
            get { return _nuevoEquipo; }
            set
            {
                this._nuevoEquipo = value;
                this.OnPropertyChanged("nuevoEquipo");
            }
        }

        public void GrabarProducto()
        {
            EquipoRegistrado nuevoProductoRegistrado = this.gestorDeVenta.Registrar(this.nuevoEquipo);
            this.equiposResgistrados.Add(nuevoProductoRegistrado);
            this.nuevoEquipo = new EquipoNuevo();
        }




        IGestorDeEquipo gestorDeVenta = new GestorDeEquipo();
        public ObservableCollection<EquipoRegistrado> equiposResgistrados { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


        public void CargarEquipo()
        {
            var equipos = gestorDeVenta.Listar();
            this.equiposResgistrados = new ObservableCollection<EquipoRegistrado>(equipos);
        }

    }
}

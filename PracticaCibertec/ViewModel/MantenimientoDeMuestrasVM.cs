using GestionDeLasMuestras;
using InterfacesMuestrasLaboratorio.Muestras;
using InterfacesMuestrasLaboratorio.Muestras.Peticiones;
using InterfacesMuestrasLaboratorio.Muestras.Respuestas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCibertec.ViewModel
{
    public class MantenimientoDeMuestrasVM
    {
        private NuevaMuestra _nuevaMuestra = new NuevaMuestra();
        public NuevaMuestra nuevaMuestra
        {
            get { return _nuevaMuestra; }
            set
            {
                this._nuevaMuestra = value;
                this.OnPropertyChanged("nuevaMuestra");
            }
        }

        public void GrabarMuestras()
        {
            MuestraRegistrada nuevaMuestraRegistrada = this._gestorDeMuestras.CrearMuestra(this.nuevaMuestra);
            this.muestraRegistrada.Add(nuevaMuestraRegistrada);
            this.nuevaMuestra = new NuevaMuestra();
        }

        public ObservableCollection<MuestraRegistrada> muestraRegistrada { get; set; }
        private IGestorDeMuestras _gestorDeMuestras = new GestorDeMuestras();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public void CargarProductos()
        {
            this.muestraRegistrada = new ObservableCollection<MuestraRegistrada>();
            _gestorDeMuestras.ListarTodasLasMuestras().ForEach(x => this.muestraRegistrada.Add(x));
        }
    }
}

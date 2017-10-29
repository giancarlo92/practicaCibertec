using GestionDeLasMuestras;
using InterfacesMuestrasLaboratorio.Muestras;
using InterfacesMuestrasLaboratorio.Muestras.Peticiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaDePruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            IGestorDeMuestras gestorDeMuestras = new GestorDeMuestras();
            NuevaMuestra nuevaMuestra = new NuevaMuestra();
            nuevaMuestra.NombreDeLaPersonaMuestrada = "Jose Fernandez";
            nuevaMuestra.FechaDeLaToma = DateTime.Now;
            nuevaMuestra.NombreDeLaPersonaQueTomaLaMuestra = "Pedro Navaja";
            gestorDeMuestras.CrearMuestra(nuevaMuestra);
        }
    }
}

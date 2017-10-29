using MuestraLaboratorio.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuestraLaboratorio.Modelos
{
    public class Muestras : EntidadBase
    {
        public string NombreDeLaPersonaMuestrada { get; set; }
        public DateTime FechaDeLaToma { get; set; }
        public string NombreDeLaPersonaQueTomaLaMuestra { get; set; }
    }
}

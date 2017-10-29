using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesMuestrasLaboratorio.Muestras.Respuestas
{
    public class MuestraRegistrada
    {
        public int Id { get; set; }
        public string NombreDeLaPersonaMuestrada { get; set; }
        public DateTime FechaDeLaToma { get; set; }
        public string NombreDeLaPersonaQueTomaLaMuestra { get; set; }
    }
}

using InterfacesMuestrasLaboratorio.Muestras.Peticiones;
using InterfacesMuestrasLaboratorio.Muestras.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesMuestrasLaboratorio.Muestras
{
    public interface IGestorDeMuestras
    {
        MuestraRegistrada CrearMuestra(NuevaMuestra nuevaMuestra);
        List<MuestraRegistrada> ListarTodasLasMuestras();
        MuestraRegistrada ActualizarMuestra(MuestraActualizada muestraActualizada);
        bool BorrarMuestra(int idDeLaMuestra);
    }
}

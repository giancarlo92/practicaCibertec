using InterfacesMuestrasLaboratorio.Muestras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesMuestrasLaboratorio.Muestras.Peticiones;
using InterfacesMuestrasLaboratorio.Muestras.Respuestas;
using MuestraLaboratorio.Contextos;
using MuestraLaboratorio.Modelos;

namespace GestionDeLasMuestras
{
    public class GestorDeMuestras : IGestorDeMuestras
    {
        public MuestraRegistrada ActualizarMuestra(MuestraActualizada muestraActualizada)
        {
            using (Laboratorio laboratorio = new Laboratorio())
            {
                Muestras muestra = laboratorio.Muestras.Find(muestraActualizada.Id);
                muestra.Id = muestraActualizada.Id;
                muestra.NombreDeLaPersonaMuestrada = muestraActualizada.NombreDeLaPersonaMuestrada;
                muestra.FechaDeLaToma = muestraActualizada.FechaDeLaToma;
                muestra.NombreDeLaPersonaQueTomaLaMuestra = muestraActualizada.NombreDeLaPersonaQueTomaLaMuestra;
                return ConvertirMuestrasA_DTO(muestra);
            }
        }

        private MuestraRegistrada ConvertirMuestrasA_DTO(Muestras muestra)
        {
            MuestraRegistrada muestraRegistrada = new MuestraRegistrada();
            muestraRegistrada.Id = muestra.Id;
            muestraRegistrada.NombreDeLaPersonaMuestrada = muestra.NombreDeLaPersonaMuestrada;
            muestraRegistrada.FechaDeLaToma = muestra.FechaDeLaToma;
            muestraRegistrada.NombreDeLaPersonaQueTomaLaMuestra = muestra.NombreDeLaPersonaQueTomaLaMuestra;
            return muestraRegistrada;
        }

        public bool BorrarMuestra(int idDeLaMuestra)
        {
            throw new NotImplementedException();
        }

        public MuestraRegistrada CrearMuestra(NuevaMuestra nuevaMuestra)
        {
            using (Laboratorio labotorio = new Laboratorio())
            {
                Muestras muestra = new Muestras();
                muestra.NombreDeLaPersonaMuestrada = nuevaMuestra.NombreDeLaPersonaMuestrada;
                muestra.FechaDeLaToma = nuevaMuestra.FechaDeLaToma;
                muestra.NombreDeLaPersonaQueTomaLaMuestra = nuevaMuestra.NombreDeLaPersonaQueTomaLaMuestra;
                labotorio.Muestras.Add(muestra);
                labotorio.SaveChanges();
                return ConvertirMuestrasA_DTO(muestra);
            }
        }

        public List<MuestraRegistrada> ListarTodasLasMuestras()
        {
            using (Laboratorio laboratorio = new Laboratorio())
            {
                return laboratorio.Muestras.ToList().Select(x => ConvertirMuestrasA_DTO(x)).ToList();
            }
        }
    }
}

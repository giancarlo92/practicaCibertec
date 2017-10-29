using MuestraLaboratorio.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuestraLaboratorio.Contextos
{
    public class Laboratorio : DbContext
    {
        public DbSet<Muestras> Muestras { get; set; }
        public Laboratorio() : base("BaseDeDatosDelLaboratorio")
        {
        }
    }
}

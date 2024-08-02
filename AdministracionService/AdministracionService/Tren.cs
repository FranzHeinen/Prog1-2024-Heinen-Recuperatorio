using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionService
{
    public class Tren
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public EnumCiudadInicio CiudadInicio { get; set; } 
        public EnumCiudadFin CiudadFin { get; set; }
        public int Capacidad { get; set; }
    }
}

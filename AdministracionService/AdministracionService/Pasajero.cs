using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionService
{
    public abstract class Pasajero
    {
        public int Dni { get; set; }
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public virtual string ObtenerDetalle()
        {
            return $"{Nombre}-{Edad}";
        }
    }
}

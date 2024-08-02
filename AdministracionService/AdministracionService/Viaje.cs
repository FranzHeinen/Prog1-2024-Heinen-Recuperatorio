using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionService
{
    public class Viaje
    {
        public int Codigo { get; set; }
        public int TrenViaje { get; set; }
        public DateTime FechaHora { get; set; }
        public int Demora { get; set; }
        public List<Pasajero>PasajerosViajes { get; set; }  = new List<Pasajero>();
        public double ImporteBoleto { get; set; }
        public double TotalViaje { get; set; }
        public void TotalViajes(double importe)
        {
            TotalViaje += ImporteBoleto;
        }
    }
}

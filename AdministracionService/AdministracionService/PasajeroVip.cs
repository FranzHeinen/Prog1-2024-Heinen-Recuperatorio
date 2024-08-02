using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionService
{
    public class PasajeroVip : Pasajero
    {
        public List<string> CiudadesFavoritas { get; set; }
        public EnumNivelUsuario NivelUsuario { get; set; }
        public override string ObtenerDetalle()
        {
            return base.ObtenerDetalle() + $"{CiudadesFavoritas[1]}";
        }
        public double CalcularDescuentoPasajeroVip()
        {
            double descuento = 0;

            if(NivelUsuario == EnumNivelUsuario.Uno)
            {
                descuento = 0.12;
            }else if (NivelUsuario == EnumNivelUsuario.Dos)
            {
                descuento = 0.15;
            }
            else
            {
                descuento = 0.17;
            }

            return descuento;
        }
    }
}

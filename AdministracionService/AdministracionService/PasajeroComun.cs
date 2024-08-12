using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionService
{
    public class PasajeroComun : Pasajero
    {
        //CORRECCION: ESTO DEBE SER UN METODO EN LA CLASE BASE QUE SE SOBREESCRIBQA
        public double CalcularDescuentoPasajeroComun()
        {
            double descuento = 0;

            if (Edad < 12)
            {
                descuento = 0.10;
            }

            return descuento;
        }
        public override string ObtenerDetalle()
        {
            return base.ObtenerDetalle();
        }
    }
}

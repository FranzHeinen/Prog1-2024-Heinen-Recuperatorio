namespace AdministracionService
{
    public class Logica
    {
        public List<Viaje>Viajes { get; set; } = new List<Viaje>();
        public List<Pasajero>Pasajeros { get; set; } = new List<Pasajero>();
        public List<Tren> Trenes { get; set; } = new List<Tren>();

        public void AgregarViaje(int codTren, DateTime fechaSalida, int demora, double importe)
        {
            Viaje viaje = new Viaje();
            viaje.Codigo = Viajes.Count() + 1;
            viaje.TrenViaje = codTren;
            viaje.Demora = demora;
            viaje.FechaHora = fechaSalida;
            viaje.ImporteBoleto = importe;
            Viajes.Add(viaje);
        }
        public void AgregarPasajeroComun(PasajeroComun pasajeroComun)
        {
            Viaje viaje = new Viaje();

            viaje.PasajerosViajes.Add(pasajeroComun);

            double descuento = pasajeroComun.CalcularDescuentoPasajeroComun();

            viaje.ImporteBoleto -= (descuento * viaje.ImporteBoleto);

            viaje.TotalViajes(viaje.ImporteBoleto);

            Pasajeros.Add(pasajeroComun);
        }
        public void AgregarPasajeroVip(PasajeroVip pasajeroVip)
        {
            Viaje viaje = new Viaje();

            viaje.PasajerosViajes.Add(pasajeroVip);

            double descuento = pasajeroVip.CalcularDescuentoPasajeroVip();

            viaje.ImporteBoleto -= (descuento * viaje.ImporteBoleto);

            viaje.TotalViajes(viaje.ImporteBoleto);

            Pasajeros.Add(pasajeroVip);
        }
        public List<Viaje> ViajesProgramados(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Viaje>ViajesProgramados = new List<Viaje>();
            
            ViajesProgramados = Viajes.FindAll(x => x.FechaHora > fechaInicio && x.FechaHora < fechaFin).ToList();

            return ViajesProgramados;
        }
    }
}

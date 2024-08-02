using AdministracionService;

namespace AdministracionServiceTest
{
    public class LogicaTest
    {
        Logica logica;
        [SetUp]
        public void Setup()
        {
            logica = new Logica();
        }

        [Test]
        public void AgregarViaje()
        {
            logica.AgregarViaje(1, DateTime.Now, 10, 100);

            Assert.That(logica.Viajes.Count(), Is.EqualTo(1));
            Assert.That(logica.Viajes[0].Demora, Is.EqualTo(10));
        }
        [Test]
        public void AgregarPasajeroComun()
        {
            PasajeroComun pasajero1 = new PasajeroComun();
            pasajero1.Nombre = "Franz";
            pasajero1.FechaNacimiento = DateTime.Now;
            pasajero1.Dni = 44022780;
            pasajero1.Edad = 10;

            logica.AgregarPasajeroComun(pasajero1);

            Assert.That(logica.Pasajeros.Count(), Is.EqualTo(1));
        }
        [Test]
        public void AgregarPasajeroVip()
        {
            PasajeroVip pasajero1 = new PasajeroVip();
            pasajero1.Nombre = "Franz";
            pasajero1.FechaNacimiento = DateTime.Now;
            pasajero1.Dni = 44022780;
            pasajero1.Edad = 10;

            logica.AgregarPasajeroVip(pasajero1);

            Assert.That(logica.Pasajeros.Count(), Is.EqualTo(1));
        }
        [Test]
        public void CalcularDescuentoVip()
        {
            PasajeroVip pasajero1 = new PasajeroVip();
            pasajero1.Nombre = "Franz";
            pasajero1.FechaNacimiento = DateTime.Now;
            pasajero1.Dni = 44022780;
            pasajero1.Edad = 10;
            pasajero1.NivelUsuario = EnumNivelUsuario.Dos;

            logica.AgregarPasajeroVip(pasajero1);

            double descuento = pasajero1.CalcularDescuentoPasajeroVip();

            Assert.That(descuento, Is.EqualTo(0.15));
        }
        [Test]
        public void CalcularDescuentoComun()
        {
            PasajeroComun pasajero1 = new PasajeroComun();
            pasajero1.Nombre = "Franz";
            pasajero1.FechaNacimiento = DateTime.Now;
            pasajero1.Dni = 44022780;
            pasajero1.Edad = 10;

            logica.AgregarPasajeroComun(pasajero1);

            double descuento = pasajero1.CalcularDescuentoPasajeroComun();

            Assert.That(descuento, Is.EqualTo(0.10));
        }
        [Test]
        public void ObtenerViajesProgramados()
        {
            Viaje viaje = new Viaje();
            logica.AgregarViaje(1, DateTime.Now, 10, 100);

            Viaje viaje1 = new Viaje();
            logica.AgregarViaje(1, DateTime.Now, 10, 100);

            var list = logica.ViajesProgramados(DateTime.MinValue, DateTime.MaxValue);

            Assert.That(list.Count, Is.EqualTo(2));
        }
        [Test]
        public void ObtenerDescripcion()
        {
            PasajeroComun pasajero1 = new PasajeroComun();
            pasajero1.Nombre = "Franz";
            pasajero1.FechaNacimiento = DateTime.Now;
            pasajero1.Dni = 44022780;
            pasajero1.Edad = 10;

            logica.AgregarPasajeroComun(pasajero1);

            var descripcion = pasajero1.ObtenerDetalle();

            Assert.That(descripcion, Is.EqualTo("Franz-10"));
        }
    }
}
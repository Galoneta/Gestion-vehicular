using System;

namespace GestionVehicular.App.Clases
{
    public class Camion : Vehiculo
    {
        public Camion(string marca, string modelo, double velocidadInicial = 0)
            : base(marca, modelo, velocidadInicial) { }

        public override void Acelerar()
        {
            CambiarVelocidad(+6);
        }

        public override void Frenar()
        {
            CambiarVelocidad(-12);
        }
    }
}
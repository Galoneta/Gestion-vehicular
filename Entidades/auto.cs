using System;

namespace GestionVehicular.App.Clases
{
    public class Auto : Vehiculo
    {
        public Auto(string marca, string modelo, double velocidadInicial = 0)
            : base(marca, modelo, velocidadInicial) { }

        public override void Acelerar()
        {
            CambiarVelocidad(+10);
        }

        public override void Frenar()
        {
            CambiarVelocidad(-7);
        }
    }
}
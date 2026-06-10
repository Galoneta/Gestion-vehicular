using System;

namespace GestionVehicular.App.Clases
{
    public class Moto : Vehiculo
    {
        public Moto(string marca, string modelo, double velocidadInicial = 0)
            : base(marca, modelo, velocidadInicial) { }

        public override void Acelerar()
        {
          
            CambiarVelocidad(+15);
        }

        public override void Frenar()
        {
            
            CambiarVelocidad(-10);
        }
    }
}
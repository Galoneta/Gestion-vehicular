using System;

namespace GestionVehicular.App.Clases
{
    public abstract class Vehiculo
    {
        public string Marca { get; }
        public string Modelo { get; }
        public double Velocidad { get; private set; }

        protected Vehiculo(string marca, string modelo, double velocidadInicial = 0)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidad = Math.Max(0, velocidadInicial);
        }

        protected void CambiarVelocidad(double delta)
        {
            Velocidad = Math.Max(0, Velocidad + delta);
        }

        public abstract void Acelerar();
        public abstract void Frenar();
        public void MostrarInformacion()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"{GetType().Name}: {Marca} {Modelo} - Velocidad: {Velocidad} km/h";
        }
    }
}
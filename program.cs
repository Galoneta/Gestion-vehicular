using System;
using System.Collections.Generic;
using GestionVehicular.App.Clases;

class Program
{
    static void Main()
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        int opcion;

        do
        {
            Console.WriteLine(" Gestión Vehicular ");
            Console.WriteLine("1- Registrar Vehiculo");
            Console.WriteLine("2- Mostrar Informacion de los vehiculos.");
            Console.WriteLine("3- Acciones de vehiculos.");
            Console.WriteLine("0- Salir");
            Console.Write("Opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("1- Auto.");
                    Console.WriteLine("2- Moto.");
                    Console.WriteLine("3- Camion.");
                    Console.Write("Tipo: ");
                    if (!int.TryParse(Console.ReadLine(), out int tipo))
                    {
                        Console.WriteLine("Tipo inválido.");
                        break;
                    }

                    Console.Write("Ingrese la marca del vehiculo: ");
                    string marca = Console.ReadLine() ?? "";

                    Console.Write("Ingrese el modelo del vehiculo: ");
                    string modelo = Console.ReadLine() ?? "";

                    Console.Write("Ingrese la velocidad inicial del vehiculo: ");
                    if (!double.TryParse(Console.ReadLine(), out double velocidadInicial))
                        velocidadInicial = 0;

                    switch (tipo)
                    {
                        case 1:
                            vehiculos.Add(new Auto(marca, modelo, velocidadInicial));
                            break;
                        case 2:
                            vehiculos.Add(new Moto(marca, modelo, velocidadInicial));
                            break;
                        case 3:
                            vehiculos.Add(new Camion(marca, modelo, velocidadInicial));
                            break;
                        default:
                            Console.WriteLine("Tipo no reconocido.");
                            break;
                    }
                    break;

                case 2:
                    if (vehiculos.Count == 0)
                    {
                        Console.WriteLine("Debe ingresar vehiculos para mostrar.");
                        break;
                    }
                    Console.WriteLine("Vehiculos...");
                    foreach (var v in vehiculos)
                        v.MostrarInformacion();
                    break;

                case 3:
                    if (vehiculos.Count == 0)
                    {
                        Console.WriteLine("No hay vehículos registrados.");
                        break;
                    }

                    foreach (var vehiculo in vehiculos)
                    {
                        Console.WriteLine($"Vehiculo: {vehiculo.Marca} {vehiculo.Modelo}");
                        Console.WriteLine($"Velocidad actual: {vehiculo.Velocidad} km/h");

                        Console.WriteLine("Acelerando...");
                        vehiculo.Acelerar();
                        Console.WriteLine($"Velocidad actual: {vehiculo.Velocidad} km/h");

                        Console.WriteLine("Frenando...");
                        vehiculo.Frenar();
                        Console.WriteLine($"Velocidad actual: {vehiculo.Velocidad} km/h");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}

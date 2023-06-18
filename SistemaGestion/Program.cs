using System;

namespace SistemaGestion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TeslaModelX teslaModelX = new TeslaModelX()
            {
                Año = 2022,
                UnidadDeUso = 10000,
                Color = "Rojo",
                Dueño = "Juan",
                Autonomia = 560,
                Asientos = 7,
                Service = 1000
            };

            TeslaModelS teslaModelS = new TeslaModelS()
            {
                Año = 2021,
                UnidadDeUso = 5000,
                Color = "Negro",
                Dueño = "María",
                Autonomia = 650,
                Asientos = 5,
                Service = 2000
            };

            Cybertruck cybertruck = new Cybertruck()
            {
                Año = 2023,
                UnidadDeUso = 2000,
                Color = "Plateado",
                Dueño = "Pedro",
                Autonomia = 800,
                Asientos = 6,
                Service = 3000
            };

            SpaceXStarship starship = new SpaceXStarship()
            {
                Año = 2022,
                UnidadDeUso = 300,
                Color = "Blanco",
                Dueño = "SpaceX",
                Autonomia = 500,
                Service = 1000
            };

            Falcon9 falcon9 = new Falcon9()
            {
                Año = 2021,
                UnidadDeUso = 100,
                Color = "Gris",
                Dueño = "SpaceX",
                Autonomia = 200,
                Service = 400
            };

            Console.WriteLine(teslaModelX.ObtenerInformacion());
            
            Console.WriteLine();
            Console.WriteLine(teslaModelS.ObtenerInformacion());
            Console.WriteLine();
            Console.WriteLine(cybertruck.ObtenerInformacion());
            Console.WriteLine();
            Console.WriteLine(starship.ObtenerInformacion());
            Console.WriteLine();
            Console.WriteLine(falcon9.ObtenerInformacion());

            Console.ReadLine();
        }
    }
}
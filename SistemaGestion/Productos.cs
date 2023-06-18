using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion
{
    public abstract class Producto
    {
        public int Año { get; set; }
        public int UnidadDeUso { get; set; }
        public string? Color { get; set; }
        public string? Dueño { get; set; }
        public int Autonomia { get; set; }
        public int Service { get; set; }

        public abstract string ObtenerInformacion();
    }

    public class TeslaModelX : Producto
    {
        public TeslaModelX()
        {
            UnidadDeUso = 560;
            Autonomia = 560;
            Service = 1000;
        }

        public int Asientos { get; set; } = 7;

        public override string ObtenerInformacion()
        {
            return $"Modelo: Tesla Model X\nAño: {Año}\nUnidad de Uso: {UnidadDeUso} km\nColor: {Color}\nDueño: {Dueño}\nAsientos: {Asientos}\nAutonomia: {Autonomia} km\nService: cada {Service} km";
        }
    }

    public class TeslaModelS : Producto
    {
        public TeslaModelS()
        {
            UnidadDeUso = 650;
            Autonomia = 650;
            Service = 2000;
        }

        public int Asientos { get; set; } = 5;

        public override string ObtenerInformacion()
        {
            return $"Modelo: Tesla Model S\nAño: {Año}\nUnidad de Uso: {UnidadDeUso} km\nColor: {Color}\nDueño: {Dueño}\nAsientos: {Asientos}\nAutonomia: {Autonomia} km\nService: cada {Service} km";
        }
    }

    public class Cybertruck : Producto
    {
        public Cybertruck()
        {
            UnidadDeUso = 800;
            Autonomia = 800;
            Service = 3000;
        }

        public int Asientos { get; set; } = 6;

        public override string ObtenerInformacion()
        {
            return $"Modelo: Cybertruck\nAño: {Año}\nUnidad de Uso: {UnidadDeUso} km\nColor: {Color}\nDueño: {Dueño}\nAsientos: {Asientos}\nAutonomia: {Autonomia} km\nService: cada {Service} km";
        }
    }

    public class SpaceXStarship : Producto
    {
        public SpaceXStarship()
        {
            UnidadDeUso = 500;
            Autonomia = 500;
            Service = 1000;
        }

        public override string ObtenerInformacion()
        {
            return $"Modelo: SpaceX Starship\nAño: {Año}\nUnidad de Uso: {UnidadDeUso} hs\nColor: {Color}\nDueño: {Dueño}\nAutonomia: {Autonomia} hs\nService: cada {Service} hs";
        }
    }

    public class Falcon9 : Producto
    {
        public Falcon9()
        {
            UnidadDeUso = 200;
            Autonomia = 200;
            Service = 400;
        }

        public override string ObtenerInformacion()
        {
            return $"Modelo: Falcon 9\nAño: {Año}\nUnidad de Uso: {UnidadDeUso} hs\nColor: {Color}\nDueño: {Dueño}\nAutonomia: {Autonomia} hs\nService: cada {Service} hs";
        }
    }

}

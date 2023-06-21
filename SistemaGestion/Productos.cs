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

        public double CargaRestante
        {
            get
            {
                int modulo = Autonomia - (UnidadDeUso % Autonomia);
                if (modulo == Autonomia)
                    return 100;
                return Math.Round((double)modulo / Autonomia * 100, 2);
            }
        }

        public abstract string ObtenerInformacion();

        public virtual void RealizarEscaneo()
        {
            // Lógica de escaneo común a todos los productos

            // Obtener el resultado del escaneo
            string resultado = ObtenerResultadoEscaneo();

            resultado = ObtenerInformacion() + "\n\n" + resultado;

            // Mostrar el resultado en un popup
            MessageBox.Show(resultado, "Resultado del escaneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected abstract string ObtenerResultadoEscaneo();
    }

    public class TeslaModelX : Producto
    {
        public TeslaModelX()
        {
            UnidadDeUso = 0;
            Autonomia = 560;
            Service = 1000;
        }

        public int Asientos { get; set; } = 7;

        public override string ObtenerInformacion()
        {
            return $" Producto: Tesla Model X\n\n Año: {Año}\n Kilometraje: {UnidadDeUso} km\n Color: {Color}\n Dueño: {Dueño}\n Asientos: {Asientos}\n Autonomia: {Autonomia} km\n Service: cada {Service} km\n Combustible restante: {CargaRestante} %";
        }

        protected override string ObtenerResultadoEscaneo()
        {
            // Lógica específica de escaneo para el Tesla Model X

            // Construir el mensaje de resultado
            string mensaje = "Service 1: (1) y (2)";

            return mensaje;
        }
    }

    public class TeslaModelS : Producto
    {
        public TeslaModelS()
        {
            UnidadDeUso = 0;
            Autonomia = 650;
            Service = 2000;
        }

        public int Asientos { get; set; } = 5;

        public override string ObtenerInformacion()
        {
            return $" Producto: Tesla Model S\n\n Año: {Año}\n Kilometraje: {UnidadDeUso} km\n Color: {Color}\n Dueño: {Dueño}\n Asientos: {Asientos}\n Autonomia: {Autonomia} km\n Service: cada {Service} km\n Combustible restante: {CargaRestante} %";
        }

        protected override string ObtenerResultadoEscaneo()
        {
            int cantidadServices = this.UnidadDeUso / this.Service;
            List<string> serviciosRealizados = new List<string>();

            for (int i = 1; i < cantidadServices + 1; i++)
            {
                // Agregar los servicios realizados a la lista
                string servicio = $"Service {i}: ";

                // Verificar si se debe realizar el control de cinturones de seguridad
                if (i * this.Service >= 1000)
                {
                    servicio += "(1) ";
                }

                if (i * this.Service >= 2000)
                {
                    servicio += "(2) ";
                }

                if (i * this.Service >= 2500)
                {
                    servicio += "(4) ";
                }

                if (i * this.Service >= 3000)
                {
                    servicio += "(5) ";
                }

                if (i * this.Service >= 3000)
                {
                    servicio += "(6) ";
                }
                serviciosRealizados.Add(servicio);
            }

            // Construir el mensaje de resultado
            string mensaje = $"Cantidad de services realizados para {this.GetType().Name}: {cantidadServices}\n";
            mensaje += "Servicios Realizados:\n";

            for (int i = 0; i < serviciosRealizados.Count; i++)
            {
                mensaje += serviciosRealizados[i] + "\n";
            }

            return mensaje;
        }
    }

    public class Cybertruck : Producto
    {
        public Cybertruck()
        {
            UnidadDeUso = 0;
            Autonomia = 800;
            Service = 3000;
        }

        public int Asientos { get; set; } = 6;

        public override string ObtenerInformacion()
        {
            return $" Producto: Tesla Cybertruck\n\n Año: {Año}\n Kilometraje: {UnidadDeUso} km\n Color: {Color}\n Dueño: {Dueño}\n Asientos: {Asientos}\n Autonomia: {Autonomia} km\n Service: cada {Service} km\n Combustible restante: {CargaRestante} %";
        }

        protected override string ObtenerResultadoEscaneo()
        {
            int cantidadServices = this.UnidadDeUso / this.Service;
            List<string> serviciosRealizados = new List<string>();

            for (int i = 1; i < cantidadServices + 1; i++)
            {
                // Agregar los servicios realizados a la lista
                string servicio = $"Service {i}: ";

                // Verificar si se deben realizar los controles
                if (i * this.Service >= 1000)
                {
                    servicio += "(1) ";
                }

                if (i * this.Service >= 2000)
                {
                    servicio += "(2) ";
                }

                if (i * this.Service >= 2500)
                {
                    servicio += "(4) ";
                }

                if (i * this.Service >= 3000)
                {
                    servicio += "(5) ";
                }

                if (i * this.Service >= 3000)
                {
                    servicio += "(6) ";
                }
                serviciosRealizados.Add(servicio);
            }

            // Construir el mensaje de resultado
            string mensaje = $"Cantidad de services realizados para {this.GetType().Name}: {cantidadServices}\n";
            mensaje += "Servicios Realizados:\n";

            for (int i = 0; i < serviciosRealizados.Count; i++)
            {
                mensaje += serviciosRealizados[i] + "\n";
            }

            return mensaje;
        }
    }


    public class SpaceXStarship : Producto
    {
        public SpaceXStarship()
        {
            UnidadDeUso = 0;
            Autonomia = 500;
            Service = 1000;
        }

        public override string ObtenerInformacion()
        {
            return $" Producto: SpaceX Starship\n\n Año: {Año}\n Horas de vuelo: {UnidadDeUso} hs\n Color: {Color}\n Dueño: {Dueño}\n Autonomia: {Autonomia} hs\n Service: cada {Service} hs\n Carga restante: {CargaRestante} %";
        }

        protected override string ObtenerResultadoEscaneo()
        {
            int cantidadServices = this.UnidadDeUso / this.Service;
            List<string> serviciosRealizados = new List<string>();

            for (int i = 0; i < cantidadServices; i++)
            {
                // Agregar los servicios realizados a la lista
                string servicio = $"Service {i + 1}: ";

                // Verificar si se debe realizar el control de cinturones de seguridad
                if (i * this.Service % 1000 == 0)
                {
                    servicio += "(3) ";
                }

                if (i * this.Service % 500 == 0)
                {
                    servicio += "(4) ";
                }
                serviciosRealizados.Add(servicio);
            }

            // Construir el mensaje de resultado
            string mensaje = $"Cantidad de services realizados para {this.GetType().Name}: {cantidadServices}\n";
            mensaje += "Servicios Realizados:\n";

            for (int i = 0; i < serviciosRealizados.Count; i++)
            {
                mensaje += serviciosRealizados[i] + "\n";
            }

            return mensaje;
        }
    }

    public class Falcon9 : Producto
    {
        public Falcon9()

        {
            UnidadDeUso = 0;
            Autonomia = 200;
            Service = 400;
        }

        public override string ObtenerInformacion()
        {
            return $" Producto: SpaceX Falcon 9\n\n Año: {Año}\n Horas de vuelo: {UnidadDeUso} hs\n Color: {Color}\n Dueño: {Dueño}\n Autonomia: {Autonomia} hs\n Service: cada {Service} hs\n Carga restante: {CargaRestante} %";
        }

        protected override string ObtenerResultadoEscaneo()
        {
            // Lógica específica de escaneo para el Tesla Model S

            // Construir el mensaje de resultado
            string mensaje = "Service 1: (1) y (2)\nService 2: (1), (2), (4), (5) y (6)";

            return mensaje;
        }
    }

}

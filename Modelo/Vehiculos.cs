using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_De_Multas_De_Transito.Modelo
{
    class Vehiculos
    {
        public string nroPlaca { get; set; }
        public string tipo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int anio { get; set; }
    }
    class VehiculosEli
    {
        public string nroPlaca { get; set; }
    }

    public class AsignarVehiculo
    {
        public string nroPlaca { get; set; }
        public int dpi { get; set; }
    }
}

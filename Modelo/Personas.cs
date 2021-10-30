using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_De_Multas_De_Transito.Modelo
{
    class Personas
    {
        public int dpi { get; set; }
        public string nombreApellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
    }
    class PersonaActu
    { 
        public int dpi { get; set; }
        public string nombreApellido { get; set; }
    }
    class PersonaEli
    {
        public int dpi { get; set; }
    }
}

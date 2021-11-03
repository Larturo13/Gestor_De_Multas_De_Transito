using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_De_Multas_De_Transito.Modelo
{
    class Multas
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public float valor { get; set; }
    }
    class MultasInsert
    {
        public string descripcion { get; set; }
        public float valor { get; set; }
    }
    class MultasActu
    {
        public int codigo { get; set; }
        public float valor { get; set; }
    }
    class GenMulta
    {
        public string nroPlaca { get; set; }
        public int codigo_infraccion { get; set; }
        public int dpi { get; set; }
        public DateTime hora { get; set; }
        public DateTime fecha { get; set; }
        public string lugar { get; set; }
    }
    class GenMultaCons
    {
        public int nro_multa { get; set; }
        public string nroPlaca { get; set; }
        public int dpi { get; set; }
        public string descripcion { get; set; }
        public float valor { get; set; }
        public TimeSpan hora { get; set; }
        public DateTime fecha { get; set; }
        public string lugar { get; set; }
    }
    class GenMultaPag
    {
        public int nro_multa { get; set; }
    }
    class MultasEli
    {
        public int codigo { get; set; }
    }
}

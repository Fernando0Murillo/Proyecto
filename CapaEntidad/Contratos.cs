using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Contratos
    {
        public int IdContrato { get; set; }
        public Empleados oEmpleado { get; set; }
        public string TipoContrato { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public string Sueldo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PuntoEmision
    {
        public int IdPuntoEmision { get;set; }
        public Sucursal oSucursal { get; set; }
        public Caja oCaja { get; set; }

    }
}

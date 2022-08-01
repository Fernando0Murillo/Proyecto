using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }
        public Direccion oDireccion { get; set; }
        public string NombreSucursal { get; set; }
        public string Telefono { get; set; }
        public string RTN { get; set; }

    }
}

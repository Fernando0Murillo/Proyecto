using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compras
    {
        public int IdCompra { get; set; }
        public Usuarios oUsuario { get; set; }
        public Proveedores oProveedor { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
    }
}

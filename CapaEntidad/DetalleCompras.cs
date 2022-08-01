using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleCompras
    {
        public int IdDetalleCompra { get; set; }
        public Compras oCompra { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string PrecioCompra { get; set; }
        public string TotalPagar { get; set; }

    }
}

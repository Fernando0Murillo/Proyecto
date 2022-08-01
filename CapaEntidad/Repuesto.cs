using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Repuesto
    {
        public int IdRepuesto { get; set; }
        public string Descripcion { get; set; }
        public float CostoAdquisicion { get; set; }
        public float CostoVenta { get; set; }
        public int Cantidad { get; set; }

    }
}

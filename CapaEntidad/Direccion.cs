using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Direccion
    {
        public int IdDireccion { get; set; }
        public Colonia oColonia { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public Marca oMarca { get; set; }
        public Version oVersion { get; set; }
        public Color oColor { get; set; }
        public Modelo oModelo { get; set; }
        public Combustible oCombustible { get; set; }
        public Tipo oTipo { get; set; }
        public string CodigoChasis { get; set; }
        public string FechaIngreso { get; set; }
        public string PrecioAdquisicion { get; set; }
        public bool Vendido { get; set; }
        public int Cantidad { get; set; }

    }
}

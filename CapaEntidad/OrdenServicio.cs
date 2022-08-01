using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class OrdenServicio
    {
        public int IdOrdenServicio { get; set; }
        public Vehiculo oVehiculo { get; set; }
        public Cliente oCliente { get; set; }
        public Sucursal oSucursal { get; set; }
        public Usuarios oUsuario { get; set; }
        public string Servicio { get; set; }
        public string FechaEmision { get; set; }
        public string Observacion { get; set; }
        public string FechaOrden { get; set; }
        public float TotalRepuesto { get; set; }
        public float TotalManoObra { get; set; }
    }
}

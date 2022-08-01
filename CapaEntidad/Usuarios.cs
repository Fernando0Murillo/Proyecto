using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public Empleados oEmpleados { get; set; }
        public Roles oRoles { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

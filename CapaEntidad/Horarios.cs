using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Horarios
    {
        public int IdHorario { get; set; }
        public string Descripcion { get; set; }
        public int DiaLibre { get; set; }
        public string HoraInicio { get; set; }
        public string HoraSalida { get; set; }
    }
}

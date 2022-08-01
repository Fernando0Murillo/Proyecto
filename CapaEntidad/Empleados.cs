namespace CapaEntidad
{
    public class Empleados
    {
        public int IdEmpleado { get; set; }
        public Sucursal oSucursal { get; set; }
        public Horarios oHorario { get; set; }
        public Genero oGenero { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string CorreoEmpresa { get; set; }

    }
}
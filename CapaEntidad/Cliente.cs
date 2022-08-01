namespace CapaEntidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public Genero oGenero { get; set; }
        public int DNI { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Correo { get; set; }
    }
}
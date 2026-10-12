namespace Mi_portafolio_Daniela.Models
{
    public class Perfil
    {
        public string Nombre { get; set; } = "";
        public string Profesion { get; set; } = "";
        public string AcercaDe { get; set; } = "";
        public string Correo { get; set; } = "";
        public string Foto { get; set; } = "";
        public List<string> Habilidades { get; set; } = new();
        public List<string> Galeria { get; set; } = new();   // nombres de las imágenes de la galería
    }
}


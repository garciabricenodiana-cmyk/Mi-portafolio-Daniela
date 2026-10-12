namespace Mi_portafolio_Daniela.Models
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public string DescripcionDetallada { get; set; } = "";
        public string Imagen { get; set; } = "";
        public string Tecnologias { get; set; } = "";
        public List<string> Funcionalidades { get; set; } = new();
        public string? UrlRepositorio { get; set; }
    }
}
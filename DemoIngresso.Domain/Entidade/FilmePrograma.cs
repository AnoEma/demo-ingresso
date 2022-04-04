namespace DemoIngresso.Domain.Entidade
{
    public class FilmePrograma
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataPrograma { get; set; }
        public List<Cinemark>? Cinemark { get; set; }
    }
}
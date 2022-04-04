namespace DemoIngresso.Domain.Entidade
{
    public class Cinemark
    {
        public int Id { get; set; }
        public string? CinemarkNome { get; set; }
        public string? Descricao { get; set; }
        public List<Sala>? Salas { get; set; }
        public List<string>? HorarioDisponiivel { get; set; }
    }
}
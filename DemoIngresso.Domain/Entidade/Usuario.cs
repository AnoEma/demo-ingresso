namespace DemoIngresso.Domain.Entidade
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? SobreNome { get; set; }
        public char DDD { get; set; }   
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? MesAniversario { get; set; }
        public int Data { get; set; }
        public bool Genero { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public char Estado { get; set; }
        public string? Cidade { get; set; }
        public bool ReceberNovidade { get; set; }
        public bool Excluido { get; set; }
    }
}
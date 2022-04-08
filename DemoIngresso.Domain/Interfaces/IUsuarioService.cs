using DemoIngresso.Domain.Entidade;

namespace DemoIngresso.Domain.Interfaces
{
    public interface IUsuarioService
    {
        Task InsertUsuario(Usuario usuario);
    }
}
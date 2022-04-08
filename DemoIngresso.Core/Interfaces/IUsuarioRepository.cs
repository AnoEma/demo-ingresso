using DemoIngresso.Domain.Entidade;

namespace DemoIngresso.Core.Interfaces
{
    public interface IUsuarioRepository
    {
        void PostUsuario(Usuario usuario);
    }
}
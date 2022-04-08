using DemoIngresso.Domain.Entidade;
using DemoIngresso.Domain.Interfaces;

namespace DemoIngresso.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        public async Task InsertUsuario(Usuario usuario)
        {
            await Task.Run(() =>
            {
                if (string.IsNullOrEmpty(usuario.CPF))
                {
                    throw new ArgumentNullException(nameof(usuario));
                }
            });
        }
    }
}
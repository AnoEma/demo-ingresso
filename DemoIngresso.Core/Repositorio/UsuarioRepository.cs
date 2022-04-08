using DemoIngresso.Core.Data;
using DemoIngresso.Core.Interfaces;
using DemoIngresso.Domain.Entidade;

namespace DemoIngresso.Core.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _context;

        public UsuarioRepository(DataContext context)
        {
            _context = context;
        }

        public void PostUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
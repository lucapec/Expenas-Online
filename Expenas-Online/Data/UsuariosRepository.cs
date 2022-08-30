
using ExpensasOnline.API.DBContexts;
using Expenas_Online.Entities;
using Expenas_Online.Models;

namespace Expenas_Online.Data

{
    public class UsuariosRepository : IUsuariosRepository
    {
        internal readonly InformacionPisosContext _context;

        public UsuariosRepository(InformacionPisosContext context)
        {
            _context = context;
        }

        public Usuario? ValidarUsuarios(AutenticacionRequestBody autenticacionRequestBody)
        {
            return _context.Usuarios.FirstOrDefault(p => p.UserName == autenticacionRequestBody.UserName && p.Password == autenticacionRequestBody.Password);
        }
        public bool GuardarCambio()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}

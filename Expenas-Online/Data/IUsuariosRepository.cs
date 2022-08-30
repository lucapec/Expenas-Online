using Expenas_Online.Entities;
using Expenas_Online.Models;

namespace Expenas_Online.Data
{
    public interface IUsuariosRepository
    {
        public Usuario? ValidarUsuarios(AutenticacionRequestBody autenticacionRequestBody);
        public bool GuardarCambio();
    }
}

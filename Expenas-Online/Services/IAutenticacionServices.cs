using Expenas_Online.Entities;
using Expenas_Online.Models;

namespace Expenas_Online.Services
{
    public interface IAutenticacionServices
    {
            Usuario? ValidarUsuario(AutenticacionRequestBody autenticacionRequestBody);
    }
    
}

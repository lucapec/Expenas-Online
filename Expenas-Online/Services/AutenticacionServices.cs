using Expenas_Online.Data;
using Expenas_Online.Entities;
using Expenas_Online.Models;

namespace Expenas_Online.Services
{
    public class AutenticacionServices : IAutenticacionServices
    {
        private readonly IUsuariosRepository _userRepository;

        public AutenticacionServices(IUsuariosRepository usuarioRepository)
        {
            _userRepository = usuarioRepository;
        }

        public Usuario? ValidarUsuario(AutenticacionRequestBody autenticacionRequest)
        {
            if (string.IsNullOrEmpty(autenticacionRequest.UserName) || string.IsNullOrEmpty(autenticacionRequest.Password))
                return null;

            return _userRepository.ValidarUsuarios(autenticacionRequest);
        }
    }
}

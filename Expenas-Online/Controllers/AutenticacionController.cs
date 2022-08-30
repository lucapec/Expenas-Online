﻿using AutoMapper;
using Expenas_Online.Entities;
using Expenas_Online.Models;
using Expenas_Online.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PisosInfo.API.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IAutenticacionServices _customAuthenticationService;

        public AuthenticationController(IConfiguration config, IAutenticacionServices autenticacionService)
        {
            _config = config;
            this._customAuthenticationService = autenticacionService;
        }

        [HttpPost("authenticate")]
        public ActionResult<string> Autenticar(AutenticacionRequestBody autenticacionRequestBody)
        {

            var user = ValidateCredentials(autenticacionRequestBody);

            if (user is null)
                return Unauthorized();


            var securityPassword = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey"]));

            var credentials = new SigningCredentials(securityPassword, SecurityAlgorithms.HmacSha256);


            var claimsForToken = new List<Claim>();
            claimsForToken.Add(new Claim("sub", user.Id.ToString()));
            claimsForToken.Add(new Claim("rol", user.Rol.ToString()));

            var jwtSecurityToken = new JwtSecurityToken(
              _config["Authentication:Issuer"],
              _config["Authentication:Audience"],
              claimsForToken,
              DateTime.UtcNow,
              DateTime.UtcNow.AddHours(1),
              credentials);

            var tokenToReturn = new JwtSecurityTokenHandler()
                .WriteToken(jwtSecurityToken);

            return Ok(tokenToReturn);
        }

        private Usuario? ValidateCredentials(AutenticacionRequestBody authParams)
        {
            return _customAuthenticationService.ValidarUsuario(authParams);
        }
    }

}

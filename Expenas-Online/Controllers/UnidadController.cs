﻿using AutoMapper;
using ExpensasOnline.API.Entities;
using ExpensasOnline.API.Models;
using ExpensasOnline.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Entities = ExpensasOnline.API.Entities;

namespace PisosInfo.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/pisos/{idPiso}/unidades")] //Ya que esto es dependiente de ciudades necesito que primero me indique la ciudad
    public class UnidadController : ControllerBase
    {
        private readonly IInfoPisosRepository _repository;
        private readonly IMapper _mapper;

        public UnidadController(IInfoPisosRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UnidadDto>> GetUnidades(int idPiso)
        {

            return Ok(_mapper.Map<IEnumerable<UnidadDto>>(_repository.GetUnidades(idPiso)));
        }

        [HttpGet("{idUnidad}", Name = "GetUnidad")] 
        public ActionResult<Unidad> GetUnidadDePiso(int idPiso, int idUnidad)
        {
            
            var unidad = _repository.GetUnidadDePiso(idPiso, idUnidad); 

            if (unidad == null)
                return NotFound();

            return Ok(_mapper.Map<UnidadDto>(unidad));
        }

      
        [HttpPut("{idUnidad}")]
        public ActionResult ActualizarUnidades(int idPiso, int idUnidad, UnidadParaUpdateDto unidad)
        {
       
            var unidadAActualizar = _repository.GetUnidadDePiso(idPiso, idUnidad);
            if (unidadAActualizar == null)
                return NotFound();

            _mapper.Map(unidad, unidadAActualizar); 

            _repository.GuardarCambio();

            return NoContent();
        }

        [HttpPost]
        public ActionResult<UnidadDto> CrearUnidad(int idPiso, UnidadParaCrearDto unidad)
        {
          

            var nuevaUnidad = _mapper.Map<Entities.Unidad>(unidad);

            _repository.AgregarUnidad(idPiso, nuevaUnidad);
            _repository.GuardarCambio();

            var unidadADevolver = _mapper.Map<UnidadParaCrearDto>(nuevaUnidad);

            return CreatedAtRoute(//CreatedAtRoute es para q devuelva 201, el 200 de post.
                "GetUnidad", //El primer parámetro es el Name del endpoint que hace el Get
                new //El segundo los parametros q necesita ese endpoint
                {
                    idPiso,
                    idUnidad = nuevaUnidad.Id
                },
                unidadADevolver);//El tercero es el objeto creado. 
        }


        [HttpDelete("{idUnidad}")]
        public ActionResult BorrarUnidad(int idPiso, int idUnidad)
        {
           
            var unidadAEliminar = _repository.GetUnidadDePiso(idPiso, idUnidad);
            if (unidadAEliminar is null)
                return NotFound();

            _repository.EliminarUnidad(unidadAEliminar);
            _repository.GuardarCambio();

            return NoContent();
        }
    }
}

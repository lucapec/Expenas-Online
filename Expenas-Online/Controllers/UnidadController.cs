using AutoMapper;
using ExpensasOnline.API.Entities;
using ExpensasOnline.API.Models;
using ExpensasOnline.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Entities = ExpensasOnline.API.Entities;

namespace PisosInfo.API.Controllers
{
    [ApiController]
    [Authorize]
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

        [HttpGet("{idUnidad}", Name = "GetUnidad")] // El name se lo da para usarlo en el POST.
        public ActionResult<Unidad> GetUnidadDePiso(int idPiso, int idUnidad)
        {
            
            var unidad = _repository.GetUnidadDePiso(idPiso, idUnidad); //Acá lo traemos y no agregamos un método al repositorio pq necesitamos la data, entonces lo tenemos que traer igualmente.

            if (unidad == null)
                return NotFound();

            return Ok(_mapper.Map<UnidadDto>(unidad));
        }

      
        [HttpPut("{idUnidad}")]
        public ActionResult ActualizarPuntoDeInteres(int idPiso, int idUnidad,UnidadParaUpdateDto unidad)
        {
       
            var unidadAActualizar = _repository.GetUnidadDePiso(idPiso, idUnidad);
            if (unidadAActualizar == null)
                return NotFound();

            _mapper.Map(unidad, unidadAActualizar); 

            _repository.GuardarCambios();

            return NoContent();
        }


        [HttpDelete("{idUnidad}")]
        public ActionResult BorrarUnidad(int idPiso, int idUnidad)
        {
           
            var unidadAEliminar = _repository.GetUnidadDePiso(idPiso, idUnidad);
            if (unidadAEliminar is null)
                return NotFound();

            _repository.EliminarUnidad(unidadAEliminar);
            _repository.GuardarCambios();

            return NoContent();
        }
    }
}

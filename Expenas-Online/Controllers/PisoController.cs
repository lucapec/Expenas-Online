using AutoMapper;
using ExpensasOnline.API.Models;
using ExpensasOnline.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PisosInfo.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/pisos")]
    public class PisoController : ControllerBase
    {
      
        private readonly IInfoPisosRepository _infoPisosRepository;
        private readonly IMapper _mapper;

        public PisoController(IInfoPisosRepository infoPisosRepository, IMapper mapper)
        {
         
            _infoPisosRepository = infoPisosRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PisoDto>> GetPisos() 
        {
            var pisos = _infoPisosRepository.GetPisos();
            return Ok(_mapper.Map<IEnumerable<PisoDto>>(pisos));

        }

        [HttpGet("{id}")]
        public IActionResult GetPiso(int id)    
                                                                                  
        {
            var piso = _infoPisosRepository.GetPiso(id);
            if ( piso == null)
                return NotFound();
            return Ok(_mapper.Map<PisoDto>(piso));

        }
    }
}

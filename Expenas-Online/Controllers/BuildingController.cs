using Expenas_Online.API.Controllers;
using Expenas_Online.Models;
using Microsoft.AspNetCore.Mvc;

namespace Expenas_Online
{
    [ApiController]
    [Route("api/building")]

    public class BuildingController : ControllerBase
    {
        [HttpGet]

        public ActionResult<IEnumerable<BuildingDto>> GetFloors()
        {
            return Ok(InquilinosData.InstanciaAcctual.Floor);
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<BuildingDto>> GetFloor(int floor)
        {
            var floorToPass = InquilinosData.InstanciaActual.Floors.FirstOrDefault(x => x.Floor == floor));
            if (floorToPass == null)
                return NotFound();
            return Ok(floorToPass.Floor);
        }
    }

}
using Expenas_Online.API.Controllers;
using Expenas_Online.Models;
using Microsoft.AspNetCore.Mvc;

namespace Expenas_Online
{
    [ApiController]
    [Route("api/building")]

    public class BuildingController : ControllerBase
    {
        private readonly InquilinosData _inquilinosData1;
        public BuildingController(InquilinosData inquilinosData)
        {
            _inquilinosData1 = inquilinosData;
        }
        [HttpGet]

        public ActionResult<IEnumerable<BuildingDto>> GetFloors()
        {
            return Ok(_inquilinosData1.Floors);
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<BuildingDto>> GetFloor(int floor)
        {
            var floorToPass = _inquilinosData1.Floors.FirstOrDefault(x => x.Floor == floor);
            if (floorToPass == null)
                return NotFound();
            return Ok(floorToPass.Floor);
        }
    }

}
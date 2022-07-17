using Expenas_Online.API.Controllers;
using Expenas_Online.Models;
using Microsoft.AspNetCore.Mvc;

namespace Expenas_Online.Controllers
{

    [ApiController]
    [Route("api/building/{floor}/units")]
    public class FloorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<FloorDto>>GetUnits(int Idfloor)
        {
            var floor = InquilinosData.InstanciaActual.Floors.FirstOrDefault(x => x.Floor == Idfloor);
            if (floor == null)
                return NotFound();
            return Ok(floor.Units);
        }

        [HttpGet("{IdFloor}", Name = "GetUnits")]
        public ActionResult<FloorDto>GetUnits(int idfloor, int idunit)
        {
            var floor = InquilinosData.InstanciaActual.Floors.FirstOrDefault(x => x.Floor == idfloor);
            if (floor == null)
                return NotFound();
            var unit = floor.Units.FirstOrDefault(x => x.Id == idunit);
            if (unit == null)
                return NotFound(unit);
            return Ok(unit);
        }

        [HttpPost(Name ="AddUnits")]
        public ActionResult<FloorDto>AddUnits(int idFloor, FloorAddDto units)
        {
            var unit = InquilinosData.InstanciaActual.Floors.FirstOrDefault(x => x.Floor == idFloor);
            if(unit == null)
            {
                return NotFound();
            }

            var idLastUnit = InquilinosData.InstanciaActual.Floors.SelectMany(z => z.Units).Max(i => i.Id);

            var newUnit = new UnitDto
            {
                Id = ++idLastUnit,
                Name = units.Name,
                Debt = units.Debt,
            };

            unit.Units.Add(newUnit);

            return CreatedAtRoute(
                "GetUnits",
                new
                {
                    idFloor,
                    IdUnits = newUnit.Id
                },
                newUnit);
        }

        [HttpPut("{IdFloor}", Name ="RestartUnits")]
        public ActionResult RestartUnits(int idFloor, int IdUnits, FloorAddDto units)
        {
            var unit = InquilinosData.InstanciaActual.Floors.FirstOrDefault(x => x.Floor == idFloor);
            if (unit == null)
                return NotFound();
            var unitBase = unit.Units.FirstOrDefault(j => j.Id == IdUnits);
            if (unitBase == null)
                return NotFound();
            unitBase.Name = units.Name;
            unitBase.Debt = units.Debt;

            return NoContent();
        }

        [HttpDelete(Name ="DeleteUnit")]
        public ActionResult DeleteUnit(int idFloor, int idUnit)
        {
            var unit = InquilinosData.InstanciaActual.Floors.FirstOrDefault(s => s.Floor == idFloor);
            if (unit == null)
                return NotFound();
            var unitToDelete = unit.Units.FirstOrDefault(j => j.Id == idUnit);
            if (unitToDelete == null)
                return NotFound();
            unit.Units.Remove(unitToDelete);

            return Ok();
        }
    }
}

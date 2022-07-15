namespace Expenas_Online.Models
{
    public class BuildingDto
    {
        public int Floor { get; set; }
        public ICollection<UnitDto> Units { get; set; } = new List<UnitDto>();
    }
}

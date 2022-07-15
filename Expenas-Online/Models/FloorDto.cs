namespace Expenas_Online.Models
{
    public class UnitDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public float Debt { get; set; } //Buscar como ahcer que esto no ´púeda ser 0
       
    }
}

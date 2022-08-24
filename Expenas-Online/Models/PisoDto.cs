namespace ExpensasOnline.API.Models;
public class PisoDto
{
    public int Id { get; set; }
    public ICollection<UnidadDto> Unidad { get; set; } = new List<UnidadDto>(); //Lo seteamos a una nueva colección para evitar que retorne un null en algún momento de la ejecución.

    public int CantidadUnidad
    {
        get { return Unidad.Count; }
    }
}


using ExpensasOnline.API.DBContexts;
using ExpensasOnline.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpensasOnline.API.Services
{
    public class InfoPisosRepository : IInfoPisosRepository
    {
        private readonly InformacionPisosContext _context;

        public InfoPisosRepository(InformacionPisosContext context)
        {
            _context = context;
        }
        public Piso? GetPiso(int idPiso)
        {
        
            return _context.Pisos.Where(c => c.Id == idPiso).FirstOrDefault();
        }

        public IEnumerable<Piso> GetPisos()
        {
            return _context.Pisos.OrderBy(x => x.Id).ToList();
        }

        public Unidad? GetUnidadDePiso(int idPiso, int idUnidad)
        {
            return _context.Unidades.Where(p => p.PisoId == idPiso && p.Id == idUnidad).FirstOrDefault();
        }

        public IEnumerable<Unidad> GetUnidades(int idPiso)
        {
            return _context.Unidades.Where(p => p.PisoId == idPiso).ToList();
        }

        public void AgregarUnidad(int idPiso, Unidad unidad)
        {
            var piso = GetPiso(idPiso);
            if (piso != null)
                piso.Unidad.Add(unidad);
        }
        public void EliminarUnidad(Unidad unidad)
        {
            _context.Unidades.Remove(unidad);
        }

        public bool GuardarCambios()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}

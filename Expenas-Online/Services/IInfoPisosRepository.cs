﻿using ExpensasOnline.API.Entities;

namespace ExpensasOnline.API.Services
{
    public interface IInfoPisosRepository
    {
        public IEnumerable<Piso> GetPisos();
        public Piso? GetPiso(int idPiso);
        public IEnumerable<Unidad> GetUnidades(int idCiudad);
        public Unidad? GetUnidadDePiso(int idPiso, int idUnidad);
        void EliminarUnidad(Unidad unidad);
        public bool GuardarCambios();
    }
}
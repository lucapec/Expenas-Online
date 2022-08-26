using AutoMapper;

namespace ExpensasOnline.API.AutoMapperProfiles
{
    public class UnidadProfile : Profile
    {
        public UnidadProfile()
        {
            CreateMap<Entities.Unidad, Models.UnidadDto>();
            CreateMap<Models.UnidadDto, Entities.Unidad>();
            CreateMap<Models.UnidadParaUpdateDto, Entities.Unidad>();
            CreateMap<Entities.Unidad, Models.UnidadParaCrearDto>();
            CreateMap<Models.UnidadParaCrearDto, Entities.Unidad>();
        }
    }
}

using AutoMapper;

namespace ExpensasOnline.API.AutoMapperProfiles
{
    public class UnidadProfile : Profile
    {
        public UnidadProfile()
        {
            CreateMap<Entities.Unidad, Models.UnidadDto>();
            CreateMap<Models.UnidadParaUpdateDto, Entities.Unidad>();
        }
    }
}

using AutoMapper;

namespace ExpensasOnline.API.AutoMapperProfiles
{
    public class PisoProfile : Profile
    {
        public PisoProfile()
        {
            CreateMap<Entities.Piso, Models.PisoDto>();
        }
    }
}

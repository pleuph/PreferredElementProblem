using AutoMapper;
using PreferredElementApi.Models;
using PreferredElementData.Models;

namespace PreferredElementApi.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MasterData, MasterDataDto>()
                .ForMember(a => a.Status, b => b.MapFrom(c => c.Status.ToString()));
        }
    }
}

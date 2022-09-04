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

            CreateMap<ItemBrick, BrickDto>()
                .ForMember(a => a.DesignId, b => b.MapFrom(c => c.Brick.DesignId))
                .ForMember(a => a.ColorCodes, b => b.MapFrom(c => c.Brick.BrickColorCodes.Select(d => d.ColorCode.Name)));

            CreateMap<Item, ItemDto>()
                .ForMember(a => a.MasterData, b => b.MapFrom(c => c.MasterDatas.FirstOrDefault()))
                .ForMember(a => a.Bricks, b => b.MapFrom(c => c.ItemBricks));
        }
    }
}

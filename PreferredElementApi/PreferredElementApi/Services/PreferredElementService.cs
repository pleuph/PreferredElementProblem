using AutoMapper;
using PreferredElementApi.Models;
using PreferredElementData;

namespace PreferredElementApi.Services
{
    public class PreferredElementService : IPreferredElementService
    {
        private readonly IPreferredElementRepository preferredElementRepository;
        private readonly IMapper mapper;

        public PreferredElementService(IPreferredElementRepository preferredElementRepository, IMapper mapper)
        {
            this.preferredElementRepository = preferredElementRepository;
            this.mapper = mapper;
        }

        public MasterDataDto[] GetMasterDatas()
        {
            var masterDatas =  preferredElementRepository.GetMasterDatas();

            if(!masterDatas?.Any() == true) return Array.Empty<MasterDataDto>();

            var masterDataDtos = mapper.Map<MasterDataDto[]>(masterDatas);
            return masterDataDtos;
        }

        public MasterDataDto GetMasterDataByItemId(int itemId)
        {
            var masterData = preferredElementRepository.GetMasterDataByItemId(itemId);

            if (masterData == null) return null;

            var masterDataDto = mapper.Map<MasterDataDto>(masterData);
            return masterDataDto;
        }

        public ItemDto GetItemById(int itemId)
        {
            var item = preferredElementRepository.GetItemById(itemId);

            if(item == null) return null;

            var itemDto = mapper.Map<ItemDto>(item);
            return itemDto;
        }

        public ItemDto[] GetItems()
        {
            var items = preferredElementRepository.GetItems();

            if(!items?.Any() == true) return Array.Empty<ItemDto>();

            var itemDtos = mapper.Map<ItemDto[]>(items);
            return itemDtos;
        }
    }
}

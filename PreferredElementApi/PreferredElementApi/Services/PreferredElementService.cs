using AutoMapper;
using PreferredElementApi.Models;
using PreferredElementData;
using PreferredElementData.Models;

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

            if(!masterDatas?.Any() == true) return new MasterDataDto[0];

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

        public Item[] GetItems()
        {
            return preferredElementRepository.GetItems();
        }
    }
}

using PreferredElementData;
using PreferredElementData.Models;

namespace PreferredElementApi.Services
{
    public class PreferredElementService : IPreferredElementService
    {
        private readonly IPreferredElementRepository preferredElementRepository;

        public PreferredElementService(IPreferredElementRepository preferredElementRepository)
        {
            this.preferredElementRepository = preferredElementRepository;
        }

        public MasterData[] GetMasterDatas()
        {
            return preferredElementRepository.GetMasterDatas();
        }

        public Item[] GetItems()
        {
            return preferredElementRepository.GetItems();
        }
    }
}

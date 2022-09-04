using PreferredElementApi.Models;
using PreferredElementData.Models;

namespace PreferredElementApi.Services
{
    public interface IPreferredElementService
    {
        Item[] GetItems();
        MasterDataDto GetMasterDataByItemId(int itemId);
        MasterDataDto[] GetMasterDatas();
    }
}
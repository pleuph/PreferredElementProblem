using PreferredElementApi.Models;

namespace PreferredElementApi.Services
{
    public interface IPreferredElementService
    {
        ItemDto[] GetItems();
        ItemDto GetItemById(int itemId);
        MasterDataDto GetMasterDataByItemId(int itemId);
        MasterDataDto[] GetMasterDatas();
    }
}
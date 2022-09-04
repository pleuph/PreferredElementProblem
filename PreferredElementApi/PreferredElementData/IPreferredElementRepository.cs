using PreferredElementData.Models;

namespace PreferredElementData
{
    public interface IPreferredElementRepository
    {
        Item[] GetItems();
        Item GetItemById(int itemId);
        MasterData GetMasterDataByItemId(int itemId);
        MasterData[] GetMasterDatas();
    }
}
using PreferredElementData.Models;

namespace PreferredElementData
{
    public interface IPreferredElementRepository
    {
        Item[] GetItems();
        MasterData GetMasterDataByItemId(int itemId);
        MasterData[] GetMasterDatas();
    }
}
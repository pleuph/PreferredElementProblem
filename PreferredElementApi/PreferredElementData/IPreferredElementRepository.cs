using PreferredElementData.Models;

namespace PreferredElementData
{
    public interface IPreferredElementRepository
    {
        Item[] GetItems();
        Item GetItemById(int itemId);
        Item[] GetPreferredItems(int[] brickDesignIds);
        MasterData GetMasterDataByItemId(int itemId);
        MasterData[] GetMasterDatas();
    }
}
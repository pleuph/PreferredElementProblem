using PreferredElementData.Models;

namespace PreferredElementApi.Services
{
    public interface IPreferredElementService
    {
        Item[] GetItems();
        MasterData[] GetMasterDatas();
    }
}
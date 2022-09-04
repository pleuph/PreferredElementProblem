using Microsoft.EntityFrameworkCore;
using PreferredElementData.Models;

namespace PreferredElementData
{
    public class PreferredElementRepository : IPreferredElementRepository
    {
        private readonly PreferredElementDbContext dbContext;

        public PreferredElementRepository(PreferredElementDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public MasterData[] GetMasterDatas()
        {
            return dbContext.MasterDatas.ToArray();
        }

        public MasterData GetMasterDataByItemId(int itemId)
        {
            return dbContext.MasterDatas.FirstOrDefault(x => x.ItemId == itemId);
        }

        public Item[] GetItems()
        {
            return dbContext.Items
                .Include(a => a.MasterDatas)
                .ToArray();
        }

        public Item GetItemById(int itemId)
        {
            return dbContext.Items
                .Include(a => a.MasterDatas)
                .Include(a => a.ItemBricks)
                .ThenInclude(a => a.Brick)
                .ThenInclude(a => a.BrickColorCodes)
                .ThenInclude(a => a.ColorCode)
                .FirstOrDefault(a => a.Id == itemId);
        }
    }
}

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

        public Item[] GetItems()
        {
            return dbContext.Items.ToArray();
        }
    }
}

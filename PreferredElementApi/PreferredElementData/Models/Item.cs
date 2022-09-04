namespace PreferredElementData.Models
{
    public class Item
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }

        public List<ItemBrick> ItemBricks { get; set; } = new List<ItemBrick>();
        public List<MasterData> MasterDatas { get; set; } = new List<MasterData>();
    }
}

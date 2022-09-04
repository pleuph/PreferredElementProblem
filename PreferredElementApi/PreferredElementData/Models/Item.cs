namespace PreferredElementData.Models
{
    public class Item
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }

        public List<Brick> Bricks { get; set; } = new List<Brick>();
        public List<MasterData> MasterDatas { get; set; } = new List<MasterData>();
    }
}

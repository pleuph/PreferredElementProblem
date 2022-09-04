namespace PreferredElementData.Models
{
    public class ItemBrick
    {
        public int ItemId { get; set; }
        public int BrickId { get; set; }
        public int Amount { get; set; }
        public DateTime Created { get; set; }

        public Item Item { get; set; }
        public Brick Brick { get; set; }
    }
}

namespace PreferredElementData.Models
{
    public class Brick
    {
        public int Id { get; set; }
        public int DesignId { get; set; }
        public DateTime Created { get; set; }

        public List<BrickColorCode> BrickColorCodes { get; set; } = new List<BrickColorCode>();
    }
}

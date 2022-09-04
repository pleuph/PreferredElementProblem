namespace PreferredElementApi.Models
{
    public class ItemDto
    {
        public int Id { get; set; } 
        
        public MasterDataDto MasterData { get; set; }

        public List<BrickDto> Bricks { get; set; } = new List<BrickDto>();
    }
}

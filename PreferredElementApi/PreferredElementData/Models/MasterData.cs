namespace PreferredElementData.Models
{
    public class MasterData
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public decimal Price { get; set; }
        public ItemStatus Status { get; set; }
        public DateTime Created { get; set; }

        // Considerations:
        // Assuming price is the suggested retail price of an item (LEGO set),
        // the data model would certainly have to account for different markets,
        // currencies and possibly other factors. This could be achieved in 
        // multiple ways that we will consider out of scope for now.
        // The status as well as the price are inherently likely to change over 
        // time. Having a 'Created' timestamp would allow us to add a new
        // MasterData record to an item any time the price or status changes,
        // and then filter for the newest one. 
    }
}

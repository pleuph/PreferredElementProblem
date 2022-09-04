namespace PreferredElementData.Models
{
    public class BrickColorCode
    {
        public int BrickId { get; set; }
        public int ColorCodeId { get; set; }
        public uint Order { get; set; }
        public DateTime Created { get; set; }

        public Brick Brick { get; set; }
        public ColorCode ColorCode { get; set; }
    }

    // Considerations:
    // The Order field is important to make sure a list of color codes
    // for a particular brick appears in the correct order. Ensuring 
    // a logical list of values (0, 1, 2 etc.) will be handled by
    // business logic in the code. Using the combination of BrickId,
    // ColorCodeId and Order as the primary key will ensure that
    // the same color can associated with the same brick in different
    // places in the ordered list.
}

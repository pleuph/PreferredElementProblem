namespace PreferredElementData.Models
{
    public class ColorCode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }

        // Future considerations:
        // Do color codes need a status, so colors can be dereleased?
        // Do we need to be able to list all bricks containing a certain color code?
        // Do we need a field referencing some industry standard code (like pantone)?
    }
}

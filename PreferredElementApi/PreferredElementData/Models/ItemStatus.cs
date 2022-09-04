namespace PreferredElementData.Models
{
    // Considerations:
    // Defining the status as an enum rather than a static data table makes it easy
    // to understand and work with in code. There are some issues with doing it
    // this way though. Querying directly on the database will not yield the status
    // description, and could make bughunting harder. Also, if these statuses are
    // likely to change, or new statuses are likely to appear, the order could
    // become a problem. 
    // For now, we will assume those issues are not relevant.

    public enum ItemStatus
    {
        Normal = 0,
        Novelty = 1,
        Outgoing = 2,
        Discontinued = 3
    }
}

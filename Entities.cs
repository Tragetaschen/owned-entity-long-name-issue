using Microsoft.EntityFrameworkCore;

namespace owned_entity_long_name_issue;

[Owned]
public class Location
{
    public float Long { get; set; }
    public float Lat { get; set; }
}


public class AReallyReallyReallyReallyReallyReallyReallyReallyReallyLongOwnerEntity
{
    public int Id { get; set; }
    public IQueryable<AReallyReallyReallyReallyReallyReallyReallyReallyReallyLongDetails> Details { get; set; } = null!;
}

public class AReallyReallyReallyReallyReallyReallyReallyReallyReallyLongDetails
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public virtual Location Location { get; set; } = null!;
}
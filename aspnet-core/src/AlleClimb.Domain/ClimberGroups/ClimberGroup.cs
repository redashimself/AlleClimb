namespace AlleClimb.ClimberGroups;

using System;
using Volo.Abp.Domain.Entities.Auditing;

public class ClimberGroup : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }

    public GroupType Type { get; set; }

    public ClimberGroup(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
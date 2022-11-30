namespace AlleClimb.ClimberGroups;

using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities.Auditing;

public class ClimberGroupDto : IEntityDto<Guid>
{
    public string Name { get; set; }

    public string Description { get; set; }

    public GroupType Type { get; set; }
    public Guid Id { get; set; }
}
namespace AlleClimb.ClimberGroups;

using System.ComponentModel.DataAnnotations;

public class CreateUpdateClimberGroupDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; }

    public string Description { get; set; }

    [Required]
    public GroupType Type { get; set; }
}
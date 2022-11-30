using AutoMapper;

namespace AlleClimb.Web;

using ClimberGroups;

public class AlleClimbWebAutoMapperProfile : Profile
{
    public AlleClimbWebAutoMapperProfile()
    {
        CreateMap<ClimberGroup, ClimberGroupDto>();
        CreateMap<CreateUpdateClimberGroupDto, ClimberGroup>();
    }
}
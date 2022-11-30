namespace AlleClimb.ClimberGroups;

using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

public class ClimberGroupAppService : CrudAppService<ClimberGroup, ClimberGroupDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateClimberGroupDto>,
    IClimberGroupAppService
{
    public ClimberGroupAppService(IRepository<ClimberGroup, Guid> repository):
        base(repository)
    {

    }
}
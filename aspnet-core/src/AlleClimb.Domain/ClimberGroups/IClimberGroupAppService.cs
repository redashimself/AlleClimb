namespace AlleClimb.ClimberGroups;

using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

public interface IClimberGroupAppService : ICrudAppService<ClimberGroupDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateClimberGroupDto>
{

}
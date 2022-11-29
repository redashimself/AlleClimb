namespace AlleClimb;

using System;
using System.Threading.Tasks;
using ClimberGroups;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

public class AlleClimbDataSeederContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<ClimberGroup, Guid> _climberGroupRepository;

    public AlleClimbDataSeederContributor(IRepository<ClimberGroup, Guid> climberGroupRepository)
    {
        _climberGroupRepository = climberGroupRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _climberGroupRepository.GetCountAsync() <= 0)
        {
            await _climberGroupRepository.InsertAsync(
                new ClimberGroup("Liūtukai", "Liutukų grupė")
            );

            await _climberGroupRepository.InsertAsync(
                new ClimberGroup("Kačiukai", "Kačiukų grupė")
            );
        }
    }
}
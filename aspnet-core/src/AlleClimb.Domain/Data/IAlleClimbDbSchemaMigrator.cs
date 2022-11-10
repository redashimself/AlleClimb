using System.Threading.Tasks;

namespace AlleClimb.Data;

public interface IAlleClimbDbSchemaMigrator
{
    Task MigrateAsync();
}

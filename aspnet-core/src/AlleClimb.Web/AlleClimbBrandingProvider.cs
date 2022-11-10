using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AlleClimb.Web;

[Dependency(ReplaceServices = true)]
public class AlleClimbBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AlleClimb";
}

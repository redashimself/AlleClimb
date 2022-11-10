using AlleClimb.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AlleClimb.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AlleClimbController : AbpControllerBase
{
    protected AlleClimbController()
    {
        LocalizationResource = typeof(AlleClimbResource);
    }
}

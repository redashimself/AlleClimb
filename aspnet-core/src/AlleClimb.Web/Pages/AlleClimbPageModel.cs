using AlleClimb.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AlleClimb.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AlleClimbPageModel : AbpPageModel
{
    protected AlleClimbPageModel()
    {
        LocalizationResourceType = typeof(AlleClimbResource);
    }
}

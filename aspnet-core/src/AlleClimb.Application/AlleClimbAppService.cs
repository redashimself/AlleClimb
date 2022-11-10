using System;
using System.Collections.Generic;
using System.Text;
using AlleClimb.Localization;
using Volo.Abp.Application.Services;

namespace AlleClimb;

/* Inherit your application services from this class.
 */
public abstract class AlleClimbAppService : ApplicationService
{
    protected AlleClimbAppService()
    {
        LocalizationResource = typeof(AlleClimbResource);
    }
}

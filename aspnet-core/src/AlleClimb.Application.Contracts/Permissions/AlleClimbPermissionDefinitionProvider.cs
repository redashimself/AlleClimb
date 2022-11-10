using AlleClimb.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AlleClimb.Permissions;

public class AlleClimbPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AlleClimbPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AlleClimbPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AlleClimbResource>(name);
    }
}

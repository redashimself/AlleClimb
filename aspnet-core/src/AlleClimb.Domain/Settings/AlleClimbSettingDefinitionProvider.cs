using Volo.Abp.Settings;

namespace AlleClimb.Settings;

public class AlleClimbSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AlleClimbSettings.MySetting1));
    }
}

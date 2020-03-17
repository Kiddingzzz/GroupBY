using Sport7.Settings;

namespace Sport7.CMS.Settings
{
    public class CMSSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            /* Define module settings here.
             * Use names from CMSSettings class.
             */

            context.Add(new SettingDefinition(CMSSettings.AnnouncementUpdatedTimeStamp, "0"));
        }
    }
}

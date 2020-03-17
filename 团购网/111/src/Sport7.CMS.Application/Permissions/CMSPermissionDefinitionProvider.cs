using Sport7.Authorization.Permissions;
using Sport7.CMS.Localization;
using Sport7.Localization;

namespace Sport7.CMS.Permissions
{
    public class CMSPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(CMSPermissions.GroupName, L("Permission:CMS"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CMSResource>(name);
        }
    }
}

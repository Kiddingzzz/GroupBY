namespace Sport7.CMS.Permissions
{
    public class CMSPermissions
    {
        public const string GroupName = "CMS";

        public static class Posts
        {
            public const string Default = GroupName + ".Post";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }

        public static class Tags
        {
            public const string Default = GroupName + ".Tag";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }

        public static class Comments
        {
            public const string Default = GroupName + ".Comment";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
        }

        public static string[] GetAll()
        {
            return new[]
            {
                GroupName,
                Posts.Default,
                Posts.Delete,
                Posts.Update,
                Posts.Create,
                Tags.Default,
                Tags.Delete,
                Tags.Update,
                Tags.Create,
                Comments.Default,
                Comments.Delete,
                Comments.Update,
                Comments.Create
            };
        }
    }
}

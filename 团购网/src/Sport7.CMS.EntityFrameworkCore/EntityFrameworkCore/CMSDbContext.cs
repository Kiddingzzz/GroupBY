using Announcements;
using Microsoft.EntityFrameworkCore;
using Sport7.AuditLogging.EntityFrameworkCore;
using Sport7.CMS.Comments;
using Sport7.CMS.Feedbacks;
using Sport7.CMS.House;
using Sport7.CMS.houseOrder;
using Sport7.CMS.News;
using Sport7.CMS.Posts;
using Sport7.CMS.Receadress;
using Sport7.CMS.Tagging;
using Sport7.CMS.VoteOptions;
using Sport7.CMS.Votes;
using Sport7.EntityFrameworkCore;
using Sport7.PermissionManagement.EntityFrameworkCore;
using Sport7.SettingManagement.EntityFrameworkCore;

namespace Sport7.CMS.EntityFrameworkCore
{
    public class CMSDbContext : Sport7DbContext<CMSDbContext>
    {
        public static string TablePrefix { get; set; } = CMSConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = CMSConsts.DefaultDbSchema;

        public DbSet<HouseInfer> houseInfers { get; set; }

        public DbSet<HouseDetail> houseDetails { get; set; }

        public DbSet<PresalePermit> presalePermits { get; set; }

        public DbSet<HouseNews> houseNews { get; set; }

        //public DbSet<Post> Posts { get; set; }

        //public DbSet<Tag> Tags { get; set; }

        //public DbSet<PostTag> PostTags { get; set; }

        //public DbSet<Announcement> Announcements { get; set; }

        //public DbSet<VoteDetail> VoteDetails { get; set; }

        //public DbSet<VoteDetailOption> VoteDetailOptions { get; set; }

        //public DbSet<Comment> Comments { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<HouseOrder> HouseOrder { get; set; }
        
        public DbSet<ReceAdress> ReceAdress { get; set; }
        public CMSDbContext(DbContextOptions<CMSDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureCMS(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });


            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureAuditLogging();
        }
    }
}

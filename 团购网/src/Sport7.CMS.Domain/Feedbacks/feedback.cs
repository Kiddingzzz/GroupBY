using Sport7.Domain.Entities.Auditing;
using System;
using Sport7.MultiTenancy;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sport7.CMS.Feedbacks
{
    /// <summary>
    ///     场馆公告
    /// </summary>
    [Table("Feedbacks")]
    public class Feedback : FullAuditedEntity<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }
        public int Score { get; set; }
        public string Content { get; set; }
        public string Contact { get; set; }
        public string ImageList { get; set; }

    }
}

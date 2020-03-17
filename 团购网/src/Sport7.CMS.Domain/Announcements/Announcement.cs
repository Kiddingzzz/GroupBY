using Sport7.Domain.Entities.Auditing;
using Sport7.MultiTenancy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Announcements
{
    /// <summary>
    ///     场馆公告
    /// </summary>
    [Table("Announcements")]
    public class Announcement : FullAuditedEntity<Guid>, IMultiTenant
    {
        /// <summary>
        ///     展示顺序
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        ///     公告标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     简短描述
        /// </summary>
        [StringLength(2000)]
        public string ShortDescription { get; set; }

        /// <summary>
        ///     详情描述
        /// </summary>
        public string Description { get; set; }
        
        public Guid? TenantId { get; set; }
    }
}

using Sport7.CMS.Votes;
using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.VoteOptions
{
    [Table("VoteDetailOption")]
    public class VoteDetailOption : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 选项内容
        /// </summary>
        public virtual string OptionContent { get; set; }

        public virtual Guid VoteDetailId { get; set; }
        [ForeignKey(nameof(VoteDetailId))]

        public virtual VoteDetail VoteDetail { get; set; }
    }
}

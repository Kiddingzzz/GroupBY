using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.Home
{
    [Table("UpdateHouse")]
    public class UpdateHouse : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 评论内容
        /// </summary>
        public virtual string Comment { get; set; }

        /// <summary>ad
        /// 评论时间
        /// </summary>
        public virtual DateTime CommentTime { get; set; }

        /// <summary>
        /// 登记人
        /// </summary>
        public virtual Guid UpdatePerson { get; set; }

        public virtual Guid HomeListId { get; set; }
    }
}

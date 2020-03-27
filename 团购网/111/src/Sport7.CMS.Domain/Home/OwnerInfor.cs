using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.Home
{
    [Table("OwnerInfor")]
    public class OwnerInfor : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 业主姓名
        /// </summary>
        public virtual string OwnerName { get; set; }

        /// <summary>
        /// 联系电话1
        /// </summary>
        public virtual string phoneNumber1 { get; set; }

        /// <summary>
        /// 联系电话2
        /// </summary>
        public virtual string phoneNumber2 { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public virtual string Sex { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public virtual string IentityCard { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public virtual string Address { get; set; }


        public virtual Guid HomeListId { get; set; }
    }
}

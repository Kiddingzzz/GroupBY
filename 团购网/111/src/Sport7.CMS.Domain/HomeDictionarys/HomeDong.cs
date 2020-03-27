using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.HomeDictionarys
{
    [Table("HomeDong")]
    public class HomeDong : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 楼盘栋数
        /// </summary>
        public virtual string BuildingNumber { get; set; }

        /// <summary>
        /// 楼盘名称Id
        /// </summary>
        public virtual Guid HomeDictinaryId { get; set; } 
    }
}

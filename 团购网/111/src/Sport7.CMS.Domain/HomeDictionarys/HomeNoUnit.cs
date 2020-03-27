using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.HomeDictionarys
{
    [Table("HomeNoUnit")]
    public class HomeNoUnit : FullAuditedEntity<Guid>
    {

        /// <summary>
        /// 楼盘名称Id
        /// </summary>
        public virtual Guid HomeDictinaryId { get; set; }

        /// <summary>
        /// 层数
        /// </summary>
        public virtual int NumberLayer { get; set; }

        /// <summary>
        /// 有无单元
        /// </summary>
        public virtual bool IsUnit { get; set; }

        /// <summary>
        /// 楼盘栋数Id
        /// </summary>
        public virtual Guid HomeDongId { get; set; }
    }
}

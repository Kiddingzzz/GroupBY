using Sport7.Domain.Entities.Auditing;
using Sport7.MultiTenancy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.HomeDictionarys
{
    [Table("HomeDictionary")]
    public class HomeDictionaryss : FullAuditedEntity<Guid>, IMultiTenant
    {
        /// <summary>
        /// 租户Id
        /// </summary>
        public virtual Guid? TenantId { get; set; }

        /// <summary>
        /// 楼盘名称
        /// </summary>
        public virtual string DictionaryName { get; set; }

        /// <summary>
        /// 楼盘栋数
        /// </summary>
        public virtual string BuildingNumber { get; set; }

        /// <summary>
        /// 单元
        /// </summary>
        public virtual int Unit { get; set; }

        /// <summary>
        /// 层数
        /// </summary>
        public virtual int NumberLayer { get; set; }
    }
}

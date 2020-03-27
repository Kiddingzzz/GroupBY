using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.House
{
    public class PresalePermit : FullAuditedEntity<Guid>
    {
        public Guid HouseInferId { get; set; }

        /// <summary>
        /// 预售许可证
        /// </summary>
        public string PreSaleCard { get; set; }

        /// <summary>
        /// 发证时间
        /// </summary>
        public string IssuingTime { get; set; }

        /// <summary>
        /// 绑定楼栋
        /// </summary>
        public string BindBuilding { get; set; }

    }
}

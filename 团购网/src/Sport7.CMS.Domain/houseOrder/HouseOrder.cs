using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.houseOrder
{
    [Table("HouseOrder")]
    public class HouseOrder : FullAuditedEntity<Guid>
    {

        public Guid UserId { get; set; }

        /// <summary>
        /// 房源标题
        /// </summary>
        public string houseTitle { get; set; }

        /// <summary>
        /// 首页图
        /// </summary>
        public string   ImgHeard { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public string HousePrice { get; set; }

        /// <summary>
        /// 是否团购
        /// </summary>
        public bool HouseType { get; set; }

        /// <summary>
        /// 房源Id
        /// </summary>
        public Guid Houseid { get; set; }
    }
}

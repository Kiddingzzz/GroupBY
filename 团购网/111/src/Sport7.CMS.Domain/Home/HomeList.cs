using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.Home
{
    [Table("HomeList")]
    public class HomeList : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 房源编码
        /// </summary>
        public virtual string Housecode { get; set; }

        /// <summary>
        /// 楼盘名称
        /// </summary>
        public virtual string BuildName { get; set; }

        /// <summary>
        /// 楼盘楼栋
        /// </summary>
        public virtual string BuildUnit { get; set; }

        /// <summary>
        /// 楼盘房号
        /// </summary>
        public virtual string BuildNumber { get; set; }

        /// <summary>
        /// 楼盘楼层
        /// </summary>
        public virtual string BuildFoolr { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        public virtual string Purpose { get; set; }

        /// <summary>
        /// 建筑面积
        /// </summary>
        public virtual int BuildArea { get; set; }

        /// <summary>
        /// 房
        /// </summary>
        public virtual string Fang { get; set; }

        /// <summary>
        /// 厅
        /// </summary>
        public virtual string Ting { get; set; }

        /// <summary>
        /// 卫
        /// </summary>
        public virtual string Wei { get; set; }

        /// <summary>
        /// 厨房
        /// </summary>
        public virtual string Chufang { get; set; }

        /// <summary>
        /// 阳台
        /// </summary>
        public virtual string Yangtai { get; set; }

        /// <summary>
        /// 装修
        /// </summary>
        public virtual string Renovation { get; set; }

        /// <summary>
        /// 套内面积
        /// </summary>
        public virtual int CoverArea { get; set; }

        /// <summary>
        /// 朝向
        /// </summary>
        public virtual string Orientation { get; set; }

        /// <summary>
        /// 电梯
        /// </summary>
        public virtual string Elevator { get; set; }

        /// <summary>
        /// 房间亮点
        /// </summary>
        public virtual string BrightSpot { get; set; }

        /// <summary>
        /// 附属设施
        /// </summary>
        public virtual string Affiliated { get; set; }

        /// <summary>
        /// 附属面积
        /// </summary>
        public virtual int AffiliatedArea { get; set; }

        /// <summary>
        /// 物业费
        /// </summary>
        public virtual string PropertyFee { get; set; }

        /// <summary>
        /// 房型结构
        /// </summary>
        public virtual string HouseStructure { get; set; }

        /// <summary>
        /// 放盘状态
        /// </summary>
        public virtual string HouseStatu { get; set; }

        /// <summary>
        /// 片区
        /// </summary>
        public virtual string Pianqu { get; set; }

        /// <summary>
        /// 登记人
        /// </summary>
        public virtual string JXWPerson { get; set; }

        /// <summary>
        /// 当前登录用户等级用户名称
        /// </summary>
        public virtual string UserName { get; set; }
    }
}

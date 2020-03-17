using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.HoseList.Dto
{
    public class HouseRulerDto
    {

        public virtual Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 房源编码
        /// </summary>
        public virtual string Housecode { get; set; }

        /// <summary>
        /// 放盘状态
        /// </summary>
        public virtual string HouseStatu { get; set; }

        /// <summary>
        /// 片区
        /// </summary>
        public virtual string Pianqu { get; set; }

        /// <summary>
        /// 楼盘名称
        /// </summary>
        public virtual string BuildName { get; set; }

        /// <summary>
        /// 楼盘单元
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
        /// 建筑面积
        /// </summary>
        public virtual int BuildArea { get; set; }

        /// <summary>
        /// 朝向
        /// </summary>
        public virtual string Orientation { get; set; }

        /// <summary>
        /// 装修
        /// </summary>
        public virtual string Renovation { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        public virtual string Purpose { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        public virtual int Price { get; set; }

        /// <summary>
        /// 租价
        /// </summary>
        public virtual int RecentMoney { get; set; }

        /// <summary>
        /// 当前月租价
        /// </summary>
        public virtual int MonthRecentMoney { get; set; }

        /// <summary>
        /// 售接盘人
        /// </summary>
        public virtual string LoginName { get; set; }

        /// <summary>
        /// 登记人
        /// </summary>
        public virtual string JXWPerson { get; set; }

        /// <summary>
        /// 套内面积
        /// </summary>
        public virtual int CoverArea { get; set; }

        /// <summary>
        /// 房
        /// </summary>
        public virtual string Fang { get; set; }

        /// <summary>
        /// 业主姓名
        /// </summary>
        public virtual string OwnerName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public virtual string Sex { get; set; }

        /// <summary>
        /// 联系电话1
        /// </summary>
        public virtual string phoneNumber1 { get; set; }

        /// <summary>
        /// 联系电话2
        /// </summary>
        public virtual string phoneNumber2 { get; set; }

        /// <summary>
        /// 盘源现状
        /// </summary>
        public virtual string HouseStay { get; set; }
    }
}

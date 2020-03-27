using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.Home
{
    [Table("HouseInformation")]
    public class HouseInformation : FullAuditedEntity<Guid>
    {

        /// <summary>
        /// 售价
        /// </summary>
        public virtual int Price { get; set; }

        /// <summary>
        /// 底价
        /// </summary>
        public virtual int FloorPrice { get; set; }

        /// <summary>
        /// 付款要求
        /// </summary>
        public virtual string Paymethod { get; set; }

        /// <summary>
        /// 私/公有
        /// </summary>
        public virtual string SaleStatu { get; set; }

        /// <summary>
        /// 售均价
        /// </summary>
        public virtual int CenterPrice { get; set; }

        /// <summary>
        /// 售接盘人
        /// </summary>
        public virtual string LoginName { get; set; }

        /// <summary>
        /// 房型年代
        /// </summary>
        public virtual string years { get; set; }

        /// <summary>
        /// 产权
        /// </summary>
        public virtual string chanquan { get; set; }

        /// <summary>
        /// 抵押现状
        /// </summary>
        public virtual string DiyaStatu { get; set; }

        /// <summary>
        /// 原购价
        /// </summary>
        public virtual string Reprice { get; set; }

        /// <summary>
        /// 购置年限
        /// </summary>
        public virtual string Buydate { get; set; }

        /// <summary>
        /// 补充说明
        /// </summary>
        public virtual string Note { get; set; }

        /// <summary>
        /// 看房方式
        /// </summary>
        public virtual string LookWay { get; set; }

        /// <summary>
        /// 盘源现状
        /// </summary>
        public virtual string HouseStay { get; set; }

        /// <summary>
        /// 当前租金
        /// </summary>
        public virtual int RecentMoney { get; set; }

        /// <summary>
        /// 当前月租金
        /// </summary>
        public virtual int MonthRecentMoney { get; set; }

        /// <summary>
        /// 收匙人
        /// </summary>
        public virtual string GetName { get; set; }

        /// <summary>
        /// 钥匙编号
        /// </summary>
        public virtual string KeyCode { get; set; }

        /// <summary>
        /// 房产证号
        /// </summary>
        public virtual string HouseID { get; set; }

        

        /// <summary>
        /// 业主来源
        /// </summary>
        public virtual string getHomer { get; set; }

        public virtual Guid HomeListId { get; set; }
    }
}

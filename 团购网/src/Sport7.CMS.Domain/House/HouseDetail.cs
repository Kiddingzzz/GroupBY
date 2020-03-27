using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.House
{
    [Table("HouseDetail")]
    public class HouseDetail : FullAuditedEntity<Guid>
    {

        /// <summary>
        /// 项目标签
        /// </summary>
        public string XiangmuTag { get; set; }


        /// <summary>
        /// 销售情况
        /// </summary>
        public string SaleCondtion { get; set; }

        /// <summary>
        /// 最新开盘
        /// </summary>
        public DateTime OpenningTime { get; set; }

        /// <summary>
        /// 交房时间
        /// </summary>
        public string FinishHouse { get; set; }

        /// <summary>
        /// 环线配置
        /// </summary>
        public string Huanxian { get; set; }

        /// <summary>
        /// 楼盘地址
        /// </summary>
        public string LoupanAddress { get; set; }

        /// <summary>
        /// 参考单价
        /// </summary>
        public string SeePrice { get; set; }

        /// <summary>
        /// 优惠折扣
        /// </summary>
        public string Sale { get; set; }

        /// <summary>
        /// 最低首付
        /// </summary>
        public string LowPrice { get; set; }

        /// <summary>
        /// 在售户型
        /// </summary>
        public string SaleHuxing { get; set; }

        /// <summary>
        /// 售楼地址
        /// </summary>
        public string ShoulouAddress { get; set; }

        /// <summary>
        /// 建筑类型
        /// </summary>
        public string BuildType { get; set; }

        /// <summary>
        /// 产权年限
        /// </summary>
        public string ChanquanNian { get; set; }

        /// <summary>
        /// 装修标准
        /// </summary>
        public string Zhuangxiu { get; set; }

        /// <summary>
        /// 开发商
        /// </summary>
        public string KaifaShop { get; set; }

        /// <summary>
        /// 投资商
        /// </summary>
        public string TouziShop { get; set; }

        /// <summary>
        /// 容积率
        /// </summary>
        public string Rongjilv { get; set; }

        /// <summary>
        /// 绿化率
        /// </summary>
        public string Lvhualv { get; set; }

        /// <summary>
        /// 规划用户
        /// </summary>
        public string GuihuaUser { get; set; }

        /// <summary>
        /// 楼层状况
        /// </summary>
        public string LoucengCondition { get; set; }

        /// <summary>
        /// 占地面积
        /// </summary>
        public string HasArea { get; set; }

        /// <summary>
        /// 建筑面积
        /// </summary>
        public string JianzhuArea { get; set; }

        /// <summary>
        /// 工程进度
        /// </summary>
        public string GongchengProgress { get; set; }

        /// <summary>
        /// 物业费
        /// </summary>
        public string WuyeFee { get; set; }

        /// <summary>
        /// 物业公司
        /// </summary>
        public string WuyeCompany { get; set; }

        /// <summary>
        /// 车位数
        /// </summary>
        public string CarNumber { get; set; }

        /// <summary>
        /// 车位比
        /// </summary>
        public string ParkingRadio { get; set; }

        /// <summary>
        /// 地上车位数
        /// </summary>
        public string CarUpNumber { get; set; }


        /// <summary>
        /// 地下车位数
        /// </summary>
        public string NumberUndergroundCar { get; set; }

        public Guid HouseInferId { get; set; }

    }
}

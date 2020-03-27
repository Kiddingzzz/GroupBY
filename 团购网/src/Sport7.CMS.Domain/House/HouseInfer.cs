﻿using Sport7.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport7.CMS.House
{
    [Table("HouseInfer")]
    public class HouseInfer : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 盘型名称
        /// </summary>
        public string FloorName { get; set; }

        /// <summary>
        /// 全景
        /// </summary>
        public string AllVideo { get; set; }

        /// <summary>
        /// 视频
        /// </summary>
        public string Video { get; set; }

        /// <summary>
        /// 首页图
        /// </summary>
        public string ImgHeader { get; set; }
        
        /// <summary>
        /// 图片
        /// </summary>
        public string ImgList { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 底价
        /// </summary>
        public string FloorPrice { get; set; }

        /// <summary>
        /// 开盘时间
        /// </summary>
        public DateTime OpeningTime { get; set; }

        /// <summary>
        /// 户型
        /// </summary>
        public string Apartment { get; set; }

        /// <summary>
        /// 建面
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 轨交
        /// </summary>
        public string Onfoot { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 主力户型图
        /// </summary>
        public string ApartMentImgList { get; set; }
        
        /// <summary>
        /// 沙盘图
        /// </summary>
        public string ShapanImgList { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 图片、全景、视屏
        /// </summary>
        public string VTImg { get; set; }

        /// <summary>
        /// 沙盘图
        /// </summary>
        public string Shijingtu { get; set; }

        /// <summary>
        /// 户型图
        /// </summary>
        public string HuxingImg { get; set; }

        /// <summary>
        /// 配套图
        /// </summary>
        public string Peitaotu { get; set; }

        /// <summary>
        /// 售楼处
        /// </summary>
        public string Shoulouchu { get; set; }

        /// <summary>
        /// 证照
        /// </summary>
        public string Zhengzhao { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.House.Dto
{
    public class HouseListLookOutput
    {

        public Guid Id { get; set; }
        /// <summary>
        /// 楼盘名称
        /// </summary>
        public string FloorName { get; set; }

        /// <summary>
        /// 建面
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public string FloorPrice { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 首页图
        /// </summary>
        public string ImgHeader { get; set; }

        /// <summary>
        /// 图片、全景、视屏
        /// </summary>
        public string VTImg { get; set; }
    }
}

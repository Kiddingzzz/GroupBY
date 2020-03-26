using System;
using System.Collections.Generic;
using System.Text;

namespace Sport7.CMS.New.Dto
{
    public class NewsDetail
    {
        /// <summary>
        /// 新闻标题
        /// </summary>
        public string HouseTitle { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PulishTime { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        public string Abstract { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 管理员
        /// </summary>
        public string GenereMange { get; set; }

        /// <summary>
        /// 首页图
        /// </summary>
        public string HeaderImg { get; set; }
    }
}
